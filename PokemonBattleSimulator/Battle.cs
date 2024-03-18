using System;
using System.Collections.Generic;

namespace PokemonBattleSimulator
{
    class BattleArena
    {
        public static int StartBattle(string firstTrainer, string secondTrainer, List<Pokeball> trainerBelt, List<Pokeball> trainerBelt2)
        {
            int firstTrainerWins = 0;
            int secondTrainerWins = 0;
            int firstTrainerTotalWins = 0;
            int secondTrainerTotalWins = 0;

            int rounds = Math.Min(trainerBelt.Count, trainerBelt2.Count);
            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"{firstTrainer} throws: {trainerBelt[i].PokemonInside.Name}");
                Pokemon pokemonTrainer1 = trainerBelt[i].PokemonInside;
                pokemonTrainer1.DoBattleCry();

                Console.WriteLine($"{secondTrainer} throws: {trainerBelt2[i].PokemonInside.Name}");
                Pokemon pokemonTrainer2 = trainerBelt2[i].PokemonInside;
                pokemonTrainer2.DoBattleCry();

<<<<<<< Updated upstream
=======
                // Check who has the advantage
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
            if (firstTrainerWins > secondTrainerWins)
            {
                Console.WriteLine($"{firstTrainer} wins the match!");
                return 1; 
=======
            // Determine the winner
            if (firstTrainerWins > secondTrainerWins)
            {
                Console.WriteLine($"{firstTrainer} wins the battle!");
                firstTrainerTotalWins++;
>>>>>>> Stashed changes
            }
            else if (secondTrainerWins > firstTrainerWins)
            {
<<<<<<< Updated upstream
                Console.WriteLine($"{secondTrainer} wins the match!");
                return 2; 
=======
                Console.WriteLine($"{secondTrainer} wins the battle!");
                secondTrainerTotalWins++;
>>>>>>> Stashed changes
            }
            else
            {
                Console.WriteLine("The match is a tie!");
                return 0; 
            }

            Console.WriteLine("Do you want to go again:");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
               Console.WriteLine($"{firstTrainer} has won {firstTrainerTotalWins} times");
               Console.WriteLine($"{secondTrainer} has won {secondTrainerTotalWins} times");
               StartBattle(firstTrainer, secondTrainer, trainerBelt, trainerBelt2);
            }
            else
            {
                Console.WriteLine($"{firstTrainer} has won {firstTrainerTotalWins} times");
                Console.WriteLine($"{secondTrainer} has won {secondTrainerTotalWins} times");
            }
        }
    }
}
