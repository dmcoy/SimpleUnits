namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of area.
/// </summary>
public static class Area
{
    /// <summary>
    /// Static constructor to register area units and conversions with the <see cref="UnitConverter"/>.
    /// </summary>
    static Area()
    {
        // Register Area unit
        UnitConverter.RegisterUnit(typeof(AreaUnit), BaseUnit.Area);

        // mm² conversions
        UnitConverter.RegisterConversion(AreaUnit.Mm2, AreaUnit.Cm2, Mm2ToCm2);
        UnitConverter.RegisterConversion(AreaUnit.Mm2, AreaUnit.M2, Mm2ToM2);
        UnitConverter.RegisterConversion(AreaUnit.Mm2, AreaUnit.In2, Mm2ToIn2);
        UnitConverter.RegisterConversion(AreaUnit.Mm2, AreaUnit.Ft2, Mm2ToFt2);
        UnitConverter.RegisterConversion(AreaUnit.Mm2, AreaUnit.Yd2, Mm2ToYd2);

        // cm² conversions
        UnitConverter.RegisterConversion(AreaUnit.Cm2, AreaUnit.Mm2, Cm2ToMm2);
        UnitConverter.RegisterConversion(AreaUnit.Cm2, AreaUnit.M2, Cm2ToM2);
        UnitConverter.RegisterConversion(AreaUnit.Cm2, AreaUnit.In2, Cm2ToIn2);
        UnitConverter.RegisterConversion(AreaUnit.Cm2, AreaUnit.Ft2, Cm2ToFt2);
        UnitConverter.RegisterConversion(AreaUnit.Cm2, AreaUnit.Yd2, Cm2ToYd2);

        // m² conversions
        UnitConverter.RegisterConversion(AreaUnit.M2, AreaUnit.Mm2, M2ToMm2);
        UnitConverter.RegisterConversion(AreaUnit.M2, AreaUnit.Cm2, M2ToCm2);
        UnitConverter.RegisterConversion(AreaUnit.M2, AreaUnit.In2, M2ToIn2);
        UnitConverter.RegisterConversion(AreaUnit.M2, AreaUnit.Ft2, M2ToFt2);
        UnitConverter.RegisterConversion(AreaUnit.M2, AreaUnit.Yd2, M2ToYd2);

        // in² conversions
        UnitConverter.RegisterConversion(AreaUnit.In2, AreaUnit.Mm2, In2ToMm2);
        UnitConverter.RegisterConversion(AreaUnit.In2, AreaUnit.Cm2, In2ToCm2);
        UnitConverter.RegisterConversion(AreaUnit.In2, AreaUnit.M2, In2ToM2);
        UnitConverter.RegisterConversion(AreaUnit.In2, AreaUnit.Ft2, In2ToFt2);
        UnitConverter.RegisterConversion(AreaUnit.In2, AreaUnit.Yd2, In2ToYd2);

        // ft² conversions
        UnitConverter.RegisterConversion(AreaUnit.Ft2, AreaUnit.Mm2, Ft2ToMm2);
        UnitConverter.RegisterConversion(AreaUnit.Ft2, AreaUnit.Cm2, Ft2ToCm2);
        UnitConverter.RegisterConversion(AreaUnit.Ft2, AreaUnit.M2, Ft2ToM2);
        UnitConverter.RegisterConversion(AreaUnit.Ft2, AreaUnit.In2, Ft2ToIn2);
        UnitConverter.RegisterConversion(AreaUnit.Ft2, AreaUnit.Yd2, Ft2ToYd2);

        // yd² conversions
        UnitConverter.RegisterConversion(AreaUnit.Yd2, AreaUnit.Mm2, Yd2ToMm2);
        UnitConverter.RegisterConversion(AreaUnit.Yd2, AreaUnit.Cm2, Yd2ToCm2);
        UnitConverter.RegisterConversion(AreaUnit.Yd2, AreaUnit.M2, Yd2ToM2);
        UnitConverter.RegisterConversion(AreaUnit.Yd2, AreaUnit.In2, Yd2ToIn2);
        UnitConverter.RegisterConversion(AreaUnit.Yd2, AreaUnit.Ft2, Yd2ToFt2);
    }

