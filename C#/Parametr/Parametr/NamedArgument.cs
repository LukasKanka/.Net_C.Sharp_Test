using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametr
{
   public class NamedArgument
    {
        public static void Main(string[] args)
        {
            PrintEmployeeDetail("Franta", 12, 2015);

            PrintEmployeeDetail(age: 34, name: "Karel", empid: 2345); // tímto způsobem nemusíme dodržovat pořadí argumentů


        }
        static void PrintEmployeeDetail(string name, int age, int empid)
        {
            Console.WriteLine($"Name : {name}, Age : {age}, Employee ID : {empid}");
        }
    }
    
}
