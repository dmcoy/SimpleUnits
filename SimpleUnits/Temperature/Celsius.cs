namespace SimpleUnits.Convert;

/// <summary>
/// Provides methods to convert Celsius temperatures to other units.
/// </summary>
public static class Celsius
{
    private const float CtoF_FactorF = 9f / 5f;
    private const double CtoF_FactorD = 9d / 5d;

    /// <summary>
    /// Converts a temperature from Celsius to Fahrenheit.
    /// </summary>
    /// <param name="value">Temperature in Celsius.</param>
    /// <returns>Temperature in Fahrenheit.</returns>
    public static float ToFahrenheit(float value) => (value * CtoF_FactorF) + 32f;

    /// <summary>
    /// Converts a temperature from Celsius to Fahrenheit.
    /// </summary>
    /// <param name="value">Temperature in Celsius.</param>
    /// <returns>Temperature in Fahrenheit.</returns>
    public static double ToFahrenheit(double value) => (value * CtoF_FactorD) + 32d;

    /// <summary>
    /// Converts a temperature from Celsius to Kelvin.
    /// </summary>
    /// <param name="value">Temperature in Celsius.</param>
    /// <returns>Temperature in Kelvin.</returns>
    public static float ToKelvin(float value) => (value + 273.15f);

    /// <summary>
    /// Converts a temperature from Celsius to Kelvin.
    /// </summary>
    /// <param name="value">Temperature in Celsius.</param>
    /// <returns>Temperature in Kelvin.</returns>
    public static double ToKelvin(double value) => (value + 273.15d);
}
