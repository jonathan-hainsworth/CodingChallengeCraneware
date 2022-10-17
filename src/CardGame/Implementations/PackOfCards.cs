using System;
using System.Collections;
using System.Collections.Generic;
using CodingChallenge.CardGame.Enums;
using CodingChallenge.CardGame.Interfaces;

namespace CodingChallenge.CardGame.Implementations
{
    public class PackOfCards : IPackOfCards
    {
        private List<ICard> pack;

        public PackOfCards()
        {
            pack = new List<ICard>(PopulateCards());
        }

        public IEnumerator<ICard> GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => pack.GetEnumerator();
        
        public int Count => pack.Count;

        public void Shuffle()
        {
            pack = PopulateCards();
            var numberOfCardSwaps = 1000000;

            for (var i = 0; i < numberOfCardSwaps; i++)
            {
                var swappedCardPosition = new Random().Next(52);
                ICard swappedCardLifted = pack[swappedCardPosition];
                pack.RemoveAt(swappedCardPosition);
                pack.Insert(new Random().Next(52), swappedCardLifted);
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            var cardPosition = pack.Count - 1;
            ICard cardToReturn = pack[cardPosition];
            pack.RemoveAt(cardPosition);
            return cardToReturn;
        }

        private static List<ICard> PopulateCards()
        {
            var returnPack = new List<ICard>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    returnPack.Add(new Card(suit, value));
                }
            }
            return returnPack;
        }
    }
}
