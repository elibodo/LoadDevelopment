using System;

namespace LoadDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("This app will help the user find a load for reloading rifle ammunition.");
            Console.WriteLine("\n\nTo find the lowest spread and a good starting point for a new load type 'SPREAD'");
            Console.WriteLine("\n\nTo find the best standard deviation using 5 shot groups type 'SDEV'.\n");
            while (input != "SPREAD" || input != "SDEV")
            {
                input = Console.ReadLine().ToUpper();

                if (input == "SPREAD")
                {
                    Spread();
                }
                else if (input == "SDEV")
                {
                    SDev();
                }
            }
        }

        public static void Spread()
        {
            Console.WriteLine("spread");
        }

        public static void SDev()
        {
            Console.WriteLine("sdev");
        }
    }
}
