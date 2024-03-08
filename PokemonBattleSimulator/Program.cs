using System;
using System.Collections.Generic;

namespace PokemonBattleSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eerste Trainer
            Console.WriteLine("Name of the first trainer:");
            string firstTrainer = Console.ReadLine();

            // Tweede Trainer
            Console.WriteLine("Name of the second trainer:");
            string secondTrainer = Console.ReadLine();

            // Lijsten voor de Pokémon van de trainers
            List<Pokeball> trainerBelt = new List<Pokeball>();
            List<Pokeball> trainerBelt2 = new List<Pokeball>();

            // Pokémon van het type Charmander voor de eerste trainer
            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "red", new Charmander());
                trainerBelt.Add(pokeball);
            }
            // Pokémon van het type Squirtle voor de eerste trainer
            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "blue", new Squirtle("Squirtle" + (i + 1)));
                trainerBelt.Add(pokeball);
            }
            // Pokémon van het type Bulbasaur voor de eerste trainer
            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "grass", new Bulbasaur("Bulbasaur" + (i + 1)));
                trainerBelt.Add(pokeball);
            }

            // Pokémon van het type Charmander voor de tweede trainer
            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "red", new Charmander());
                trainerBelt2.Add(pokeball);
            }
            // Pokémon van het type Squirtle voor de tweede trainer
            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "blue", new Squirtle("Squirtle" + (i + 1)));
                trainerBelt2.Add(pokeball);
            }
            // Pokémon van het type Bulbasaur voor de tweede trainer
            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "grass", new Bulbasaur("Bulbasaur" + (i + 1)));
                trainerBelt2.Add(pokeball);
            }

            // Aantal ronden beperken tot het minimum aantal Pokémon dat beide trainers hebben
            int ronden = Math.Min(trainerBelt.Count, trainerBelt2.Count);
            for (int i = 0; i < ronden; i++)
            {
                // Eerste trainer gooit zijn Pokémon in de strijd
                Console.WriteLine($"{firstTrainer} throws: {trainerBelt[i].PokemonInside.Name}");
                Pokemon pokemonTrainer1 = trainerBelt[i].PokemonInside;
                pokemonTrainer1.DoBattleCry();

                // Tweede trainer doet hetzelfde
                Console.WriteLine($"{secondTrainer} throws: {trainerBelt2[i].PokemonInside.Name}");
                Pokemon pokemonTrainer2 = trainerBelt2[i].PokemonInside;
                pokemonTrainer2.DoBattleCry();

                // Beide trainers roepen hun Pokémon terug
                Console.WriteLine($"{firstTrainer} calls {trainerBelt[i].PokemonInside.Name} back to the pokeball");
                Console.WriteLine($"{secondTrainer} calls {trainerBelt2[i].PokemonInside.Name} back to the pokeball");
            }

            Console.ReadLine();
        }
    }
}