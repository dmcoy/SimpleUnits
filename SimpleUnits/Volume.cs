namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of volume.
/// </summary>
public static class Volume
{
    /// <summary>
    /// Static constructor to register volume units and conversions with the <see cref="UnitConverter"/>.
    /// </summary>
    static Volume()
    {
        // Register Volume unit
        UnitConverter.RegisterUnit(typeof(VolumeUnit), BaseUnit.Volume);

        // cm³ conversions
        UnitConverter.RegisterConversion(VolumeUnit.Cm3, VolumeUnit.M3, Cm3ToM3);
        UnitConverter.RegisterConversion(VolumeUnit.Cm3, VolumeUnit.Ltr, Cm3ToLtr);
        UnitConverter.RegisterConversion(VolumeUnit.Cm3, VolumeUnit.In3, Cm3ToIn3);
        UnitConverter.RegisterConversion(VolumeUnit.Cm3, VolumeUnit.Ft3, Cm3ToFt3);
        UnitConverter.RegisterConversion(VolumeUnit.Cm3, VolumeUnit.USGal, Cm3ToUSGal);
        UnitConverter.RegisterConversion(VolumeUnit.Cm3, VolumeUnit.ImpGal, Cm3ToImpGal);
        UnitConverter.RegisterConversion(VolumeUnit.Cm3, VolumeUnit.USBrl, Cm3ToUSBrl);

        // m³ conversions
        UnitConverter.RegisterConversion(VolumeUnit.M3, VolumeUnit.Cm3, M3ToCm3);
        UnitConverter.RegisterConversion(VolumeUnit.M3, VolumeUnit.Ltr, M3ToLtr);
        UnitConverter.RegisterConversion(VolumeUnit.M3, VolumeUnit.In3, M3ToIn3);
        UnitConverter.RegisterConversion(VolumeUnit.M3, VolumeUnit.Ft3, M3ToFt3);
        UnitConverter.RegisterConversion(VolumeUnit.M3, VolumeUnit.USGal, M3ToUSGal);
        UnitConverter.RegisterConversion(VolumeUnit.M3, VolumeUnit.ImpGal, M3ToImpGal);

        // Ltr conversions
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.Cm3, LtrToCm3);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.M3, LtrToM3);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.In3, LtrToIn3);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.Ft3, LtrToFt3);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.USGal, LtrToUSGal);
        UnitConverter.RegisterConversion(VolumeUnit.Ltr, VolumeUnit.ImpGal, LtrToImpGal);

        // in³ conversions
        UnitConverter.RegisterConversion(VolumeUnit.In3, VolumeUnit.Cm3, In3ToCm3);
        UnitConverter.RegisterConversion(VolumeUnit.In3, VolumeUnit.M3, In3ToM3);
        UnitConverter.RegisterConversion(VolumeUnit.In3, VolumeUnit.Ltr, In3ToLtr);
        UnitConverter.RegisterConversion(VolumeUnit.In3, VolumeUnit.Ft3, In3ToFt3);
        UnitConverter.RegisterConversion(VolumeUnit.In3, VolumeUnit.USGal, In3ToUSGal);
        UnitConverter.RegisterConversion(VolumeUnit.In3, VolumeUnit.ImpGal, In3ToImpGal);
        UnitConverter.RegisterConversion(VolumeUnit.In3, VolumeUnit.USBrl, In3ToUSBrl);

        // ft³ conversions
        UnitConverter.RegisterConversion(VolumeUnit.Ft3, VolumeUnit.Cm3, Ft3ToCm3);
        UnitConverter.RegisterConversion(VolumeUnit.Ft3, VolumeUnit.M3, Ft3ToM3);
        UnitConverter.RegisterConversion(VolumeUnit.Ft3, VolumeUnit.Ltr, Ft3ToLtr);
        UnitConverter.RegisterConversion(VolumeUnit.Ft3, VolumeUnit.In3, Ft3ToIn3);
        UnitConverter.RegisterConversion(VolumeUnit.Ft3, VolumeUnit.USGal, Ft3ToUSGal);
        UnitConverter.RegisterConversion(VolumeUnit.Ft3, VolumeUnit.ImpGal, Ft3ToImpGal);
        UnitConverter.RegisterConversion(VolumeUnit.Ft3, VolumeUnit.USBrl, Ft3ToUSBrl);

        // US gal conversions
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.Cm3, USGalToCm3);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.M3, USGalToM3);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.Ltr, USGalToLtr);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.In3, USGalToIn3);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.Ft3, USGalToFt3);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.ImpGal, USGalToImpGal);
        UnitConverter.RegisterConversion(VolumeUnit.USGal, VolumeUnit.USBrl, USGalToUSBrl);

        // Imp gal conversions
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.Cm3, ImpGalToCm3);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.M3, ImpGalToM3);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.Ltr, ImpGalToLtr);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.In3, ImpGalToIn3);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.Ft3, ImpGalToFt3);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.USGal, ImpGalToUSGal);
        UnitConverter.RegisterConversion(VolumeUnit.ImpGal, VolumeUnit.USBrl, ImpGalToUSBrl);

        // US barrel (oil) conversions
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.Cm3, USBrlToCm3);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.M3, USBrlToM3);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.Ltr, USBrlToLtr);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.In3, USBrlToIn3);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.Ft3, USBrlToFt3);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.USGal, USBrlToUSGal);
        UnitConverter.RegisterConversion(VolumeUnit.USBrl, VolumeUnit.ImpGal, USBrlToImpGal);
    }

    #region Conversion Factors
    /// <summary>
    /// Collection of conversion factors for volume units.
    /// </summary>
    public struct Factor
    {
        /// <summary>
        /// Conversion factor from cubic centimeters (cm³) to cubic meters (m³).
        /// </summary>
        public const double Cm3ToM3 = 0.000_001;
        /// <summary>
        /// Conversion factor from cubic centimeters (cm³) to liters (L).
        /// </summary>
        public const double Cm3ToLtr = 0.001;
        /// <summary>
        /// Conversion factor from cubic centimeters (cm³) to cubic inches (in³).
        /// </summary>
        public const double Cm3ToIn3 = 0.061_024;
        /// <summary>
        /// Conversion factor from cubic centimeters (cm³) to cubic feet (ft³).
        /// </summary>
        public const double Cm3ToFt3 = 0.000_035;
        /// <summary>
        /// Conversion factor from cubic centimeters (cm³) to US gallons (US gal).
        /// </summary>
        public const double Cm3ToUSGal = 0.000_264;
        /// <summary>
        /// Conversion factor from cubic centimeters (cm³) to Imperial gallons (Imp gal).
        /// </summary>
        public const double Cm3ToImpGal = 0.000_22;
        /// <summary>
        /// Conversion factor from cubic centimeters (cm³) to US barrels (oil) (US brl).
        /// </summary>
        public const double Cm3ToUSBrl = 0.000006;

        /// <summary>
        /// Conversion factor from cubic meters (m³) to cubic centimeters (cm³).
        /// </summary>
        public const double M3ToCm3 = 1_000_000;
        /// <summary>
        /// Conversion factor from cubic meters (m³) to liters (L).
        /// </summary>
        public const double M3ToLtr = 1_000;
        /// <summary>
        /// Conversion factor from cubic meters (m³) to cubic inches (in³).
        /// </summary>
        public const double M3ToIn3 = 61_024;
        /// <summary>
        /// Conversion factor from cubic meters (m³) to cubic feet (ft³).
        /// </summary>
        public const double M3ToFt3 = 35;
        /// <summary>
        /// Conversion factor from cubic meters (m³) to US gallons (US gal).
        /// </summary>
        public const double M3ToUSGal = 264;
        /// <summary>
        /// Conversion factor from cubic meters (m³) to Imperial gallons (Imp gal).
        /// </summary>
        public const double M3ToImpGal = 220;

        /// <summary>
        /// Conversion factor from liters (L) to cubic centimeters (cm³).
        /// </summary>
        public const double LtrToCm3 = 1_000;
        /// <summary>
        /// Conversion factor from liters (L) to cubic meters (m³).
        /// </summary>
        public const double LtrToM3 = 0.001;
        /// <summary>
        /// Conversion factor from liters (L) to cubic inches (in³).
        /// </summary>
        public const double LtrToIn3 = 61;
        /// <summary>
        /// Conversion factor from liters (L) to cubic feet (ft³).
        /// </summary>
        public const double LtrToFt3 = 0.035;
        /// <summary>
        /// Conversion factor from liters (L) to US gallons (US gal).
        /// </summary>
        public const double LtrToUSGal = 0.264_201;
        /// <summary>
        /// Conversion factor from liters (L) to Imperial gallons (Imp gal).
        /// </summary>
        public const double LtrToImpGal = 0.22;

        /// <summary>
        /// Conversion factor from cubic inches (in³) to cubic centimeters (cm³).
        /// </summary>
        public const double In3ToCm3 = 16.4;
        /// <summary>
        /// Conversion factor from cubic inches (in³) to cubic meters (m³).
        /// </summary>
        public const double In3ToM3 = 0.000_016;
        /// <summary>
        /// Conversion factor from cubic inches (in³) to liters (L).
        /// </summary>
        public const double In3ToLtr = 0.016_387;
        /// <summary>
        /// Conversion factor from cubic inches (in³) to cubic feet (ft³).
        /// </summary>
        public const double In3ToFt3 = 0.000_579;
        /// <summary>
        /// Conversion factor from cubic inches (in³) to US gallons (US gal).
        /// </summary>
        public const double In3ToUSGal = 0.004_329;
        /// <summary>
        /// Conversion factor from cubic inches (in³) to Imperial gallons (Imp gal).
        /// </summary>
        public const double In3ToImpGal = 0.003_605;
        /// <summary>
        /// Conversion factor from cubic inches (in³) to US barrels (oil) (US brl).
        /// </summary>
        public const double In3ToUSBrl = 0.000_103;

        /// <summary>
        /// Conversion factor from cubic feet (ft³) to cubic centimeters (cm³).
        /// </summary>
        public const double Ft3ToCm3 = 28_317;
        /// <summary>
        /// Conversion factor from cubic feet (ft³) to cubic meters (m³).
        /// </summary>
        public const double Ft3ToM3 = 0.028_317;
        /// <summary>
        /// Conversion factor from cubic feet (ft³) to liters (L).
        /// </summary>
        public const double Ft3ToLtr = 28.316_85;
        /// <summary>
        /// Conversion factor from cubic feet (ft³) to cubic inches (in³).
        /// </summary>
        public const double Ft3ToIn3 = 1_728;
        /// <summary>
        /// Conversion factor from cubic feet (ft³) to US gallons (US gal).
        /// </summary>
        public const double Ft3ToUSGal = 7.481_333;
        /// <summary>
        /// Conversion factor from cubic feet (ft³) to Imperial gallons (Imp gal).
        /// </summary>
        public const double Ft3ToImpGal = 6.229_712;
        /// <summary>
        /// Conversion factor from cubic feet (ft³) to US barrels (oil) (US brl).
        /// </summary>
        public const double Ft3ToUSBrl = 0.178_127;

        /// <summary>
        /// Conversion factor from US gallons (US gal) to cubic centimeters (cm³).
        /// </summary>
        public const double USGalToCm3 = 3_785;
        /// <summary>
        /// Conversion factor from US gallons (US gal) to cubic meters (m³).
        /// </summary>
        public const double USGalToM3 = 0.003_785;
        /// <summary>
        /// Conversion factor from US gallons (US gal) to liters (L).
        /// </summary>
        public const double USGalToLtr = 3.79;
        /// <summary>
        /// Conversion factor from US gallons (US gal) to cubic inches (in³).
        /// </summary>
        public const double USGalToIn3 = 231;
        /// <summary>
        /// Conversion factor from US gallons (US gal) to cubic feet (ft³).
        /// </summary>
        public const double USGalToFt3 = 0.13;
        /// <summary>
        /// Conversion factor from US gallons (US gal) to Imperial gallons (Imp gal).
        /// </summary>
        public const double USGalToImpGal = 0.832_701;
        /// <summary>
        /// Conversion factor from US gallons (US gal) to US barrels (oil) (US brl).
        /// </summary>
        public const double USGalToUSBrl = 0.023_81;

        /// <summary>
        /// Conversion factor from Imperial gallons (Imp gal) to cubic centimeters (cm³).
        /// </summary>
        public const double ImpGalToCm3 = 4_545;
        /// <summary>
        /// Conversion factor from Imperial gallons (Imp gal) to cubic meters (m³).
        /// </summary>
        public const double ImpGalToM3 = 0.004_545;
        /// <summary>
        /// Conversion factor from Imperial gallons (Imp gal) to liters (L).
        /// </summary>
        public const double ImpGalToLtr = 4.55;
        /// <summary>
        /// Conversion factor from Imperial gallons (Imp gal) to cubic inches (in³).
        /// </summary>
        public const double ImpGalToIn3 = 277;
        /// <summary>
        /// Conversion factor from Imperial gallons (Imp gal) to cubic feet (ft³).
        /// </summary>
        public const double ImpGalToFt3 = 0.16;
        /// <summary>
        /// Conversion factor from Imperial gallons (Imp gal) to US gallons (US gal).
        /// </summary>
        public const double ImpGalToUSGal = 1.20;
        /// <summary>
        /// Conversion factor from Imperial gallons (Imp gal) to US barrels (oil) (US brl).
        /// </summary>
        public const double ImpGalToUSBrl = 0.028_593;

        /// <summary>
        /// Conversion factor from US barrels (oil) (US brl) to cubic centimeters (cm³).
        /// </summary>
        public const double USBrlToCm3 = 158_970;
        /// <summary>
        /// Conversion factor from US barrels (oil) (US brl) to cubic meters (m³).
        /// </summary>
        public const double USBrlToM3 = 0.158_97;
        /// <summary>
        /// Conversion factor from US barrels (oil) (US brl) to liters (L).
        /// </summary>
        public const double USBrlToLtr = 159;
        /// <summary>
        /// Conversion factor from US barrels (oil) (US brl) to cubic inches (in³).
        /// </summary>
        public const double USBrlToIn3 = 9_701;
        /// <summary>
        /// Conversion factor from US barrels (oil) (US brl) to cubic feet (ft³).
        /// </summary>
        public const double USBrlToFt3 = 6;
        /// <summary>
        /// Conversion factor from US barrels (oil) (US brl) to US gallons (US gal).
        /// </summary>
        public const double USBrlToUSGal = 42;
        /// <summary>
        /// Conversion factor from US barrels (oil) (US brl) to Imperial gallons (Imp gal).
        /// </summary>
        public const double USBrlToImpGal = 35;
    }
    #endregion

    /// <summary>
    /// Converts a value in cubic centimeters (cm³) to cubic meters (m³).
    /// </summary>
    /// <param name="value">The value in cubic centimeters.</param>
    /// <returns>The equivalent value in cubic meters.</returns>
    public static double Cm3ToM3(double value) => value * Factor.Cm3ToM3;

    /// <summary>
    /// Converts a value in cubic centimeters (cm³) to liters (L).
    /// </summary>
    /// <param name="value">The value in cubic centimeters.</param>
    /// <returns>The equivalent value in liters.</returns>
    public static double Cm3ToLtr(double value) => value * Factor.Cm3ToLtr;

    /// <summary>
    /// Converts a value in cubic centimeters (cm³) to cubic inches (in³).
    /// </summary>
    /// <param name="value">The value in cubic centimeters.</param>
    /// <returns>The equivalent value in cubic inches.</returns>
    public static double Cm3ToIn3(double value) => value * Factor.Cm3ToIn3;

    /// <summary>
    /// Converts a value in cubic centimeters (cm³) to cubic feet (ft³).
    /// </summary>
    /// <param name="value">The value in cubic centimeters.</param>
    /// <returns>The equivalent value in cubic feet.</returns>
    public static double Cm3ToFt3(double value) => value * Factor.Cm3ToFt3;

    /// <summary>
    /// Converts a value in cubic centimeters (cm³) to US gallons (US gal).
    /// </summary>
    /// <param name="value">The value in cubic centimeters.</param>
    /// <returns>The equivalent value in US gallons.</returns>
    public static double Cm3ToUSGal(double value) => value * Factor.Cm3ToUSGal;

    /// <summary>
    /// Converts a value in cubic centimeters (cm³) to Imperial gallons (Imp gal).
    /// </summary>
    /// <param name="value">The value in cubic centimeters.</param>
    /// <returns>The equivalent value in Imperial gallons.</returns>
    public static double Cm3ToImpGal(double value) => value * Factor.Cm3ToImpGal;

    /// <summary>
    /// Converts a value in cubic centimeters (cm³) to US barrels (oil) (US brl).
    /// </summary>
    /// <param name="value">The value in cubic centimeters.</param>
    /// <returns>The equivalent value in US barrels (oil).</returns>
    public static double Cm3ToUSBrl(double value) => value * Factor.Cm3ToUSBrl;

    /// <summary>
    /// Converts a value in cubic meters (m³) to cubic centimeters (cm³).
    /// </summary>
    /// <param name="value">The value in cubic meters.</param>
    /// <returns>The equivalent value in cubic centimeters.</returns>
    public static double M3ToCm3(double value) => value * Factor.M3ToCm3;

    /// <summary>
    /// Converts a value in cubic meters (m³) to liters (L).
    /// </summary>
    /// <param name="value">The value in cubic meters.</param>
    /// <returns>The equivalent value in liters.</returns>
    public static double M3ToLtr(double value) => value * Factor.M3ToLtr;

    /// <summary>
    /// Converts a value in cubic meters (m³) to cubic inches (in³).
    /// </summary>
    /// <param name="value">The value in cubic meters.</param>
    /// <returns>The equivalent value in cubic inches.</returns>
    public static double M3ToIn3(double value) => value * Factor.M3ToIn3;

    /// <summary>
    /// Converts a value in cubic meters (m³) to cubic feet (ft³).
    /// </summary>
    /// <param name="value">The value in cubic meters.</param>
    /// <returns>The equivalent value in cubic feet.</returns>
    public static double M3ToFt3(double value) => value * Factor.M3ToFt3;

    /// <summary>
    /// Converts a value in cubic meters (m³) to US gallons (US gal).
    /// </summary>
    /// <param name="value">The value in cubic meters.</param>
    /// <returns>The equivalent value in US gallons.</returns>
    public static double M3ToUSGal(double value) => value * Factor.M3ToUSGal;

    /// <summary>
    /// Converts a value in cubic meters (m³) to Imperial gallons (Imp gal).
    /// </summary>
    /// <param name="value">The value in cubic meters.</param>
    /// <returns>The equivalent value in Imperial gallons.</returns>
    public static double M3ToImpGal(double value) => value * Factor.M3ToImpGal;

    /// <summary>
    /// Converts a value in liters (L) to cubic centimeters (cm³).
    /// </summary>
    /// <param name="value">The value in liters.</param>
    /// <returns>The equivalent value in cubic centimeters.</returns>
    public static double LtrToCm3(double value) => value * Factor.LtrToCm3;

    /// <summary>
    /// Converts a value in liters (L) to cubic meters (m³).
    /// </summary>
    /// <param name="value">The value in liters.</param>
    /// <returns>The equivalent value in cubic meters.</returns>
    public static double LtrToM3(double value) => value * Factor.LtrToM3;

    /// <summary>
    /// Converts a value in liters (L) to cubic inches (in³).
    /// </summary>
    /// <param name="value">The value in liters.</param>
    /// <returns>The equivalent value in cubic inches.</returns>
    public static double LtrToIn3(double value) => value * Factor.LtrToIn3;

    /// <summary>
    /// Converts a value in liters (L) to cubic feet (ft³).
    /// </summary>
    /// <param name="value">The value in liters.</param>
    /// <returns>The equivalent value in cubic feet.</returns>
    public static double LtrToFt3(double value) => value * Factor.LtrToFt3;

    /// <summary>
    /// Converts a value in liters (L) to US gallons (US gal).
    /// </summary>
    /// <param name="value">The value in liters.</param>
    /// <returns>The equivalent value in US gallons.</returns>
    public static double LtrToUSGal(double value) => value * Factor.LtrToUSGal;

    /// <summary>
    /// Converts a value in liters (L) to Imperial gallons (Imp gal).
    /// </summary>
    /// <param name="value">The value in liters.</param>
    /// <returns>The equivalent value in Imperial gallons.</returns>
    public static double LtrToImpGal(double value) => value * Factor.LtrToImpGal;

    /// <summary>
    /// Converts a value in cubic inches (in³) to cubic centimeters (cm³).
    /// </summary>
    /// <param name="value">The value in cubic inches.</param>
    /// <returns>The equivalent value in cubic centimeters.</returns>
    public static double In3ToCm3(double value) => value * Factor.In3ToCm3;

    /// <summary>
    /// Converts a value in cubic inches (in³) to cubic meters (m³).
    /// </summary>
    /// <param name="value">The value in cubic inches.</param>
    /// <returns>The equivalent value in cubic meters.</returns>
    public static double In3ToM3(double value) => value * Factor.In3ToM3;

    /// <summary>
    /// Converts a value in cubic inches (in³) to liters (L).
    /// </summary>
    /// <param name="value">The value in cubic inches.</param>
    /// <returns>The equivalent value in liters.</returns>
    public static double In3ToLtr(double value) => value * Factor.In3ToLtr;

    /// <summary>
    /// Converts a value in cubic inches (in³) to cubic feet (ft³).
    /// </summary>
    /// <param name="value">The value in cubic inches.</param>
    /// <returns>The equivalent value in cubic feet.</returns>
    public static double In3ToFt3(double value) => value * Factor.In3ToFt3;

    /// <summary>
    /// Converts a value in cubic inches (in³) to US gallons (US gal).
    /// </summary>
    /// <param name="value">The value in cubic inches.</param>
    /// <returns>The equivalent value in US gallons.</returns>
    public static double In3ToUSGal(double value) => value * Factor.In3ToUSGal;

    /// <summary>
    /// Converts a value in cubic inches (in³) to Imperial gallons (Imp gal).
    /// </summary>
    /// <param name="value">The value in cubic inches.</param>
    /// <returns>The equivalent value in Imperial gallons.</returns>
    public static double In3ToImpGal(double value) => value * Factor.In3ToImpGal;

    /// <summary>
    /// Converts a value in cubic inches (in³) to US barrels (oil) (US brl).
    /// </summary>
    /// <param name="value">The value in cubic inches.</param>
    /// <returns>The equivalent value in US barrels (oil).</returns>
    public static double In3ToUSBrl(double value) => value * Factor.In3ToUSBrl;

    /// <summary>
    /// Converts a value in cubic feet (ft³) to cubic centimeters (cm³).
    /// </summary>
    /// <param name="value">The value in cubic feet.</param>
    /// <returns>The equivalent value in cubic centimeters.</returns>
    public static double Ft3ToCm3(double value) => value * Factor.Ft3ToCm3;

    /// <summary>
    /// Converts a value in cubic feet (ft³) to cubic meters (m³).
    /// </summary>
    /// <param name="value">The value in cubic feet.</param>
    /// <returns>The equivalent value in cubic meters.</returns>
    public static double Ft3ToM3(double value) => value * Factor.Ft3ToM3;

    /// <summary>
    /// Converts a value in cubic feet (ft³) to liters (L).
    /// </summary>
    /// <param name="value">The value in cubic feet.</param>
    /// <returns>The equivalent value in liters.</returns>
    public static double Ft3ToLtr(double value) => value * Factor.Ft3ToLtr;

    /// <summary>
    /// Converts a value in cubic feet (ft³) to cubic inches (in³).
    /// </summary>
    /// <param name="value">The value in cubic feet.</param>
    /// <returns>The equivalent value in cubic inches.</returns>
    public static double Ft3ToIn3(double value) => value * Factor.Ft3ToIn3;

    /// <summary>
    /// Converts a value in cubic feet (ft³) to US gallons (US gal).
    /// </summary>
    /// <param name="value">The value in cubic feet.</param>
    /// <returns>The equivalent value in US gallons.</returns>
    public static double Ft3ToUSGal(double value) => value * Factor.Ft3ToUSGal;

    /// <summary>
    /// Converts a value in cubic feet (ft³) to Imperial gallons (Imp gal).
    /// </summary>
    /// <param name="value">The value in cubic feet.</param>
    /// <returns>The equivalent value in Imperial gallons.</returns>
    public static double Ft3ToImpGal(double value) => value * Factor.Ft3ToImpGal;

    /// <summary>
    /// Converts a value in cubic feet (ft³) to US barrels (oil) (US brl).
    /// </summary>
    /// <param name="value">The value in cubic feet.</param>
    /// <returns>The equivalent value in US barrels (oil).</returns>
    public static double Ft3ToUSBrl(double value) => value * Factor.Ft3ToUSBrl;

    /// <summary>
    /// Converts a value in US gallons (US gal) to cubic centimeters (cm³).
    /// </summary>
    /// <param name="value">The value in US gallons.</param>
    /// <returns>The equivalent value in cubic centimeters.</returns>
    public static double USGalToCm3(double value) => value * Factor.USGalToCm3;

    /// <summary>
    /// Converts a value in US gallons (US gal) to cubic meters (m³).
    /// </summary>
    /// <param name="value">The value in US gallons.</param>
    /// <returns>The equivalent value in cubic meters.</returns>
    public static double USGalToM3(double value) => value * Factor.USGalToM3;

    /// <summary>
    /// Converts a value in US gallons (US gal) to liters (L).
    /// </summary>
    /// <param name="value">The value in US gallons.</param>
    /// <returns>The equivalent value in liters.</returns>
    public static double USGalToLtr(double value) => value * Factor.USGalToLtr;

    /// <summary>
    /// Converts a value in US gallons (US gal) to cubic inches (in³).
    /// </summary>
    /// <param name="value">The value in US gallons.</param>
    /// <returns>The equivalent value in cubic inches.</returns>
    public static double USGalToIn3(double value) => value * Factor.USGalToIn3;

    /// <summary>
    /// Converts a value in US gallons (US gal) to cubic feet (ft³).
    /// </summary>
    /// <param name="value">The value in US gallons.</param>
    /// <returns>The equivalent value in cubic feet.</returns>
    public static double USGalToFt3(double value) => value * Factor.USGalToFt3;

    /// <summary>
    /// Converts a value in US gallons (US gal) to Imperial gallons (Imp gal).
    /// </summary>
    /// <param name="value">The value in US gallons.</param>
    /// <returns>The equivalent value in Imperial gallons.</returns>
    public static double USGalToImpGal(double value) => value * Factor.USGalToImpGal;

    /// <summary>
    /// Converts a value in US gallons (US gal) to US barrels (oil) (US brl).
    /// </summary>
    /// <param name="value">The value in US gallons.</param>
    /// <returns>The equivalent value in US barrels (oil).</returns>
    public static double USGalToUSBrl(double value) => value * Factor.USGalToUSBrl;

    /// <summary>
    /// Converts a value in Imperial gallons (Imp gal) to cubic centimeters (cm³).
    /// </summary>
    /// <param name="value">The value in Imperial gallons.</param>
    /// <returns>The equivalent value in cubic centimeters.</returns>
    public static double ImpGalToCm3(double value) => value * Factor.ImpGalToCm3;

    /// <summary>
    /// Converts a value in Imperial gallons (Imp gal) to cubic meters (m³).
    /// </summary>
    /// <param name="value">The value in Imperial gallons.</param>
    /// <returns>The equivalent value in cubic meters.</returns>
    public static double ImpGalToM3(double value) => value * Factor.ImpGalToM3;

    /// <summary>
    /// Converts a value in Imperial gallons (Imp gal) to liters (L).
    /// </summary>
    /// <param name="value">The value in Imperial gallons.</param>
    /// <returns>The equivalent value in liters.</returns>
    public static double ImpGalToLtr(double value) => value * Factor.ImpGalToLtr;

    /// <summary>
    /// Converts a value in Imperial gallons (Imp gal) to cubic inches (in³).
    /// </summary>
    /// <param name="value">The value in Imperial gallons.</param>
    /// <returns>The equivalent value in cubic inches.</returns>
    public static double ImpGalToIn3(double value) => value * Factor.ImpGalToIn3;

    /// <summary>
    /// Converts a value in Imperial gallons (Imp gal) to cubic feet (ft³).
    /// </summary>
    /// <param name="value">The value in Imperial gallons.</param>
    /// <returns>The equivalent value in cubic feet.</returns>
    public static double ImpGalToFt3(double value) => value * Factor.ImpGalToFt3;

    /// <summary>
    /// Converts a value in Imperial gallons (Imp gal) to US gallons (US gal).
    /// </summary>
    /// <param name="value">The value in Imperial gallons.</param>
    /// <returns>The equivalent value in US gallons.</returns>
    public static double ImpGalToUSGal(double value) => value * Factor.ImpGalToUSGal;

    /// <summary>
    /// Converts a value in Imperial gallons (Imp gal) to US barrels (oil) (US brl).
    /// </summary>
    /// <param name="value">The value in Imperial gallons.</param>
    /// <returns>The equivalent value in US barrels (oil).</returns>
    public static double ImpGalToUSBrl(double value) => value * Factor.ImpGalToUSBrl;

    /// <summary>
    /// Converts a value in US barrels (oil) (US brl) to cubic centimeters (cm³).
    /// </summary>
    /// <param name="value">The value in US barrels (oil).</param>
    /// <returns>The equivalent value in cubic centimeters.</returns>
    public static double USBrlToCm3(double value) => value * Factor.USBrlToCm3;

    /// <summary>
    /// Converts a value in US barrels (oil) (US brl) to cubic meters (m³).
    /// </summary>
    /// <param name="value">The value in US barrels (oil).</param>
    /// <returns>The equivalent value in cubic meters.</returns>
    public static double USBrlToM3(double value) => value * Factor.USBrlToM3;

    /// <summary>
    /// Converts a value in US barrels (oil) (US brl) to liters (L).
    /// </summary>
    /// <param name="value">The value in US barrels (oil).</param>
    /// <returns>The equivalent value in liters.</returns>
    public static double USBrlToLtr(double value) => value * Factor.USBrlToLtr;

    /// <summary>
    /// Converts a value in US barrels (oil) (US brl) to cubic inches (in³).
    /// </summary>
    /// <param name="value">The value in US barrels (oil).</param>
    /// <returns>The equivalent value in cubic inches.</returns>
    public static double USBrlToIn3(double value) => value * Factor.USBrlToIn3;

    /// <summary>
    /// Converts a value in US barrels (oil) (US brl) to cubic feet (ft³).
    /// </summary>
    /// <param name="value">The value in US barrels (oil).</param>
    /// <returns>The equivalent value in cubic feet.</returns>
    public static double USBrlToFt3(double value) => value * Factor.USBrlToFt3;

    /// <summary>
    /// Converts a value in US barrels (oil) (US brl) to US gallons (US gal).
    /// </summary>
    /// <param name="value">The value in US barrels (oil).</param>
    /// <returns>The equivalent value in US gallons.</returns>
    public static double USBrlToUSGal(double value) => value * Factor.USBrlToUSGal;

    /// <summary>
    /// Converts a value in US barrels (oil) (US brl) to Imperial gallons (Imp gal).
    /// </summary>
    /// <param name="value">The value in US barrels (oil).</param>
    /// <returns>The equivalent value in Imperial gallons.</returns>
    public static double USBrlToImpGal(double value) => value * Factor.USBrlToImpGal;

    /// <summary>
    /// Converts a value from one volume unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of volume.</param>
    /// <param name="to">The target unit of volume.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, VolumeUnit from, VolumeUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }

    /// <summary>
    /// Converts a value from one volume unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of volume.</param>
    /// <param name="to">The target unit of volume.</param>
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
    Cm3,
    /// <summary>
    /// Cubic meters (m³).
    /// </summary>
    M3,
    /// <summary>
    /// Liters (ltr).
    /// </summary>
    Ltr,
    /// <summary>
    /// Cubic inches (in³).
    /// </summary>
    In3,
    /// <summary>
    /// Cubic feet (ft³).
    /// </summary>
    Ft3,
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