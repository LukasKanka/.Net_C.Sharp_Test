
namespace Metody3Return
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = AkForUsersName();
            Console.WriteLine("Hello " + name);

            Console.ReadLine();
        }
        static string AkForUsersName() //navratová metoda
        {
            Console.WriteLine("What is your name?");
            string nameOfTheUser = Console.ReadLine();
            return nameOfTheUser; // vracíme proměnou string zpět do první metody
        }
    }
}