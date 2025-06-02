namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of density.
/// </summary>
public static class Density
{
    /// <summary>
    /// Static constructor to register density units and conversions with the <see cref="UnitConverter"/>.
    /// </summary>
    static Density()
    {
        // Register Density unit
        UnitConverter.RegisterUnit(typeof(DensityUnit), BaseUnit.Density);

        // g/ml conversions
        UnitConverter.RegisterConversion(DensityUnit.Gml, DensityUnit.Kgm3, GmlToKgm3);
        UnitConverter.RegisterConversion(DensityUnit.Gml, DensityUnit.Lbft3, GmlToLbft3);
        UnitConverter.RegisterConversion(DensityUnit.Gml, DensityUnit.Lbin3, GmlToLbin3);

        // kg/m³ conversions
        UnitConverter.RegisterConversion(DensityUnit.Kgm3, DensityUnit.Gml, Kgm3ToGml);
        UnitConverter.RegisterConversion(DensityUnit.Kgm3, DensityUnit.Lbft3, Kgm3ToLbft3);
        UnitConverter.RegisterConversion(DensityUnit.Kgm3, DensityUnit.Lbin3, Kgm3ToLbin3);

        // lb/ft³ conversions
        UnitConverter.RegisterConversion(DensityUnit.Lbft3, DensityUnit.Gml, Lbft3ToGml);
        UnitConverter.RegisterConversion(DensityUnit.Lbft3, DensityUnit.Kgm3, Lbft3ToKgm3);
        UnitConverter.RegisterConversion(DensityUnit.Lbft3, DensityUnit.Lbin3, Lbft3ToLbin3);

        // lb/in³ conversions
        UnitConverter.RegisterConversion(DensityUnit.Lbin3, DensityUnit.Gml, Lbin3ToGml);
        UnitConverter.RegisterConversion(DensityUnit.Lbin3, DensityUnit.Kgm3, Lbin3ToKgm3);
        UnitConverter.RegisterConversion(DensityUnit.Lbin3, DensityUnit.Lbft3, Lbin3ToLbft3);
    }

    #region Conversion Factors
    /// <summary>
    /// Collection of conversion factors for density units.
    /// </summary>
    public struct Factor
    {
        /// <summary>
        /// Conversion factor from gram per milliliter (g/ml) to kilogram per cubic meter (kg/m³).
        /// </summary>
        public const double GmlToKgm3 = 1000;
        /// <summary>
        /// Conversion factor from gram per milliliter (g/ml) to pound per cubic foot (lb/ft³).
        /// </summary>
        public const double GmlToLbft3 = 62.42197;
        /// <summary>
        /// Conversion factor from gram per milliliter (g/ml) to pound per cubic inch (lb/in³).
        /// </summary>
        public const double GmlToLbin3 = 0.036127;

        /// <summary>
        /// Conversion factor from kilogram per cubic meter (kg/m³) to gram per milliliter (g/ml).
        /// </summary>
        public const double Kgm3ToGml = 0.001;
        /// <summary>
        /// Conversion factor from kilogram per cubic meter (kg/m³) to pound per cubic foot (lb/ft³).
        /// </summary>
        public const double Kgm3ToLbft3 = 0.062422;
        /// <summary>
        /// Conversion factor from kilogram per cubic meter (kg/m³) to pound per cubic inch (lb/in³).
        /// </summary>
        public const double Kgm3ToLbin3 = 0.000036;

        /// <summary>
        /// Conversion factor from pound per cubic foot (lb/ft³) to gram per milliliter (g/ml).
        /// </summary>
        public const double Lbft3ToGml = 0.01602;
        /// <summary>
        /// Conversion factor from pound per cubic foot (lb/ft³) to kilogram per cubic meter (kg/m³).
        /// </summary>
        public const double Lbft3ToKgm3 = 16.02;
        /// <summary>
        /// Conversion factor from pound per cubic foot (lb/ft³) to pound per cubic inch (lb/in³).
        /// </summary>
        public const double Lbft3ToLbin3 = 0.000579;

        /// <summary>
        /// Conversion factor from pound per cubic inch (lb/in³) to gram per milliliter (g/ml).
        /// </summary>
        public const double Lbin3ToGml = 27.68;
        /// <summary>
        /// Conversion factor from pound per cubic inch (lb/in³) to kilogram per cubic meter (kg/m³).
        /// </summary>
        public const double Lbin3ToKgm3 = 27680;
        /// <summary>
        /// Conversion factor from pound per cubic inch (lb/in³) to pound per cubic foot (lb/ft³).
        /// </summary>
        public const double Lbin3ToLbft3 = 1727.84;
    }
    #endregion

    /// <summary>
    /// Converts a value from gram per milliliter (g/ml) to kilogram per cubic meter (kg/m³).
    /// </summary>
    /// <param name="value">The value in gram per milliliter.</param>
    /// <returns>The equivalent value in kilogram per cubic meter.</returns>
    public static double GmlToKgm3(double value) => value * Factor.GmlToKgm3;

