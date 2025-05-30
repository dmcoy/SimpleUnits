namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting values in kilometers to various other length units.
/// </summary>
public static class Kilometers
{
    /// <summary>
    /// Converts a value in kilometers to millimeters.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static float ToMillimeters(float value) => value * (float)Conversions.KilometersToMillimeters;

    /// <summary>
    /// Converts a value in kilometers to millimeters.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static double ToMillimeters(double value) => value * Conversions.KilometersToMillimeters;

    /// <summary>
    /// Converts a value in kilometers to centimeters.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static float ToCentimeters(float value) => value * (float)Conversions.KilometersToCentimeters;

    /// <summary>
    /// Converts a value in kilometers to centimeters.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static double ToCentimeters(double value) => value * Conversions.KilometersToCentimeters;

    /// <summary>
    /// Converts a value in kilometers to meters.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static float ToMeters(float value) => value * (float)Conversions.KilometersToMeters;

    /// <summary>
    /// Converts a value in kilometers to meters.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static double ToMeters(double value) => value * Conversions.KilometersToMeters;

    /// <summary>
    /// Converts a value in kilometers to inches.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static float ToInches(float value) => value * (float)Conversions.KilometersToInches;

    /// <summary>
    /// Converts a value in kilometers to inches.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static double ToInches(double value) => value * Conversions.KilometersToInches;

    /// <summary>
    /// Converts a value in kilometers to feet.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static float ToFeet(float value) => value * (float)Conversions.KilometersToFeet;

    /// <summary>
    /// Converts a value in kilometers to feet.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static double ToFeet(double value) => value * Conversions.KilometersToFeet;

    /// <summary>
    /// Converts a value in kilometers to yards.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static float ToYards(float value) => value * (float)Conversions.KilometersToYards;

    /// <summary>
    /// Converts a value in kilometers to yards.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in yards.</returns>
    public static double ToYards(double value) => value * Conversions.KilometersToYards;

    /// <summary>
    /// Converts a value in kilometers to miles.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static float ToMiles(float value) => value * (float)Conversions.KilometersToMiles;

    /// <summary>
    /// Converts a value in kilometers to miles.
    /// </summary>
    /// <param name="value">The value in kilometers.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static double ToMiles(double value) => value * Conversions.KilometersToMiles;
}
