public class Plant: PokedexItem {
    //states

    string smell;
    bool hasLeaves;
    bool hasRoots;
    bool collectsSunlight;
    bool makesGlucose;

    public Plant(string color, string smell, bool hasLeaves, bool hasRoots, bool collectsSunlight, bool makesGlucose): base(color) {
        this.smell = smell;
        this.hasLeaves = hasLeaves;
        this.hasRoots = hasRoots;
        this.collectsSunlight = collectsSunlight;
        this.makesGlucose = makesGlucose;
    }

    public string Smell { get { return smell; } set { smell = value; } }
    public bool HasLeaves { get { return hasLeaves; } set { hasLeaves = value; } }
    public bool HasRoots { get { return hasRoots; } set { hasRoots = value; } }
    public bool CollectsSunlight { get { return collectsSunlight; } set { collectsSunlight = value; } }
    public bool MakesGlucose { get { return makesGlucose; } set { makesGlucose = value; } }

    //behaviors
    public string Photosynthesizes() {
        if (collectsSunlight && makesGlucose) {
            return "This plant can photosynthesize!";
        }
        return "I don't think that's a plant...";
    }

    public string Grows() {
        if (Color == "green" && smell == "fresh" && hasLeaves && hasRoots) {
            return "This is a plant...not sure why that's in here.";
        }
        return "This plant is not growing...maybe try watering it?";
    }

    public bool hasDied() {
        if (smell == "rotten" && Color == "brown") {
            return true;
         }
        return false;
    }
}
