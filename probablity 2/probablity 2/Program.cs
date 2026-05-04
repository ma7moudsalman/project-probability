using System;

class Program
{
    static void Main()
    {
        int[] values = {115, 182, 191, 31, 196, 1099, 5, 172, 10, 179,
                        83, 21, 20, 21, 186, 177, 195, 193,
                        188, 199, 62, 109, 105, 183, 110};

        int n = values.Length;

        // Sort first
        Array.Sort(values);

        // Quartiles
        double firstQuartile = values[n / 4];
        double thirdQuartile = values[(3 * n) / 4];

        // IQR
        double interRange = thirdQuartile - firstQuartile;

        // Limits
        double minLimit = firstQuartile - (1.5 * interRange);
        double maxLimit = thirdQuartile + (1.5 * interRange);

        Console.WriteLine("Checking Outliers...");
        Console.WriteLine("Lower Limit: " + minLimit);
        Console.WriteLine("Upper Limit: " + maxLimit);

        Console.WriteLine();

        int i = 0;

        while (i < n)
        {
            if (values[i] < minLimit || values[i] > maxLimit)
            {
                Console.WriteLine("Value " + values[i] + " is Outlier");
            }
            else
            {
                Console.WriteLine("Value " + values[i] + " is Normal");
            }

            i++;
        }
    }
}