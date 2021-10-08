using System;

namespace FacadeDesignPattern
{
    public class Confusing : IConfusing
    {
        public string MethodOne()
        {
            return "One";
        }

        public string MethodTwo()
        {
            var random = new Random();
            return "You roll a D20 and it lands on " + random.Next(1, 20);
        }
    }
}