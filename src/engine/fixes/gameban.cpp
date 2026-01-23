/************************************************************************************************
 *  SwiftlyS2 is a scripting framework for Source2-based games.
 *  Copyright (C) 2023-2026 Swiftly Solution SRL via Sava Andrei-Sebastian and it's contributors
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 ************************************************************************************************/

// Take from https://github.com/Source2ZE/CS2Fixes/commit/d67f069374e349efb95b9fb5a360172fa08550c8

#include <api/interfaces/manager.h>
#include "gameban.h"

struct CGcBanInformation_t
{
	uint32_t m_uiReason;
	double m_dblUnk;
	double m_dblExpiration;
	uint32_t m_uiAccountId;
};

IFunctionHook* g_pCheckSteamBanHook = nullptr;
inline CUtlMap<uint32, CGcBanInformation_t, uint32>* g_pSm_MapGcBanInformation;

void Hook_Think_CheckSteamBan()
{
    reinterpret_cast<decltype(&Hook_Think_CheckSteamBan)>(g_pCheckSteamBanHook->GetOriginal())();

    CUtlMap<uint32, CGcBanInformation_t, uint32>* pMap = g_pSm_MapGcBanInformation;
	unsigned int count = pMap->Count();

	// After player has been kicked, remove any ban entries, to prevent spreading to all new joining players
	if (count > 0)
		pMap->RemoveAll();
}

void GameBanFix::Start()
{
    auto hooksmanager = g_ifaceService.FetchInterface<IHooksManager>(HOOKSMANAGER_INTERFACE_VERSION);
    auto gamedata = g_ifaceService.FetchInterface<IGameDataManager>(GAMEDATA_INTERFACE_VERSION);
    auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);

    void* Think_CheckSteamBan = gamedata->GetSignatures()->Fetch("GameSystem::Think_CheckSteamBan");
    if (!Think_CheckSteamBan) {
        logger->Error("EngineFixes", "GameSystem::Think_CheckSteamBan Signature not found!");
        return;
    }

    uintptr_t MapGcBanInformation = (uintptr_t)gamedata->GetSignatures()->Fetch("CCSGameRules::sm_mapGcBanInformation");
    if (!MapGcBanInformation) {
        logger->Error("EngineFixes", "CCSGameRules::sm_mapGcBanInformation Signature not found!");
        return;
    }

    // the opcode is 3 bytes so we skip those
	MapGcBanInformation += 3;

	// Grab the offset as 4 bytes
	uint32 offset = *(uint32*)MapGcBanInformation;

	// Go to the next instruction, which is what the relative address is based off
	MapGcBanInformation += 4;

	// Get the real address
	g_pSm_MapGcBanInformation = (decltype(g_pSm_MapGcBanInformation))(MapGcBanInformation + offset);

	if (!g_pSm_MapGcBanInformation)
    {
        logger->Error("EngineFixes", "CCSGameRules::sm_mapGcBanInformation not valid!");
        return;
    }
    
    g_pCheckSteamBanHook = hooksmanager->CreateFunctionHook();
    g_pCheckSteamBanHook->SetHookFunction(Think_CheckSteamBan, reinterpret_cast<void*>(Hook_Think_CheckSteamBan));
    g_pCheckSteamBanHook->Enable();
}

void GameBanFix::Stop()
{
    if (g_pCheckSteamBanHook)
    {
        g_pCheckSteamBanHook->Disable();
        auto hooksmanager = g_ifaceService.FetchInterface<IHooksManager>(HOOKSMANAGER_INTERFACE_VERSION);
        hooksmanager->DestroyFunctionHook(g_pCheckSteamBanHook);
    }
}