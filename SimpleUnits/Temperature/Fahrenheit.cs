namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting temperatures from Fahrenheit to other units.
/// </summary>
public static class Fahrenheit
{
    private const float FtoC_FactorF = 5f / 9f;
    private const double FtoC_FactorD = 5d / 9d;

    /// <summary>
    /// Converts a temperature from Fahrenheit to Celsius.
    /// </summary>
    /// <param name="value">The temperature in Fahrenheit.</param>
    /// <returns>The equivalent temperature in Celsius.</returns>
    public static float ToCelsius(float value) => (value - 32f) * FtoC_FactorF;

    /// <summary>
    /// Converts a temperature from Fahrenheit to Celsius.
    /// </summary>
    /// <param name="value">The temperature in Fahrenheit.</param>
    /// <returns>The equivalent temperature in Celsius.</returns>
    public static double ToCelsius(double value) => (value - 32d) * FtoC_FactorD;

    /// <summary>
    /// Converts a temperature from Fahrenheit to Kelvin.
    /// </summary>
    /// <param name="value">The temperature in Fahrenheit.</param>
    /// <returns>The equivalent temperature in Kelvin.</returns>
    public static float ToKelvin(float value) => (value + 459.67f) / 1.8f;

    /// <summary>
    /// Converts a temperature from Fahrenheit to Kelvin.
    /// </summary>
    /// <param name="value">The temperature in Fahrenheit.</param>
    /// <returns>The equivalent temperature in Kelvin.</returns>
    public static double ToKelvin(double value) => (value + 459.67d) / 1.8d;
}
