public class PolarBear: PokedexItem, IBear {
    string growl;

    public PolarBear(string growl, string color) : base (color)
    {
        this.growl = growl;
    }
    public string Kill() {
        return "The polar bear says " + growl + " then eats you!";
    }

    public string MoveFast() {
        return "The polar bear runs fast";
    }

    public bool IsTheBearMean() {
        return true;
    }

    public bool Attacks()
    {   
        return this.IsTheBearMean();
    }

    public string Roll()
    {
        return this.MoveFast();
    }
}