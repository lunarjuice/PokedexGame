using System;
using System.Collections.Generic; //ask warren

public class Pokedex {
    //states
    const string shape = "Rectangle";
    const string color = "Red";
    bool screenIsLitUp;
    List<PokedexItem> pokemonsAndStuff = new List<PokedexItem>();

    public Pokedex(bool screenIsLitUp) {
        this.screenIsLitUp = screenIsLitUp;
    }

    public static string Shape => shape;

    public static string Color => color;

    public bool ScreenIsLitUp { get { return screenIsLitUp; } set { screenIsLitUp = value; } }
//what is this? "List<Poke...etc.
//The accessor for the private property above (Encapsulation)
    public List<PokedexItem> PokemonsAndStuff { get => pokemonsAndStuff; set => pokemonsAndStuff = value; }

    
}

