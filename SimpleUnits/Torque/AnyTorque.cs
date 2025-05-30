namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting between different units of torque.
/// </summary>
public static class AnyTorque
{
    /// <summary>
    /// Converts a value from the specified <see cref="Torque"/> unit to Newton-meters (float).
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to Newton-meters as a float.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already Newton-meters or unsupported.</exception>
    public static float ToNewtonMeters(float value, Torque unit)
    {
        return unit switch
        {
            Torque.NewtonMeters => throw new ArgumentException("Cannot convert the same units"),
            Torque.KilogramForceMeters => KilogramForceMeters.ToNewtonMeters(value),
            Torque.FootPounds => FootPounds.ToNewtonMeters(value),
            Torque.InchPounds => InchPounds.ToNewtonMeters(value),
            _ => throw new ArgumentException($"Unsupported torque unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Torque"/> unit to Newton-meters (double).
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to Newton-meters as a double.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already Newton-meters or unsupported.</exception>
    public static double ToNewtonMeters(double value, Torque unit)
    {
        return unit switch
        {
            Torque.NewtonMeters => throw new ArgumentException("Cannot convert the same units"),
            Torque.KilogramForceMeters => KilogramForceMeters.ToNewtonMeters(value),
            Torque.FootPounds => FootPounds.ToNewtonMeters(value),
            Torque.InchPounds => InchPounds.ToNewtonMeters(value),
            _ => throw new ArgumentException($"Unsupported torque unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Torque"/> unit to kilogram-force meters (float).
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to kilogram-force meters as a float.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already kilogram-force meters or unsupported.</exception>
    public static float ToKilogramForceMeters(float value, Torque unit)
    {
        return unit switch
        {
            Torque.NewtonMeters => NewtonMeters.ToKilogramForceMeters(value),
            Torque.KilogramForceMeters => throw new ArgumentException("Cannot convert the same units"),
            Torque.FootPounds => FootPounds.ToKilogramForceMeters(value),
            Torque.InchPounds => InchPounds.ToKilogramForceMeters(value),
            _ => throw new ArgumentException($"Unsupported torque unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Torque"/> unit to kilogram-force meters (double).
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to kilogram-force meters as a double.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already kilogram-force meters or unsupported.</exception>
    public static double ToKilogramForceMeters(double value, Torque unit)
    {
        return unit switch
        {
            Torque.NewtonMeters => NewtonMeters.ToKilogramForceMeters(value),
            Torque.KilogramForceMeters => throw new ArgumentException("Cannot convert the same units"),
            Torque.FootPounds => FootPounds.ToKilogramForceMeters(value),
            Torque.InchPounds => InchPounds.ToKilogramForceMeters(value),
            _ => throw new ArgumentException($"Unsupported torque unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Torque"/> unit to foot-pounds (float).
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to foot-pounds as a float.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already foot-pounds or unsupported.</exception>
    public static float ToFootPounds(float value, Torque unit)
    {
        return unit switch
        {
            Torque.NewtonMeters => NewtonMeters.ToFootPounds(value),
            Torque.KilogramForceMeters => KilogramForceMeters.ToFootPounds(value),
            Torque.FootPounds => throw new ArgumentException("Cannot convert the same units"),
            Torque.InchPounds => InchPounds.ToFootPounds(value),
            _ => throw new ArgumentException($"Unsupported torque unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Torque"/> unit to foot-pounds (double).
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to foot-pounds as a double.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already foot-pounds or unsupported.</exception>
    public static double ToFootPounds(double value, Torque unit)
    {
        return unit switch
        {
            Torque.NewtonMeters => NewtonMeters.ToFootPounds(value),
            Torque.KilogramForceMeters => KilogramForceMeters.ToFootPounds(value),
            Torque.FootPounds => throw new ArgumentException("Cannot convert the same units"),
            Torque.InchPounds => InchPounds.ToFootPounds(value),
            _ => throw new ArgumentException($"Unsupported torque unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Torque"/> unit to inch-pounds (float).
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to inch-pounds as a float.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already inch-pounds or unsupported.</exception>
    public static float ToInchPounds(float value, Torque unit)
    {
        return unit switch
        {
            Torque.NewtonMeters => NewtonMeters.ToInchPounds(value),
            Torque.KilogramForceMeters => KilogramForceMeters.ToInchPounds(value),
            Torque.FootPounds => FootPounds.ToInchPounds(value),
            Torque.InchPounds => throw new ArgumentException("Cannot convert the same units"),
            _ => throw new ArgumentException($"Unsupported torque unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Torque"/> unit to inch-pounds (double).
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to inch-pounds as a double.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already inch-pounds or unsupported.</exception>
    public static double ToInchPounds(double value, Torque unit)
    {
        return unit switch
        {
            Torque.NewtonMeters => NewtonMeters.ToInchPounds(value),
            Torque.KilogramForceMeters => KilogramForceMeters.ToInchPounds(value),
            Torque.FootPounds => FootPounds.ToInchPounds(value),
            Torque.InchPounds => throw new ArgumentException("Cannot convert the same units"),
            _ => throw new ArgumentException($"Unsupported torque unit: {unit}")
        };
    }
}
