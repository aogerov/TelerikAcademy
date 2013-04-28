using System;
using Kitchen;

public class PotatoRefactoring
{
    public void PotatoTest()
    {
        Potato potato = new Potato();

        if (potato != null)
        {
            if (potato.IsPeeled)
            {
                if (!potato.IsRotten)
                {
                    Cook(potato);
                }
            }
        }
        else
        {
            throw new ArgumentNullException("Potato don't exists.");
        }
    }

    private void Cook(Potato potato)
    {
        //cooking potato
    }
}