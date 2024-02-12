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

            // Create trainers with their pokemons
            Trainer trainer1 = new Trainer(firstTrainer);
            Trainer trainer2 = new Trainer(secondTrainer);

            // Add pokemons to trainers
            trainer1.AddPokemon(new Charmander("Charmander1"));
            trainer1.AddPokemon(new Squirtle("Squirtle1"));
            trainer1.AddPokemon(new Bulbasaur("Bulbasaur1"));
            trainer1.AddPokemon(new Pikachu("Pikachu1"));
            trainer1.AddPokemon(new Eevee("Eevee1"));
            trainer1.AddPokemon(new Jigglypuff("Jigglypuff1"));

            trainer2.AddPokemon(new Charmander("Charmander2"));
            trainer2.AddPokemon(new Squirtle("Squirtle2"));
            trainer2.AddPokemon(new Bulbasaur("Bulbasaur2"));
            trainer2.AddPokemon(new Pikachu("Pikachu2"));
            trainer2.AddPokemon(new Eevee("Eevee2"));
            trainer2.AddPokemon(new Jigglypuff("Jigglypuff2"));

            // Show pokemons of each trainer
            Console.WriteLine($"{firstTrainer}'s pokemons:");
            trainer1.DisplayPokemons();
            Console.WriteLine($"{secondTrainer}'s pokemons:");
            trainer2.DisplayPokemons();

            // Pokeball functionality
            Random random = new Random();
            Console.WriteLine("Trainer 1 threw a Pokeball!");
            int randomIndex = random.Next(trainer2.Pokemons.Count);
            Pokemon capturedPokemon = trainer2.Pokemons[randomIndex];
            Console.WriteLine($"{capturedPokemon.Name} roared!");
            Console.WriteLine("Trainer 1 threw another Pokeball!");

            Console.WriteLine("Do you want to recall the captured Pokemon? (yes/no)");
            string recallChoice = Console.ReadLine();
            if (recallChoice.ToLower() == "yes")
            {
                trainer2.RecallPokemon(capturedPokemon);
                Console.WriteLine($"Trainer 1 successfully recalled {capturedPokemon.Name}!");
            }
            else
            {
                Console.WriteLine($"Trainer 1 chose not to recall {capturedPokemon.Name}.");
            }

            Console.WriteLine("Thanks for playing!");
        }
    }

    class Trainer
    {
        public string Name { get; }
        public List<Pokemon> Pokemons { get; }

        public Trainer(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

        public void DisplayPokemons()
        {
            foreach (var pokemon in Pokemons)
            {
                Console.WriteLine(pokemon.Name);
            }
        }

        public void RecallPokemon(Pokemon pokemon)
        {
            Pokemons.Remove(pokemon);
        }
    }

    // Existing Pokemon classes
    class Charmander : Pokemon
    {
        public Charmander(string name) : base(name, "Fire", "Water") { }
    }

    class Squirtle : Pokemon
    {
        public Squirtle(string name) : base(name, "Water", "Grass") { }
    }

    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name, "Grass", "Fire") { }
    }

    class Pikachu : Pokemon
    {
        public Pikachu(string name) : base(name, "Electric", "Ground") { }
    }
    class Eevee : Pokemon
    {
        public Eevee(string name) : base(name, "Normal", "Fighting") { }
    }

    class Jigglypuff : Pokemon
    {
        public Jigglypuff(string name) : base(name, "Fairy", "Steel") { }
    }

    class Pokemon
    {
        public string Name { get; }
        public string Type { get; }
        public string Weakness { get; }

        public Pokemon(string name, string type, string weakness)
        {
            Name = name;
            Type = type;
            Weakness = weakness;
        }

        public string DoBattlecry()
        {
            return $"GROWLLLL I am {Name}";
        }
    }
}
