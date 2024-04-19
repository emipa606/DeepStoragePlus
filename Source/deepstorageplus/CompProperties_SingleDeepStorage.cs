using Verse;

namespace deepstorageplus;

// Class from https://github.com/KiameV/rimworld-rimfridge/blob/master/Source/CompProperties_SecondLayer.cs
// Usage under MIT license
public class CompProperties_SingleDeepStorage : CompProperties
{
    public readonly AltitudeLayer altitudeLayer = AltitudeLayer.MoteOverhead;
    public GraphicData graphicData = null;

    public string ignoredComp = string.Empty;

    public CompProperties_SingleDeepStorage()
    {
        compClass = typeof(CompSingleDeepStorage);
    }

    public float Altitude => altitudeLayer.AltitudeFor();
}