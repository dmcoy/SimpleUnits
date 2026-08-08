namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of temperature.
    /// </summary>
    public static class TemperatureExtensions
    {
        /// <summary>
        /// Converts a temperature from Celsius to Fahrenheit.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double CtoF(this double value) => Temperature.CtoF(value);

        /// <summary>
        /// Converts a temperature from Celsius to Fahrenheit.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float CtoF(this float value) => (float)Temperature.CtoF(value);

        /// <summary>
        /// Converts a temperature from Celsius to Kelvin.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double CtoK(this double value) => Temperature.CtoK(value);

        /// <summary>
        /// Converts a temperature from Celsius to Kelvin.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float CtoK(this float value) => (float)Temperature.CtoK(value);

        /// <summary>
        /// Converts a temperature from Fahrenheit to Celsius.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtoC(this double value) => Temperature.FtoC(value);

        /// <summary>
        /// Converts a temperature from Fahrenheit to Celsius.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtoC(this float value) => (float)Temperature.FtoC(value);

        /// <summary>
        /// Converts a temperature from Fahrenheit to Kelvin.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtoK(this double value) => Temperature.FtoK(value);

        /// <summary>
        /// Converts a temperature from Fahrenheit to Kelvin.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtoK(this float value) => (float)Temperature.FtoK(value);

        /// <summary>
        /// Converts a temperature from Kelvin to Celsius.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KtoC(this double value) => Temperature.KtoC(value);

        /// <summary>
        /// Converts a temperature from Kelvin to Celsius.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KtoC(this float value) => (float)Temperature.KtoC(value);

        /// <summary>
        /// Converts a temperature from Kelvin to Fahrenheit.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KtoF(this double value) => Temperature.KtoF(value);

        /// <summary>
        /// Converts a temperature from Kelvin to Fahrenheit.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KtoF(this float value) => (float)Temperature.KtoF(value);
    }
}
