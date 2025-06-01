namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of density.
/// </summary>
public static class Density
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from gram per milliliter (g/ml) to kilogram per cubic meter (kg/m³).
    /// </summary>
    public const double Gml_to_Kgm3 = 1000;
    /// <summary>
    /// Conversion factor from gram per milliliter (g/ml) to pound per cubic foot (lb/ft³).
    /// </summary>
    public const double Gml_to_Lbft3 = 62.42197;
    /// <summary>
    /// Conversion factor from gram per milliliter (g/ml) to pound per cubic inch (lb/in³).
    /// </summary>
    public const double Gml_to_Lbin3 = 0.036127;

    /// <summary>
    /// Conversion factor from kilogram per cubic meter (kg/m³) to gram per milliliter (g/ml).
    /// </summary>
    public const double Kgm3_to_Gml = 0.001;
    /// <summary>
    /// Conversion factor from kilogram per cubic meter (kg/m³) to pound per cubic foot (lb/ft³).
    /// </summary>
    public const double Kgm3_to_Lbft3 = 0.062422;
    /// <summary>
    /// Conversion factor from kilogram per cubic meter (kg/m³) to pound per cubic inch (lb/in³).
    /// </summary>
    public const double Kgm3_to_Lbin3 = 0.000036;

    /// <summary>
    /// Conversion factor from pound per cubic foot (lb/ft³) to gram per milliliter (g/ml).
    /// </summary>
    public const double Lbft3_to_Gml = 0.01602;
    /// <summary>
    /// Conversion factor from pound per cubic foot (lb/ft³) to kilogram per cubic meter (kg/m³).
    /// </summary>
    public const double Lbft3_to_Kgm3 = 16.02;
    /// <summary>
    /// Conversion factor from pound per cubic foot (lb/ft³) to pound per cubic inch (lb/in³).
    /// </summary>
    public const double Lbft3_to_Lbin3 = 0.000579;

    /// <summary>
    /// Conversion factor from pound per cubic inch (lb/in³) to gram per milliliter (g/ml).
    /// </summary>
    public const double Lbin3_to_Gml = 27.68;
    /// <summary>
    /// Conversion factor from pound per cubic inch (lb/in³) to kilogram per cubic meter (kg/m³).
    /// </summary>
    public const double Lbin3_to_Kgm3 = 27680;
    /// <summary>
    /// Conversion factor from pound per cubic inch (lb/in³) to pound per cubic foot (lb/ft³).
    /// </summary>
    public const double Lbin3_to_Lbft3 = 1727.84;
    #endregion

    static Density()
    {
        // Register Density unit
        UnitConverter.RegisterUnit(typeof(DensityUnit), BaseUnit.Density);

        // g/ml conversions
        UnitConverter.RegisterConversion(DensityUnit.Gml, DensityUnit.Kgm3, value => value * Gml_to_Kgm3);
        UnitConverter.RegisterConversion(DensityUnit.Gml, DensityUnit.Lbft3, value => value * Gml_to_Lbft3);
        UnitConverter.RegisterConversion(DensityUnit.Gml, DensityUnit.Lbin3, value => value * Gml_to_Lbin3);

        // kg/m³ conversions
        UnitConverter.RegisterConversion(DensityUnit.Kgm3, DensityUnit.Gml, value => value * Kgm3_to_Gml);
        UnitConverter.RegisterConversion(DensityUnit.Kgm3, DensityUnit.Lbft3, value => value * Kgm3_to_Lbft3);
        UnitConverter.RegisterConversion(DensityUnit.Kgm3, DensityUnit.Lbin3, value => value * Kgm3_to_Lbin3);

        // lb/ft³ conversions
        UnitConverter.RegisterConversion(DensityUnit.Lbft3, DensityUnit.Gml, value => value * Lbft3_to_Gml);
        UnitConverter.RegisterConversion(DensityUnit.Lbft3, DensityUnit.Kgm3, value => value * Lbft3_to_Kgm3);
        UnitConverter.RegisterConversion(DensityUnit.Lbft3, DensityUnit.Lbin3, value => value * Lbft3_to_Lbin3);

        // lb/in³ conversions
        UnitConverter.RegisterConversion(DensityUnit.Lbin3, DensityUnit.Gml, value => value * Lbin3_to_Gml);
        UnitConverter.RegisterConversion(DensityUnit.Lbin3, DensityUnit.Kgm3, value => value * Lbin3_to_Kgm3);
        UnitConverter.RegisterConversion(DensityUnit.Lbin3, DensityUnit.Lbft3, value => value * Lbin3_to_Lbft3);
    }

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