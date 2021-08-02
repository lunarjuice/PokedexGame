public class GrizzlyBear : Bear, IBear
{

    string locale;

    public GrizzlyBear(string color, string shape, int weight, bool scary, string locale) : base(color, shape, weight, scary)
    {
        this.locale = locale;
    }

    //behaviors 

    public override bool Attacks()
    {
        if (locale == "Yellowstone")
        {
            return true;
        }
        return false;
    }

    public override string Roll()
    {
        return "Holy canolly there's a grizzly bear rolling towards you";
    }
}
