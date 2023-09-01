namespace Kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our number multiplier!");
            Console.WriteLine("What is your first number?");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int results = firstNumber * secondNumber;
            Console.WriteLine("The result is: " +  results);
            Console.ReadLine();

        }
    }
}