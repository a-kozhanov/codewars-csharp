﻿using System;
using System.Linq;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new string("world".Reverse().ToArray()));
            //Console.WriteLine(ReversedStrings.Solution("world"));

            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 1, 11, 2, 3 })); //6
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 6, 2, 1, 8, 10 })); //16
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 2, 3 })); 
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 2})); 
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 3 }));
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(null));

            //Console.WriteLine(TitleCase.titleCase("a an the of", "a clash of KINGS"));    //"A Clash of Kings"
            //Console.WriteLine(TitleCase.titleCase("The In", "THE WIND IN THE WILLOWS"));  //"The Wind in the Willows"
            //Console.WriteLine(TitleCase.titleCase("the quick brown fox"));                         //"The Quick Brown Fox"


            //Console.WriteLine(BreakCamelCase.breakCamelCase("c a m e l CamelCasing"));
            //Console.WriteLine(BreakCamelCase.breakCamelCase("camelCasingTest"));
            //Console.WriteLine(BreakCamelCase.breakCamelCase("...Sm Xjbjr Jiw Sijuop Q Xcwt Pcy Bwowulhs Feyz Bx L N Pqjsghc J"));

            //Console.WriteLine(Divisors.divisors(30));

            MexicanWave mexicanWave = new MexicanWave();
            //Console.WriteLine(mexicanWave.wave("hello"));
            //Console.WriteLine(mexicanWave.wave("two words"));
            foreach (var w in mexicanWave.wave("two words"))
            {
                Console.WriteLine(w);
            }

        }
    }
}
