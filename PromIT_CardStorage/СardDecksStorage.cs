using System;
using System.Collections.Generic;

namespace PromIT_CardStorage
{
    internal class СardDecksStorage
    {
        private Dictionary<string, Deck> cardDecks; // Список именованных колод

        public СardDecksStorage()
        {
            cardDecks = new Dictionary<string, Deck>();
        }

        // Метод создания и добавления колоды в список
        public void CreateDeck(string name)
        {
            Deck deck = new Deck();
            AddDeck(name, deck);
        }
        
        //Метод добавления колоды в список
        public void AddDeck(string name, Deck deck)
        {
            cardDecks.Add(name, deck);
        }

        // Метод вывода колоды по имени
        public void PrintDeck(string name)
        {
            Console.WriteLine($"\nКолода: {name}");

            if (cardDecks.ContainsKey(name))
                cardDecks[name].Print();
            else
                throw new KeyNotFoundException("Колоды с таким именем не существует");
        }

        // Метод удаления колоды из хранилища
        public void RemoveDeck(string name)
        {
            if (cardDecks.ContainsKey(name))
                cardDecks.Remove(name);                           
            else
                throw new KeyNotFoundException("Колоды с таким именем не существует");
        }

        // Метод вывода имен хранящихся колод
        public void PrintNameDecks()
        {
            Console.WriteLine("\nХранящиеся колоды:");

            foreach (var name in cardDecks.Keys)
                Console.WriteLine(name);
        }

        // Метод тасование
        public void Shuffle(string name)
        {
            cardDecks[name].ShuffleCard();
        }
    }
}