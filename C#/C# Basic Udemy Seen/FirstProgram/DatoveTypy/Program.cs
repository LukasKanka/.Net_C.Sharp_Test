namespace DatoveTypy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // příklad zběratelská karta
            string firstName = "Spongebob";
            string lastName = "Squarepants";
            int age = 21;
            int weight = 20; 

            double height = 1.45;
            float height1 = 1.45f;
            decimal height2 = 1.45m; // velká přesnost, dlouhé číslo, vhodné do bank

            bool isFirstEditionCards = true;

            char grade = 'A'; // char oproti string má jedno písmeno





            Console.WriteLine(firstName);
            Console.WriteLine(lastName); 
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(height);
            Console.WriteLine(isFirstEditionCards);
            Console.WriteLine(grade);
            Console.ReadLine();
        }
    }
}