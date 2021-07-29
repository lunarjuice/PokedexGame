using System; 

public class Pokemon: ActualPokemon {
    //states (name, *color, avg size, type, region, HP, Attack, Defense, Sp.Defense, Sp.Attack, Speed, abilities, type effectiveness)
    public string name; 
    public string avgSize; 
    public string pokemonType; 
    public string region;
    public int hp;
    public int attack;
    public int defense;
    public int spDefense;
    public int spAttack;
    public int speed;
    public string typeEffectiveness;
    public string typeWeakness;


    public Pokemon (string name, string avgSize, string color, string pokemonType, string region, int hp, int attack, int defense, int spDefense, int spAttack, int speed, string ability, string typeEffectiveness, string typeWeakness): base(ability, color) {
        this.name = name;
        this.avgSize = avgSize;
        this.pokemonType = pokemonType; 
        this.region = region; 
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
        this.spDefense = spDefense;
        this.spAttack = spAttack;
        this.speed = speed;
        this.typeEffectiveness = typeEffectiveness;
        this.typeWeakness = typeWeakness;
    }
    
    public string Name {get {return name;} set {name = value;} }
    public string AvgSize {get {return avgSize;} set {avgSize = value;} }
    public string PokemonType {get {return pokemonType;} set {pokemonType = value;} }
    public string Region {get => region; set => region = value; }
    public int Hp { get => hp; set => hp = value; }
    public int Attack { get => attack; set => attack = value; }
    public int Defense { get => defense; set => defense = value; }
    public int SpDefense { get => spDefense; set => spDefense = value; }
    public int SpAttack { get => spAttack; set => spAttack = value; }
    public int Speed { get => speed; set => speed = value; }
    public string TypeEffectiveness { get => typeEffectiveness; set => typeEffectiveness = value; }
    public string TypeWeekness { get => typeWeakness; set => typeWeakness = value; }
}

    //behaviours 

//Suggestions:
//bool run away
//bool fight
//bool 