    #region Conversion Factors
    /// <summary>
    /// Collection of conversion factors for area units.
    /// </summary>
    public struct Factor
    {
        /// <summary>
        /// Conversion factor from square millimeters (mm²) to square centimeters (cm²).
        /// </summary>
        public const double Mm2ToCm2 = 0.01;
        /// <summary>
        /// Conversion factor from square millimeters (mm²) to square meters (m²).
        /// </summary>
        public const double Mm2ToM2 = 0.000_001;
        /// <summary>
        /// Conversion factor from square millimeters (mm²) to square inches (in²).
        /// </summary>
        public const double Mm2ToIn2 = 0.001_55;
        /// <summary>
        /// Conversion factor from square millimeters (mm²) to square feet (ft²).
        /// </summary>
        public const double Mm2ToFt2 = 0.000_011;
        /// <summary>
        /// Conversion factor from square millimeters (mm²) to square yards (yd²).
        /// </summary>
        public const double Mm2ToYd2 = 0.000_001;

        /// <summary>
        /// Conversion factor from square centimeters (cm²) to square millimeters (mm²).
        /// </summary>
        public const double Cm2ToMm2 = 100;
        /// <summary>
        /// Conversion factor from square centimeters (cm²) to square meters (m²).
        /// </summary>
        public const double Cm2ToM2 = 0.000_1;
        /// <summary>
        /// Conversion factor from square centimeters (cm²) to square inches (in²).
        /// </summary>
        public const double Cm2ToIn2 = 0.155;
        /// <summary>
        /// Conversion factor from square centimeters (cm²) to square feet (ft²).
        /// </summary>
        public const double Cm2ToFt2 = 0.001_076;
        /// <summary>
        /// Conversion factor from square centimeters (cm²) to square yards (yd²).
        /// </summary>
        public const double Cm2ToYd2 = 0.000_12;

        /// <summary>
        /// Conversion factor from square meters (m²) to square millimeters (mm²).
        /// </summary>
        public const double M2ToMm2 = 1_000_000;
        /// <summary>
        /// Conversion factor from square meters (m²) to square centimeters (cm²).
        /// </summary>
        public const double M2ToCm2 = 10_000;
        /// <summary>
        /// Conversion factor from square meters (m²) to square inches (in²).
        /// </summary>
        public const double M2ToIn2 = 1_550.003;
        /// <summary>
        /// Conversion factor from square meters (m²) to square feet (ft²).
        /// </summary>
        public const double M2ToFt2 = 10.763_91;
        /// <summary>
        /// Conversion factor from square meters (m²) to square yards (yd²).
        /// </summary>
        public const double M2ToYd2 = 1.195_99;

        /// <summary>
        /// Conversion factor from square inches (in²) to square millimeters (mm²).
        /// </summary>
        public const double In2ToMm2 = 645.16;
        /// <summary>
        /// Conversion factor from square inches (in²) to square centimeters (cm²).
        /// </summary>
        public const double In2ToCm2 = 6.451_6;
        /// <summary>
        /// Conversion factor from square inches (in²) to square meters (m²).
        /// </summary>
        public const double In2ToM2 = 0.000_645;
        /// <summary>
        /// Conversion factor from square inches (in²) to square feet (ft²).
        /// </summary>
        public const double In2ToFt2 = 0.006_944;
        /// <summary>
        /// Conversion factor from square inches (in²) to square yards (yd²).
        /// </summary>
        public const double In2ToYd2 = 0.000_772;

