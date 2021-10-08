using System;

namespace FacadeDesignPattern
{
    public class Nonsense : INonsense
    {
        public void N(int x, int y, int apples)
        {
            Console.WriteLine(x + y + apples);
        }
    }
}