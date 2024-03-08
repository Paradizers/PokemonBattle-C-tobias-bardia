using System;
using System.Collections.Generic;

namespace PokemonBattleSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Trainer
            Console.WriteLine("Name of the first trainer:");
            string firstTrainer = Console.ReadLine();

            // Second Trainer
            Console.WriteLine("Name of the second trainer:");
            string secondTrainer = Console.ReadLine();

            // Lists for the trainers' Pokémon
            List<Pokeball> trainerBelt = new List<Pokeball>();
            List<Pokeball> trainerBelt2 = new List<Pokeball>();

            // Pokémon of type Charmander for the first trainer
            for (int i = 0; i < 6; i++)
            {
                Pokemon pokemon = new Pokemon("Charmander", "fire", "water");
                Pokeball pokeball = new Pokeball(80, "red", pokemon);
                trainerBelt.Add(pokeball);
            }

            // Pokémon of type Charmander for the second trainer
            for (int i = 0; i < 6; i++)
            {
                Pokemon pokemon = new Pokemon("Charmander", "fire", "water");
                Pokeball pokeball = new Pokeball(80, "red", pokemon);
                trainerBelt2.Add(pokeball);
            }

            // Limiting rounds to the minimum number of Pokémon both trainers have
            int rounds = Math.Min(trainerBelt.Count, trainerBelt2.Count);
            for (int i = 0; i < rounds; i++)
            {
                // First trainer sends out their Pokémon
                Console.WriteLine($"{firstTrainer} sends out: Charmander {i + 1}");
                Pokemon pokemonTrainer1 = trainerBelt[i].PokemonInside;
                pokemonTrainer1.DoBattleCry();

                // Second trainer does the same
                Console.WriteLine($"{secondTrainer} sends out: Charmander {i + 1}");
                Pokemon pokemonTrainer2 = trainerBelt2[i].PokemonInside;
                pokemonTrainer2.DoBattleCry();

                // Both trainers recall their Pokémon
                Console.WriteLine($"{firstTrainer} recalls Charmander back to its pokeball");
                Console.WriteLine($"{secondTrainer} recalls Charmander back to its pokeball");
            }

            Console.ReadLine();
        }
    }
}
