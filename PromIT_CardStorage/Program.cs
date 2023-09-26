using System;
using System.Collections.Generic;

namespace PromIT_CardStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            СardDecksStorage сardDecks = new СardDecksStorage();

            сardDecks.CreateDeck("Колода 1");
            сardDecks.CreateDeck("Колода 2");
            сardDecks.CreateDeck("Колода 3");

            сardDecks.PrintNameDecks();

            сardDecks.RemoveDeck("Колода 1");

            сardDecks.PrintNameDecks();

            сardDecks.PrintDeck("Колода 2");
            сardDecks.PrintDeck("Колода 3");

            сardDecks.Shuffle("Колода 3");
            сardDecks.PrintDeck("Колода 3");
        }
    }
}
