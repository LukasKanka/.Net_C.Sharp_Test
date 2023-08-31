using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class JednoduchaKalkulacka
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo pro sčítání");
            int i1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte číslo pro sčítání");
            int i2 = int.Parse(Console.ReadLine());

           

            Console.WriteLine("Napište + pro sčítání, - pro odčítání, * pro násobení, / pro dělení.");

            string result = Console.ReadLine();
            if (result == "+")
            {
                Console.WriteLine (i1 + i2);
            }
            else if (result == "-")
            {
                Console.WriteLine(i1 - i2);
            }
            else if (result == "*")
            {
                Console.WriteLine(i1 * i2);
            }
            else if (result == "/")
            {
                if (i2 ! == 0)
                {
                    Console.WriteLine(i1 / i2);
                }
                else
                {
                    Console.WriteLine("Výraz nemůže být nula!");
                }
                
            }
            else
            {
                Console.WriteLine("Nebyl zadán ani jeden požadovaný znak!");
            }

            
        }
    }
}
