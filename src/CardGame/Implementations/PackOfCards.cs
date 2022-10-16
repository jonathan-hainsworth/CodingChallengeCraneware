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
            throw new NotImplementedException();
        }

        public ICard TakeCardFromTopOfPack()
        {
            throw new NotImplementedException();
        }

        private static List<ICard> PopulateCards()
        {
            throw new NotImplementedException();
        }
    }
}
