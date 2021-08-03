public class PokedexItem {
//states
    private string color;
    public string Color { get => color; set => color = value; }

    public PokedexItem(string color)
    {
        this.color = color;
    }
}