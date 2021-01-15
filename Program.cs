using System;
using System.Collections.Generic;

namespace AllCardsOnDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numberOfCardsInDeck = 52;
            var suits = new List<string>() { "Clubs", "Hearts", "Spades", "Diamonds" };
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var deck = new List<string>();

            foreach (var suit in suits)   // Grabs first var in "suits" then :
            {
                foreach (var rank in ranks)    // Grabs each var in "ranks" then goes back ^ until each var in "suits" is exhausted.
                {
                    deck.Add($"{rank} of {suit}");    // This creates the deck by adding rank and suit to deck List
                }

            }

            // numberOfCards = length of our deck
            var numberOfCards = deck.Count;

            // for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)   // Setting rightIndex to numberOfCards (52) -1 (51). As long as rightIndex is greater than or equal to 1, subtract 1.
            {
                //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer"
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                //   Now swap the values at rightIndex and leftIndex by doing this:
                //     leftCard = the value from deck[leftIndex]
                //     rightCard = the value from deck[rightIndex]
                //     deck[rightIndex] = leftCard
                //     deck[leftIndex] = rightCard
                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;
            } // This was a lot of fun.
            Console.WriteLine($"{deck[0]}, {deck[1]}");
        }
    }
}
