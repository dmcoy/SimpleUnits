namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of volume.
/// </summary>
public static class Volume
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from cubic centimeters (cm³) to cubic meters (m³).
    /// </summary>
    public const double Cm_3_to_M_3 = 0.000_001;
    /// <summary>
    /// Conversion factor from cubic centimeters (cm³) to liters (ltr).
    /// </summary>
    public const double Cm_3_to_Ltr = 0.001;
    /// <summary>
    /// Conversion factor from cubic centimeters (cm³) to cubic inches (in³).
    /// </summary>
    public const double Cm_3_to_In_3 = 0.061_024;
    /// <summary>
    /// Conversion factor from cubic centimeters (cm³) to cubic feet (ft³).
    /// </summary>
    public const double Cm_3_to_Ft_3 = 0.000_035;
    /// <summary>
    /// Conversion factor from cubic centimeters (cm³) to US gallons (US gal).
    /// </summary>
    public const double Cm_3_to_USGal = 0.000_264;
    /// <summary>
    /// Conversion factor from cubic centimeters (cm³) to Imperial gallons (Imp. gal).
    /// </summary>
    public const double Cm_3_to_ImpGal = 0.000_22;
    /// <summary>
    /// Conversion factor from cubic centimeters (cm³) to US barrels (oil) (US brl).
    /// </summary>
    public const double Cm_3_to_USBrl = 0.000006;

    /// <summary>
    /// Conversion factor from cubic meters (m³) to cubic centimeters (cm³).
    /// </summary>
    public const double M_3_to_Cm_3 = 1_000_000;
    /// <summary>
    /// Conversion factor from cubic meters (m³) to liters (ltr).
    /// </summary>
    public const double M_3_to_Ltr = 1_000;
    /// <summary>
    /// Conversion factor from cubic meters (m³) to cubic inches (in³).
    /// </summary>
    public const double M_3_to_In_3 = 61_024;
    /// <summary>
    /// Conversion factor from cubic meters (m³) to cubic feet (ft³).
    /// </summary>
    public const double M_3_to_Ft_3 = 35;
    /// <summary>
    /// Conversion factor from cubic meters (m³) to US gallons (US gal).
    /// </summary>
    public const double M_3_to_USGal = 264;
    /// <summary>
    /// Conversion factor from cubic meters (m³) to Imperial gallons (Imp. gal).
    /// </summary>
    public const double M_3_to_ImpGal = 220;

    /// <summary>
    /// Conversion factor from liters (ltr) to cubic centimeters (cm³).
    /// </summary>
    public const double Ltr_to_Cm_3 = 1_000;
    /// <summary>
    /// Conversion factor from liters (ltr) to cubic meters (m³).
    /// </summary>
    public const double Ltr_to_M_3 = 0.001;
    /// <summary>
    /// Conversion factor from liters (ltr) to cubic inches (in³).
    /// </summary>
    public const double Ltr_to_In_3 = 61;
    /// <summary>
    /// Conversion factor from liters (ltr) to cubic feet (ft³).
    /// </summary>
    public const double Ltr_to_Ft_3 = 0.035;
    /// <summary>
    /// Conversion factor from liters (ltr) to US gallons (US gal).
    /// </summary>
    public const double Ltr_to_USGal = 0.264_201;
    /// <summary>
    /// Conversion factor from liters (ltr) to Imperial gallons (Imp. gal).
    /// </summary>
    public const double Ltr_to_ImpGal = 0.22;

    // Inch cube (in³) conversions
    /// <summary>
    /// Conversion factor from cubic inches (in³) to cubic centimeters (cm³).
    /// </summary>
    public const double In_3_to_Cm_3 = 16.4;
    /// <summary>
    /// Conversion factor from cubic inches (in³) to cubic meters (m³).
    /// </summary>
    public const double In_3_to_M_3 = 0.000_016;
    /// <summary>
    /// Conversion factor from cubic inches (in³) to liters (ltr).
    /// </summary>
    public const double In_3_to_Ltr = 0.016_387;
    /// <summary>
    /// Conversion factor from cubic inches (in³) to cubic feet (ft³).
    /// </summary>
    public const double In_3_to_Ft_3 = 0.000_579;
    /// <summary>
    /// Conversion factor from cubic inches (in³) to US gallons (US gal).
    /// </summary>
    public const double In_3_to_USGal = 0.004_329;
    /// <summary>
    /// Conversion factor from cubic inches (in³) to Imperial gallons (Imp. gal).
    /// </summary>
    public const double In_3_to_ImpGal = 0.003_605;
    /// <summary>
    /// Conversion factor from cubic inches (in³) to US barrels (oil) (US brl).
    /// </summary>
    public const double In_3_to_USBrl = 0.000_103;

    // Foot cube (ft³) conversions
    /// <summary>
    /// Conversion factor from cubic feet (ft³) to cubic centimeters (cm³).
    /// </summary>
    public const double Ft_3_to_Cm_3 = 28_317;
    /// <summary>
    /// Conversion factor from cubic feet (ft³) to cubic meters (m³).
    /// </summary>
    public const double Ft_3_to_M_3 = 0.028_317;
    /// <summary>
    /// Conversion factor from cubic feet (ft³) to liters (ltr).
    /// </summary>
    public const double Ft_3_to_Ltr = 28.316_85;
    /// <summary>
    /// Conversion factor from cubic feet (ft³) to cubic inches (in³).
    /// </summary>
    public const double Ft_3_to_In_3 = 1_728;
    /// <summary>
    /// Conversion factor from cubic feet (ft³) to US gallons (US gal).
    /// </summary>
    public const double Ft_3_to_USGal = 7.481_333;
    /// <summary>
    /// Conversion factor from cubic feet (ft³) to Imperial gallons (Imp. gal).
    /// </summary>
    public const double Ft_3_to_ImpGal = 6.229_712;
    /// <summary>
    /// Conversion factor from cubic feet (ft³) to US barrels (oil) (US brl).
    /// </summary>
    public const double Ft_3_to_USBrl = 0.178_127;

    // US gallons (US gal) conversions
    /// <summary>
    /// Conversion factor from US gallons (US gal) to cubic centimeters (cm³).
    /// </summary>
    public const double USGal_to_Cm_3 = 3_785;
    /// <summary>
    /// Conversion factor from US gallons (US gal) to cubic meters (m³).
    /// </summary>
    public const double USGal_to_M_3 = 0.003_785;
    /// <summary>
    /// Conversion factor from US gallons (US gal) to liters (ltr).
    /// </summary>
    public const double USGal_to_Ltr = 3.79;
    /// <summary>
    /// Conversion factor from US gallons (US gal) to cubic inches (in³).
    /// </summary>
    public const double USGal_to_In_3 = 231;
    /// <summary>
    /// Conversion factor from US gallons (US gal) to cubic feet (ft³).
    /// </summary>
    public const double USGal_to_Ft_3 = 0.13;
    /// <summary>
    /// Conversion factor from US gallons (US gal) to Imperial gallons (Imp. gal).
    /// </summary>
    public const double USGal_to_ImpGal = 0.832_701;
    /// <summary>
    /// Conversion factor from US gallons (US gal) to US barrels (oil) (US brl).
    /// </summary>
    public const double USGal_to_USBrl = 0.023_81;

    // Imperial gallons (Imp. gal) conversions
    /// <summary>
    /// Conversion factor from Imperial gallons (Imp. gal) to cubic centimeters (cm³).
    /// </summary>
    public const double ImpGal_to_Cm_3 = 4_545;
    /// <summary>
    /// Conversion factor from Imperial gallons (Imp. gal) to cubic meters (m³).
    /// </summary>
    public const double ImpGal_to_M_3 = 0.004_545;
    /// <summary>
    /// Conversion factor from Imperial gallons (Imp. gal) to liters (ltr).
    /// </summary>
    public const double ImpGal_to_Ltr = 4.55;
    /// <summary>
    /// Conversion factor from Imperial gallons (Imp. gal) to cubic inches (in³).
    /// </summary>
    public const double ImpGal_to_In_3 = 277;
    /// <summary>
    /// Conversion factor from Imperial gallons (Imp. gal) to cubic feet (ft³).
    /// </summary>
    public const double ImpGal_to_Ft_3 = 0.16;
    /// <summary>
    /// Conversion factor from Imperial gallons (Imp. gal) to US gallons (US gal).
    /// </summary>
    public const double ImpGal_to_USGal = 1.20;
    /// <summary>
    /// Conversion factor from Imperial gallons (Imp. gal) to US barrels (oil) (US brl).
    /// </summary>
    public const double ImpGal_to_USBrl = 0.028_593;

    // US barrel (oil) conversions
    /// <summary>
    /// Conversion factor from US barrels (oil) (US brl) to cubic centimeters (cm³).
    /// </summary>
    public const double USBrl_to_Cm_3 = 158_970;
    /// <summary>
    /// Conversion factor from US barrels (oil) (US brl) to cubic meters (m³).
    /// </summary>
    public const double USBrl_to_M_3 = 0.158_97;
    /// <summary>
    /// Conversion factor from US barrels (oil) (US brl) to liters (ltr).
    /// </summary>
    public const double USBrl_to_Ltr = 159;
    /// <summary>
    /// Conversion factor from US barrels (oil) (US brl) to cubic inches (in³).
    /// </summary>
    public const double USBrl_to_In_3 = 9_701;
    /// <summary>
    /// Conversion factor from US barrels (oil) (US brl) to cubic feet (ft³).
    /// </summary>
    public const double USBrl_to_Ft_3 = 6;
    /// <summary>
    /// Conversion factor from US barrels (oil) (US brl) to US gallons (US gal).
    /// </summary>
    public const double USBrl_to_USGal = 42;
    /// <summary>
    /// Conversion factor from US barrels (oil) (US brl) to Imperial gallons (Imp. gal).
    /// </summary>
    public const double USBrl_to_ImpGal = 35;
    #endregion

    static Volume()
    {
        // Register Volume unit
        UnitConverter.RegisterUnit(typeof(VolumeUnit), BaseUnit.Volume);

        // cm³ conversions
        UnitConverter.RegisterConversion(VolumeUnit.Cm_3, VolumeUnit.M_3, value => value * Cm_3_to_M_3);
        UnitConverter.RegisterConversion(VolumeUnit.Cm_3, VolumeUnit.Ltr, value => value * Cm_3_to_Ltr);
        UnitConverter.RegisterConversion(VolumeUnit.Cm_3, VolumeUnit.In_3, value => value * Cm_3_to_In_3);
        UnitConverter.RegisterConversion(VolumeUnit.Cm_3, VolumeUnit.Ft_3, value => value * Cm_3_to_Ft_3);
        UnitConverter.RegisterConversion(VolumeUnit.Cm_3, VolumeUnit.USGal, value => value * Cm_3_to_USGal);
        UnitConverter.RegisterConversion(VolumeUnit.Cm_3, VolumeUnit.ImpGal, value => value * Cm_3_to_ImpGal);
        UnitConverter.RegisterConversion(VolumeUnit.Cm_3, VolumeUnit.USBrl, value => value * Cm_3_to_USBrl);

        // m³ conversions
        UnitConverter.RegisterConversion(VolumeUnit.M_3, VolumeUnit.Cm_3, value => value * M_3_to_Cm_3);
        UnitConverter.RegisterConversion(VolumeUnit.M_3, VolumeUnit.Ltr, value => value * M_3_to_Ltr);
        UnitConverter.RegisterConversion(VolumeUnit.M_3, VolumeUnit.In_3, value => value * M_3_to_In_3);
        UnitConverter.RegisterConversion(VolumeUnit.M_3, VolumeUnit.Ft_3, value => value * M_3_to_Ft_3);
        UnitConverter.RegisterConversion(VolumeUnit.M_3, VolumeUnit.USGal, value => value * M_3_to_USGal);
        UnitConverter.RegisterConversion(VolumeUnit.M_3, VolumeUnit.ImpGal, value => value * M_3_to_ImpGal);

        // Ltr conversions
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.Cm_3, value => value * Ltr_to_Cm_3);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.M_3, value => value * Ltr_to_M_3);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.In_3, value => value * Ltr_to_In_3);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.Ft_3, value => value * Ltr_to_Ft_3);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.USGal, value => value * Ltr_to_USGal);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.ImpGal, value => value * Ltr_to_ImpGal);

        // in³ conversions
        UnitConverter.RegisterConversion(VolumeUnit.In_3, VolumeUnit.Cm_3, value => value * In_3_to_Cm_3);
        UnitConverter.RegisterConversion(VolumeUnit.In_3, VolumeUnit.M_3, value => value * In_3_to_M_3);
        UnitConverter.RegisterConversion(VolumeUnit.In_3, VolumeUnit.Ltr, value => value * In_3_to_Ltr);
        UnitConverter.RegisterConversion(VolumeUnit.In_3, VolumeUnit.Ft_3, value => value * In_3_to_Ft_3);
        UnitConverter.RegisterConversion(VolumeUnit.In_3, VolumeUnit.USGal, value => value * In_3_to_USGal);
        UnitConverter.RegisterConversion(VolumeUnit.In_3, VolumeUnit.ImpGal, value => value * In_3_to_ImpGal);
        UnitConverter.RegisterConversion(VolumeUnit.In_3, VolumeUnit.USBrl, value => value * In_3_to_USBrl);

        // ft³ conversions
        UnitConverter.RegisterConversion(VolumeUnit.Ft_3, VolumeUnit.Cm_3, value => value * Ft_3_to_Cm_3);
        UnitConverter.RegisterConversion(VolumeUnit.Ft_3, VolumeUnit.M_3, value => value * Ft_3_to_M_3);
        UnitConverter.RegisterConversion(VolumeUnit.Ft_3, VolumeUnit.Ltr, value => value * Ft_3_to_Ltr);
        UnitConverter.RegisterConversion(VolumeUnit.Ft_3, VolumeUnit.In_3, value => value * Ft_3_to_In_3);
        UnitConverter.RegisterConversion(VolumeUnit.Ft_3, VolumeUnit.USGal, value => value * Ft_3_to_USGal);
        UnitConverter.RegisterConversion(VolumeUnit.Ft_3, VolumeUnit.ImpGal, value => value * Ft_3_to_ImpGal);
        UnitConverter.RegisterConversion(VolumeUnit.Ft_3, VolumeUnit.USBrl, value => value * Ft_3_to_USBrl);

        // US gal conversions
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.Cm_3, value => value * USGal_to_Cm_3);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.M_3, value => value * USGal_to_M_3);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.Ltr, value => value * USGal_to_Ltr);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.In_3, value => value * USGal_to_In_3);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.Ft_3, value => value * USGal_to_Ft_3);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.ImpGal, value => value * USGal_to_ImpGal);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.USBrl, value => value * USGal_to_USBrl);

        // Imp gal conversions
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.Cm_3, value => value * ImpGal_to_Cm_3);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.M_3, value => value * ImpGal_to_M_3);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.Ltr, value => value * ImpGal_to_Ltr);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.In_3, value => value * ImpGal_to_In_3);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.Ft_3, value => value * ImpGal_to_Ft_3);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.USGal, value => value * ImpGal_to_USGal);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.USBrl, value => value * ImpGal_to_USBrl);

        // US barrel (oil) conversions
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.Cm_3, value => value * USBrl_to_Cm_3);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.M_3, value => value * USBrl_to_M_3);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.Ltr, value => value * USBrl_to_Ltr);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.In_3, value => value * USBrl_to_In_3);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.Ft_3, value => value * USBrl_to_Ft_3);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.USGal, value => value * USBrl_to_USGal);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.ImpGal, value => value * USBrl_to_ImpGal);
    }

    /// <summary>
    /// Converts a value from one Volume unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of Volume.</param>
    /// <param name="to">The target unit of Volume.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, VolumeUnit from, VolumeUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }

    /// <summary>
    /// Converts a value from one Volume unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of Volume.</param>
    /// <param name="to">The target unit of Volume.</param>
    /// <returns>The converted value in the target unit as a float.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static float Convert(float value, VolumeUnit from, VolumeUnit to)
    {
        return (float)UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of Volume measurement
/// </summary>
public enum VolumeUnit
{
    /// <summary>
    /// Cubic centimeters (cm³).
    /// </summary>
    Cm_3,
    /// <summary>
    /// Cubic meters (m³).
    /// </summary>
    M_3,
    /// <summary>
    /// Liters (ltr).
    /// </summary>
    Ltr,
    /// <summary>
    /// Cubic inches (in³).
    /// </summary>
    In_3,
    /// <summary>
    /// Cubic feet (ft³).
    /// </summary>
    Ft_3,
    /// <summary>
    /// US Gallons (US Gal).
    /// </summary>
    USGal,
    /// <summary>
    /// Imperial Gallons (Imp. Gal).
    /// </summary>
    ImpGal,
    /// <summary>
    /// US Barrel [oil] (US brl).
    /// </summary>
    USBrl
}