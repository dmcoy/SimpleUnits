namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting kilogram-force meters to other torque units.
/// </summary>
public static class KilogramForceMeters
{
    /// <summary>
    /// Converts a value from kilogram-force meters to Newton-meters (float).
    /// </summary>
    /// <param name="value">The value in kilogram-force meters.</param>
    /// <returns>The value in Newton-meters as a float.</returns>
    public static float ToNewtonMeters(float value) => value * (float)Conversions.Kgfm_to_Nm;

    /// <summary>
    /// Converts a value from kilogram-force meters to Newton-meters (double).
    /// </summary>
    /// <param name="value">The value in kilogram-force meters.</param>
    /// <returns>The value in Newton-meters as a double.</returns>
    public static double ToNewtonMeters(double value) => value * Conversions.Kgfm_to_Nm;

    /// <summary>
    /// Converts a value from kilogram-force meters to foot-pounds (float).
    /// </summary>
    /// <param name="value">The value in kilogram-force meters.</param>
    /// <returns>The value in foot-pounds as a float.</returns>
    public static float ToFootPounds(float value) => value * (float)Conversions.Kgfm_to_Ftlb;

    /// <summary>
    /// Converts a value from kilogram-force meters to foot-pounds (double).
    /// </summary>
    /// <param name="value">The value in kilogram-force meters.</param>
    /// <returns>The value in foot-pounds as a double.</returns>
    public static double ToFootPounds(double value) => value * Conversions.Kgfm_to_Ftlb;

    /// <summary>
    /// Converts a value from kilogram-force meters to inch-pounds (float).
    /// </summary>
    /// <param name="value">The value in kilogram-force meters.</param>
    /// <returns>The value in inch-pounds as a float.</returns>
    public static float ToInchPounds(float value) => value * (float)Conversions.Kgfm_to_Inlb;

    /// <summary>
    /// Converts a value from kilogram-force meters to inch-pounds (double).
    /// </summary>
    /// <param name="value">The value in kilogram-force meters.</param>
    /// <returns>The value in inch-pounds as a double.</returns>
    public static double ToInchPounds(double value) => value * Conversions.Kgfm_to_Inlb;
}
