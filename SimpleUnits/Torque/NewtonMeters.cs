namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting Newton-meters to other torque units.
/// </summary>
public static class NewtonMeters
{
    /// <summary>
    /// Converts a value from Newton-meters to kilogram-force meters (float).
    /// </summary>
    /// <param name="value">The value in Newton-meters.</param>
    /// <returns>The value in kilogram-force meters as a float.</returns>
    public static float ToKilogramForceMeters(float value) => value * (float)Conversions.Nm_to_Kgfm;

    /// <summary>
    /// Converts a value from Newton-meters to kilogram-force meters (double).
    /// </summary>
    /// <param name="value">The value in Newton-meters.</param>
    /// <returns>The value in kilogram-force meters as a double.</returns>
    public static double ToKilogramForceMeters(double value) => value * Conversions.Nm_to_Kgfm;

    /// <summary>
    /// Converts a value from Newton-meters to foot-pounds (float).
    /// </summary>
    /// <param name="value">The value in Newton-meters.</param>
    /// <returns>The value in foot-pounds as a float.</returns>
    public static float ToFootPounds(float value) => value * (float)Conversions.Nm_to_Ftlb;

    /// <summary>
    /// Converts a value from Newton-meters to foot-pounds (double).
    /// </summary>
    /// <param name="value">The value in Newton-meters.</param>
    /// <returns>The value in foot-pounds as a double.</returns>
    public static double ToFootPounds(double value) => value * Conversions.Nm_to_Ftlb;

    /// <summary>
    /// Converts a value from Newton-meters to inch-pounds (float).
    /// </summary>
    /// <param name="value">The value in Newton-meters.</param>
    /// <returns>The value in inch-pounds as a float.</returns>
    public static float ToInchPounds(float value) => value * (float)Conversions.Nm_to_Inlb;

    /// <summary>
    /// Converts a value from Newton-meters to inch-pounds (double).
    /// </summary>
    /// <param name="value">The value in Newton-meters.</param>
    /// <returns>The value in inch-pounds as a double.</returns>
    public static double ToInchPounds(double value) => value * Conversions.Nm_to_Inlb;
}
