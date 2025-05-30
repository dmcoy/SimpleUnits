namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting values in millimeters to various other length units.
/// </summary>
public static class Millimeters
{
    /// <summary>
    /// Converts a value in millimeters to centimeters.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static float ToCentimeters(float value) => value * (float)Conversions.MillimetersToCentimeters;

    /// <summary>
    /// Converts a value in millimeters to centimeters.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static double ToCentimeters(double value) => value * Conversions.MillimetersToCentimeters;

    /// <summary>
    /// Converts a value in millimeters to meters.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static float ToMeters(float value) => value * (float)Conversions.MillimetersToMeters;

    /// <summary>
    /// Converts a value in millimeters to meters.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static double ToMeters(double value) => value * Conversions.MillimetersToMeters;

    /// <summary>
    /// Converts a value in millimeters to kilometers.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static float ToKilometers(float value) => value * (float)Conversions.MillimetersToKilometers;

    /// <summary>
    /// Converts a value in millimeters to kilometers.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static double ToKilometers(double value) => value * Conversions.MillimetersToKilometers;

    /// <summary>
    /// Converts a value in millimeters to inches.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static float ToInches(float value) => value * (float)Conversions.MillimetersToInches;

    /// <summary>
    /// Converts a value in millimeters to inches.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static double ToInches(double value) => value * Conversions.MillimetersToInches;

    /// <summary>
    /// Converts a value in millimeters to feet.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static float ToFeet(float value) => value * (float)Conversions.MillimetersToFeet;

    /// <summary>
    /// Converts a value in millimeters to feet.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static double ToFeet(double value) => value * Conversions.MillimetersToFeet;

    /// <summary>
    /// Converts a value in millimeters to yards.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static float ToYards(float value) => value * (float)Conversions.MillimetersToYards;

    /// <summary>
    /// Converts a value in millimeters to yards.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static double ToYards(double value) => value * Conversions.MillimetersToYards;

    /// <summary>
    /// Converts a value in millimeters to miles.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static float ToMiles(float value) => value * (float)Conversions.MillimetersToMiles;

    /// <summary>
    /// Converts a value in millimeters to miles.
    /// </summary>
    /// <param name="value">The value in millimeters.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static double ToMiles(double value) => value * Conversions.MillimetersToMiles;
}
