using HarmonyLib;
using Verse;

namespace deepstorageplus;

internal class DoHarmony : Mod
{
    public DoHarmony(ModContentPack content) : base(content)
    {
        new Harmony("im.skye.rimworld.deepstorageplus").PatchAll();
    }
}