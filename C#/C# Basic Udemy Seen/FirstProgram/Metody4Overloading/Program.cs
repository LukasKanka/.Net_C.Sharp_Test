namespace Metody4Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6;
            int num2 = 16;

            int result = Add(num1, num2);

            Console.WriteLine("The result is: " + result);
            Console.ReadLine();
        }

        static int Add(int num1, int num2) // Add je metoda
        {
            return (num1 + num2);
        }

        /// <summary>
        /// Zde jsem otestoval funkčnost XML kometáře v metodě Add. Teď na ni stačí na jet myší.
        /// </summary>
        /// <param name="num1- je číslo"></param>
        /// <param name="num2"></param>
        /// <returns>vrací hodnotu čísel</returns>
        static double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        /*
         * Overloading --> přetížení
         * dovoluje mít jednu metodu, ale dát ji jiné parametry
         */
    }
}