using System.Linq;
using HarmonyLib;
using LWM.DeepStorage;
using Verse;

namespace deepstorageplus;

[HarmonyPatch(typeof(CompDeepStorage), nameof(CompDeepStorage.CapacityToStoreThingAt))]
public static class Patch_CompDeepStorage_CapacityToStoreThingAt
{
    // Execute some behaviour if parent has the SingleDeepStorage comp.
    private static void Postfix(CompDeepStorage __instance, Thing thing, Map map, IntVec3 cell, ref int __result)
    {
        // If doesn't have the single storage comp just return
        var singleDeep = __instance.parent.GetComp<CompSingleDeepStorage>();
        if (singleDeep == null)
        {
            return;
        }

        // Otherwise, check that the first item in the stack is the same as the thing.
        // If that's not true, we modify the result to be 0 instead.
        var things = map.thingGrid.ThingsListAt(cell)
            .Where(t => t.def.building == null)
            .ToList();
        if (things.Count == 0)
        {
            return;
        }

        if (things[0].def.defName != thing.def.defName)
        {
            __result = 0;
        }
    }
}