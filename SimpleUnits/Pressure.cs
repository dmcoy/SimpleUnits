namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of pressure.
/// </summary>
public static class Pressure
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from bar to pounds per square inch (psi).
    /// </summary>
    public const double Bar_to_Psi = 14.503_26;
    /// <summary>
    /// Conversion factor from bar to kilopascal (kPa).
    /// </summary>
    public const double Bar_to_KPa = 100;
    /// <summary>
    /// Conversion factor from bar to megapascal (MPa).
    /// </summary>
    public const double Bar_to_MPa = 0.1;
    /// <summary>
    /// Conversion factor from bar to kilogram-force per square centimeter (kgf/cm²).
    /// </summary>
    public const double Bar_to_kgf_cm_2 = 1.019_68;
    /// <summary>
    /// Conversion factor from bar to millimeters of mercury (mmHg).
    /// </summary>
    public const double Bar_to_MmHg = 750.018_8;
    /// <summary>
    /// Conversion factor from bar to standard atmosphere (atm).
    /// </summary>
    public const double Bar_to_Atm = 0.987_167;
    /// <summary>
    /// Conversion factor from bar to pascal (Pa).
    /// </summary>
    public const double Bar_to_Pa = 100_000;

    /// <summary>
    /// Conversion factor from pounds per square inch (psi) to bar.
    /// </summary>
    public const double Psi_to_Bar = 0.068_95;
    /// <summary>
    /// Conversion factor from pounds per square inch (psi) to kilopascal (kPa).
    /// </summary>
    public const double Psi_to_KPa = 6.895;
    /// <summary>
    /// Conversion factor from pounds per square inch (psi) to megapascal (MPa).
    /// </summary>
    public const double Psi_to_MPa = 0.006_895;
    /// <summary>
    /// Conversion factor from pounds per square inch (psi) to kilogram-force per square centimeter (kgf/cm²).
    /// </summary>
    public const double Psi_to_kgf_cm_2 = 0.070_307;
    /// <summary>
    /// Conversion factor from pounds per square inch (psi) to millimeters of mercury (mmHg).
    /// </summary>
    public const double Psi_to_MmHg = 51.713_79;
    /// <summary>
    /// Conversion factor from pounds per square inch (psi) to standard atmosphere (atm).
    /// </summary>
    public const double Psi_to_Atm = 0.068_065;
    /// <summary>
    /// Conversion factor from pounds per square inch (psi) to pascal (Pa).
    /// </summary>
    public const double Psi_to_Pa = 6_895;

    /// <summary>
    /// Conversion factor from kilopascal (kPa) to bar.
    /// </summary>
    public const double KPa_to_Bar = 0.01;
    /// <summary>
    /// Conversion factor from kilopascal (kPa) to pounds per square inch (psi).
    /// </summary>
    public const double KPa_to_Psi = 0.145_0;
    /// <summary>
    /// Conversion factor from kilopascal (kPa) to megapascal (MPa).
    /// </summary>
    public const double KPa_to_MPa = 0.001;
    /// <summary>
    /// Conversion factor from kilopascal (kPa) to kilogram-force per square centimeter (kgf/cm²).
    /// </summary>
    public const double KPa_to_kgf_cm_2 = 0.010_20;
    /// <summary>
    /// Conversion factor from kilopascal (kPa) to millimeters of mercury (mmHg).
    /// </summary>
    public const double KPa_to_MmHg = 7.500_2;
    /// <summary>
    /// Conversion factor from kilopascal (kPa) to standard atmosphere (atm).
    /// </summary>
    public const double KPa_to_Atm = 0.009_87;
    /// <summary>
    /// Conversion factor from kilopascal (kPa) to pascal (Pa).
    /// </summary>
    public const double KPa_to_Pa = 1_000;

    /// <summary>
    /// Conversion factor from megapascal (MPa) to bar.
    /// </summary>
    public const double MPa_to_Bar = 10;
    /// <summary>
    /// Conversion factor from megapascal (MPa) to pounds per square inch (psi).
    /// </summary>
    public const double MPa_to_Psi = 145.03;
    /// <summary>
    /// Conversion factor from megapascal (MPa) to kilopascal (kPa).
    /// </summary>
    public const double MPa_to_KPa = 1_000;
    /// <summary>
    /// Conversion factor from megapascal (MPa) to kilogram-force per square centimeter (kgf/cm²).
    /// </summary>
    public const double MPa_to_kgf_cm_2 = 10.197;
    /// <summary>
    /// Conversion factor from megapascal (MPa) to millimeters of mercury (mmHg).
    /// </summary>
    public const double MPa_to_MmHg = 7_500.2;
    /// <summary>
    /// Conversion factor from megapascal (MPa) to standard atmosphere (atm).
    /// </summary>
    public const double MPa_to_Atm = 9.871_7;
    /// <summary>
    /// Conversion factor from megapascal (MPa) to pascal (Pa).
    /// </summary>
    public const double MPa_to_Pa = 1_000_000;

    /// <summary>
    /// Conversion factor from kilogram-force per square centimeter (kgf/cm²) to bar.
    /// </summary>
    public const double Kgf_cm_2_to_Bar = 0.980_7;
    /// <summary>
    /// Conversion factor from kilogram-force per square centimeter (kgf/cm²) to pounds per square inch (psi).
    /// </summary>
    public const double Kgf_cm_2_to_Psi = 14.223_35;
    /// <summary>
    /// Conversion factor from kilogram-force per square centimeter (kgf/cm²) to kilopascal (kPa).
    /// </summary>
    public const double Kgf_cm_2_to_KPa = 98.07;
    /// <summary>
    /// Conversion factor from kilogram-force per square centimeter (kgf/cm²) to megapascal (MPa).
    /// </summary>
    public const double Kgf_cm_2_to_MPa = 0.098_07;
    /// <summary>
    /// Conversion factor from kilogram-force per square centimeter (kgf/cm²) to millimeters of mercury (mmHg).
    /// </summary>
    public const double Kgf_cm_2_to_MmHg = 735.543_4;
    /// <summary>
    /// Conversion factor from kilogram-force per square centimeter (kgf/cm²) to standard atmosphere (atm).
    /// </summary>
    public const double Kgf_cm_2_to_Atm = 0.968_115;
    /// <summary>
    /// Conversion factor from kilogram-force per square centimeter (kgf/cm²) to pascal (Pa).
    /// </summary>
    public const double Kgf_cm_2_to_Pa = 98_066.5;

    /// <summary>
    /// Conversion factor from millimeters of mercury (mmHg) to bar.
    /// </summary>
    public const double MmHg_to_Bar = 0.001_333;
    /// <summary>
    /// Conversion factor from millimeters of mercury (mmHg) to pounds per square inch (psi).
    /// </summary>
    public const double MmHg_to_Psi = 0.019_337;
    /// <summary>
    /// Conversion factor from millimeters of mercury (mmHg) to kilopascal (kPa).
    /// </summary>
    public const double MmHg_to_KPa = 0.133_33;
    /// <summary>
    /// Conversion factor from millimeters of mercury (mmHg) to megapascal (MPa).
    /// </summary>
    public const double MmHg_to_MPa = 0.000_133_3;
    /// <summary>
    /// Conversion factor from millimeters of mercury (mmHg) to kilogram-force per square centimeter (kgf/cm²).
    /// </summary>
    public const double MmHg_to_kgf_cm_2 = 0.001_36;
    /// <summary>
    /// Conversion factor from millimeters of mercury (mmHg) to standard atmosphere (atm).
    /// </summary>
    public const double MmHg_to_Atm = 0.001_316;
    /// <summary>
    /// Conversion factor from millimeters of mercury (mmHg) to pascal (Pa).
    /// </summary>
    public const double MmHg_to_Pa = 133.322;

    /// <summary>
    /// Conversion factor from standard atmosphere (atm) to bar.
    /// </summary>
    public const double Atm_to_Bar = 1.013;
    /// <summary>
    /// Conversion factor from standard atmosphere (atm) to pounds per square inch (psi).
    /// </summary>
    public const double Atm_to_Psi = 14.691_81;
    /// <summary>
    /// Conversion factor from standard atmosphere (atm) to kilopascal (kPa).
    /// </summary>
    public const double Atm_to_KPa = 101.3;
    /// <summary>
    /// Conversion factor from standard atmosphere (atm) to megapascal (MPa).
    /// </summary>
    public const double Atm_to_MPa = 0.101_3;
    /// <summary>
    /// Conversion factor from standard atmosphere (atm) to kilogram-force per square centimeter (kgf/cm²).
    /// </summary>
    public const double Atm_to_kgf_cm_2 = 1.032_936;
    /// <summary>
    /// Conversion factor from standard atmosphere (atm) to millimeters of mercury (mmHg).
    /// </summary>
    public const double Atm_to_MmHg = 759.769;
    /// <summary>
    /// Conversion factor from standard atmosphere (atm) to pascal (Pa).
    /// </summary>
    public const double Atm_to_Pa = 101_325;

    /// <summary>
    /// Conversion factor from pascal (Pa) to bar.
    /// </summary>
    public const double Pa_to_Bar = 0.000_01;
    /// <summary>
    /// Conversion factor from pascal (Pa) to pounds per square inch (psi).
    /// </summary>
    public const double Pa_to_Psi = 0.000_145_0;
    /// <summary>
    /// Conversion factor from pascal (Pa) to kilopascal (kPa).
    /// </summary>
    public const double Pa_to_KPa = 0.001;
    /// <summary>
    /// Conversion factor from pascal (Pa) to megapascal (MPa).
    /// </summary>
    public const double Pa_to_MPa = 0.000_001;
    /// <summary>
    /// Conversion factor from pascal (Pa) to kilogram-force per square centimeter (kgf/cm²).
    /// </summary>
    public const double Pa_to_Kgf_cm_2 = 0.000_010_20;
    /// <summary>
    /// Conversion factor from pascal (Pa) to millimeters of mercury (mmHg).
    /// </summary>
    public const double Pa_to_MmHg = 0.007_500_62;
    /// <summary>
    /// Conversion factor from pascal (Pa) to standard atmosphere (atm).
    /// </summary>
    public const double Pa_to_Atm = 0.000_009_87;
    #endregion

    static Pressure()
    {
        // Register Pressure unit
        UnitConverter.RegisterUnit(typeof(PressureUnit), BaseUnit.Pressure);
        // Bar conversions
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.Psi, value => value * Bar_to_Psi);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.Pa, value => value * Bar_to_Pa);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.KPa, value => value * Bar_to_KPa);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.MPa, value => value * Bar_to_MPa);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.Kgf_cm_2, value => value * Bar_to_kgf_cm_2);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.MmHg, value => value * Bar_to_MmHg);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.Atm, value => value * Bar_to_Atm);

        // psi conversions
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.Bar, value => value * Psi_to_Bar);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.Pa, value => value * Psi_to_Pa);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.KPa, value => value * Psi_to_KPa);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.MPa, value => value * Psi_to_MPa);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.Kgf_cm_2, value => value * Psi_to_kgf_cm_2);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.MmHg, value => value * Psi_to_MmHg);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.Atm, value => value * Psi_to_Atm);

        // Pa conversions
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.Bar, value => value * Pa_to_Bar);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.Psi, value => value * Pa_to_Bar * Bar_to_Psi);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.KPa, value => value * Pa_to_Bar * Bar_to_KPa);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.MPa, value => value * Pa_to_Bar * Bar_to_MPa);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.Kgf_cm_2, value => value * Pa_to_Bar * Bar_to_kgf_cm_2);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.MmHg, value => value * Pa_to_Bar * Bar_to_MmHg);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.Atm, value => value * Pa_to_Bar * Bar_to_Atm);

        // KPa conversions
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Bar, value => value * KPa_to_Bar);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Psi, value => value * KPa_to_Psi);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Pa, value => value * KPa_to_Pa);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.MPa, value => value * KPa_to_MPa);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Kgf_cm_2, value => value * KPa_to_kgf_cm_2);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.MmHg, value => value * KPa_to_MmHg);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Atm, value => value * KPa_to_Atm);

        // MPa conversions
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Bar, value => value * MPa_to_Bar);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Psi, value => value * MPa_to_Psi);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Pa, value => value * MPa_to_Pa);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.KPa, value => value * MPa_to_KPa);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Kgf_cm_2, value => value * MPa_to_kgf_cm_2);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.MmHg, value => value * MPa_to_MmHg);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Atm, value => value * MPa_to_Atm);

        // Kgf/cm² conversions
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.Bar, value => value * Kgf_cm_2_to_Bar);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.Psi, value => value * Kgf_cm_2_to_Psi);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.Pa, value => value * Kgf_cm_2_to_Pa);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.KPa, value => value * Kgf_cm_2_to_KPa);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.MPa, value => value * Kgf_cm_2_to_MPa);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.MmHg, value => value * Kgf_cm_2_to_MmHg);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.Atm, value => value * Kgf_cm_2_to_Atm);

        // mmHg conversions
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Bar, value => value * MmHg_to_Bar);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Psi, value => value * MmHg_to_Psi);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Pa, value => value * MmHg_to_Pa);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.KPa, value => value * MmHg_to_KPa);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.MPa, value => value * MmHg_to_MPa);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Kgf_cm_2, value => value * MmHg_to_kgf_cm_2);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Atm, value => value * MmHg_to_Atm);

        // atm conversions
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.Bar, value => value * Atm_to_Bar);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.Psi, value => value * Atm_to_Psi);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.Pa, value => value * Atm_to_Pa);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.KPa, value => value * Atm_to_KPa);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.MPa, value => value * Atm_to_MPa);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.Kgf_cm_2, value => value * Atm_to_kgf_cm_2);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.MmHg, value => value * Atm_to_MmHg);
    }

    /// <summary>
    /// Converts a value from one pressure unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of pressure.</param>
    /// <param name="to">The target unit of pressure.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, PressureUnit from, PressureUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }

    /// <summary>
    /// Converts a value from one pressure unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of pressure.</param>
    /// <param name="to">The target unit of pressure.</param>
    /// <returns>The converted value in the target unit as a float.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static float Convert(float value, PressureUnit from, PressureUnit to)
    {
        return (float)UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of pressure measurement.
/// </summary>
public enum PressureUnit
{
    /// <summary>
    /// Bar.
    /// </summary>
    Bar,
    /// <summary>
    /// Pounds per square inch (psi).
    /// </summary>
    Psi,
    /// <summary>
    /// Pascal (Pa).
    /// </summary>
    Pa,
    /// <summary>
    /// KiloPascal (KPa).
    /// </summary>
    KPa,
    /// <summary>
    /// MegaPascal (MPa).
    /// </summary>
    MPa,
    /// <summary>
    /// Kilogram-force per square centimeter (Kgf/cm²).
    /// </summary>
    Kgf_cm_2,
    /// <summary>
    /// Millimeters of mercury (mmHg).
    /// </summary>
    MmHg,
    /// <summary>
    /// Standard Atmosphere (atm).
    /// </summary>
    Atm
}