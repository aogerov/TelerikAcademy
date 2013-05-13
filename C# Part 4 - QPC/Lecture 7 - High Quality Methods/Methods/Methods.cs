using System;

namespace Methods
{
    public class Methods
    {
        public static void Main()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double triangleArea = CalcTriangleArea(sideA, sideB, sideC);
            Console.WriteLine(triangleArea);

            int digit = 5;
            string digitAsString = DigitToString(digit);
            Console.WriteLine(digitAsString);

            int[] numbers = { 5, -1, 3, 2, 14, 2, 3 };
            int maxNumber = FindMax(numbers);
            Console.WriteLine(maxNumber);

            double numberAsFloat = 1.3;
            int digitsAterDecimalPoint = 2;
            PrintNumberAsFloat(numberAsFloat, digitsAterDecimalPoint);

            double numberAsPercent = 0.75;
            PrintNumberAsPercent(numberAsPercent);

            double numberRightOriented = 2.30;
            int offset = 8;
            PrintNumberRightOriented(numberRightOriented, offset);

            double x1 = 3;
            double y1 = -1;
            double x2 = 3;
            double y2 = 2.5;
            bool horizontal = CheckLineHorizontality(y1, y2);
            bool vertical = CheckLineVerticality(x1, x2);
            double distance = CalcDistance(x1, y1, x2, y2);
            Console.WriteLine("Distance : " + distance);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student()
            {
                FirstName = "Peter",
                LastName = "Ivanov",
                Born = new DateTime(1992, 3, 17),
                OtherInfo = "From Sofia"
            };

            Student stella = new Student()
            {
                FirstName = "Stella",
                LastName = "Markova",
                Born = new DateTime(1993, 11, 3),
                OtherInfo = "From Vidin, gamer, high results"
            };

            bool peterIsOlderThanStella =
                StudetsComparator.IsFirstIsOlderThanSecond(peter, stella);
            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peterIsOlderThanStella);
        }

        private static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double perimeterHalf = (sideA + sideB + sideC) / 2;
            double areaWithHeronsFormula = Math.Sqrt(perimeterHalf *
                (perimeterHalf - sideA) * (perimeterHalf - sideB) * (perimeterHalf - sideC));
            return areaWithHeronsFormula;
        }

        private static string DigitToString(int digit)
        {
            if (digit < 0)
            {
                throw new ArgumentException("Digit can't be negative!");
            }
            else if (digit > 9)
            {
                throw new ArgumentException("Digit is bigger tha 9");
            }

            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";

                default: throw new ArgumentException("Unexpected error!");
            }
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Array don't exists in heap memory.");
            }
            else if (elements.Length == 0)
            {
                throw new ArgumentException("Array should contain at least 1 element!");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        private static void PrintNumberAsFloat(double number, int digitsAterDecimalPoint)
        {
            if (digitsAterDecimalPoint < 0)
            {
                throw new ArgumentException("digitsAterDecimalPoint can't be negative!");
            }

            string formatedOutput = "{0:f" + digitsAterDecimalPoint + "}";
            Console.WriteLine(formatedOutput, number);
        }

        private static void PrintNumberAsPercent(double number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        private static void PrintNumberRightOriented(double number, int offset)
        {
            if (offset < 0)
            {
                throw new ArgumentException("offset can't be negative!");
            }

            string formatedOutput = "{0," + offset + "}";
            Console.WriteLine(formatedOutput, number);
        }

        private static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        private static bool CheckLineHorizontality(double y1, double y2)
        {
            bool isHorizontal = (y1 == y2);
            return isHorizontal;
        }

        private static bool CheckLineVerticality(double x1, double x2)
        {
            bool isVertical = (x1 == x2);
            return isVertical;
        }
    }
}
