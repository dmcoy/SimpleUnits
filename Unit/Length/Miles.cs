namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting values in miles to various other length units.
/// </summary>
public static class Miles
{
    /// <summary>
    /// Converts a value in miles to millimeters.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static float ToMillimeters(float value) => value * (float)Conversions.MilesToMillimeters;

    /// <summary>
    /// Converts a value in miles to millimeters.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static double ToMillimeters(double value) => value * Conversions.MilesToMillimeters;

    /// <summary>
    /// Converts a value in miles to centimeters.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static float ToCentimeters(float value) => value * (float)Conversions.MilesToCentimeters;

    /// <summary>
    /// Converts a value in miles to centimeters.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static double ToCentimeters(double value) => value * Conversions.MilesToCentimeters;

    /// <summary>
    /// Converts a value in miles to meters.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static float ToMeters(float value) => value * (float)Conversions.MilesToMeters;

    /// <summary>
    /// Converts a value in miles to meters.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static double ToMeters(double value) => value * Conversions.MilesToMeters;

    /// <summary>
    /// Converts a value in miles to kilometers.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static float ToKilometers(float value) => value * (float)Conversions.MilesToKilometers;

    /// <summary>
    /// Converts a value in miles to kilometers.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static double ToKilometers(double value) => value * Conversions.MilesToKilometers;

    /// <summary>
    /// Converts a value in miles to inches.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static float ToInches(float value) => value * (float)Conversions.MilesToInches;

    /// <summary>
    /// Converts a value in miles to inches.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static double ToInches(double value) => value * Conversions.MilesToInches;

    /// <summary>
    /// Converts a value in miles to feet.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static float ToFeet(float value) => value * (float)Conversions.MilesToFeet;

    /// <summary>
    /// Converts a value in miles to feet.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static double ToFeet(double value) => value * Conversions.MilesToFeet;

    /// <summary>
    /// Converts a value in miles to yards.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static float ToYards(float value) => value * (float)Conversions.MilesToYards;

    /// <summary>
    /// Converts a value in miles to yards.
    /// </summary>
    /// <param name="value">The value in miles.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static double ToYards(double value) => value * Conversions.MilesToYards;
}
