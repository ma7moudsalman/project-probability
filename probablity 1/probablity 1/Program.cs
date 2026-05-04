using System;

class Program
{
    static void Main()
    {
        int[] data = {115, 182, 191, 31, 196, 1099, 5, 172, 10, 179,
                      83, 21, 20, 21, 186, 177, 195, 193,
                      188, 199, 62, 109, 105, 183, 110};

        int size = data.Length;

        // Sort
        Array.Sort(data);

        // Sum
        double total = 0;
        int i = 0;

        while (i < size)
        {
            total = total + data[i];
            i++;
        }

        double mean = total / size;

        // Median
        double medianValue;

        if (size % 2 == 0)
        {
            medianValue = (data[size / 2] + data[(size / 2) - 1]) / 2.0;
        }
        else
        {
            medianValue = data[size / 2];
        }

        // Mode
        int modeValue = data[0];
        int highestCount = 0;

        int a = 0;

        while (a < size)
        {
            int count = 0;
            int b = 0;

            while (b < size)
            {
                if (data[a] == data[b])
                {
                    count++;
                }
                b++;
            }

            if (count > highestCount)
            {
                highestCount = count;
                modeValue = data[a];
            }

            a++;
        }

        // Variance
        double variance = 0;
        int c = 0;

        while (c < size)
        {
            variance += Math.Pow(data[c] - mean, 2);
            c++;
        }

        variance = variance / size;

        double stdDev = Math.Sqrt(variance);

        // Range
        int rangeValue = data[size - 1] - data[0];

        // Quartiles
        double Q1 = data[size / 4];
        double Q2 = medianValue;
        double Q3 = data[(3 * size) / 4];

        double IQR = Q3 - Q1;

        // Percentiles
        double P20 = data[(int)(0.20 * size)];
        double P50 = data[(int)(0.50 * size)];

        Console.WriteLine("Mean = " + mean);
        Console.WriteLine("Median = " + medianValue);
        Console.WriteLine("Mode = " + modeValue);

        Console.WriteLine("Variance = " + variance);
        Console.WriteLine("Standard Deviation = " + stdDev);

        Console.WriteLine("Range = " + rangeValue);

        Console.WriteLine("P20 = " + P20);
        Console.WriteLine("P50 = " + P50);

        Console.WriteLine("Q1 = " + Q1);
        Console.WriteLine("Q2 = " + Q2);
        Console.WriteLine("Q3 = " + Q3);

        Console.WriteLine("Interquartile Range = " + IQR);

        Console.WriteLine("Summation = " + total);
    }
}