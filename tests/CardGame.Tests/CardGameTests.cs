using System.Diagnostics;
using CodingChallenge.CardGame.Enums;
using CodingChallenge.CardGame.Implementations;
using CodingChallenge.CardGame.Interfaces;
using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class CardGameTests
    {
        [Test]
        public void ProvideAPackOfCardsTest()
        {
            // Arrange
            var packOfCardsCreator = new PackOfCardsCreator();
            // Act
            IPackOfCards pack = packOfCardsCreator.Create();
            // Assert
            Debug.Assert(pack.Count == 52, "Check that 52 cards are returned");
        }

        [Test]
        public void TakeACardFromTheTopOfPackTest()
        {
            // Arrange
            IPackOfCards pack = new PackOfCards();
            // Act
            pack.TakeCardFromTopOfPack();
            // Assert
            Debug.Assert(pack.Count==51, "Check that deck size is 51");
        }

        [Test]
        public void ShufflePackSizeTest()
        {
            // Arrange
            IPackOfCards pack = new PackOfCardsCreator().Create();
            // Act
            pack.TakeCardFromTopOfPack();
            pack.Shuffle();
            // Assert
            Debug.Assert(pack.Count == 52, "Check deck has 52 cards once shuffled");
        }

        [Test]
        public void CheckUnshuffledPackIsCorrectSizeTest()
        {
            // Arrange, Act
            IPackOfCards pack = new PackOfCardsCreator().Create();           
            // Assert
            Debug.Assert(pack.Count == 52, "Check deck has 52 cards before being shuffled");
        }

        [Test]
        public void CheckUnshuffledPackReturnsSpadeKing()
        {
            // Arrange
            IPackOfCards pack = new PackOfCardsCreator().Create();;
            // Act
            ICard card = pack.TakeCardFromTopOfPack();
            // Assert
            Debug.Assert(card.Equals(new Card(Suit.Spades, Value.King)),"Tests that King Spade is top of an unshuffled pack");
        }

        [Test]
        public void ShufflePackComparedToUnsuffledPackTest()
        {
            // Arrange
            IPackOfCards unshuffledCards = new PackOfCardsCreator().Create();
            IPackOfCards shuffledCards = new PackOfCardsCreator().Create();
            // Act
            shuffledCards.Shuffle();
            // Assert
            var IsShuffled = false;

            for(var i = 0; i < unshuffledCards.Count; i++)
            {
                if(!unshuffledCards.TakeCardFromTopOfPack().Equals(shuffledCards.TakeCardFromTopOfPack()))
                {
                    IsShuffled = true;
                }
            }
            Debug.Assert(IsShuffled,"This is not a perfect test? Tests that the order of the sorted and unsorted packs is not the same. " +
                "A shuffled pack could potentailly be shuffled into the order it started" +
                "and as such has a very very unlikely chance of failure: 1 / (52*51*50*...*2), I would fire the croupier!");
        }
    }
}
