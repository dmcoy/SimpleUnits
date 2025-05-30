namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting foot-pounds to other torque units.
/// </summary>
public static class FootPounds
{
    /// <summary>
    /// Converts a value from foot-pounds to Newton-meters (float).
    /// </summary>
    /// <param name="value">The value in foot-pounds.</param>
    /// <returns>The value in Newton-meters as a float.</returns>
    public static float ToNewtonMeters(float value) => value * (float)Conversions.Ftlb_to_Nm;

    /// <summary>
    /// Converts a value from foot-pounds to Newton-meters (double).
    /// </summary>
    /// <param name="value">The value in foot-pounds.</param>
    /// <returns>The value in Newton-meters as a double.</returns>
    public static double ToNewtonMeters(double value) => value * Conversions.Ftlb_to_Nm;

    /// <summary>
    /// Converts a value from foot-pounds to kilogram-force meters (float).
    /// </summary>
    /// <param name="value">The value in foot-pounds.</param>
    /// <returns>The value in kilogram-force meters as a float.</returns>
    public static float ToKilogramForceMeters(float value) => value * (float)Conversions.Ftlb_to_Kgfm;

    /// <summary>
    /// Converts a value from foot-pounds to kilogram-force meters (double).
    /// </summary>
    /// <param name="value">The value in foot-pounds.</param>
    /// <returns>The value in kilogram-force meters as a double.</returns>
    public static double ToKilogramForceMeters(double value) => value * Conversions.Ftlb_to_Kgfm;

    /// <summary>
    /// Converts a value from foot-pounds to inch-pounds (float).
    /// </summary>
    /// <param name="value">The value in foot-pounds.</param>
    /// <returns>The value in inch-pounds as a float.</returns>
    public static float ToInchPounds(float value) => value * (float)Conversions.Ftlb_to_Inlb;

    /// <summary>
    /// Converts a value from foot-pounds to inch-pounds (double).
    /// </summary>
    /// <param name="value">The value in foot-pounds.</param>
    /// <returns>The value in inch-pounds as a double.</returns>
    public static double ToInchPounds(double value) => value * Conversions.Ftlb_to_Inlb;
}