        /// <summary>
        /// Conversion factor from square feet (ft²) to square millimeters (mm²).
        /// </summary>
        public const double Ft2ToMm2 = 929_03;
        /// <summary>
        /// Conversion factor from square feet (ft²) to square centimeters (cm²).
        /// </summary>
        public const double Ft2ToCm2 = 929.030_4;
        /// <summary>
        /// Conversion factor from square feet (ft²) to square meters (m²).
        /// </summary>
        public const double Ft2ToM2 = 0.092_903;
        /// <summary>
        /// Conversion factor from square feet (ft²) to square inches (in²).
        /// </summary>
        public const double Ft2ToIn2 = 144;
        /// <summary>
        /// Conversion factor from square feet (ft²) to square yards (yd²).
        /// </summary>
        public const double Ft2ToYd2 = 0.111_111;

        /// <summary>
        /// Conversion factor from square yards (yd²) to square millimeters (mm²).
        /// </summary>
        public const double Yd2ToMm2 = 836_127;
        /// <summary>
        /// Conversion factor from square yards (yd²) to square centimeters (cm²).
        /// </summary>
        public const double Yd2ToCm2 = 8_361.274;
        /// <summary>
        /// Conversion factor from square yards (yd²) to square meters (m²).
        /// </summary>
        public const double Yd2ToM2 = 0.836_127;
        /// <summary>
        /// Conversion factor from square yards (yd²) to square inches (in²).
        /// </summary>
        public const double Yd2ToIn2 = 1_296;
        /// <summary>
        /// Conversion factor from square yards (yd²) to square feet (ft²).
        /// </summary>
        public const double Yd2ToFt2 = 9;
    }
    #endregion

    /// <summary>
    /// Converts a value from square millimeters (mm²) to square centimeters (cm²).
    /// </summary>
    public static double Mm2ToCm2(double value) => value * Factor.Mm2ToCm2;
    /// <summary>
    /// Converts a value from square millimeters (mm²) to square meters (m²).
    /// </summary>
    public static double Mm2ToM2(double value) => value * Factor.Mm2ToM2;
    /// <summary>
    /// Converts a value from square millimeters (mm²) to square inches (in²).
    /// </summary>
    public static double Mm2ToIn2(double value) => value * Factor.Mm2ToIn2;
    /// <summary>
    /// Converts a value from square millimeters (mm²) to square feet (ft²).
    /// </summary>
    public static double Mm2ToFt2(double value) => value * Factor.Mm2ToFt2;
    /// <summary>
    /// Converts a value from square millimeters (mm²) to square yards (yd²).
    /// </summary>
    public static double Mm2ToYd2(double value) => value * Factor.Mm2ToYd2;

    /// <summary>
    /// Converts a value from square centimeters (cm²) to square millimeters (mm²).
    /// </summary>
    public static double Cm2ToMm2(double value) => value * Factor.Cm2ToMm2;
    /// <summary>
    /// Converts a value from square centimeters (cm²) to square meters (m²).
    /// </summary>
    public static double Cm2ToM2(double value) => value * Factor.Cm2ToM2;
    /// <summary>
    /// Converts a value from square centimeters (cm²) to square inches (in²).
    /// </summary>
    public static double Cm2ToIn2(double value) => value * Factor.Cm2ToIn2;
    /// <summary>
    /// Converts a value from square centimeters (cm²) to square feet (ft²).
    /// </summary>
    public static double Cm2ToFt2(double value) => value * Factor.Cm2ToFt2;
    /// <summary>
    /// Converts a value from square centimeters (cm²) to square yards (yd²).
    /// </summary>
    public static double Cm2ToYd2(double value) => value * Factor.Cm2ToYd2;

    /// <summary>
    /// Converts a value from square meters (m²) to square millimeters (mm²).
    /// </summary>
    public static double M2ToMm2(double value) => value * Factor.M2ToMm2;
    /// <summary>
    /// Converts a value from square meters (m²) to square centimeters (cm²).
    /// </summary>
    public static double M2ToCm2(double value) => value * Factor.M2ToCm2;
    /// <summary>
    /// Converts a value from square meters (m²) to square inches (in²).
    /// </summary>
    public static double M2ToIn2(double value) => value * Factor.M2ToIn2;
    /// <summary>
    /// Converts a value from square meters (m²) to square feet (ft²).
    /// </summary>
    public static double M2ToFt2(double value) => value * Factor.M2ToFt2;
    /// <summary>
    /// Converts a value from square meters (m²) to square yards (yd²).
    /// </summary>
    public static double M2ToYd2(double value) => value * Factor.M2ToYd2;

