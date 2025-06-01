namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of area.
/// </summary>
public class Area
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from square millimeters (mm²) to square centimeters (cm²).
    /// </summary>
    public const double Mm_2_to_Cm_2 = 0.01;
    /// <summary>
    /// Conversion factor from square millimeters (mm²) to square meters (m²).
    /// </summary>
    public const double Mm_2_to_M_2 = 0.000_001;
    /// <summary>
    /// Conversion factor from square millimeters (mm²) to square inches (in²).
    /// </summary>
    public const double Mm_2_to_In_2 = 0.001_55;
    /// <summary>
    /// Conversion factor from square millimeters (mm²) to square feet (ft²).
    /// </summary>
    public const double Mm_2_to_Ft_2 = 0.000_011;
    /// <summary>
    /// Conversion factor from square millimeters (mm²) to square yards (yd²).
    /// </summary>
    public const double Mm_2_to_Yd_2 = 0.000_001;

    /// <summary>
    /// Conversion factor from square centimeters (cm²) to square millimeters (mm²).
    /// </summary>
    public const double Cm_2_to_Mm_2 = 100;
    /// <summary>
    /// Conversion factor from square centimeters (cm²) to square meters (m²).
    /// </summary>
    public const double Cm_2_to_M_2 = 0.000_1;
    /// <summary>
    /// Conversion factor from square centimeters (cm²) to square inches (in²).
    /// </summary>
    public const double Cm_2_to_In_2 = 0.155;
    /// <summary>
    /// Conversion factor from square centimeters (cm²) to square feet (ft²).
    /// </summary>
    public const double Cm_2_to_Ft_2 = 0.001_076;
    /// <summary>
    /// Conversion factor from square centimeters (cm²) to square yards (yd²).
    /// </summary>
    public const double Cm_2_to_Yd_2 = 0.000_12;

    /// <summary>
    /// Conversion factor from square meters (m²) to square millimeters (mm²).
    /// </summary>
    public const double M_2_to_Mm_2 = 1_000_000;
    /// <summary>
    /// Conversion factor from square meters (m²) to square centimeters (cm²).
    /// </summary>
    public const double M_2_to_Cm_2 = 10_000;
    /// <summary>
    /// Conversion factor from square meters (m²) to square inches (in²).
    /// </summary>
    public const double M_2_to_In_2 = 1_550.003;
    /// <summary>
    /// Conversion factor from square meters (m²) to square feet (ft²).
    /// </summary>
    public const double M_2_to_Ft_2 = 10.763_91;
    /// <summary>
    /// Conversion factor from square meters (m²) to square yards (yd²).
    /// </summary>
    public const double M_2_to_Yd_2 = 1.195_99;

    /// <summary>
    /// Conversion factor from square inches (in²) to square millimeters (mm²).
    /// </summary>
    public const double In_2_to_Mm_2 = 645.16;
    /// <summary>
    /// Conversion factor from square inches (in²) to square centimeters (cm²).
    /// </summary>
    public const double In_2_to_Cm_2 = 6.451_6;
    /// <summary>
    /// Conversion factor from square inches (in²) to square meters (m²).
    /// </summary>
    public const double In_2_to_M_2 = 0.000_645;
    /// <summary>
    /// Conversion factor from square inches (in²) to square feet (ft²).
    /// </summary>
    public const double In_2_to_Ft_2 = 0.006_944;
    /// <summary>
    /// Conversion factor from square inches (in²) to square yards (yd²).
    /// </summary>
    public const double In_2_to_Yd_2 = 0.000_772;

    /// <summary>
    /// Conversion factor from square feet (ft²) to square millimeters (mm²).
    /// </summary>
    public const double Ft_2_to_Mm_2 = 929_03;
    /// <summary>
    /// Conversion factor from square feet (ft²) to square centimeters (cm²).
    /// </summary>
    public const double Ft_2_to_Cm_2 = 929.030_4;
    /// <summary>
    /// Conversion factor from square feet (ft²) to square meters (m²).
    /// </summary>
    public const double Ft_2_to_M_2 = 0.092_903;
    /// <summary>
    /// Conversion factor from square feet (ft²) to square inches (in²).
    /// </summary>
    public const double Ft_2_to_In_2 = 144;
    /// <summary>
    /// Conversion factor from square feet (ft²) to square yards (yd²).
    /// </summary>
    public const double Ft_2_to_Yd_2 = 0.111_111;

    /// <summary>
    /// Conversion factor from square yards (yd²) to square millimeters (mm²).
    /// </summary>
    public const double Yd_2_to_Mm_2 = 836_127;
    /// <summary>
    /// Conversion factor from square yards (yd²) to square centimeters (cm²).
    /// </summary>
    public const double Yd_2_to_Cm_2 = 8_361.274;
    /// <summary>
    /// Conversion factor from square yards (yd²) to square meters (m²).
    /// </summary>
    public const double Yd_2_to_M_2 = 0.836_127;
    /// <summary>
    /// Conversion factor from square yards (yd²) to square inches (in²).
    /// </summary>
    public const double Yd_2_to_In_2 = 1_296;
    /// <summary>
    /// Conversion factor from square yards (yd²) to square feet (ft²).
    /// </summary>
    public const double Yd_2_to_Ft_2 = 9;
    #endregion
    
    static Area()
    {
        // Register Area unit
        UnitConverter.RegisterUnit(typeof(AreaUnit), BaseUnit.Area);

        // Millimeter conversions
        UnitConverter.RegisterConversion(AreaUnit.Mm_2, AreaUnit.Cm_2, value => value * Mm_2_to_Cm_2);
        UnitConverter.RegisterConversion(AreaUnit.Mm_2, AreaUnit.M_2, value => value * Mm_2_to_M_2);
        UnitConverter.RegisterConversion(AreaUnit.Mm_2, AreaUnit.In_2, value => value * Mm_2_to_In_2);
        UnitConverter.RegisterConversion(AreaUnit.Mm_2, AreaUnit.Ft_2, value => value * Mm_2_to_Ft_2);
        UnitConverter.RegisterConversion(AreaUnit.Mm_2, AreaUnit.Yd_2, value => value * Mm_2_to_Yd_2);

        // Centimeters conversions
        UnitConverter.RegisterConversion(AreaUnit.Cm_2, AreaUnit.Mm_2, value => value * Cm_2_to_Mm_2);
        UnitConverter.RegisterConversion(AreaUnit.Cm_2, AreaUnit.M_2, value => value * Cm_2_to_M_2);
        UnitConverter.RegisterConversion(AreaUnit.Cm_2, AreaUnit.In_2, value => value * Cm_2_to_In_2);
        UnitConverter.RegisterConversion(AreaUnit.Cm_2, AreaUnit.Ft_2, value => value * Cm_2_to_Ft_2);
        UnitConverter.RegisterConversion(AreaUnit.Cm_2, AreaUnit.Yd_2, value => value * Cm_2_to_Yd_2);

        // Meter conversions
        UnitConverter.RegisterConversion(AreaUnit.M_2, AreaUnit.Mm_2, value => value * M_2_to_Mm_2);
        UnitConverter.RegisterConversion(AreaUnit.M_2, AreaUnit.Cm_2, value => value * M_2_to_Cm_2);
        UnitConverter.RegisterConversion(AreaUnit.M_2, AreaUnit.In_2, value => value * M_2_to_In_2);
        UnitConverter.RegisterConversion(AreaUnit.M_2, AreaUnit.Ft_2, value => value * M_2_to_Ft_2);
        UnitConverter.RegisterConversion(AreaUnit.M_2, AreaUnit.Yd_2, value => value * M_2_to_Yd_2);

        // Inch conversions
        UnitConverter.RegisterConversion(AreaUnit.In_2, AreaUnit.Mm_2, value => value * In_2_to_Mm_2);
        UnitConverter.RegisterConversion(AreaUnit.In_2, AreaUnit.Cm_2, value => value * In_2_to_Cm_2);
        UnitConverter.RegisterConversion(AreaUnit.In_2, AreaUnit.M_2, value => value * In_2_to_M_2);
        UnitConverter.RegisterConversion(AreaUnit.In_2, AreaUnit.Ft_2, value => value % Ft_2_to_In_2 == 0 ? Math.Round(value * In_2_to_Ft_2) : value * In_2_to_Ft_2);
        UnitConverter.RegisterConversion(AreaUnit.In_2, AreaUnit.Yd_2, value => value % Yd_2_to_In_2 == 0 ? Math.Round(value * In_2_to_Yd_2) : value * In_2_to_Yd_2);

        // Feet conversions
        UnitConverter.RegisterConversion(AreaUnit.Ft_2, AreaUnit.Mm_2, value => value * Ft_2_to_Mm_2);
        UnitConverter.RegisterConversion(AreaUnit.Ft_2, AreaUnit.Cm_2, value => value * Ft_2_to_Cm_2);
        UnitConverter.RegisterConversion(AreaUnit.Ft_2, AreaUnit.M_2, value => value * Ft_2_to_M_2);
        UnitConverter.RegisterConversion(AreaUnit.Ft_2, AreaUnit.In_2, value => value * Ft_2_to_In_2);
        UnitConverter.RegisterConversion(AreaUnit.Ft_2, AreaUnit.Yd_2, value => value % Yd_2_to_Ft_2 == 0 ? Math.Round(value * Ft_2_to_Yd_2) : value * Ft_2_to_Yd_2);

        // Yard conversions
        UnitConverter.RegisterConversion(AreaUnit.Yd_2, AreaUnit.Mm_2, value => value * Yd_2_to_Mm_2);
        UnitConverter.RegisterConversion(AreaUnit.Yd_2, AreaUnit.Cm_2, value => value * Yd_2_to_Cm_2);
        UnitConverter.RegisterConversion(AreaUnit.Yd_2, AreaUnit.M_2, value => value * Yd_2_to_M_2);
        UnitConverter.RegisterConversion(AreaUnit.Yd_2, AreaUnit.In_2, value => value * Yd_2_to_In_2);
        UnitConverter.RegisterConversion(AreaUnit.Yd_2, AreaUnit.Ft_2, value => value * Yd_2_to_Ft_2);
    }

    /// <summary>
    /// Converts a value from one area unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of area.</param>
    /// <param name="to">The target unit of area.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, AreaUnit from, AreaUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of area measurement.
/// </summary>
public enum AreaUnit
{
    /// <summary>
    /// Square millimeters (mm²).
    /// </summary>
    Mm_2,
    /// <summary>
    /// Square centimeters (cm²).
    /// </summary>
    Cm_2,
    /// <summary>
    /// Square meters (m²).
    /// </summary>
    M_2,
    /// <summary>
    /// Square inches (in²).
    /// </summary>
    In_2,
    /// <summary>
    /// Square feet (ft²).
    /// </summary>
    Ft_2,
    /// <summary>
    /// Square yards (yd²).
    /// </summary>
    Yd_2
}
