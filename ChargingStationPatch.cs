using HarmonyLib;
using UnityEngine;

namespace RepoInfiniteEnergy;

[HarmonyPatch(typeof(ChargingStation))]
static class ChargingStationPatch
{
    [HarmonyPatch("Start")]
    [HarmonyPrefix]
    private static bool Start(ref ChargingStation __instance)
    {
        // Change the chargeTotal to a very high number
        Debug.Log((object) $"InfiniteEnergy: Setting Total Charge to a very high number");
        __instance.chargeTotal = 1000000000;
        
        // Return true to continue with the original method
        return true;
    }
}