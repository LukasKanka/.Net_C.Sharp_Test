namespace Metody
{
    internal class Program
    {
        static void Main(string[] args) // zde pouštíme na importované medoty níže
        {
           SayHelloWorld(); // <-- Parametr
           CusSportak();
            Console.ReadLine();
        }
        // další metoda
        static void SayHelloWorld() // <-- toto je metoda
        {
            Console.WriteLine("HelloWorld!");
        }

        static void CusSportak()
        {
            Console.WriteLine("Čus Sporťák!");
        }
    }
}
