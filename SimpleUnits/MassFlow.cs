namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of mass flow.
/// </summary>
public static class MassFlow
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from kilogram per hour (kg/h) to pound per hour (lb/h).
    /// </summary>
    public const double Kgh_to_Lbh = 2.204_586;
    /// <summary>
    /// Conversion factor from kilogram per hour (kg/h) to kilogram per second (kg/s).
    /// </summary>
    public const double Kgh_to_Kgs = 0.000_278;
    /// <summary>
    /// Conversion factor from kilogram per hour (kg/h) to ton per hour (t/h).
    /// </summary>
    public const double Kgh_to_Th = 0.001;

    /// <summary>
    /// Conversion factor from pound per hour (lb/h) to kilogram per hour (kg/h).
    /// </summary>
    public const double Lbh_to_Kgh = 0.453_6;
    /// <summary>
    /// Conversion factor from pound per hour (lb/h) to kilogram per second (kg/s).
    /// </summary>
    public const double Lbh_to_Kgs = 0.000_126;
    /// <summary>
    /// Conversion factor from pound per hour (lb/h) to ton per hour (t/h).
    /// </summary>
    public const double Lbh_to_Th = 0.000_454;

    /// <summary>
    /// Conversion factor from kilogram per second (kg/s) to kilogram per hour (kg/h).
    /// </summary>
    public const double Kgs_to_Kgh = 3_600;
    /// <summary>
    /// Conversion factor from kilogram per second (kg/s) to pound per hour (lb/h).
    /// </summary>
    public const double Kgs_to_Lbh = 7_936.508;
    /// <summary>
    /// Conversion factor from kilogram per second (kg/s) to ton per hour (t/h).
    /// </summary>
    public const double Kgs_to_Th = 3.6;

    /// <summary>
    /// Conversion factor from ton per hour (t/h) to kilogram per hour (kg/h).
    /// </summary>
    public const double Th_to_Kgh = 1_000;
    /// <summary>
    /// Conversion factor from ton per hour (t/h) to pound per hour (lb/h).
    /// </summary>
    public const double Th_to_Lbh = 2_204.586;
    /// <summary>
    /// Conversion factor from ton per hour (t/h) to kilogram per second (kg/s).
    /// </summary>
    public const double Th_to_Kgs = 0.277_778;
    #endregion

    static MassFlow()
    {
        // Register MassFlow unit
        UnitConverter.RegisterUnit(typeof(MassFlowUnit), BaseUnit.MassFlow);

        // kg/h conversions
        UnitConverter.RegisterConversion(MassFlowUnit.Kgh, MassFlowUnit.Lbh, value => value * Kgh_to_Lbh);
        UnitConverter.RegisterConversion(MassFlowUnit.Kgh, MassFlowUnit.Kgs, value => value * Kgh_to_Kgs);
        UnitConverter.RegisterConversion(MassFlowUnit.Kgh, MassFlowUnit.Th, value => value * Kgh_to_Th);

        // lb/h conversions
        UnitConverter.RegisterConversion(MassFlowUnit.Lbh, MassFlowUnit.Kgh, value => value * Lbh_to_Kgh);
        UnitConverter.RegisterConversion(MassFlowUnit.Lbh, MassFlowUnit.Kgs, value => value * Lbh_to_Kgs);
        UnitConverter.RegisterConversion(MassFlowUnit.Lbh, MassFlowUnit.Th, value => value * Lbh_to_Th);

        // kg/s conversions
        UnitConverter.RegisterConversion(MassFlowUnit.Kgs, MassFlowUnit.Kgh, value => value * Kgs_to_Kgh);
        UnitConverter.RegisterConversion(MassFlowUnit.Kgs, MassFlowUnit.Lbh, value => value * Kgs_to_Lbh);
        UnitConverter.RegisterConversion(MassFlowUnit.Kgs, MassFlowUnit.Th, value => value * Kgs_to_Th);

        // t/h conversions
        UnitConverter.RegisterConversion(MassFlowUnit.Th, MassFlowUnit.Kgh, value => value * Th_to_Kgh);
        UnitConverter.RegisterConversion(MassFlowUnit.Th, MassFlowUnit.Lbh, value => value * Th_to_Lbh);
        UnitConverter.RegisterConversion(MassFlowUnit.Th, MassFlowUnit.Kgs, value => value * Th_to_Kgs);
    }

    /// <summary>
    /// Converts a value from one mass flow unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of mass flow.</param>
    /// <param name="to">The target unit of mass flow.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, MassFlowUnit from, MassFlowUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }

    /// <summary>
    /// Converts a value from one mass flow unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of mass flow.</param>
    /// <param name="to">The target unit of mass flow.</param>
    /// <returns>The converted value in the target unit as a float.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static float Convert(float value, MassFlowUnit from, MassFlowUnit to)
    {
        return (float)UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of mass flow measurement.
/// </summary>
public enum MassFlowUnit
{
    /// <summary>
    /// Kilogram per hour (kg/h).
    /// </summary>
    Kgh,
    /// <summary>
    /// Pound per hour (lb/h).
    /// </summary>
    Lbh,
    /// <summary>
    /// Kilogram per second (kg/s).
    /// </summary>
    Kgs,
    /// <summary>
    /// Ton per hour (t/h).
    /// </summary>
    Th
}