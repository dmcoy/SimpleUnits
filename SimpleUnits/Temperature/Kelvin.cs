namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting temperatures from Kelvin to other units.
/// </summary>
public static class Kelvin
{
    /// <summary>
    /// Converts a temperature from Kelvin to Celsius.
    /// </summary>
    /// <param name="value">The temperature in Kelvin.</param>
    /// <returns>The equivalent temperature in Celsius.</returns>
    public static float ToCelsius(float value) => (value - 273.15f);

    /// <summary>
    /// Converts a temperature from Kelvin to Celsius.
    /// </summary>
    /// <param name="value">The temperature in Kelvin.</param>
    /// <returns>The equivalent temperature in Celsius.</returns>
    public static double ToCelsius(double value) => (value - 273.15d);

    /// <summary>
    /// Converts a temperature from Kelvin to Fahrenheit.
    /// </summary>
    /// <param name="value">The temperature in Kelvin.</param>
    /// <returns>The equivalent temperature in Fahrenheit.</returns>
    public static float ToFahrenheit(float value) => (1.8f * value) - 459.67f;

    /// <summary>
    /// Converts a temperature from Kelvin to Fahrenheit.
    /// </summary>
    /// <param name="value">The temperature in Kelvin.</param>
    /// <returns>The equivalent temperature in Fahrenheit.</returns>
    public static double ToFahrenheit(double value) => (1.8d * value) - 459.67d;
}
