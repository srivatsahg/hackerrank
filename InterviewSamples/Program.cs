using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int[] arr = new[] { 1, 2, 1, 2, 1, 3, 2 };

            sockMerchant(arr);

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }

        private static void sockMerchant(int[] arr)
        {
            int pairCount = 0;

            var query = arr.Distinct().ToList();

            int possibleColors = query.Count;

            int[] colorCount = new int[possibleColors];

            foreach (var element in query)
            {
                var filtered = arr.Where(e => e == element).ToList().Count;
                if(filtered >= 2)
                {
                    pairCount += (filtered / 2);
                }
            }

            Console.WriteLine($"Total pairs : {pairCount}");

        }
    }
}
