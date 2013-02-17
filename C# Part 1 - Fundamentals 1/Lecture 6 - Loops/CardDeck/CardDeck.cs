using System;

class CardDeck
{
    static void Main()
    {

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                string card = "";
                switch (i)
                {
                    case 2: card += "2 ";
                        break;
                    case 3: card += "3 ";
                        break;
                    case 4: card += "4 ";
                        break;
                    case 5: card += "5 ";
                        break;
                    case 6: card += "6 ";
                        break;
                    case 7: card += "7 ";
                        break;
                    case 8: card += "8 ";
                        break;
                    case 9: card += "9 ";
                        break;
                    case 10: card += "10 ";
                        break;
                    case 11: card += "Jack  ";
                        break;
                    case 12: card += "Queen ";
                        break;
                    case 13: card += "King ";
                        break;
                    case 14: card += "Ace ";
                        break;
                    default:
                        break;
                }

                switch (j)
                {
                    case 1: card += "Club";
                        break;
                    case 2: card += "Diamond";
                        break;
                    case 3: card += "Heart";
                        break;
                    case 4: card += "Spade";
                        break;
                    default:
                        break;
                }

                Console.WriteLine(card);
            }
            Console.WriteLine();
        }
    }
}