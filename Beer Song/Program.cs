using System;
using System.Collections.Generic;

namespace BeerSong
{

    class Program
    {
        public static Main(string [] args)
        {
            string BeerSong();
        
            string lyrics = string.Empty;

            int startingpoint = 99;

            for (int index = startingpoint; index > 0; index--)
            {
                string line = string.Empty;

                if (index != 1)
                {
                    if (index == 2)
                    {
                        line = $"{index} bottles of beer on the wall,{index} bottles of beer." + "\n";
                        line = $"Take one down and pass it around,{index - 1} bottles of beer on the wall." + "\n";
                    }
                    else
                    {
                        line = $"{index} bottles of beer on the wall,{index} bottles of beer." + "\n";
                        line = $"Take one down and pass it around,{index - 1} bottles of beer on the wall." + "\n";
                    }
                }
                else
                {
                    line = $"{index} bottles of beer on the wall,{index} bottles of beer." + "\n";
                    line = $"Take one down and pass it around,{index - 1} bottles of beer on the wall." + "\n";

                }
                lyrics += line + "\n";
            }
            return lyrics;
        }
    }
}
   
 

