public class Bear: PokedexItem {

    //states 
    string shape;
    int weight; 
    bool scary; 

    public Bear(string color, string shape, int weight, bool scary): base(color) {
        this.shape = shape;
        this.weight = weight;
        this.scary = scary;
    }

    public string Shape { get{ return shape; } set { shape = value; }}
    public int Weight { get{ return weight; } set { weight = value; }}
    public bool Scary { get{ return scary; } set { scary = value; }} 

    //behaviors 

    public bool attacks() {
        if (weight > 200 && scary == true) {
            return true;
        }
        return false;
    }


    public string roll() {
        if (weight > 150 && shape == "circle") {
            return "This is a bear...it's definitly scary, but not a pokemon. Maybe try again.";
        }
        return "He will NOT roll!";
    }
}