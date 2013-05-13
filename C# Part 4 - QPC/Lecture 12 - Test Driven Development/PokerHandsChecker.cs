using System;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            Hand handForTest = (Hand)hand;
            List<ICard> cards = (List<ICard>)handForTest.Cards;
            bool isValid = true;

            if (cards.Count != 5)
            {
                isValid = false;
                return isValid;
            }

            for (int i = 0; i < cards.Count - 1; i++)
            {
                Card firstCard = cards[i] as Card;

                for (int k = i + 1; k < cards.Count; k++)
                {
                    Card secondCard = cards[k] as Card;

                    if (firstCard.ToString() == secondCard.ToString())
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            return isValid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            Hand handForTest = (Hand)hand;
            List<ICard> cards = (List<ICard>)handForTest.Cards;
            int[] cardFaces = new int[5];

            for (int i = 0; i < cards.Count; i++)
            {
                int currentCardFace = (int)cards[i].Face;
                cardFaces[i] = currentCardFace;
            }

            int maxOccurrences = CountMaxFaceOccurrences(cardFaces);
            bool isFourOfAKind = maxOccurrences == 4;

            return isFourOfAKind;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            Hand handForTest = (Hand)hand;
            List<ICard> cards = (List<ICard>)handForTest.Cards;

            bool hasCorrectSuit = this.HasCorrectSuit(cards);
            bool hasCorrectFace = this.HasOrderedFaces(cards);
            bool isFlush = hasCorrectSuit && (!hasCorrectFace);

            return isFlush;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private static int CountMaxFaceOccurrences(int[] cardFaces)
        {
            int maxCount = 0;

            for (int i = 0; i < cardFaces.Length - 1; i++)
            {
                int currentCard = cardFaces[i];
                int occurrences = 1;

                for (int k = 1; k < cardFaces.Length; k++)
                {
                    if (currentCard == cardFaces[k])
                    {
                        occurrences++;
                    }
                }

                if (maxCount < occurrences)
                {
                    maxCount = occurrences;
                }
            }

            return maxCount;
        }

        private bool HasCorrectSuit(List<ICard> cards)
        {
            bool hasCorrectSuit = true;
            int cardSuit = (int)cards[0].Suit;

            for (int i = 1; i < cards.Count; i++)
            {
                Card card = cards[i] as Card;
                int currentCardSuit = (int)card.Suit;

                if (cardSuit != currentCardSuit)
                {
                    hasCorrectSuit = false;
                    break;
                }
            }

            return hasCorrectSuit;
        }

        private bool HasOrderedFaces(List<ICard> cards)
        {
            int[] cardFaces = new int[5];

            for (int i = 0; i < cards.Count; i++)
            {
                int currentCardFace = (int)cards[i].Face;
                cardFaces[i] = currentCardFace;
            }

            Array.Sort(cardFaces);
            bool hasOrderedFaces = true;

            for (int i = 0; i < cardFaces.Length - 1; i++)
            {
                if (cardFaces[i] + 1 != cardFaces[i + 1])
                {
                    hasOrderedFaces = false;
                    break;
                }
            }

            return hasOrderedFaces;
        }
    }
}
