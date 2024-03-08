using System;

namespace PokemonBattleSimulator
{
    abstract class Pokemon
    {
        public string Name;
        public string Strength;
        public string Weakness;
        public abstract string Nickname { get; }

        public Pokemon(string name, string strength, string weakness)
        {
            this.Name = name;
            this.Strength = strength;
            this.Weakness = weakness;
        }

        public abstract void DoBattleCry();
    }

    class Charmander : Pokemon
    {
        private string nickname;

        public Charmander() : base("Charmander", "fire", "water")
        {
            this.nickname = nickname;
        }

        public override string Nickname
        {
            get { return nickname; }
        }

        public override void DoBattleCry()
        {
            Console.WriteLine(" Charmander Charmander!");
        }
    }

    class Squirtle : Pokemon
    {
        private string nickname;

        public Squirtle(string nickname) : base("Squirtle", "water", "grass")
        {
            this.nickname = nickname;
        }

        public override string Nickname
        {
            get { return nickname; }
        }

        public override void DoBattleCry()
        {
            Console.WriteLine(" Squirtle Squirtle!");
        }
    }

    class Bulbasaur : Pokemon
    {
        private string nickname;

        public Bulbasaur(string nickname) : base("Bulbasaur", "grass", "fire")
        {
            this.nickname = nickname;
        }

        public override string Nickname
        {
            get { return nickname; }
        }

        public override void DoBattleCry()
        {
            Console.WriteLine(" Bulba Bulba!");
        }
    }
}