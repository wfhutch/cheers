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
            System.Console.WriteLine("What's your birthday? (MM/DD)"); 
            string birthday = System.Console.ReadLine();
            DateTime userDate = Convert.ToDateTime(birthday);
            DateTime dateNow = DateTime.Now.Date;
            string lowName = name.ToLower();
            System.Console.WriteLine("Hi, " + name);
            foreach (char letter in lowName)
            {
                string anLetters = "halfnorsemix";
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
            System.Console.WriteLine(newName + "'s just GRAND!");
            var days = Math.Abs((userDate - dateNow).TotalDays);
            if (userDate == dateNow)
            {
                System.Console.WriteLine("Happy Birthday!");
            }
            else
            if (userDate < dateNow)
            {
                userDate = userDate.AddYears(1);
                System.Console.WriteLine("Your birthday is " + Math.Abs((userDate - dateNow).TotalDays) + " days away!");
            }
            else
            if (days == 1)
            {
                System.Console.WriteLine("Your birthday is " + days + " day away!");
            }
            else
            {
                System.Console.WriteLine("Your birthday is " + days + " days away!");
            }
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
