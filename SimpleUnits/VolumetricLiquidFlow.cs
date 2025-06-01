namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of volumetric liquid flow.
/// </summary>
public static class VolumetricLiquidFlow
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from liter per second (L/sec) to liter per minute (L/min).
    /// </summary>
    public const double Lsec_to_Lmin = 60;
    /// <summary>
    /// Conversion factor from liter per second (L/sec) to meter cube per hour (m³/hr).
    /// </summary>
    public const double Lsec_to_M3hr = 3.6;
    /// <summary>
    /// Conversion factor from liter per second (L/sec) to foot cube per minute (ft³/min).
    /// </summary>
    public const double Lsec_to_Ft3min = 2.119093;
    /// <summary>
    /// Conversion factor from liter per second (L/sec) to foot cube per hour (ft³/hr).
    /// </summary>
    public const double Lsec_to_Ft3hr = 127.1197;
    /// <summary>
    /// Conversion factor from liter per second (L/sec) to US gallons per minute (gal/min).
    /// </summary>
    public const double Lsec_to_Galmin = 15.85037;
    /// <summary>
    /// Conversion factor from liter per second (L/sec) to US barrels (oil) per day (US brl/d).
    /// </summary>
    public const double Lsec_to_Brld = 543.4783;

    /// <summary>
    /// Conversion factor from liter per minute (L/min) to liter per second (L/sec).
    /// </summary>
    public const double Lmin_to_Lsec = 0.016666;
    /// <summary>
    /// Conversion factor from liter per minute (L/min) to meter cube per hour (m³/hr).
    /// </summary>
    public const double Lmin_to_M3hr = 0.06;
    /// <summary>
    /// Conversion factor from liter per minute (L/min) to foot cube per minute (ft³/min).
    /// </summary>
    public const double Lmin_to_Ft3min = 0.035317;
    /// <summary>
    /// Conversion factor from liter per minute (L/min) to foot cube per hour (ft³/hr).
    /// </summary>
    public const double Lmin_to_Ft3hr = 2.118577;
    /// <summary>
    /// Conversion factor from liter per minute (L/min) to US gallons per minute (gal/min).
    /// </summary>
    public const double Lmin_to_Galmin = 0.264162;
    /// <summary>
    /// Conversion factor from liter per minute (L/min) to US barrels (oil) per day (US brl/d).
    /// </summary>
    public const double Lmin_to_Brld = 9.057609;

    /// <summary>
    /// Conversion factor from meter cube per hour (m³/hr) to liter per second (L/sec).
    /// </summary>
    public const double M3hr_to_Lsec = 0.277778;
    /// <summary>
    /// Conversion factor from meter cube per hour (m³/hr) to liter per minute (L/min).
    /// </summary>
    public const double M3hr_to_Lmin = 16.6667;
    /// <summary>
    /// Conversion factor from meter cube per hour (m³/hr) to foot cube per minute (ft³/min).
    /// </summary>
    public const double M3hr_to_Ft3min = 0.588637;
    /// <summary>
    /// Conversion factor from meter cube per hour (m³/hr) to foot cube per hour (ft³/hr).
    /// </summary>
    public const double M3hr_to_Ft3hr = 35.31102;
    /// <summary>
    /// Conversion factor from meter cube per hour (m³/hr) to US gallons per minute (gal/min).
    /// </summary>
    public const double M3hr_to_Galmin = 4.40288;
    /// <summary>
    /// Conversion factor from meter cube per hour (m³/hr) to US barrels (oil) per day (US brl/d).
    /// </summary>
    public const double M3hr_to_Brld = 150.9661;

    /// <summary>
    /// Conversion factor from foot cube per minute (ft³/min) to liter per second (L/sec).
    /// </summary>
    public const double Ft3min_to_Lsec = 0.4719;
    /// <summary>
    /// Conversion factor from foot cube per minute (ft³/min) to liter per minute (L/min).
    /// </summary>
    public const double Ft3min_to_Lmin = 28.31513;
    /// <summary>
    /// Conversion factor from foot cube per minute (ft³/min) to meter cube per hour (m³/hr).
    /// </summary>
    public const double Ft3min_to_M3hr = 1.69884;
    /// <summary>
    /// Conversion factor from foot cube per minute (ft³/min) to foot cube per hour (ft³/hr).
    /// </summary>
    public const double Ft3min_to_Ft3hr = 60;
    /// <summary>
    /// Conversion factor from foot cube per minute (ft³/min) to US gallons per minute (gal/min).
    /// </summary>
    public const double Ft3min_to_Galmin = 7.479791;
    /// <summary>
    /// Conversion factor from foot cube per minute (ft³/min) to US barrels (oil) per day (US brl/d).
    /// </summary>
    public const double Ft3min_to_Brld = 256.4674;

    /// <summary>
    /// Conversion factor from foot cube per hour (ft³/hr) to liter per second (L/sec).
    /// </summary>
    public const double Ft3hr_to_Lsec = 0.007867;
    /// <summary>
    /// Conversion factor from foot cube per hour (ft³/hr) to liter per minute (L/min).
    /// </summary>
    public const double Ft3hr_to_Lmin = 0.472015;
    /// <summary>
    /// Conversion factor from foot cube per hour (ft³/hr) to meter cube per hour (m³/hr).
    /// </summary>
    public const double Ft3hr_to_M3hr = 0.02832;
    /// <summary>
    /// Conversion factor from foot cube per hour (ft³/hr) to foot cube per minute (ft³/min).
    /// </summary>
    public const double Ft3hr_to_Ft3min = 0.016667;
    /// <summary>
    /// Conversion factor from foot cube per hour (ft³/hr) to US gallons per minute (gal/min).
    /// </summary>
    public const double Ft3hr_to_Galmin = 0.124689;
    /// <summary>
    /// Conversion factor from foot cube per hour (ft³/hr) to US barrels (oil) per day (US brl/d).
    /// </summary>
    public const double Ft3hr_to_Brld = 4.275326;

    /// <summary>
    /// Conversion factor from US gallons per minute (gal/min) to liter per second (L/sec).
    /// </summary>
    public const double Galmin_to_Lsec = 0.06309;
    /// <summary>
    /// Conversion factor from US gallons per minute (gal/min) to liter per minute (L/min).
    /// </summary>
    public const double Galmin_to_Lmin = 3.785551;
    /// <summary>
    /// Conversion factor from US gallons per minute (gal/min) to meter cube per hour (m³/hr).
    /// </summary>
    public const double Galmin_to_M3hr = 0.227124;
    /// <summary>
    /// Conversion factor from US gallons per minute (gal/min) to foot cube per minute (ft³/min).
    /// </summary>
    public const double Galmin_to_Ft3min = 0.133694;
    /// <summary>
    /// Conversion factor from US gallons per minute (gal/min) to foot cube per hour (ft³/hr).
    /// </summary>
    public const double Galmin_to_Ft3hr = 8.019983;
    /// <summary>
    /// Conversion factor from US gallons per minute (gal/min) to US barrels (oil) per day (US brl/d).
    /// </summary>
    public const double Galmin_to_Brld = 34.28804;

    /// <summary>
    /// Conversion factor from US barrels (oil) per day (US brl/d) to liter per second (L/sec).
    /// </summary>
    public const double Brld_to_Lsec = 0.00184;
    /// <summary>
    /// Conversion factor from US barrels (oil) per day (US brl/d) to liter per minute (L/min).
    /// </summary>
    public const double Brld_to_Lmin = 0.110404;
    /// <summary>
    /// Conversion factor from US barrels (oil) per day (US brl/d) to meter cube per hour (m³/hr).
    /// </summary>
    public const double Brld_to_M3hr = 0.006624;
    /// <summary>
    /// Conversion factor from US barrels (oil) per day (US brl/d) to foot cube per minute (ft³/min).
    /// </summary>
    public const double Brld_to_Ft3min = 0.003899;
    /// <summary>
    /// Conversion factor from US barrels (oil) per day (US brl/d) to foot cube per hour (ft³/hr).
    /// </summary>
    public const double Brld_to_Ft3hr = 0.2339;
    /// <summary>
    /// Conversion factor from US barrels (oil) per day (US brl/d) to US gallons per minute (gal/min).
    /// </summary>
    public const double Brld_to_Galmin = 0.029165;
    #endregion

    static VolumetricLiquidFlow()
    {
        // Register VolumetricLiquidFlow unit
        UnitConverter.RegisterUnit(typeof(VolumetricLiquidFlowUnit), BaseUnit.VolumetricLiquidFlow);

        // L/sec conversions
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lsec, VolumetricLiquidFlowUnit.Lmin, value => value * Lsec_to_Lmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lsec, VolumetricLiquidFlowUnit.M3hr, value => value * Lsec_to_M3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lsec, VolumetricLiquidFlowUnit.Ft3min, value => value * Lsec_to_Ft3min);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lsec, VolumetricLiquidFlowUnit.Ft3hr, value => value * Lsec_to_Ft3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lsec, VolumetricLiquidFlowUnit.Galmin, value => value * Lsec_to_Galmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lsec, VolumetricLiquidFlowUnit.Brld, value => value * Lsec_to_Brld);

        // L/min conversions
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lmin, VolumetricLiquidFlowUnit.Lsec, value => value * Lmin_to_Lsec);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lmin, VolumetricLiquidFlowUnit.M3hr, value => value * Lmin_to_M3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lmin, VolumetricLiquidFlowUnit.Ft3min, value => value * Lmin_to_Ft3min);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lmin, VolumetricLiquidFlowUnit.Ft3hr, value => value * Lmin_to_Ft3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lmin, VolumetricLiquidFlowUnit.Galmin, value => value * Lmin_to_Galmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Lmin, VolumetricLiquidFlowUnit.Brld, value => value * Lmin_to_Brld);

        // m³/hr conversions
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.M3hr, VolumetricLiquidFlowUnit.Lsec, value => value * M3hr_to_Lsec);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.M3hr, VolumetricLiquidFlowUnit.Lmin, value => value * M3hr_to_Lmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.M3hr, VolumetricLiquidFlowUnit.Ft3min, value => value * M3hr_to_Ft3min);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.M3hr, VolumetricLiquidFlowUnit.Ft3hr, value => value * M3hr_to_Ft3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.M3hr, VolumetricLiquidFlowUnit.Galmin, value => value * M3hr_to_Galmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.M3hr, VolumetricLiquidFlowUnit.Brld, value => value * M3hr_to_Brld);

        // ft³/min conversions
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3min, VolumetricLiquidFlowUnit.Lsec, value => value * Ft3min_to_Lsec);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3min, VolumetricLiquidFlowUnit.Lmin, value => value * Ft3min_to_Lmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3min, VolumetricLiquidFlowUnit.M3hr, value => value * Ft3min_to_M3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3min, VolumetricLiquidFlowUnit.Ft3hr, value => value * Ft3min_to_Ft3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3min, VolumetricLiquidFlowUnit.Galmin, value => value * Ft3min_to_Galmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3min, VolumetricLiquidFlowUnit.Brld, value => value * Ft3min_to_Brld);

        // ft³/hr conversions
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3hr, VolumetricLiquidFlowUnit.Lsec, value => value * Ft3hr_to_Lsec);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3hr, VolumetricLiquidFlowUnit.Lmin, value => value * Ft3hr_to_Lmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3hr, VolumetricLiquidFlowUnit.M3hr, value => value * Ft3hr_to_M3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3hr, VolumetricLiquidFlowUnit.Ft3min, value => value * Ft3hr_to_Ft3min);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3hr, VolumetricLiquidFlowUnit.Galmin, value => value * Ft3hr_to_Galmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Ft3hr, VolumetricLiquidFlowUnit.Brld, value => value * Ft3hr_to_Brld);

        // gal/min conversions
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Galmin, VolumetricLiquidFlowUnit.Lsec, value => value * Galmin_to_Lsec);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Galmin, VolumetricLiquidFlowUnit.Lmin, value => value * Galmin_to_Lmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Galmin, VolumetricLiquidFlowUnit.M3hr, value => value * Galmin_to_M3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Galmin, VolumetricLiquidFlowUnit.Ft3min, value => value * Galmin_to_Ft3min);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Galmin, VolumetricLiquidFlowUnit.Ft3hr, value => value * Galmin_to_Ft3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Galmin, VolumetricLiquidFlowUnit.Brld, value => value * Galmin_to_Brld);

        // US brl/d conversions
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Brld, VolumetricLiquidFlowUnit.Lsec, value => value * Brld_to_Lsec);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Brld, VolumetricLiquidFlowUnit.Lmin, value => value * Brld_to_Lmin);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Brld, VolumetricLiquidFlowUnit.M3hr, value => value * Brld_to_M3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Brld, VolumetricLiquidFlowUnit.Ft3min, value => value * Brld_to_Ft3min);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Brld, VolumetricLiquidFlowUnit.Ft3hr, value => value * Brld_to_Ft3hr);
        UnitConverter.RegisterConversion(VolumetricLiquidFlowUnit.Brld, VolumetricLiquidFlowUnit.Galmin, value => value * Brld_to_Galmin);
    }

    /// <summary>
    /// Converts a value from one volumetric liquid flow unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of volumetric liquid flow.</param>
    /// <param name="to">The target unit of volumetric liquid flow.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, VolumetricLiquidFlowUnit from, VolumetricLiquidFlowUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }

    /// <summary>
    /// Converts a value from one volumetric liquid flow unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of volumetric liquid flow.</param>
    /// <param name="to">The target unit of volumetric liquid flow.</param>
    /// <returns>The converted value in the target unit as a float.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static float Convert(float value, VolumetricLiquidFlowUnit from, VolumetricLiquidFlowUnit to)
    {
        return (float)UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of volumetric liquid flow measurement.
/// </summary>
public enum VolumetricLiquidFlowUnit
{
    /// <summary>
    /// Liter per second (L/sec).
    /// </summary>
    Lsec,
    /// <summary>
    /// Liter per minute (L/min).
    /// </summary>
    Lmin,
    /// <summary>
    /// Meter cube per hour (m³/hr).
    /// </summary>
    M3hr,
    /// <summary>
    /// Foot cube per minute (ft³/min).
    /// </summary>
    Ft3min,
    /// <summary>
    /// Foot cube per hour (ft³/hr).
    /// </summary>
    Ft3hr,
    /// <summary>
    /// US gallons per minute (gal/min).
    /// </summary>
    Galmin,
    /// <summary>
    /// US barrels (oil) per day (US brl/d).
    /// </summary>
    Brld
}