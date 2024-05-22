using System;

public class De
{
    private Random random;

    public De()
    {
        random = new Random();
    }

    public int Lancer()
    {
        return random.Next(1, 21);
    }
}