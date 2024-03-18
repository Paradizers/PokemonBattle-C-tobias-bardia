using System;

namespace PokemonBattleSimulator
{
    abstract class Pokemon
    {
        public string Name;
        public string Strength;
        public string Weakness;
        protected string nickname;

        public abstract string Nickname { get; }

        public Pokemon(string name, string strength, string weakness, string nickname)
        {
            this.Name = name;
            this.Strength = strength;
            this.Weakness = weakness;
            this.nickname = nickname;
        }

        public abstract void DoBattleCry();
    }

    class Charmander : Pokemon
    {
        public Charmander(string nickname) : base("Charmander", "fire", "water", nickname)
        {
        }

        public override string Nickname
        {
            get { return nickname; }
        }
     
        public override void DoBattleCry()
        {
            Console.WriteLine("Charmander Charmander!");
        }
    }

    class Squirtle : Pokemon
    {
        public Squirtle(string nickname) : base("Squirtle", "water", "grass", nickname)
        {
        }

        public override string Nickname
        {
            get { return nickname; }
        }

        public override void DoBattleCry()
        {
            Console.WriteLine("Squirtle Squirtle!");
        }
    }

    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname) : base("Bulbasaur", "grass", "fire", nickname)
        {
        }

        public override string Nickname
        {
            get { return nickname; }
        }

        public override void DoBattleCry()
        {
            Console.WriteLine("Bulba Bulba!");
        }
    }
}
