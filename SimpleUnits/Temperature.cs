namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of temperature.
/// </summary>
public static class Temperature
{
    #region Conversion Factors
    /// <summary>Converts Celsius to Fahrenheit.</summary>
    private static double CelsiusToFahrenheit(double c) => (c * 9.0 / 5.0) + 32.0;
    /// <summary>Converts Celsius to Kelvin.</summary>
    private static double CelsiusToKelvin(double c) => c + 273.15;

    /// <summary>Converts Fahrenheit to Celsius.</summary>
    private static double FahrenheitToCelsius(double f) => (f - 32.0) * 5.0 / 9.0;
    /// <summary>Converts Fahrenheit to Kelvin.</summary>
    private static double FahrenheitToKelvin(double f) => (f - 32.0) * 5.0 / 9.0 + 273.15;

    /// <summary>Converts Kelvin to Celsius.</summary>
    private static double KelvinToCelsius(double k) => k - 273.15;
    /// <summary>Converts Kelvin to Fahrenheit.</summary>
    private static double KelvinToFahrenheit(double k) => (k - 273.15) * 9.0 / 5.0 + 32.0;
    #endregion

    static Temperature()
    {
        // Register Temperature unit
        UnitConverter.RegisterUnit(typeof(TemperatureUnit), BaseUnit.Temperature);
        // Celsius conversions
        UnitConverter.RegisterConversion(TemperatureUnit.C, TemperatureUnit.F, CelsiusToFahrenheit);
        UnitConverter.RegisterConversion(TemperatureUnit.C, TemperatureUnit.K, CelsiusToKelvin);
        // Fahrenheit conversions
        UnitConverter.RegisterConversion(TemperatureUnit.F, TemperatureUnit.C, FahrenheitToCelsius);
        UnitConverter.RegisterConversion(TemperatureUnit.F, TemperatureUnit.K, FahrenheitToKelvin);
        // Kelvin conversions
        UnitConverter.RegisterConversion(TemperatureUnit.K, TemperatureUnit.C, KelvinToCelsius);
        UnitConverter.RegisterConversion(TemperatureUnit.K, TemperatureUnit.F, KelvinToFahrenheit);
    }

    /// <summary>
    /// Converts a value from one temperature unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of temperature.</param>
    /// <param name="to">The target unit of temperature.</param>
    /// <returns>The converted value in the target unit.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, TemperatureUnit from, TemperatureUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Represents temperature measurement units.
/// </summary>
public enum TemperatureUnit
{
    /// <summary>
    /// Celsius (C).
    /// </summary>
    C,
    /// <summary>
    /// Fahrenheit (F).
    /// </summary>
    F,
    /// <summary>
    /// Kelvin (K).
    /// </summary>
    K
}