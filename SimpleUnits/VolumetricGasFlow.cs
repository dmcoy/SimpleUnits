namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of volumetric gas flow.
/// </summary>
public static class VolumetricGasFlow
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from normal meter cube per hour (Nm³/hr) to standard cubic feet per hour (scfh).
    /// </summary>
    public const double Nm3hr_to_Scfh = 35.31073;
    /// <summary>
    /// Conversion factor from normal meter cube per hour (Nm³/hr) to standard cubic feet per minute (scfm).
    /// </summary>
    public const double Nm3hr_to_Scfm = 0.588582;

    /// <summary>
    /// Conversion factor from standard cubic feet per hour (scfh) to normal meter cube per hour (Nm³/hr).
    /// </summary>
    public const double Scfh_to_Nm3hr = 0.02832;
    /// <summary>
    /// Conversion factor from standard cubic feet per hour (scfh) to standard cubic feet per minute (scfm).
    /// </summary>
    public const double Scfh_to_Scfm = 0.016669;

    /// <summary>
    /// Conversion factor from standard cubic feet per minute (scfm) to normal meter cube per hour (Nm³/hr).
    /// </summary>
    public const double Scfm_to_Nm3hr = 1.699;
    /// <summary>
    /// Conversion factor from standard cubic feet per minute (scfm) to standard cubic feet per hour (scfh).
    /// </summary>
    public const double Scfm_to_Scfh = 59.99294;
    #endregion

    static VolumetricGasFlow()
    {
        // Register VolumetricGasFlow unit
        UnitConverter.RegisterUnit(typeof(VolumetricGasFlowUnit), BaseUnit.VolumetricGasFlow);

        // Nm³/hr conversions
        UnitConverter.RegisterConversion(VolumetricGasFlowUnit.Nm3hr, VolumetricGasFlowUnit.Scfh, value => value * Nm3hr_to_Scfh);
        UnitConverter.RegisterConversion(VolumetricGasFlowUnit.Nm3hr, VolumetricGasFlowUnit.Scfm, value => value * Nm3hr_to_Scfm);

        // scfh conversions
        UnitConverter.RegisterConversion(VolumetricGasFlowUnit.Scfh, VolumetricGasFlowUnit.Nm3hr, value => value * Scfh_to_Nm3hr);
        UnitConverter.RegisterConversion(VolumetricGasFlowUnit.Scfh, VolumetricGasFlowUnit.Scfm, value => value * Scfh_to_Scfm);

        // scfm conversions
        UnitConverter.RegisterConversion(VolumetricGasFlowUnit.Scfm, VolumetricGasFlowUnit.Nm3hr, value => value * Scfm_to_Nm3hr);
        UnitConverter.RegisterConversion(VolumetricGasFlowUnit.Scfm, VolumetricGasFlowUnit.Scfh, value => value * Scfm_to_Scfh);
    }

    /// <summary>
    /// Converts a value from one volumetric gas flow unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of volumetric gas flow.</param>
    /// <param name="to">The target unit of volumetric gas flow.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, VolumetricGasFlowUnit from, VolumetricGasFlowUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }

    /// <summary>
    /// Converts a value from one volumetric gas flow unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of volumetric gas flow.</param>
    /// <param name="to">The target unit of volumetric gas flow.</param>
    /// <returns>The converted value in the target unit as a float.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static float Convert(float value, VolumetricGasFlowUnit from, VolumetricGasFlowUnit to)
    {
        return (float)UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of volumetric gas flow measurement.
/// </summary>
public enum VolumetricGasFlowUnit
{
    /// <summary>
    /// Normal meter cube per hour (Nm³/hr).
    /// </summary>
    Nm3hr,
    /// <summary>
    /// Standard cubic feet per hour (scfh).
    /// </summary>
    Scfh,
    /// <summary>
    /// Standard cubic feet per minute (scfm).
    /// </summary>
    Scfm
}