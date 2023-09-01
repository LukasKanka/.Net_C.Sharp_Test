namespace VstupInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string results = Console.ReadLine();
            Console.WriteLine("Hello" + " " + results + "!");
            Console.ReadLine();
        }
    }
}