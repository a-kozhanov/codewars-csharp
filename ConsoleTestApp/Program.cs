﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join(", ", FindMultiplesOfNumber.FindMultiples(5, 25)));
        }
    }
}
