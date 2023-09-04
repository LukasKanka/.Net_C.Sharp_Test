namespace Metody2
{
    internal class Program
    {
        static void Main(string[] args) // zde pouštíme na importované medoty níže
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); // <-- zde místo náme může být SayHelloUser a také to bude fungovat

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); // <-- uživatel musí zadat číslo

            SayHelloUser(name, age);

            Console.ReadLine();
        }
        // další metoda
        static void SayHelloUser(string name, int age )
            /*
             * <-- toto je metoda a její parametr name propojíme s metodou výšše
             * Parametru můžeme do metody vložit více
             * Uvnitř metody může mít parametr jiný název
             *
             */
        {
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is: " + age);
        }


    }
}