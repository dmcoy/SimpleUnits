using System;

namespace SimpleUnits
{
    internal static class Calculate
    {
        internal const double MaxTolerance = 1e-12;
        internal enum Operator
        {
            Divide,
            Multiply
        }

        internal static double TowardZero(double value, double factor)
        {
            bool isApproximatelyZero = false;
            if (value > factor)
            {
                double roundedValue = Math.Round(factor % value, 3);
                Console.WriteLine($"Rounded value: {roundedValue}");
                isApproximatelyZero = roundedValue == 0;
            }
            else if (factor < value)
            {
                isApproximatelyZero = value % factor == 0;
            }
            Console.WriteLine($"Is approx zero: {isApproximatelyZero}");
            return isApproximatelyZero ? Math.Round(value * factor) : value * factor;
        }
    }
}
