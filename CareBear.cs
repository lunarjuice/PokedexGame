public class CareBear: Bear, IBear {

    bool doesCare;
    bool talks;

    public CareBear(string color, string shape, int weight, bool scary, bool doesCare, bool talks): base(color, shape, weight, scary) {
        this.doesCare = doesCare;
        this.talks = talks;
    }

    //behaviors 
    public override bool Attacks() {
        if (doesCare) {
            return true;
        }
        return false;
    }

    public override string Roll() {
        return "Care Bear Stare!";
    }
}
