using System.Collections.Generic;

namespace CodingChallenge.CardGame.Interfaces
{
    public interface IPackOfCards : IReadOnlyCollection<ICard>
    {
        public void Shuffle();

        public ICard TakeCardFromTopOfPack();
    }
}
