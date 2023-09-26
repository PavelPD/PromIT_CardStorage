using System;
using System.Collections.Generic;

namespace PromIT_CardStorage
{
    internal class Card
    {
        public string Suit { get; set; } // Масть карты
        public string Rank { get; set; } // Номинал карты

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} \t {Suit}";
        }
    }
}
