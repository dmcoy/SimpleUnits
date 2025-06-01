namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of torque.
/// </summary>
public static class Torque
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from newton-meters to kilogram-force meters.
    /// </summary>
    public const double Nm_to_Kgfm = 0.101972;
    /// <summary>
    /// Conversion factor from newton-meters to foot-pounds.
    /// </summary>
    public const double Nm_to_Ftlb = 0.737561;
    /// <summary>
    /// Conversion factor from newton-meters to inch-pounds.
    /// </summary>
    public const double Nm_to_Inlb = 8.850732;

    /// <summary>
    /// Conversion factor from kilogram-force meters to newton-meters.
    /// </summary>
    public const double Kgfm_to_Nm = 9.80665;
    /// <summary>
    /// Conversion factor from kilogram-force meters to foot-pounds.
    /// </summary>
    public const double Kgfm_to_Ftlb = 7.233003;
    /// <summary>
    /// Conversion factor from kilogram-force meters to inch-pounds.
    /// </summary>
    public const double Kgfm_to_Inlb = 86.79603;

    /// <summary>
    /// Conversion factor from foot-pounds to newton-meters.
    /// </summary>
    public const double Ftlb_to_Nm = 1.35582;
    /// <summary>
    /// Conversion factor from foot-pounds to kilogram-force meters.
    /// </summary>
    public const double Ftlb_to_Kgfm = 0.138255;
    /// <summary>Conversion factor from foot-pounds to inch-pounds.</summary>
    public const double Ftlb_to_Inlb = 12;

    /// <summary>
    /// Conversion factor from inch-pounds to newton-meters.
    /// </summary>
    public const double Inlb_to_Nm = 0.112985;
    /// <summary>
    /// Conversion factor from inch-pounds to kilogram-force meters.
    /// </summary>
    public const double Inlb_to_Kgfm = 0.011521;
    /// <summary>
    /// Conversion factor from inch-pounds to foot-pounds.
    /// </summary>
    public const double Inlb_to_Ftlb = 0.083333;
    #endregion

    static Torque()
    {
        // Register Torque unit
        UnitConverter.RegisterUnit(typeof(TorqueUnit), BaseUnit.Torque);

        // Newton meter conversions
        UnitConverter.RegisterConversion(TorqueUnit.Nm, TorqueUnit.Kgfm, value => value * Nm_to_Kgfm);
        UnitConverter.RegisterConversion(TorqueUnit.Nm, TorqueUnit.Ftlb, value => value * Nm_to_Ftlb);
        UnitConverter.RegisterConversion(TorqueUnit.Nm, TorqueUnit.Inlb, value => value * Nm_to_Inlb);

        // Kilogram-force meter conversions
        UnitConverter.RegisterConversion(TorqueUnit.Kgfm, TorqueUnit.Nm, value => value * Kgfm_to_Nm);
        UnitConverter.RegisterConversion(TorqueUnit.Kgfm, TorqueUnit.Ftlb, value => value * Kgfm_to_Ftlb);
        UnitConverter.RegisterConversion(TorqueUnit.Kgfm, TorqueUnit.Inlb, value => value * Kgfm_to_Inlb);

        // Foot-pound conversions
        UnitConverter.RegisterConversion(TorqueUnit.Ftlb, TorqueUnit.Nm, value => value * Ftlb_to_Nm);
        UnitConverter.RegisterConversion(TorqueUnit.Ftlb, TorqueUnit.Kgfm, value => value * Ftlb_to_Kgfm);
        UnitConverter.RegisterConversion(TorqueUnit.Ftlb, TorqueUnit.Inlb, value => value * Ftlb_to_Inlb);

        // Inch-pound conversions
        UnitConverter.RegisterConversion(TorqueUnit.Inlb, TorqueUnit.Nm, value => value * Inlb_to_Nm);
        UnitConverter.RegisterConversion(TorqueUnit.Inlb, TorqueUnit.Kgfm, value => value * Inlb_to_Kgfm);
        UnitConverter.RegisterConversion(TorqueUnit.Inlb, TorqueUnit.Ftlb, value => value % Ftlb_to_Inlb == 0 ? Math.Round(value * Inlb_to_Ftlb) : value * Inlb_to_Ftlb);
    }

    /// <summary>
    /// Converts a value from one torque unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of torque.</param>
    /// <param name="to">The target unit of torque.</param>
    /// <returns>The converted value in the target unit.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, TorqueUnit from, TorqueUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of torque measurement.
/// </summary>
public enum TorqueUnit
{
    /// <summary>
    /// Newton meters (Nm).
    /// </summary>
    Nm,
    /// <summary>
    /// Kilogram force meters (kgfm).
    /// </summary>
    Kgfm,
    /// <summary>
    /// Foot pounds (ftlb).
    /// </summary>
    Ftlb,
    /// <summary>
    /// Inch pounds (inlb).
    /// </summary>
    Inlb
}