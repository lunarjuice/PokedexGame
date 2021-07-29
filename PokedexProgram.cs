using System;
using System.Collections.Generic;
namespace PokedexTest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PokedexItem> PokedexContents = new List<PokedexItem>();

        //(name, avg size, color, type, region, HP, Attack, Defense, Sp.Defense, Sp.Attack, Speed, abilities, type effectiveness, type weakness) //could we change the abilties to be 1/2 abilities since pokemon can hamve more than one abilties. 
            PokedexContents.Add(new Pokemon("Pidgey", "small and chubby", "brown", "flying & normal", "Kanto & Johto, ", 40, 45, 40, 35, 35, 56, "Keen Eye", "bug and grass","eletcric, ice, and rock"));
            PokedexContents.Add(new Pokemon("Ponyta", "small", "yellow", "fire", " Galar ",50,85,55,65,65,90,"Flash Fire","grass, ice, bug, steel and fairy","water, ground, and rock" ));
            PokedexContents.Add(new Pokemon("Charmander", "small", "orange", "fire", "Kanto", 39,52,43,50,60,62,"Blaze","Grass, Ice, Bug, Steel, Fairy","Water,Ground,Rock"));
            PokedexContents.Add(new Pokemon("Glameow", "small", "grey", "normal", "Sinnoh",49,55,42,37,42,85,"Own Tempo", "None","Fighting and Ghost" ));
            PokedexContents.Add(new Pokemon("Rufflet", "small", "white & dark blue", "flying & normal", "Unova",70,83,50,50,37,60,"Sheer Force"," Bug and Grass ", "Electric, Ice, and Rock"));
            PokedexContents.Add(new Pokemon("Onix", "humongous", "grey", "rock & ground", "Kanto",35,45,160,45,30,70,"Sturdy","Fire, Electric, Poison, Bug, Rock, Steel, Flying","Water, Grass, Fighting"));
            PokedexContents.Add(new Pokemon("Mantine", "humongous", "blue & white", "water & flying", "Alola",85,40,70,140,80,70,"Swift Swim","Fire,Ground,Fighting,Rock,Bug,Grass","Electric"));
            PokedexContents.Add(new Plant("green", "fresh", true, true, true, true));
            PokedexContents.Add(new Bear("brown", "circle", 200, true));
            PokedexContents.Add(new Homework("white","circle" ,20, true));
            PokedexContents.Add(new Pokemon("Squritle", "small", "blue", "water", "Kanto", 44, 48, 65, 64, 50, 43, "Torrent", "ground, rock, & dragon", "water, grass, & dragon"));
            PokedexContents.Add(new Pokemon("Arbok", "large", "purple", "poison", "Kanto", 60, 95, 69, 79, 65, 80, "Intimidate", "grass & fairy", "poison, ground, rock, ghost, & steel"));
            PokedexContents.Add(new Pokemon("Deerling", "small", "pink & white with yellow accents", "normal & grass", "Unova", 60, 60, 50, 50, 40, 74, "Chlorophyll", "ground, rock, & water", "rock, ghost, steel, flying, poison, bug, fire, grass, & dragon")); //stop

            List<ActualPokemon> ChallengerContents = new List<ActualPokemon>();
            ChallengerContents.Add(new Pokemon ("diglett", "small", "brown", "ground", "Kanto", 10, 55, 25, 45, 35, 95, "Sand Veil", "poison, rock, steel ,fire, & electric", "flying, bug, & grass"));
            ChallengerContents.Add(new Pokemon ("drowzee", "small", "yellow & brown", "psychic", "Kanto", 60, 48,45, 90, 43, 42, "Insomnia", "fighting & poison", "steel, psychic, & dark"));
            ChallengerContents.Add(new Pokemon ("eevee", "small", "brown", "normal", "Kanto", 55, 55, 50, 65, 45, 55, "Adaptability", "none", "rock, ghost, & steel"));
            ChallengerContents.Add(new Pokemon ("ekans", "small", "purple & yellow", "poison", "Kanto", 35, 60, 44, 54, 40, 55, "Shed Skin", "grass & fairy", "poison, ground, rock, steel, & ghost"));
            ChallengerContents.Add(new Pokemon ("fearow", "large", "brown", "normal & flying", "Kanto", 65, 90, 65, 61, 61, 100, "Keen Eye", "fighting, bug, & grass", "rock, steel , & electric"));
            ChallengerContents.Add(new Pokemon ("tepig","small","orange and red","fire","Unova",65,63,45,45,45,45,"Blaze","Grass, Steel, Bug, and Ice","Ground, Rock, and Water"));
            ChallengerContents.Add(new Pokemon ("goldeen", "small", "white & orange", "water", "Kanto", 45, 67, 60, 50, 35, 63, "Swift Swim", "ground, rock, & fire", "water, grass, & dragon"));
            ChallengerContents.Add(new Pokemon ("illumise", "small", "blue, purple, & black", "bug", "Hoenn", 65, 47, 75, 85, 73, 85, "Tinted Lense", "grass, psychic, & dark", "fighting, flying, poison, ghost, steel, fire, & fairy"));
            ChallengerContents.Add(new Pokemon ("kabuto", "small", "brown", "rock & water", "Kanto", 30, 80, 90, 45, 55, 55, "Battle Armor", "flying, bug, fire, ice, & ground", "fighting, ground, steel, water, grass, & dragon"));
            ChallengerContents.Add(new Pokemon ("lapras","large","blue","water and ice","Kanto",130,85,80,95,85,60,"Water Absorb","ground, dragon, flying, rock","steel and rock"));
            ChallengerContents.Add(new Pokemon ("marill","small","blue and white","water and fairy","Johto",70,20,50,50,20,40,"Thick Fat","fire,rock,ground,fighting,dark,dragon","electric, grass, poison"));
            ChallengerContents.Add(new Pokemon ("snorlax","large","white and blue","normal","Kanto",160,110,65,110,65,30,"Immunity","None","fighting"));
            ChallengerContents.Add(new Pokemon ("lunatone", "large", "tan", "rock & psychic", "Hoenn", 90, 55, 65, 85, 95, 70, "Levitate", "flying, bug, fire, ice, fighting, & poison", "fighting, ground, steel, psychic, & dark"));
            ChallengerContents.Add(new Pokemon ("snivy","small","green","grass","Unova",45,45,55,55,45,63,"Overgrow","Ground,Rock, and Water","Bug,Fire,Flying,Ice, Poison"));
            //add pokemon
          

            Console.WriteLine("It looks like you've found an object! Will you pick it up? (Yes or No)");
            string userResponse = Console.ReadLine();
            if(userResponse == "Yes") {
//pokedex 1
                Pokedex foundPokedex = new Pokedex(true);
                foundPokedex.PokemonsAndStuff = PokedexContents;
//pokedex 2
                ChallengerPokedex StrangerPokedex = new ChallengerPokedex(true);
                StrangerPokedex.Pokemons = ChallengerContents;

                Random rd = new Random();

                Console.WriteLine("You might have found a pokedex...what shape is it?");
                userResponse = Console.ReadLine(); 
                if (userResponse == Pokedex.Shape) {
                    Console.WriteLine("Oh, that sounds like it might be a Pokedex...what color is it?");
                    userResponse = Console.ReadLine(); 
                    if (userResponse == Pokedex.Color) {
                        Console.WriteLine("Wow you found a pokedex! Would you like to hear about some pokemon?");
                        userResponse = Console.ReadLine();
                        do {
                            var randomPokemonItem = foundPokedex.PokemonsAndStuff[rd.Next(0,13)]; //find random pokedexItem
                            if (randomPokemonItem is Plant) {
                                Console.WriteLine(((Plant)randomPokemonItem).Grows());
                            }
                            else if (randomPokemonItem is Bear) {
                                Console.WriteLine(((Bear)randomPokemonItem).roll());
                            }
                            else if (randomPokemonItem is Homework) {
                                Console.WriteLine(((Homework)randomPokemonItem).getsCrumbled());
                            }
                            else if (randomPokemonItem is Pokemon) {
                                Console.WriteLine("You got it boss. Here's one, this is a " + ((Pokemon)randomPokemonItem).name + ". " + ((Pokemon)randomPokemonItem).name + " is " + ((Pokemon)randomPokemonItem).Color + ". They are usually " + ((Pokemon)randomPokemonItem).avgSize + ". " + ((Pokemon)randomPokemonItem).name + " is a " + ((Pokemon)randomPokemonItem).pokemonType + " type and can be found in the " +((Pokemon)randomPokemonItem).region + " Region.");
                            }
                            Console.WriteLine("Would you like to hear about another pokemon?");
                            userResponse = Console.ReadLine();
                        } while (userResponse == "Yes");
                        Console.WriteLine("Aw okay. Maybe another time then.");

                        //A stranger approaches
            Console.WriteLine("A stranger approaches, they ask if you would like to compare pokemon. Would you like to? (Yes or No");
            userResponse = Console.ReadLine();
            if (userResponse == "Yes") {
                do {
                    // { pick randomPokemon }
                    var randomPokemonItem = foundPokedex.PokemonsAndStuff[rd.Next(0,13)];

                    // { pick randomChallenmgerPokemon }
                    var randomActualPokemon = StrangerPokedex.Pokemons[rd.Next(0,14)];

                // { display table with both pokemon stats }

                Console.WriteLine("Would you like to compare another pokemon?");
                userResponse = Console.ReadLine();
                 } while (userResponse == "Yes");
            }
            else {Console.WriteLine("The stranger wishes you a good day and walks off.");
            }

            Console.WriteLine("The stranger looks disappointed, but accepts your response...");
                    }
                    else  { 
                        Console.WriteLine("I'm sorry I don't think that's a Pokedex.");
                    }
                }  
                else {
                    Console.WriteLine("I'm sorry I don't think that's a Pokedex.");
                }
            }
            else if(userResponse == "No") {
                Console.WriteLine("hmm...I don't think that's a pokedex. Better luck next time.");
            }
            else {
                Console.WriteLine("You needed to enter Yes or No, the instructions were pretty simple...not sure how you messed that one up.");
            }
        }
    }  
}


//To Do List:
// Done: *Cristian* - add list 2 
// Done: *Makayla* change pokemon cookie cutter to ActualPokemon 
// Done: *Makayla* - add object challenger pokedex 
// Done: *Makayla* - add to states: HP, Attack, Defense, Sp.Defense, Sp.Attack, Speed, abilities, type effectiveness agaisnt other pokemon (effective, notEffective) 
// Done: *Cristian* - give pokemon in list newly added states 
// write code for random ch.pokemon
// write code for random pokmeon
// write out "text" for stats
// write code for chart with stats (later)
//

