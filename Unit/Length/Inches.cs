namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting values in inches to various other length units.
/// </summary>
public static class Inches
{
    /// <summary>
    /// Converts a value in inches to millimeters.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static float ToMillimeters(float value) => value * (float)Conversions.InchesToMillimeters;

    /// <summary>
    /// Converts a value in inches to millimeters.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static double ToMillimeters(double value) => value * Conversions.InchesToMillimeters;

    /// <summary>
    /// Converts a value in inches to centimeters.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static float ToCentimeters(float value) => value * (float)Conversions.InchesToCentimeters;

    /// <summary>
    /// Converts a value in inches to centimeters.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static double ToCentimeters(double value) => value * Conversions.InchesToCentimeters;

    /// <summary>
    /// Converts a value in inches to meters.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static float ToMeters(float value) => value * (float)Conversions.InchesToMeters;

    /// <summary>
    /// Converts a value in inches to meters.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static double ToMeters(double value) => value * Conversions.InchesToMeters;

    /// <summary>
    /// Converts a value in inches to kilometers.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static float ToKilometers(float value) => value * (float)Conversions.InchesToKilometers;

    /// <summary>
    /// Converts a value in inches to kilometers.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static double ToKilometers(double value) => value * Conversions.InchesToKilometers;

    /// <summary>
    /// Converts a value in inches to feet.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static float ToFeet(float value) => value * (float)Conversions.InchesToFeet;

    /// <summary>
    /// Converts a value in inches to feet.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static double ToFeet(double value) => value * Conversions.InchesToFeet;

    /// <summary>
    /// Converts a value in inches to yards.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static float ToYards(float value) => value * (float)Conversions.InchesToYards;

    /// <summary>
    /// Converts a value in inches to yards.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static double ToYards(double value) => value * Conversions.InchesToYards;

    /// <summary>
    /// Converts a value in inches to miles.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static float ToMiles(float value) => value * (float)Conversions.InchesToMiles;

    /// <summary>
    /// Converts a value in inches to miles.
    /// </summary>
    /// <param name="value">The value in inches.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static double ToMiles(double value) => value * Conversions.InchesToMiles;
}
