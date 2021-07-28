public class ActualPokemon: PokedexItem { 
    public string ability;
    public string Ability {get {return ability;} set {ability = value;} }

    public ActualPokemon(string ability, string color): base(color) {
        this.ability = ability;
    }
}