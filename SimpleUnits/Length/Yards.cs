namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting values in yards to various other length units.
/// </summary>
public static class Yards
{
    /// <summary>
    /// Converts a value in yards to millimeters.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static float ToMillimeters(float value) => value * (float)Conversions.YardsToMillimeters;

    /// <summary>
    /// Converts a value in yards to millimeters.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in millimeters.</returns>
    public static double ToMillimeters(double value) => value * Conversions.YardsToMillimeters;

    /// <summary>
    /// Converts a value in yards to centimeters.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static float ToCentimeters(float value) => value * (float)Conversions.YardsToCentimeters;

    /// <summary>
    /// Converts a value in yards to centimeters.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in centimeters.</returns>
    public static double ToCentimeters(double value) => value * Conversions.YardsToCentimeters;

    /// <summary>
    /// Converts a value in yards to meters.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static float ToMeters(float value) => value * (float)Conversions.YardsToMeters;

    /// <summary>
    /// Converts a value in yards to meters.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in meters.</returns>
    public static double ToMeters(double value) => value * Conversions.YardsToMeters;

    /// <summary>
    /// Converts a value in yards to kilometers.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static float ToKilometers(float value) => value * (float)Conversions.YardsToKilometers;

    /// <summary>
    /// Converts a value in yards to kilometers.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in kilometers.</returns>
    public static double ToKilometers(double value) => value * Conversions.YardsToKilometers;

    /// <summary>
    /// Converts a value in yards to inches.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static float ToInches(float value) => value * (float)Conversions.YardsToInches;

    /// <summary>
    /// Converts a value in yards to inches.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in inches.</returns>
    public static double ToInches(double value) => value * Conversions.YardsToInches;

    /// <summary>
    /// Converts a value in yards to feet.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static float ToFeet(float value) => value * (float)Conversions.YardsToFeet;

    /// <summary>
    /// Converts a value in yards to feet.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in feet.</returns>
    public static double ToFeet(double value) => value * Conversions.YardsToFeet;

    /// <summary>
    /// Converts a value in yards to miles.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static float ToMiles(float value) => value * (float)Conversions.YardsToMiles;

    /// <summary>
    /// Converts a value in yards to miles.
    /// </summary>
    /// <param name="value">The value in yards.</param>
    /// <returns>The equivalent value in miles.</returns>
    public static double ToMiles(double value) => value * Conversions.YardsToMiles;
}