    /// <summary>
    /// Converts a value from gram per milliliter (g/ml) to pound per cubic foot (lb/ft³).
    /// </summary>
    /// <param name="value">The value in gram per milliliter.</param>
    /// <returns>The equivalent value in pound per cubic foot.</returns>
    public static double GmlToLbft3(double value) => value * Factor.GmlToLbft3;

    /// <summary>
    /// Converts a value from gram per milliliter (g/ml) to pound per cubic inch (lb/in³).
    /// </summary>
    /// <param name="value">The value in gram per milliliter.</param>
    /// <returns>The equivalent value in pound per cubic inch.</returns>
    public static double GmlToLbin3(double value) => value * Factor.GmlToLbin3;

    /// <summary>
    /// Converts a value from kilogram per cubic meter (kg/m³) to gram per milliliter (g/ml).
    /// </summary>
    /// <param name="value">The value in kilogram per cubic meter.</param>
    /// <returns>The equivalent value in gram per milliliter.</returns>
    public static double Kgm3ToGml(double value) => value * Factor.Kgm3ToGml;

    /// <summary>
    /// Converts a value from kilogram per cubic meter (kg/m³) to pound per cubic foot (lb/ft³).
    /// </summary>
    /// <param name="value">The value in kilogram per cubic meter.</param>
    /// <returns>The equivalent value in pound per cubic foot.</returns>
    public static double Kgm3ToLbft3(double value) => value * Factor.Kgm3ToLbft3;

    /// <summary>
    /// Converts a value from kilogram per cubic meter (kg/m³) to pound per cubic inch (lb/in³).
    /// </summary>
    /// <param name="value">The value in kilogram per cubic meter.</param>
    /// <returns>The equivalent value in pound per cubic inch.</returns>
    public static double Kgm3ToLbin3(double value) => value * Factor.Kgm3ToLbin3;

    /// <summary>
    /// Converts a value from pound per cubic foot (lb/ft³) to gram per milliliter (g/ml).
    /// </summary>
    /// <param name="value">The value in pound per cubic foot.</param>
    /// <returns>The equivalent value in gram per milliliter.</returns>
    public static double Lbft3ToGml(double value) => value * Factor.Lbft3ToGml;

    /// <summary>
    /// Converts a value from pound per cubic foot (lb/ft³) to kilogram per cubic meter (kg/m³).
    /// </summary>
    /// <param name="value">The value in pound per cubic foot.</param>
    /// <returns>The equivalent value in kilogram per cubic meter.</returns>
    public static double Lbft3ToKgm3(double value) => value * Factor.Lbft3ToKgm3;

    /// <summary>
    /// Converts a value from pound per cubic foot (lb/ft³) to pound per cubic inch (lb/in³).
    /// </summary>
    /// <param name="value">The value in pound per cubic foot.</param>
    /// <returns>The equivalent value in pound per cubic inch.</returns>
    public static double Lbft3ToLbin3(double value) => value * Factor.Lbft3ToLbin3;

    /// <summary>
    /// Converts a value from pound per cubic inch (lb/in³) to gram per milliliter (g/ml).
    /// </summary>
    /// <param name="value">The value in pound per cubic inch.</param>
    /// <returns>The equivalent value in gram per milliliter.</returns>
    public static double Lbin3ToGml(double value) => value * Factor.Lbin3ToGml;

    /// <summary>
    /// Converts a value from pound per cubic inch (lb/in³) to kilogram per cubic meter (kg/m³).
    /// </summary>
    /// <param name="value">The value in pound per cubic inch.</param>
    /// <returns>The equivalent value in kilogram per cubic meter.</returns>
    public static double Lbin3ToKgm3(double value) => value * Factor.Lbin3ToKgm3;

    /// <summary>
    /// Converts a value from pound per cubic inch (lb/in³) to pound per cubic foot (lb/ft³).
    /// </summary>
    /// <param name="value">The value in pound per cubic inch.</param>
    /// <returns>The equivalent value in pound per cubic foot.</returns>
    public static double Lbin3ToLbft3(double value) => value * Factor.Lbin3ToLbft3;

    /// <summary>
    /// Converts a value from one density unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of density.</param>
    /// <param name="to">The target unit of density.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, DensityUnit from, DensityUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }

    /// <summary>
    /// Converts a value from one density unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of density.</param>
    /// <param name="to">The target unit of density.</param>
    /// <returns>The converted value in the target unit as a float.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static float Convert(float value, DensityUnit from, DensityUnit to)
    {
        return (float)UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of density measurement.
/// </summary>
public enum DensityUnit
{
    /// <summary>
    /// Gram per milliliter (g/ml).
    /// </summary>
    Gml,
    /// <summary>
    /// Kilogram per cubic meter (kg/m³).
    /// </summary>
    Kgm3,
    /// <summary>
    /// Pound per cubic foot (lb/ft³).
    /// </summary>
    Lbft3,
    /// <summary>
    /// Pound per cubic inch (lb/in³).
    /// </summary>
    Lbin3
}