public class PokedexItem {
//states
    string color;

    string shapeA;
    int weight; 
    bool scary; 
    
    string shapeB;
    string smell;
    bool hasLeaves;
    bool hasRoots;
    bool collectsSunlight;
    bool makesGlucose;

    string shapeC;
    string name; 
    string avgSize; 
    string pokemonType; 
    string region;
    int hp;
    int attack;
    int defense;
    int spDefense;
    int spAttack;
    int speed;
    string typeEffectiveness;
    string typeWeakness;


    public string Color { get => color; set => color = value; }

    public PokedexItem(string color)
    {
        this.color = color;
    }

    public string Grows() {
        if (hasLeaves) {
            if (Color == "green" && smell == "fresh" && hasLeaves && hasRoots) {
                return "This is a plant...not sure why that's in here.";
            }
            return "This plant is not growing...maybe try watering it?";
        }
    }

    
    public virtual bool Attacks() {
        if (scary) {
            if (weight > 200 && scary == true) {
                return true;
            }
            return false;
        }
    }

}