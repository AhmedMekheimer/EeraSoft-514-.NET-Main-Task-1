namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate For Islam's Carpet Cleaning Service");
            Console.Write("Number of small carpets: ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets: ");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());
            int smallPrice = 25;    int largePrice = 35;
            Console.WriteLine($"Price per small carpet: ${smallPrice}");
            Console.WriteLine($"Price per large carpet: ${largePrice}");
            int cost = smallCarpets * smallPrice + largeCarpets * largePrice;
            Console.WriteLine($"Cost of Carpets: ${cost}");
            double taxRate = 0.06;
            Console.WriteLine($"Tax: ${taxRate * cost}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Total Cost: ${cost+taxRate * cost}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
