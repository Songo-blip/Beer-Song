using System;
using System.Collections.Generic;

namespace BeerSong
{
    class Program
    {
                static void Main(string[] args)
        {
            for (int counter = 99; counter >= 0; counter--)
            {
                Console.WriteLine(counter + "bottles of beer on the wall, bottles of beer.");
                Console.WriteLine((counter) + "Take one down and pass it around, bottles of beer on the wall.");
            }
        }
    }
}

