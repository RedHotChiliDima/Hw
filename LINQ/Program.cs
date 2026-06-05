using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card();

            var startingDeck = card1.Suits()
                .SelectMany(s => card1.Ranks(), (suit, rank) => (Suit: suit, Rank: rank));

            Console.WriteLine("Исходная колода:");
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffledDeck = top.InterleaveSequences(bottom);

            Console.WriteLine("\nПервое перемешивание:");
            foreach (var card in shuffledDeck)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("\nМножественное перемешивание:");
            var deckCopy = startingDeck.ToList();
            int times = 0;

            do
            {
                deckCopy = deckCopy.Take(20).InterleaveSequences(deckCopy.Skip(20)).ToList();

                Console.WriteLine($"Перемешивание {++times}:");
                foreach (var card in deckCopy)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine();
            } while (!deckCopy.SequencesEqual(startingDeck));

            Console.WriteLine($"Колода совпала после {times} перемешиваний");
        }
    }
}
