namespace SimpleUnits.Convert;

using System;
using SimpleUnits;

/// <summary>
/// Provides static methods for converting between different units of temperature.
/// </summary>
public static class AnyTemperature
{
    /// <summary>
    /// Converts a value from the specified <see cref="Temperature"/> unit to Celsius.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to Celsius.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already Celsius or unsupported.</exception>
    public static float ToCelsius(float value, Temperature unit)
    {
        return unit switch
        {
            Temperature.Celsius => throw new ArgumentException("Cannot convert the same units"),
            Temperature.Fahrenheit => Fahrenheit.ToCelsius(value),
            Temperature.Kelvin => Kelvin.ToCelsius(value),
            _ => throw new ArgumentException($"Unsupported temperature unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Temperature"/> unit to Celsius.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to Celsius.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already Celsius or unsupported.</exception>
    public static double ToCelsius(double value, Temperature unit)
    {
        return unit switch
        {
            Temperature.Celsius => throw new ArgumentException("Cannot convert the same units"),
            Temperature.Fahrenheit => Fahrenheit.ToCelsius(value),
            Temperature.Kelvin => Kelvin.ToCelsius(value),
            _ => throw new ArgumentException($"Unsupported temperature unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Temperature"/> unit to Fahrenheit.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to Fahrenheit.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already Fahrenheit or unsupported.</exception>
    public static float ToFahrenheit(float value, Temperature unit)
    {
        return unit switch
        {
            Temperature.Celsius => Celsius.ToFahrenheit(value),
            Temperature.Fahrenheit => throw new ArgumentException("Cannot convert the same units"),
            Temperature.Kelvin => Kelvin.ToFahrenheit(value),
            _ => throw new ArgumentException($"Unsupported temperature unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Temperature"/> unit to Fahrenheit.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to Fahrenheit.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already Fahrenheit or unsupported.</exception>
    public static double ToFahrenheit(double value, Temperature unit)
    {
        return unit switch
        {
            Temperature.Celsius => Celsius.ToFahrenheit(value),
            Temperature.Fahrenheit => throw new ArgumentException("Cannot convert the same units"),
            Temperature.Kelvin => Kelvin.ToFahrenheit(value),
            _ => throw new ArgumentException($"Unsupported temperature unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Temperature"/> unit to Kelvin.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to Kelvin.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already Kelvin or unsupported.</exception>
    public static float ToKelvin(float value, Temperature unit)
    {
        return unit switch
        {
            Temperature.Celsius => Celsius.ToKelvin(value),
            Temperature.Fahrenheit => Fahrenheit.ToKelvin(value),
            Temperature.Kelvin => throw new ArgumentException("Cannot convert the same units"),
            _ => throw new ArgumentException($"Unsupported temperature unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Temperature"/> unit to Kelvin.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to Kelvin.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already Kelvin or unsupported.</exception>
    public static double ToKelvin(double value, Temperature unit)
    {
        return unit switch
        {
            Temperature.Celsius => Celsius.ToKelvin(value),
            Temperature.Fahrenheit => Fahrenheit.ToKelvin(value),
            Temperature.Kelvin => throw new ArgumentException("Cannot convert the same units"),
            _ => throw new ArgumentException($"Unsupported temperature unit: {unit}")
        };
    }
}
