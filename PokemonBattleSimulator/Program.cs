using ConsoleApp1;
using System;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Trainer
            Console.WriteLine("First trainer's name:");
            string firstTrainer = Console.ReadLine();

            // Second Trainer
            Console.WriteLine("Second trainer's name:");
            string secondTrainer = Console.ReadLine();

            // Charmander name
            Console.WriteLine("Give a name to your Charmander:");
            string charmanderName = Console.ReadLine();
            Charmander charmander = new(charmanderName);

            // Charmander battle cry
            Console.WriteLine("Charmander's battle cry:");
            for (int i = 0; i < 10; i++)
            {
                charmander.BattleCry();
            }

            // Charmander rename loop
            while (true)
            {
                Console.WriteLine("Would you like to give Charmander a new name? (yes/no)");
                string answer = Console.ReadLine();
                if (answer == "no")
                    break;
                else if (answer == "yes")
                {
                    Console.WriteLine("Enter the new name:");
                    charmanderName = Console.ReadLine();
                    charmander.SetName(charmanderName);

                    // Charmander battle cry after renaming
                    Console.WriteLine("Charmander's battle cry:");
                    for (int i = 0; i < 10; i++)
                    {
                        charmander.BattleCry();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }

            Console.WriteLine("Thanks for playing!");

            // Create Charmander pokemon instance
            Pokemon charmanderPokemon = new Pokemon("Charmander", "fire", "water");

            // Create Pokeball with Charmander
            Pokeball pokeball = new Pokeball(50, "red", charmanderPokemon);

            // Display Charmander's name from the Pokeball
            Console.WriteLine(pokeball.pokemon.name);
        }
    }

    class Pokemon
    {
        public string name;
        public string type;
        public string weakness;

        public Pokemon(string name, string strength, string weakness)
        {
            this.name = name;
            this.type = strength;
            this.weakness = weakness;
        }

        public string DoBattlecry()
        {
            return $"GROWLLLL ik ben {name}";
        }
    }

    internal class Pokeball
    {
        public int catchRate;
        public string color;
        public Pokemon pokemon;

        public Pokeball(int catchRate, string color, Pokemon pokemon)
        {
            this.catchRate = catchRate;
            this.color = color;
            this.pokemon = pokemon;
        }

        public void Open()
        {
            // pokebal openen
        }
    }
}

namespace ConsoleApp1
{
    class Charmander
    {
        private string nickname;

        public Charmander(string nickname)
        {
            this.nickname = nickname;
        }

        public void SetName(string newName)
        {
            nickname = newName;
        }

        public void BattleCry()
        {
            Console.WriteLine($"{nickname} shouts: Charmander!");
        }
    }
}