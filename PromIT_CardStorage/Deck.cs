using System;
using System.Collections.Generic;

namespace PromIT_CardStorage
{
    internal class Deck
    {
        private List<Card> cards; // Колода кард

        public Deck() // Добавляем в лист все возможные карты
        {
            cards = new List<Card>();

            string[] suits = { "Heart", "Diamond", "Club", "Spade" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10",
                "Jack", "Queen", "King", "Ace", };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Card card = new Card(suit, rank);
                    cards.Add(card);
                }
            }
        }        

        public void Print() // Вывод колоды
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ранк \t Масть");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var card in cards)
            {                
                Console.Write(card.ToString());
                Console.WriteLine();
            }
        }
        
        public void ShuffleCard() // Тасование Фишера–Йетса
        {
            Random rand = new Random();

            for (int i = cards.Count - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                Card value = cards[k];
                cards[k] = cards[i];
                cards[i] = value;
            }
        }        
    }
}