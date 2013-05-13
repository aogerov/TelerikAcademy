using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string output = string.Empty;

            switch (this.Face)
            {
                case CardFace.Two: output += "2";
                    break;
                case CardFace.Three: output += "3";
                    break;
                case CardFace.Four: output += "4";
                    break;
                case CardFace.Five: output += "5";
                    break;
                case CardFace.Six: output += "6";
                    break;
                case CardFace.Seven: output += "7";
                    break;
                case CardFace.Eight: output += "8";
                    break;
                case CardFace.Nine: output += "9";
                    break;
                case CardFace.Ten: output += "10";
                    break;
                case CardFace.Jack: output += "J";
                    break;
                case CardFace.Queen: output += "Q";
                    break;
                case CardFace.King: output += "K";
                    break;
                case CardFace.Ace: output += "A";
                    break;
                default: throw new InvalidOperationException("Incorrect Face" + this.Face);
            }

            switch (this.Suit)
            {
                case CardSuit.Clubs: output += "♣";
                    break;
                case CardSuit.Diamonds: output += "♦";
                    break;
                case CardSuit.Hearts: output += "♥";
                    break;
                case CardSuit.Spades: output += "♠";
                    break;
                default: throw new InvalidOperationException("Incorrect Suit" + this.Suit);
            }
            
            return output;
        }
    }
}