    /// <summary>
    /// Converts a value from square inches (in²) to square millimeters (mm²).
    /// </summary>
    public static double In2ToMm2(double value) => value * Factor.In2ToMm2;
    /// <summary>
    /// Converts a value from square inches (in²) to square centimeters (cm²).
    /// </summary>
    public static double In2ToCm2(double value) => value * Factor.In2ToCm2;
    /// <summary>
    /// Converts a value from square inches (in²) to square meters (m²).
    /// </summary>
    public static double In2ToM2(double value) => value * Factor.In2ToM2;
    /// <summary>
    /// Converts a value from square inches (in²) to square feet (ft²).
    /// </summary>
    public static double In2ToFt2(double value) => value * Factor.In2ToFt2;
    /// <summary>
    /// Converts a value from square inches (in²) to square yards (yd²).
    /// </summary>
    public static double In2ToYd2(double value) => value * Factor.In2ToYd2;

    /// <summary>
    /// Converts a value from square feet (ft²) to square millimeters (mm²).
    /// </summary>
    public static double Ft2ToMm2(double value) => value * Factor.Ft2ToMm2;
    /// <summary>
    /// Converts a value from square feet (ft²) to square centimeters (cm²).
    /// </summary>
    public static double Ft2ToCm2(double value) => value * Factor.Ft2ToCm2;
    /// <summary>
    /// Converts a value from square feet (ft²) to square meters (m²).
    /// </summary>
    public static double Ft2ToM2(double value) => value * Factor.Ft2ToM2;
    /// <summary>
    /// Converts a value from square feet (ft²) to square inches (in²).
    /// </summary>
    public static double Ft2ToIn2(double value) => value * Factor.Ft2ToIn2;
    /// <summary>
    /// Converts a value from square feet (ft²) to square yards (yd²).
    /// </summary>
    public static double Ft2ToYd2(double value) => value * Factor.Ft2ToYd2;

    /// <summary>
    /// Converts a value from square yards (yd²) to square millimeters (mm²).
    /// </summary>
    public static double Yd2ToMm2(double value) => value * Factor.Yd2ToMm2;
    /// <summary>
    /// Converts a value from square yards (yd²) to square centimeters (cm²).
    /// </summary>
    public static double Yd2ToCm2(double value) => value * Factor.Yd2ToCm2;
    /// <summary>
    /// Converts a value from square yards (yd²) to square meters (m²).
    /// </summary>
    public static double Yd2ToM2(double value) => value * Factor.Yd2ToM2;
    /// <summary>
    /// Converts a value from square yards (yd²) to square inches (in²).
    /// </summary>
    public static double Yd2ToIn2(double value) => value * Factor.Yd2ToIn2;
    /// <summary>
    /// Converts a value from square yards (yd²) to square feet (ft²).
    /// </summary>
    public static double Yd2ToFt2(double value) => value * Factor.Yd2ToFt2;

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

    /// <summary>
    /// Converts a value from one area unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of area.</param>
    /// <param name="to">The target unit of area.</param>
    /// <returns>The converted value in the target unit as a float.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static float Convert(float value, AreaUnit from, AreaUnit to)
    {
        return (float)UnitConverter.Convert(value, from, to);
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
    Mm2,
    /// <summary>
    /// Square centimeters (cm²).
    /// </summary>
    Cm2,
    /// <summary>
    /// Square meters (m²).
    /// </summary>
    M2,
    /// <summary>
    /// Square inches (in²).
    /// </summary>
    In2,
    /// <summary>
    /// Square feet (ft²).
    /// </summary>
    Ft2,
    /// <summary>
    /// Square yards (yd²).
    /// </summary>
    Yd2
}
