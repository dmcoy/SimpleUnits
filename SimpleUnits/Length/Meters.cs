namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting values in meters to various other length units.
/// </summary>
public static class Meters
{
    /// <summary>
    /// Converts a value in meters to millimeters.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static float ToMillimeters(float value) => value * (float)Conversions.MetersToMillimeters;

    /// <summary>
    /// Converts a value in meters to millimeters.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static double ToMillimeters(double value) => value * Conversions.MetersToMillimeters;

    /// <summary>
    /// Converts a value in meters to centimeters.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static float ToCentimeters(float value) => value * (float)Conversions.MetersToCentimeters;

    /// <summary>
    /// Converts a value in meters to centimeters.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static double ToCentimeters(double value) => value * Conversions.MetersToCentimeters;

    /// <summary>
    /// Converts a value in meters to kilometers.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static float ToKilometers(float value) => value * (float)Conversions.MetersToKilometers;

    /// <summary>
    /// Converts a value in meters to kilometers.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static double ToKilometers(double value) => value * Conversions.MetersToKilometers;

    /// <summary>
    /// Converts a value in meters to inches.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static float ToInches(float value) => value * (float)Conversions.MetersToInches;

    /// <summary>
    /// Converts a value in meters to inches.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static double ToInches(double value) => value * Conversions.MetersToInches;

    /// <summary>
    /// Converts a value in meters to feet.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static float ToFeet(float value) => value * (float)Conversions.MetersToFeet;

    /// <summary>
    /// Converts a value in meters to feet.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static double ToFeet(double value) => value * Conversions.MetersToFeet;

    /// <summary>
    /// Converts a value in meters to yards.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static float ToYards(float value) => value * (float)Conversions.MetersToYards;

    /// <summary>
    /// Converts a value in meters to yards.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static double ToYards(double value) => value * Conversions.MetersToYards;

    /// <summary>
    /// Converts a value in meters to miles.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static float ToMiles(float value) => value * (float)Conversions.MetersToMiles;

    /// <summary>
    /// Converts a value in meters to miles.
    /// </summary>
    /// <param name="value">The value in meters.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static double ToMiles(double value) => value * Conversions.MetersToMiles;
}
