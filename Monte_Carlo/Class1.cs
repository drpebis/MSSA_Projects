using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo
{
    class MonteCarloRNGExample //This example was found off of:
                               //https://www.centerspace.net/examples/nmath/csharp/core/monte-carlo-random-number-generator-example.php
                               //It computes Pi slightly different than my example. 
    {
        static void Main(string[] args)
        {
            // Construct a random number generator that generates random deviates
            // distributed uniformly over the interval [-1,1]
            Random rng = new Random();

            // We'll approximate pi to within 5 digits.
            double tolerance = 1e-5;

            double piApproximation = 0;
            int total = 0;
            int numInCircle = 0;
            double x, y; // Coordinates of the random point.

            // Generate random points until our approximation within
            // the desired tolerance.
            while (Math.Abs(Math.PI - piApproximation) > tolerance)
            {
                x = rng.Next();
                y = rng.Next();
                if (x * x + y * y <= 1.0) // Is the point in the circle?
                {
                    ++numInCircle;
                }
                ++total;
                piApproximation = 4.0 * ((double)numInCircle / (double)total);
            }

            Console.WriteLine();

            Console.WriteLine("Pi calculated to within {0} digits with {1} random points.",
              -Math.Log10(tolerance), total);
            Console.WriteLine("Approximated Pi = {0}", piApproximation);

            Console.WriteLine();
            Console.WriteLine("Press Enter Key");
            Console.Read();
        }
    }
}