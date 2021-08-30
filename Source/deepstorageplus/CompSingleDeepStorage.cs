using Verse;

namespace deepstorageplus
{
    // Empty comp that is used to indicate that a storage unit should only hold 1 type of item
    public class CompSingleDeepStorage : ThingComp
    {
        public CompProperties_SingleDeepStorage Props => (CompProperties_SingleDeepStorage)props;
    }
}