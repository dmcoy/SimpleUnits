namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting values in feet to various other length units.
/// </summary>
public static class Feet
{
    /// <summary>
    /// Converts a value in feet to millimeters.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static float ToMillimeters(float value) => value * (float)Conversions.FeetToMillimeters;

    /// <summary>
    /// Converts a value in feet to millimeters.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static double ToMillimeters(double value) => value * Conversions.FeetToMillimeters;

    /// <summary>
    /// Converts a value in feet to centimeters.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static float ToCentimeters(float value) => value * (float)Conversions.FeetToCentimeters;

    /// <summary>
    /// Converts a value in feet to centimeters.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static double ToCentimeters(double value) => value * Conversions.FeetToCentimeters;

    /// <summary>
    /// Converts a value in feet to meters.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static float ToMeters(float value) => value * (float)Conversions.FeetToMeters;

    /// <summary>
    /// Converts a value in feet to meters.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static double ToMeters(double value) => value * Conversions.FeetToMeters;

    /// <summary>
    /// Converts a value in feet to kilometers.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static float ToKilometers(float value) => value * (float)Conversions.FeetToKilometers;

    /// <summary>
    /// Converts a value in feet to kilometers.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static double ToKilometers(double value) => value * Conversions.FeetToKilometers;

    /// <summary>
    /// Converts a value in feet to inches.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static float ToInches(float value) => value * (float)Conversions.FeetToInches;

    /// <summary>
    /// Converts a value in feet to inches.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static double ToInches(double value) => value * Conversions.FeetToInches;

    /// <summary>
    /// Converts a value in feet to yards.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static float ToYards(float value) => value * (float)Conversions.FeetToYards;

    /// <summary>
    /// Converts a value in feet to yards.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static double ToYards(double value) => value * Conversions.FeetToYards;

    /// <summary>
    /// Converts a value in feet to miles.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static float ToMiles(float value) => value * (float)Conversions.FeetToMiles;

    /// <summary>
    /// Converts a value in feet to miles.
    /// </summary>
    /// <param name="value">The value in feet.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static double ToMiles(double value) => value * Conversions.FeetToMiles;
}
