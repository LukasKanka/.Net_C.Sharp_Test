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

        static double Add(double num1, double num2) // Add je metoda
        {
            return (num1 + num2);
        }

        /*
         * Overloading --> přetížení
         * dovoluje mít jednu metodu, ale dát ji jiné parametry
         */
    }
}