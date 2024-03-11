using System;
using System.Collections.Generic;

namespace PokemonBattleSimulator
{
    class Battle
    {
        public static void StartBattle(string firstTrainer, string secondTrainer, List<Pokeball> trainerBelt, List<Pokeball> trainerBelt2)
        {
            int firstTrainerWins = 0;
            int secondTrainerWins = 0;

            int rounds = Math.Min(trainerBelt.Count, trainerBelt2.Count);
            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"{firstTrainer} throws: {trainerBelt[i].PokemonInside.Name}");
                Pokemon pokemonTrainer1 = trainerBelt[i].PokemonInside;
                pokemonTrainer1.DoBattleCry();

                Console.WriteLine($"{secondTrainer} throws: {trainerBelt2[i].PokemonInside.Name}");
                Pokemon pokemonTrainer2 = trainerBelt2[i].PokemonInside;
                pokemonTrainer2.DoBattleCry();

                // Kijk wie het voordeel heeft
                if (pokemonTrainer1.Strength == pokemonTrainer2.Weakness)
                {
                    Console.WriteLine($"{firstTrainer} has the advantage!");
                    firstTrainerWins++;
                    Console.WriteLine($"{firstTrainer} wins the battle!");
                }
                else if (pokemonTrainer1.Weakness == pokemonTrainer2.Strength)
                {
                    Console.WriteLine($"{secondTrainer} has the advantage!");
                    secondTrainerWins++;
                    Console.WriteLine($"{secondTrainer} wins the battle!");
                }
                else
                {
                    Console.WriteLine("It's a draw!");
                }

                Console.WriteLine($"{firstTrainer} calls {trainerBelt[i].PokemonInside.Name} back to the pokeball");
                Console.WriteLine($"{secondTrainer} calls {trainerBelt2[i].PokemonInside.Name} back to the pokeball");
            }

            // Wie heeft er gewonnen
            if (firstTrainerWins > secondTrainerWins)
            {
                Console.WriteLine($"{firstTrainer} wins the battle!");
            }
            else if (firstTrainerWins < secondTrainerWins)
            {
                Console.WriteLine($"{secondTrainer} wins the battle!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
