using System;
using CodingChallenge.CardGame.Enums;

namespace CodingChallenge.CardGame.Interfaces
{
    public interface ICard : IEquatable<ICard>
    {
        Suit Suit { get; }

        Value Value { get; }
    }
}
