using System;
using System.Linq;
using System.Collections.Generic;

namespace Studio2
{
    class Program
    {
        static string stringToCheck = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

        static Dictionary<char, int> characterCounts = new Dictionary<char, int>();

        static void Main(string[] args){
            for (int a = 0; a < stringToCheck.Length; a++)
            {
                char currentChar = stringToCheck[a];

                if (characterCounts.ContainsKey(currentChar))
                {
                    characterCounts[currentChar]++;
                }
                else
                {
                    characterCounts.Add(currentChar, 1);
                }
            }

            List<char> characterNames = new List<char>(characterCounts.Keys.ToList());

            for (int a = 0; a < characterCounts.Count; a++)
            {
                Console.WriteLine(characterNames[a]+": " + characterCounts[characterNames[a]]);
            }

            Console.ReadLine();
        }
    }
}