using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }
        public void Go()
        {
            Console.Write("Which country you flied from: ");
            String country = Console.ReadLine();
            Console.Write("How many bags you had with you: ");
            String numberOfBags = Console.ReadLine();
            int bags = int.Parse(numberOfBags);
            Console.Write("Total weight of luggage: ");
            String totalWeight = Console.ReadLine();
            int weight = int.Parse(totalWeight);
            Console.WriteLine($"I flew from {country} with {bags} bags and a total weight of {weight} kg");

            //int total = fruit * 5;
            //Console.WriteLine("You entered: {0}", myInt);
            //Console.WriteLine("You entered currency: {0:C}", myInt);
            //Console.WriteLine("You entered fixed point {0:F}", myInt); 
            //Console.WriteLine("You entered exponential {0}", myInt.ToString("e"));
            //Console.WriteLine("We brought {0} and paid: {1:C}", fruit, total);
        }
    }
}
