using System;
using System.Collections.Generic; //ask warren

public class ChallengerPokedex {
    bool screenIsLitUp2;
    List<ActualPokemon> pokemons = new List<ActualPokemon>();

public ChallengerPokedex(bool screenIsLitUp2) {
        this.screenIsLitUp2 = screenIsLitUp2;
    }
public bool ScreenIsLitUp2 { get { return screenIsLitUp2; } set { screenIsLitUp2 = value; } }

public List<ActualPokemon> Pokemons { get => pokemons; set => pokemons = value; }
}