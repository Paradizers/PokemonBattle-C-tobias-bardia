using System;
using System.Collections.Generic;

namespace PokemonBattleSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokeball> trainerBelt = new List<Pokeball>();
            List<Pokeball> trainerBelt2 = new List<Pokeball>();

            Console.WriteLine("Name of the first trainer:");
            string firstTrainer = Console.ReadLine();

            Console.WriteLine("Name of the second trainer:");
            string secondTrainer = Console.ReadLine();

            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "red", new Charmander("Charmander" + (i + 1)));
                trainerBelt.Add(pokeball);
            }

            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "blue", new Squirtle("Squirtle" + (i + 1)));
                trainerBelt.Add(pokeball);
            }

            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "grass", new Bulbasaur("Bulbasaur" + (i + 1)));
                trainerBelt.Add(pokeball);
            }

            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "red", new Charmander("Charmander" + (i + 1)));
                trainerBelt2.Add(pokeball);
            }

            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "blue", new Squirtle("Squirtle" + (i + 1)));
                trainerBelt2.Add(pokeball);
            }

            for (int i = 0; i < 2; i++)
            {
                Pokeball pokeball = new Pokeball(80, "grass", new Bulbasaur("Bulbasaur" + (i + 1)));
                trainerBelt2.Add(pokeball);
            }

            // Shuffle the lists
            Random rng = new Random();
            Shuffle(trainerBelt, rng);
            Shuffle(trainerBelt2, rng);

            // Start the battle    
            BattleArena.StartBattle(firstTrainer, secondTrainer, trainerBelt, trainerBelt2);


            Console.ReadLine();
        }

        static void Shuffle<T>(IList<T> list, Random rng)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
