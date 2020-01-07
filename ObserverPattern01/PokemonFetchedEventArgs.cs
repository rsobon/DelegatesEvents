using System;
using ObserverPattern01.Object;

namespace ObserverPattern01
{
    public class PokemonFetchedEventArgs : EventArgs
    {
        public PokemonFetchedEventArgs(Pokemon pokemon)
        {
            Pokemon = pokemon;
        }

        public Pokemon Pokemon { get; set; }
    }
}
