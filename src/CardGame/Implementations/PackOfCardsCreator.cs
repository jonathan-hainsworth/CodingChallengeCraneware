using CodingChallenge.CardGame.Interfaces;

namespace CodingChallenge.CardGame.Implementations
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            return new PackOfCards();
        }
    }
}
