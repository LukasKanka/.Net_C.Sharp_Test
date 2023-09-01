namespace Retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Spongebob";
            string lastName = "Squarepants";
            Console.WriteLine(firstName + " " + lastName);

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            // podřetězce
            string name = "Spongebob Squarepants";
            string sponge = name.Substring(0, 6);
            Console.WriteLine(sponge);

            // náhrada
            string pat = name.Replace("Spongebob", "Patrik");
            Console.WriteLine(pat);

            // délka řetězce
            string example = "The best character is Spongebob Squarepants!";
            Console.WriteLine(example.Length);

            // pozice řetězce
            int index = example.IndexOf("Spongebob");
            Console.WriteLine(index);

            Console.ReadLine();
        }
    }
}