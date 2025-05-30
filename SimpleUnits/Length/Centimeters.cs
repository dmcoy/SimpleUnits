namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting values in centimeters to various other length units.
/// </summary>
public static class Centimeters
{
    /// <summary>
    /// Converts a value in centimeters to millimeters.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static float ToMillimeters(float value) => value * (float)Conversions.CentimetersToMillimeters;

    /// <summary>
    /// Converts a value in centimeters to millimeters.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static double ToMillimeters(double value) => value * Conversions.CentimetersToMillimeters;

    /// <summary>
    /// Converts a value in centimeters to meters.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static float ToMeters(float value) => value * (float)Conversions.CentimetersToMeters;

    /// <summary>
    /// Converts a value in centimeters to meters.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static double ToMeters(double value) => value * Conversions.CentimetersToMeters;

    /// <summary>
    /// Converts a value in centimeters to kilometers.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static float ToKilometers(float value) => value * (float)Conversions.CentimetersToKilometers;

    /// <summary>
    /// Converts a value in centimeters to kilometers.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static double ToKilometers(double value) => value * Conversions.CentimetersToKilometers;

    /// <summary>
    /// Converts a value in centimeters to inches.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static float ToInches(float value) => value * (float)Conversions.CentimetersToInches;

    /// <summary>
    /// Converts a value in centimeters to inches.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static double ToInches(double value) => value * Conversions.CentimetersToInches;

    /// <summary>
    /// Converts a value in centimeters to feet.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static float ToFeet(float value) => value * (float)Conversions.CentimetersToFeet;

    /// <summary>
    /// Converts a value in centimeters to feet.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static double ToFeet(double value) => value * Conversions.CentimetersToFeet;

    /// <summary>
    /// Converts a value in centimeters to yards.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static float ToYards(float value) => value * (float)Conversions.CentimetersToYards;

    /// <summary>
    /// Converts a value in centimeters to yards.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static double ToYards(double value) => value * Conversions.CentimetersToYards;

    /// <summary>
    /// Converts a value in centimeters to miles.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static float ToMiles(float value) => value * (float)Conversions.CentimetersToMiles;

    /// <summary>
    /// Converts a value in centimeters to miles.
    /// </summary>
    /// <param name="value">The value in centimeters.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static double ToMiles(double value) => value * Conversions.CentimetersToMiles;
}
