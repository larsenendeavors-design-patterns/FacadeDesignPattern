using System;

namespace FacadeDesignPattern
{
    internal static class FacadePatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from the Derek Banas YouTube series in
         * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/08
         */
        
        private static void Main()
        {
            // Similar to the Adapter pattern the facade pattern is used when you have several interfaces that you
            // need to work, but you want to boil them down to make them easy to work with and give you common results.
            // Looking at IConfusing and INonsense, their methods don't mean anything, but by using a facade we're able
            // to translate their methods into something that at the very least gives expected output.
            var confusing = new Confusing();
            var nonsense = new Nonsense();
            var facadeExample = new FacadeExample(confusing, nonsense);

            Console.WriteLine(facadeExample.GetRollD20Message());
            Console.WriteLine(facadeExample.GetTheWordOne());
            facadeExample.PrintAddingThreeNumbers(1,2,3);
        }
    }

}