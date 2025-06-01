namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of speed.
/// </summary>
public static class Speed
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from meter per second (m/s) to meter per minute (m/min).
    /// </summary>
    public const double Ms_to_Mmin = 59.988;
    /// <summary>
    /// Conversion factor from meter per second (m/s) to kilometer per hour (km/h).
    /// </summary>
    public const double Ms_to_Kmh = 3.599712;
    /// <summary>
    /// Conversion factor from meter per second (m/s) to foot per second (ft/s).
    /// </summary>
    public const double Ms_to_Fts = 3.28084;
    /// <summary>
    /// Conversion factor from meter per second (m/s) to foot per minute (ft/min).
    /// </summary>
    public const double Ms_to_Ftmin = 196.8504;
    /// <summary>
    /// Conversion factor from meter per second (m/s) to mile per hour (mi/h).
    /// </summary>
    public const double Ms_to_Mih = 2.237136;

    /// <summary>
    /// Conversion factor from meter per minute (m/min) to meter per second (m/s).
    /// </summary>
    public const double Mmin_to_Ms = 0.01667;
    /// <summary>
    /// Conversion factor from meter per minute (m/min) to kilometer per hour (km/h).
    /// </summary>
    public const double Mmin_to_Kmh = 0.060007;
    /// <summary>
    /// Conversion factor from meter per minute (m/min) to foot per second (ft/s).
    /// </summary>
    public const double Mmin_to_Fts = 0.054692;
    /// <summary>
    /// Conversion factor from meter per minute (m/min) to foot per minute (ft/min).
    /// </summary>
    public const double Mmin_to_Ftmin = 3.281496;
    /// <summary>
    /// Conversion factor from meter per minute (m/min) to mile per hour (mi/h).
    /// </summary>
    public const double Mmin_to_Mih = 0.037293;

    /// <summary>
    /// Conversion factor from kilometer per hour (km/h) to meter per second (m/s).
    /// </summary>
    public const double Kmh_to_Ms = 0.2778;
    /// <summary>
    /// Conversion factor from kilometer per hour (km/h) to meter per minute (m/min).
    /// </summary>
    public const double Kmh_to_Mmin = 16.66467;
    /// <summary>
    /// Conversion factor from kilometer per hour (km/h) to foot per second (ft/s).
    /// </summary>
    public const double Kmh_to_Fts = 0.911417;
    /// <summary>
    /// Conversion factor from kilometer per hour (km/h) to foot per minute (ft/min).
    /// </summary>
    public const double Kmh_to_Ftmin = 54.68504;
    /// <summary>
    /// Conversion factor from kilometer per hour (km/h) to mile per hour (mi/h).
    /// </summary>
    public const double Kmh_to_Mih = 0.621477;

    /// <summary>
    /// Conversion factor from foot per second (ft/s) to meter per second (m/s).
    /// </summary>
    public const double Fts_to_Ms = 0.3048;
    /// <summary>
    /// Conversion factor from foot per second (ft/s) to meter per minute (m/min).
    /// </summary>
    public const double Fts_to_Mmin = 18.28434;
    /// <summary>
    /// Conversion factor from foot per second (ft/s) to kilometer per hour (km/h).
    /// </summary>
    public const double Fts_to_Kmh = 1.097192;
    /// <summary>
    /// Conversion factor from foot per second (ft/s) to foot per minute (ft/min).
    /// </summary>
    public const double Fts_to_Ftmin = 60;
    /// <summary>
    /// Conversion factor from foot per second (ft/s) to mile per hour (mi/h).
    /// </summary>
    public const double Fts_to_Mih = 0.681879;

    /// <summary>
    /// Conversion factor from foot per minute (ft/min) to meter per second (m/s).
    /// </summary>
    public const double Ftmin_to_Ms = 0.00508;
    /// <summary>
    /// Conversion factor from foot per minute (ft/min) to meter per minute (m/min).
    /// </summary>
    public const double Ftmin_to_Mmin = 0.304739;
    /// <summary>
    /// Conversion factor from foot per minute (ft/min) to kilometer per hour (km/h).
    /// </summary>
    public const double Ftmin_to_Kmh = 0.018287;
    /// <summary>
    /// Conversion factor from foot per minute (ft/min) to foot per second (ft/s).
    /// </summary>
    public const double Ftmin_to_Fts = 0.016667;
    /// <summary>
    /// Conversion factor from foot per minute (ft/min) to mile per hour (mi/h).
    /// </summary>
    public const double Ftmin_to_Mih = 0.011365;

    /// <summary>
    /// Conversion factor from mile per hour (mi/h) to meter per second (m/s).
    /// </summary>
    public const double Mih_to_Ms = 0.447;
    /// <summary>
    /// Conversion factor from mile per hour (mi/h) to meter per minute (m/min).
    /// </summary>
    public const double Mih_to_Mmin = 26.81464;
    /// <summary>
    /// Conversion factor from mile per hour (mi/h) to kilometer per hour (km/h).
    /// </summary>
    public const double Mih_to_Kmh = 1.609071;
    /// <summary>
    /// Conversion factor from mile per hour (mi/h) to foot per second (ft/s).
    /// </summary>
    public const double Mih_to_Fts = 1.466535;
    /// <summary>
    /// Conversion factor from mile per hour (mi/h) to foot per minute (ft/min).
    /// </summary>
    public const double Mih_to_Ftmin = 87.99213;
    #endregion

    static Speed()
    {
        // Register Speed unit
        UnitConverter.RegisterUnit(typeof(SpeedUnit), BaseUnit.Speed);

        // m/s conversions
        UnitConverter.RegisterConversion(SpeedUnit.Ms, SpeedUnit.Mmin, value => value * Ms_to_Mmin);
        UnitConverter.RegisterConversion(SpeedUnit.Ms, SpeedUnit.Kmh, value => value * Ms_to_Kmh);
        UnitConverter.RegisterConversion(SpeedUnit.Ms, SpeedUnit.Fts, value => value * Ms_to_Fts);
        UnitConverter.RegisterConversion(SpeedUnit.Ms, SpeedUnit.Ftmin, value => value * Ms_to_Ftmin);
        UnitConverter.RegisterConversion(SpeedUnit.Ms, SpeedUnit.Mih, value => value * Ms_to_Mih);

        // m/min conversions
        UnitConverter.RegisterConversion(SpeedUnit.Mmin, SpeedUnit.Ms, value => value * Mmin_to_Ms);
        UnitConverter.RegisterConversion(SpeedUnit.Mmin, SpeedUnit.Kmh, value => value * Mmin_to_Kmh);
        UnitConverter.RegisterConversion(SpeedUnit.Mmin, SpeedUnit.Fts, value => value * Mmin_to_Fts);
        UnitConverter.RegisterConversion(SpeedUnit.Mmin, SpeedUnit.Ftmin, value => value * Mmin_to_Ftmin);
        UnitConverter.RegisterConversion(SpeedUnit.Mmin, SpeedUnit.Mih, value => value * Mmin_to_Mih);

        // km/h conversions
        UnitConverter.RegisterConversion(SpeedUnit.Kmh, SpeedUnit.Ms, value => value * Kmh_to_Ms);
        UnitConverter.RegisterConversion(SpeedUnit.Kmh, SpeedUnit.Mmin, value => value * Kmh_to_Mmin);
        UnitConverter.RegisterConversion(SpeedUnit.Kmh, SpeedUnit.Fts, value => value * Kmh_to_Fts);
        UnitConverter.RegisterConversion(SpeedUnit.Kmh, SpeedUnit.Ftmin, value => value * Kmh_to_Ftmin);
        UnitConverter.RegisterConversion(SpeedUnit.Kmh, SpeedUnit.Mih, value => value * Kmh_to_Mih);

        // ft/s conversions
        UnitConverter.RegisterConversion(SpeedUnit.Fts, SpeedUnit.Ms, value => value * Fts_to_Ms);
        UnitConverter.RegisterConversion(SpeedUnit.Fts, SpeedUnit.Mmin, value => value * Fts_to_Mmin);
        UnitConverter.RegisterConversion(SpeedUnit.Fts, SpeedUnit.Kmh, value => value * Fts_to_Kmh);
        UnitConverter.RegisterConversion(SpeedUnit.Fts, SpeedUnit.Ftmin, value => value * Fts_to_Ftmin);
        UnitConverter.RegisterConversion(SpeedUnit.Fts, SpeedUnit.Mih, value => value * Fts_to_Mih);

        // ft/min conversions
        UnitConverter.RegisterConversion(SpeedUnit.Ftmin, SpeedUnit.Ms, value => value * Ftmin_to_Ms);
        UnitConverter.RegisterConversion(SpeedUnit.Ftmin, SpeedUnit.Mmin, value => value * Ftmin_to_Mmin);
        UnitConverter.RegisterConversion(SpeedUnit.Ftmin, SpeedUnit.Kmh, value => value * Ftmin_to_Kmh);
        UnitConverter.RegisterConversion(SpeedUnit.Ftmin, SpeedUnit.Fts, value => value * Ftmin_to_Fts);
        UnitConverter.RegisterConversion(SpeedUnit.Ftmin, SpeedUnit.Mih, value => value * Ftmin_to_Mih);

        // mi/h conversions
        UnitConverter.RegisterConversion(SpeedUnit.Mih, SpeedUnit.Ms, value => value * Mih_to_Ms);
        UnitConverter.RegisterConversion(SpeedUnit.Mih, SpeedUnit.Mmin, value => value * Mih_to_Mmin);
        UnitConverter.RegisterConversion(SpeedUnit.Mih, SpeedUnit.Kmh, value => value * Mih_to_Kmh);
        UnitConverter.RegisterConversion(SpeedUnit.Mih, SpeedUnit.Fts, value => value * Mih_to_Fts);
        UnitConverter.RegisterConversion(SpeedUnit.Mih, SpeedUnit.Ftmin, value => value * Mih_to_Ftmin);
    }

    /// <summary>
    /// Converts a value from one speed unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of speed.</param>
    /// <param name="to">The target unit of speed.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, SpeedUnit from, SpeedUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }

    /// <summary>
    /// Converts a value from one speed unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of speed.</param>
    /// <param name="to">The target unit of speed.</param>
    /// <returns>The converted value in the target unit as a float.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static float Convert(float value, SpeedUnit from, SpeedUnit to)
    {
        return (float)UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of speed measurement.
/// </summary>
public enum SpeedUnit
{
    /// <summary>
    /// Meter per second (m/s).
    /// </summary>
    Ms,
    /// <summary>
    /// Meter per minute (m/min).
    /// </summary>
    Mmin,
    /// <summary>
    /// Kilometer per hour (km/h).
    /// </summary>
    Kmh,
    /// <summary>
    /// Foot per second (ft/s).
    /// </summary>
    Fts,
    /// <summary>
    /// Foot per minute (ft/min).
    /// </summary>
    Ftmin,
    /// <summary>
    /// Mile per hour (mi/h).
    /// </summary>
    Mih
}