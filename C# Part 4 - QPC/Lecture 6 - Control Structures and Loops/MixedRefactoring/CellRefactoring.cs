using System;

class CellRefactoring
{
    private const int MIN_X = int.MinValue;
    private const int MAX_X = int.MaxValue;
    private const int MIN_Y = int.MinValue;
    private const int MAX_Y = int.MaxValue;

    public void CellTest(int x = 0, int y = 0)
    {
        bool xBiggerThanMin = (x >= MIN_X);
        bool xSmallerThanMax = (x <= MAX_X);
        bool yBiggerThanMin = (y >= MIN_Y);
        bool ySamllerThanMax = (y <= MAX_Y);
        bool isInRange = (xBiggerThanMin && xSmallerThanMax && yBiggerThanMin && ySamllerThanMax);
        bool shouldVisitCell = true; //giving true value for the test

        if (isInRange && shouldVisitCell)
        {
            VisitCell();
        }
    }

    private void VisitCell()
    {
        //cell visited
    }
}