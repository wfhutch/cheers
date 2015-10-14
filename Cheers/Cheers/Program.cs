using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there! What's your name?");
            string name = System.Console.ReadLine();
            string lowName = name.ToLower();
            System.Console.WriteLine("Hi, " + name);
            foreach (char letter in lowName)
            {
                string anLetters = "halfnorsemixHALFNORSEMIX";
                if (anLetters.IndexOf(letter) == -1)
                {
                    System.Console.WriteLine("Give me a .. " + letter);
                    System.Console.ReadLine();
                }
                else
                {
                    System.Console.WriteLine("Give me an .. " + letter);
                    System.Console.ReadLine();
                }  
            }
            string newName = name.ToUpper();
            System.Console.WriteLine(newName + " is.. GRAND!");
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
