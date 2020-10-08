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
            Console.WriteLine("Input velocities from a 20 shot test where there is 2 shots at each charge.");
            Console.WriteLine("Press enter between each velocity.");
            int[] shots = new int[20];
            int charge = 1;
            for (int i = 0; i < shots.Length; i++)
            {   
                string velocity;
                Console.Write("Charge " + charge + ": ");
                velocity = Console.ReadLine();
                shots[i] = Convert.ToInt32(velocity);
                if (i % 2 == 1)
                {
                    charge++;
                    Console.WriteLine();
                }
            }
            int bestCharge = (FindSpread(shots)/2) + 1;
            Console.WriteLine("Best spread was with charge: " + bestCharge);

        }

        public static int FindSpread(int[] shot)
        {
            int bestCharge = int.MaxValue;
            int best = int.MaxValue;
            for (int i = 0; i < shot.Length-1; i+=2)
            {
                int j = i + 1;
                int spread = Math.Abs(shot[i] - shot[j]);
                if (spread < best)
                {
                    best = spread;
                    bestCharge = i;
                }
            }
            return bestCharge;
        }

        public static void SDev()
        {
            Console.WriteLine("sdev");
        }
    }
}
