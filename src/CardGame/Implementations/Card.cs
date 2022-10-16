using CodingChallenge.CardGame.Enums;
using CodingChallenge.CardGame.Interfaces;

namespace CodingChallenge.CardGame.Implementations
{
    public class Card : ICard
    {
        public Suit Suit { get; }
        public Value Value { get; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public bool Equals(ICard other)
        {
            return true;
        }
    }
}
