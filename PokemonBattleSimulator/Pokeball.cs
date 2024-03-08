using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator
{
    class Pokeball
    {
        public int catchRate;
        public string color;
        public Pokemon pokemon;

        public Pokemon PokemonInside
        {
            get { return pokemon; }
            set { pokemon = value; }
        }

        public Pokeball(int catchRate, string color, Pokemon pokemon)
        {
            this.catchRate = catchRate;
            this.color = color;
            this.pokemon = pokemon;
        }
    }
}
