using Verse;

namespace deepstorageplus;

// Class from https://github.com/KiameV/rimworld-rimfridge/blob/master/Source/CompProperties_SecondLayer.cs
// Usage under MIT license
public class CompProperties_SecondLayer : CompProperties
{
    public AltitudeLayer altitudeLayer = AltitudeLayer.MoteOverhead;
    public GraphicData graphicData = null;

    public CompProperties_SecondLayer()
    {
        compClass = typeof(CompSecondLayer);
    }

    public float Altitude => altitudeLayer.AltitudeFor();
}