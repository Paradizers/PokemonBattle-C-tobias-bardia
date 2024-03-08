using System;

namespace PokemonBattleSimulator
{
    class Pokemon
    {
        public string name;
        public string type;
        public string weakness;

        public Pokemon(string name, string type, string weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }

        public void DoBattleCry()
        {
            Console.WriteLine("Rawrrrrr!!!! " + name + "!");
        }
    }

    class Charmander : Pokemon
    {
        public Charmander(string name) : base(name, "Fire", "Water")
        {
            
        }
    }

    class Squirtle : Pokemon
    {
        public Squirtle(string name) : base(name, "Water", "Electric")
        {
            
        }
    }

    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name, "Grass", "Fire")
        {
            
        }
    }
}
