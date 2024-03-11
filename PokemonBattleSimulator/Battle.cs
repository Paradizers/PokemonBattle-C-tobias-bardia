using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PokemonBattleSimulator
{
    class Battle
    {
        int round = 0;
        int maxRounds = 6;
        int firstTrainerWins = 0;
        int secondTrainerWins = 0;

        public void StartBattle(string firstTrainer, string secondTrainer, List<Pokeball> trainerBelt, List<Pokeball> trainerBelt2)
        {
            int rounds = Math.Min(trainerBelt.Count, trainerBelt2.Count);
            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"{firstTrainer} throws: {trainerBelt[i].PokemonInside.Name}");
                Pokemon pokemonTrainer1 = trainerBelt[i].PokemonInside;
                pokemonTrainer1.DoBattleCry();

                Console.WriteLine($"{secondTrainer} throws: {trainerBelt2[i].PokemonInside.Name}");
                Pokemon pokemonTrainer2 = trainerBelt2[i].PokemonInside;
                pokemonTrainer2.DoBattleCry();

                Console.WriteLine($"{firstTrainer} calls {trainerBelt[i].PokemonInside.Name} back to the pokeball");
                Console.WriteLine($"{secondTrainer} calls {trainerBelt2[i].PokemonInside.Name} back to the pokeball");
            }
        }
    }
}
