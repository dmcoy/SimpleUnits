namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of pressure.
/// </summary>
public static class Pressure
{
    /// <summary>
    /// Static constructor to register pressure units and conversions with the <see cref="UnitConverter"/>.
    /// </summary>
    static Pressure()
    {
        // Register Pressure unit
        UnitConverter.RegisterUnit(typeof(PressureUnit), BaseUnit.Pressure);

        // Bar conversions
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.Psi, BarToPsi);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.Pa, BarToPa);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.KPa, BarToKPa);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.MPa, BarToMPa);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.Kgf_cm_2, BarToKgfCm2);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.MmHg, BarToMmHg);
        UnitConverter.RegisterConversion(PressureUnit.Bar, PressureUnit.Atm, BarToAtm);

        // psi conversions
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.Bar, PsiToBar);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.Pa, PsiToPa);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.KPa, PsiToKPa);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.MPa, PsiToMPa);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.Kgf_cm_2, PsiToKgfCm2);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.MmHg, PsiToMmHg);
        UnitConverter.RegisterConversion(PressureUnit.Psi, PressureUnit.Atm, PsiToAtm);

        // Pa conversions
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.Bar, PaToBar);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.Psi, PaToPsi);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.KPa, PaToKPa);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.MPa, PaToMPa);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.Kgf_cm_2, PaToKgfCm2);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.MmHg, PaToMmHg);
        UnitConverter.RegisterConversion(PressureUnit.Pa, PressureUnit.Atm, PaToAtm);

        // KPa conversions
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Bar, KPaToBar);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Psi, KPaToPsi);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Pa, KPaToPa);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.MPa, KPaToMPa);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Kgf_cm_2, KPaToKgfCm2);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.MmHg, KPaToMmHg);
        UnitConverter.RegisterConversion(PressureUnit.KPa, PressureUnit.Atm, KPaToAtm);

        // MPa conversions
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Bar, MPaToBar);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Psi, MPaToPsi);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Pa, MPaToPa);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.KPa, MPaToKPa);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Kgf_cm_2, MPaToKgfCm2);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.MmHg, MPaToMmHg);
        UnitConverter.RegisterConversion(PressureUnit.MPa, PressureUnit.Atm, MPaToAtm);

        // Kgf/cm² conversions
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.Bar, KgfCm2ToBar);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.Psi, KgfCm2ToPsi);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.Pa, KgfCm2ToPa);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.KPa, KgfCm2ToKPa);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.MPa, KgfCm2ToMPa);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.MmHg, KgfCm2ToMmHg);
        UnitConverter.RegisterConversion(PressureUnit.Kgf_cm_2, PressureUnit.Atm, KgfCm2ToAtm);

        // mmHg conversions
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Bar, MmHgToBar);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Psi, MmHgToPsi);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Pa, MmHgToPa);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.KPa, MmHgToKPa);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.MPa, MmHgToMPa);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Kgf_cm_2, MmHgToKgfCm2);
        UnitConverter.RegisterConversion(PressureUnit.MmHg, PressureUnit.Atm, MmHgToAtm);

        // atm conversions
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.Bar, AtmToBar);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.Psi, AtmToPsi);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.Pa, AtmToPa);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.KPa, AtmToKPa);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.MPa, AtmToMPa);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.Kgf_cm_2, AtmToKgfCm2);
        UnitConverter.RegisterConversion(PressureUnit.Atm, PressureUnit.MmHg, AtmToMmHg);
    }

    #region Conversion Factors
    /// <summary>
    /// Collection of conversion factors for pressure units.
    /// </summary>
    public struct Factor
    {
        /// <summary>
        /// Conversion factor from Bar to Pounds per square inch (psi).
        /// </summary>
        public const double BarToPsi = 14.503_26;
        /// <summary>
        /// Conversion factor from Bar to KiloPascal (kPa).
        /// </summary>
        public const double BarToKPa = 100;
        /// <summary>
        /// Conversion factor from Bar to MegaPascal (MPa).
        /// </summary>
        public const double BarToMPa = 0.1;
        /// <summary>
        /// Conversion factor from Bar to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        public const double BarToKgfCm2 = 1.019_68;
        /// <summary>
        /// Conversion factor from Bar to Millimeters of mercury (mmHg).
        /// </summary>
        public const double BarToMmHg = 750.018_8;
        /// <summary>
        /// Conversion factor from Bar to Standard Atmosphere (atm).
        /// </summary>
        public const double BarToAtm = 0.987_167;
        /// <summary>
        /// Conversion factor from Bar to Pascal (Pa).
        /// </summary>
        public const double BarToPa = 100_000;

        /// <summary>
        /// Conversion factor from Pounds per square inch (psi) to Bar.
        /// </summary>
        public const double PsiToBar = 0.068_95;
        /// <summary>
        /// Conversion factor from Pounds per square inch (psi) to KiloPascal (kPa).
        /// </summary>
        public const double PsiToKPa = 6.895;
        /// <summary>
        /// Conversion factor from Pounds per square inch (psi) to MegaPascal (MPa).
        /// </summary>
        public const double PsiToMPa = 0.006_895;
        /// <summary>
        /// Conversion factor from Pounds per square inch (psi) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        public const double PsiToKgfCm2 = 0.070_307;
        /// <summary>
        /// Conversion factor from Pounds per square inch (psi) to Millimeters of mercury (mmHg).
        /// </summary>
        public const double PsiToMmHg = 51.713_79;
        /// <summary>
        /// Conversion factor from Pounds per square inch (psi) to Standard Atmosphere (atm).
        /// </summary>
        public const double PsiToAtm = 0.068_065;
        /// <summary>
        /// Conversion factor from Pounds per square inch (psi) to Pascal (Pa).
        /// </summary>
        public const double PsiToPa = 6_895;

        /// <summary>
        /// Conversion factor from KiloPascal (kPa) to Bar.
        /// </summary>
        public const double KPaToBar = 0.01;
        /// <summary>
        /// Conversion factor from KiloPascal (kPa) to Pounds per square inch (psi).
        /// </summary>
        public const double KPaToPsi = 0.145_0;
        /// <summary>
        /// Conversion factor from KiloPascal (kPa) to MegaPascal (MPa).
        /// </summary>
        public const double KPaToMPa = 0.001;
        /// <summary>
        /// Conversion factor from KiloPascal (kPa) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        public const double KPaToKgfCm2 = 0.010_20;
        /// <summary>
        /// Conversion factor from KiloPascal (kPa) to Millimeters of mercury (mmHg).
        /// </summary>
        public const double KPaToMmHg = 7.500_2;
        /// <summary>
        /// Conversion factor from KiloPascal (kPa) to Standard Atmosphere (atm).
        /// </summary>
        public const double KPaToAtm = 0.009_87;
        /// <summary>
        /// Conversion factor from KiloPascal (kPa) to Pascal (Pa).
        /// </summary>
        public const double KPaToPa = 1_000;

        /// <summary>
        /// Conversion factor from MegaPascal (MPa) to Bar.
        /// </summary>
        public const double MPaToBar = 10;
        /// <summary>
        /// Conversion factor from MegaPascal (MPa) to Pounds per square inch (psi).
        /// </summary>
        public const double MPaToPsi = 145.03;
        /// <summary>
        /// Conversion factor from MegaPascal (MPa) to KiloPascal (kPa).
        /// </summary>
        public const double MPaToKPa = 1_000;
        /// <summary>
        /// Conversion factor from MegaPascal (MPa) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        public const double MPaToKgfCm2 = 10.197;
        /// <summary>
        /// Conversion factor from MegaPascal (MPa) to Millimeters of mercury (mmHg).
        /// </summary>
        public const double MPaToMmHg = 7_500.2;
        /// <summary>
        /// Conversion factor from MegaPascal (MPa) to Standard Atmosphere (atm).
        /// </summary>
        public const double MPaToAtm = 9.871_7;
        /// <summary>
        /// Conversion factor from MegaPascal (MPa) to Pascal (Pa).
        /// </summary>
        public const double MPaToPa = 1_000_000;

        /// <summary>
        /// Conversion factor from Kilogram-force per square centimeter (Kgf/cm²) to Bar.
        /// </summary>
        public const double KgfCm2ToBar = 0.980_7;
        /// <summary>
        /// Conversion factor from Kilogram-force per square centimeter (Kgf/cm²) to Pounds per square inch (psi).
        /// </summary>
        public const double KgfCm2ToPsi = 14.223_35;
        /// <summary>
        /// Conversion factor from Kilogram-force per square centimeter (Kgf/cm²) to KiloPascal (kPa).
        /// </summary>
        public const double KgfCm2ToKPa = 98.07;
        /// <summary>
        /// Conversion factor from Kilogram-force per square centimeter (Kgf/cm²) to MegaPascal (MPa).
        /// </summary>
        public const double KgfCm2ToMPa = 0.098_07;
        /// <summary>
        /// Conversion factor from Kilogram-force per square centimeter (Kgf/cm²) to Millimeters of mercury (mmHg).
        /// </summary>
        public const double KgfCm2ToMmHg = 735.543_4;
        /// <summary>
        /// Conversion factor from Kilogram-force per square centimeter (Kgf/cm²) to Standard Atmosphere (atm).
        /// </summary>
        public const double KgfCm2ToAtm = 0.968_115;
        /// <summary>
        /// Conversion factor from Kilogram-force per square centimeter (Kgf/cm²) to Pascal (Pa).
        /// </summary>
        public const double KgfCm2ToPa = 98_066.5;

        /// <summary>
        /// Conversion factor from Millimeters of mercury (mmHg) to Bar.
        /// </summary>
        public const double MmHgToBar = 0.001_333;
        /// <summary>
        /// Conversion factor from Millimeters of mercury (mmHg) to Pounds per square inch (psi).
        /// </summary>
        public const double MmHgToPsi = 0.019_337;
        /// <summary>
        /// Conversion factor from Millimeters of mercury (mmHg) to KiloPascal (kPa).
        /// </summary>
        public const double MmHgToKPa = 0.133_33;
        /// <summary>
        /// Conversion factor from Millimeters of mercury (mmHg) to MegaPascal (MPa).
        /// </summary>
        public const double MmHgToMPa = 0.000_133_3;
        /// <summary>
        /// Conversion factor from Millimeters of mercury (mmHg) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        public const double MmHgToKgfCm2 = 0.001_36;
        /// <summary>
        /// Conversion factor from Millimeters of mercury (mmHg) to Standard Atmosphere (atm).
        /// </summary>
        public const double MmHgToAtm = 0.001_316;
        /// <summary>
        /// Conversion factor from Millimeters of mercury (mmHg) to Pascal (Pa).
        /// </summary>
        public const double MmHgToPa = 133.322;

        /// <summary>
        /// Conversion factor from Standard Atmosphere (atm) to Bar.
        /// </summary>
        public const double AtmToBar = 1.013;
        /// <summary>
        /// Conversion factor from Standard Atmosphere (atm) to Pounds per square inch (psi).
        /// </summary>
        public const double AtmToPsi = 14.691_81;
        /// <summary>
        /// Conversion factor from Standard Atmosphere (atm) to KiloPascal (kPa).
        /// </summary>
        public const double AtmToKPa = 101.3;
        /// <summary>
        /// Conversion factor from Standard Atmosphere (atm) to MegaPascal (MPa).
        /// </summary>
        public const double AtmToMPa = 0.101_3;
        /// <summary>
        /// Conversion factor from Standard Atmosphere (atm) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        public const double AtmToKgfCm2 = 1.032_936;
        /// <summary>
        /// Conversion factor from Standard Atmosphere (atm) to Millimeters of mercury (mmHg).
        /// </summary>
        public const double AtmToMmHg = 759.769;
        /// <summary>
        /// Conversion factor from Standard Atmosphere (atm) to Pascal (Pa).
        /// </summary>
        public const double AtmToPa = 101_325;

        /// <summary>
        /// Conversion factor from Pascal (Pa) to Bar.
        /// </summary>
        public const double PaToBar = 0.000_01;
        /// <summary>
        /// Conversion factor from Pascal (Pa) to Pounds per square inch (psi).
        /// </summary>
        public const double PaToPsi = 0.000_145_0;
        /// <summary>
        /// Conversion factor from Pascal (Pa) to KiloPascal (kPa).
        /// </summary>
        public const double PaToKPa = 0.001;
        /// <summary>
        /// Conversion factor from Pascal (Pa) to MegaPascal (MPa).
        /// </summary>
        public const double PaToMPa = 0.000_001;
        /// <summary>
        /// Conversion factor from Pascal (Pa) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        public const double PaToKgfCm2 = 0.000_010_20;
        /// <summary>
        /// Conversion factor from Pascal (Pa) to Millimeters of mercury (mmHg).
        /// </summary>
        public const double PaToMmHg = 0.007_500_62;
        /// <summary>
        /// Conversion factor from Pascal (Pa) to Standard Atmosphere (atm).
        /// </summary>
        public const double PaToAtm = 0.000_009_87;
    }
    #endregion

    /// <summary>
    /// Converts a value in Bar to Pounds per square inch (psi).
    /// </summary>
    /// <param name="value">The value in Bar.</param>
    /// <returns>The equivalent value in psi.</returns>
    public static double BarToPsi(double value) => value * Factor.BarToPsi;
    /// <summary>
    /// Converts a value in Bar to KiloPascal (kPa).
    /// </summary>
    /// <param name="value">The value in Bar.</param>
    /// <returns>The equivalent value in kPa.</returns>
    public static double BarToKPa(double value) => value * Factor.BarToKPa;
    /// <summary>
    /// Converts a value in Bar to MegaPascal (MPa).
    /// </summary>
    /// <param name="value">The value in Bar.</param>
    /// <returns>The equivalent value in MPa.</returns>
    public static double BarToMPa(double value) => value * Factor.BarToMPa;
    /// <summary>
    /// Converts a value in Bar to Kilogram-force per square centimeter (Kgf/cm²).
    /// </summary>
    /// <param name="value">The value in Bar.</param>
    /// <returns>The equivalent value in Kgf/cm².</returns>
    public static double BarToKgfCm2(double value) => value * Factor.BarToKgfCm2;
    /// <summary>
    /// Converts a value in Bar to Millimeters of mercury (mmHg).
    /// </summary>
    /// <param name="value">The value in Bar.</param>
    /// <returns>The equivalent value in mmHg.</returns>
    public static double BarToMmHg(double value) => value * Factor.BarToMmHg;
    /// <summary>
    /// Converts a value in Bar to Standard Atmosphere (atm).
    /// </summary>
    /// <param name="value">The value in Bar.</param>
    /// <returns>The equivalent value in atm.</returns>
    public static double BarToAtm(double value) => value * Factor.BarToAtm;
    /// <summary>
    /// Converts a value in Bar to Pascal (Pa).
    /// </summary>
    /// <param name="value">The value in Bar.</param>
    /// <returns>The equivalent value in Pa.</returns>
    public static double BarToPa(double value) => value * Factor.BarToPa;

    // Psi conversions

    /// <summary>
    /// Converts a value in Pounds per square inch (psi) to Bar.
    /// </summary>
    /// <param name="value">The value in psi.</param>
    /// <returns>The equivalent value in Bar.</returns>
    public static double PsiToBar(double value) => value * Factor.PsiToBar;
    /// <summary>
    /// Converts a value in Pounds per square inch (psi) to KiloPascal (kPa).
    /// </summary>
    /// <param name="value">The value in psi.</param>
    /// <returns>The equivalent value in kPa.</returns>
    public static double PsiToKPa(double value) => value * Factor.PsiToKPa;
    /// <summary>
    /// Converts a value in Pounds per square inch (psi) to MegaPascal (MPa).
    /// </summary>
    /// <param name="value">The value in psi.</param>
    /// <returns>The equivalent value in MPa.</returns>
    public static double PsiToMPa(double value) => value * Factor.PsiToMPa;
    /// <summary>
    /// Converts a value in Pounds per square inch (psi) to Kilogram-force per square centimeter (Kgf/cm²).
    /// </summary>
    /// <param name="value">The value in psi.</param>
    /// <returns>The equivalent value in Kgf/cm².</returns>
    public static double PsiToKgfCm2(double value) => value * Factor.PsiToKgfCm2;
    /// <summary>
    /// Converts a value in Pounds per square inch (psi) to Millimeters of mercury (mmHg).
    /// </summary>
    /// <param name="value">The value in psi.</param>
    /// <returns>The equivalent value in mmHg.</returns>
    public static double PsiToMmHg(double value) => value * Factor.PsiToMmHg;
    /// <summary>
    /// Converts a value in Pounds per square inch (psi) to Standard Atmosphere (atm).
    /// </summary>
    /// <param name="value">The value in psi.</param>
    /// <returns>The equivalent value in atm.</returns>
    public static double PsiToAtm(double value) => value * Factor.PsiToAtm;
    /// <summary>
    /// Converts a value in Pounds per square inch (psi) to Pascal (Pa).
    /// </summary>
    /// <param name="value">The value in psi.</param>
    /// <returns>The equivalent value in Pa.</returns>
    public static double PsiToPa(double value) => value * Factor.PsiToPa;

    // KPa conversions

    /// <summary>
    /// Converts a value in KiloPascal (kPa) to Bar.
    /// </summary>
    /// <param name="value">The value in kPa.</param>
    /// <returns>The equivalent value in Bar.</returns>
    public static double KPaToBar(double value) => value * Factor.KPaToBar;
    /// <summary>
    /// Converts a value in KiloPascal (kPa) to Pounds per square inch (psi).
    /// </summary>
    /// <param name="value">The value in kPa.</param>
    /// <returns>The equivalent value in psi.</returns>
    public static double KPaToPsi(double value) => value * Factor.KPaToPsi;
    /// <summary>
    /// Converts a value in KiloPascal (kPa) to MegaPascal (MPa).
    /// </summary>
    /// <param name="value">The value in kPa.</param>
    /// <returns>The equivalent value in MPa.</returns>
    public static double KPaToMPa(double value) => value * Factor.KPaToMPa;
    /// <summary>
    /// Converts a value in KiloPascal (kPa) to Kilogram-force per square centimeter (Kgf/cm²).
    /// </summary>
    /// <param name="value">The value in kPa.</param>
    /// <returns>The equivalent value in Kgf/cm².</returns>
    public static double KPaToKgfCm2(double value) => value * Factor.KPaToKgfCm2;
    /// <summary>
    /// Converts a value in KiloPascal (kPa) to Millimeters of mercury (mmHg).
    /// </summary>
    /// <param name="value">The value in kPa.</param>
    /// <returns>The equivalent value in mmHg.</returns>
    public static double KPaToMmHg(double value) => value * Factor.KPaToMmHg;
    /// <summary>
    /// Converts a value in KiloPascal (kPa) to Standard Atmosphere (atm).
    /// </summary>
    /// <param name="value">The value in kPa.</param>
    /// <returns>The equivalent value in atm.</returns>
    public static double KPaToAtm(double value) => value * Factor.KPaToAtm;
    /// <summary>
    /// Converts a value in KiloPascal (kPa) to Pascal (Pa).
    /// </summary>
    /// <param name="value">The value in kPa.</param>
    /// <returns>The equivalent value in Pa.</returns>
    public static double KPaToPa(double value) => value * Factor.KPaToPa;

    // MPa conversions

    /// <summary>
    /// Converts a value in MegaPascal (MPa) to Bar.
    /// </summary>
    /// <param name="value">The value in MPa.</param>
    /// <returns>The equivalent value in Bar.</returns>
    public static double MPaToBar(double value) => value * Factor.MPaToBar;
    /// <summary>
    /// Converts a value in MegaPascal (MPa) to Pounds per square inch (psi).
    /// </summary>
    /// <param name="value">The value in MPa.</param>
    /// <returns>The equivalent value in psi.</returns>
    public static double MPaToPsi(double value) => value * Factor.MPaToPsi;
    /// <summary>
    /// Converts a value in MegaPascal (MPa) to KiloPascal (kPa).
    /// </summary>
    /// <param name="value">The value in MPa.</param>
    /// <returns>The equivalent value in kPa.</returns>
    public static double MPaToKPa(double value) => value * Factor.MPaToKPa;
    /// <summary>
    /// Converts a value in MegaPascal (MPa) to Kilogram-force per square centimeter (Kgf/cm²).
    /// </summary>
    /// <param name="value">The value in MPa.</param>
    /// <returns>The equivalent value in Kgf/cm².</returns>
    public static double MPaToKgfCm2(double value) => value * Factor.MPaToKgfCm2;
    /// <summary>
    /// Converts a value in MegaPascal (MPa) to Millimeters of mercury (mmHg).
    /// </summary>
    /// <param name="value">The value in MPa.</param>
    /// <returns>The equivalent value in mmHg.</returns>
    public static double MPaToMmHg(double value) => value * Factor.MPaToMmHg;
    /// <summary>
    /// Converts a value in MegaPascal (MPa) to Standard Atmosphere (atm).
    /// </summary>
    /// <param name="value">The value in MPa.</param>
    /// <returns>The equivalent value in atm.</returns>
    public static double MPaToAtm(double value) => value * Factor.MPaToAtm;
    /// <summary>
    /// Converts a value in MegaPascal (MPa) to Pascal (Pa).
    /// </summary>
    /// <param name="value">The value in MPa.</param>
    /// <returns>The equivalent value in Pa.</returns>
    public static double MPaToPa(double value) => value * Factor.MPaToPa;

    // Kgf/cm² conversions

    /// <summary>
    /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Bar.
    /// </summary>
    /// <param name="value">The value in Kgf/cm².</param>
    /// <returns>The equivalent value in Bar.</returns>
    public static double KgfCm2ToBar(double value) => value * Factor.KgfCm2ToBar;
    /// <summary>
    /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Pounds per square inch (psi).
    /// </summary>
    /// <param name="value">The value in Kgf/cm².</param>
    /// <returns>The equivalent value in psi.</returns>
    public static double KgfCm2ToPsi(double value) => value * Factor.KgfCm2ToPsi;
    /// <summary>
    /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to KiloPascal (kPa).
    /// </summary>
    /// <param name="value">The value in Kgf/cm².</param>
    /// <returns>The equivalent value in kPa.</returns>
    public static double KgfCm2ToKPa(double value) => value * Factor.KgfCm2ToKPa;
    /// <summary>
    /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to MegaPascal (MPa).
    /// </summary>
    /// <param name="value">The value in Kgf/cm².</param>
    /// <returns>The equivalent value in MPa.</returns>
    public static double KgfCm2ToMPa(double value) => value * Factor.KgfCm2ToMPa;
    /// <summary>
    /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Millimeters of mercury (mmHg).
    /// </summary>
    /// <param name="value">The value in Kgf/cm².</param>
    /// <returns>The equivalent value in mmHg.</returns>
    public static double KgfCm2ToMmHg(double value) => value * Factor.KgfCm2ToMmHg;
    /// <summary>
    /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Standard Atmosphere (atm).
    /// </summary>
    /// <param name="value">The value in Kgf/cm².</param>
    /// <returns>The equivalent value in atm.</returns>
    public static double KgfCm2ToAtm(double value) => value * Factor.KgfCm2ToAtm;
    /// <summary>
    /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Pascal (Pa).
    /// </summary>
    /// <param name="value">The value in Kgf/cm².</param>
    /// <returns>The equivalent value in Pa.</returns>
    public static double KgfCm2ToPa(double value) => value * Factor.KgfCm2ToPa;

    // mmHg conversions

    /// <summary>
    /// Converts a value in Millimeters of mercury (mmHg) to Bar.
    /// </summary>
    /// <param name="value">The value in mmHg.</param>
    /// <returns>The equivalent value in Bar.</returns>
    public static double MmHgToBar(double value) => value * Factor.MmHgToBar;
    /// <summary>
    /// Converts a value in Millimeters of mercury (mmHg) to Pounds per square inch (psi).
    /// </summary>
    /// <param name="value">The value in mmHg.</param>
    /// <returns>The equivalent value in psi.</returns>
    public static double MmHgToPsi(double value) => value * Factor.MmHgToPsi;
    /// <summary>
    /// Converts a value in Millimeters of mercury (mmHg) to KiloPascal (kPa).
    /// </summary>
    /// <param name="value">The value in mmHg.</param>
    /// <returns>The equivalent value in kPa.</returns>
    public static double MmHgToKPa(double value) => value * Factor.MmHgToKPa;
    /// <summary>
    /// Converts a value in Millimeters of mercury (mmHg) to MegaPascal (MPa).
    /// </summary>
    /// <param name="value">The value in mmHg.</param>
    /// <returns>The equivalent value in MPa.</returns>
    public static double MmHgToMPa(double value) => value * Factor.MmHgToMPa;
    /// <summary>
    /// Converts a value in Millimeters of mercury (mmHg) to Kilogram-force per square centimeter (Kgf/cm²).
    /// </summary>
    /// <param name="value">The value in mmHg.</param>
    /// <returns>The equivalent value in Kgf/cm².</returns>
    public static double MmHgToKgfCm2(double value) => value * Factor.MmHgToKgfCm2;
    /// <summary>
    /// Converts a value in Millimeters of mercury (mmHg) to Standard Atmosphere (atm).
    /// </summary>
    /// <param name="value">The value in mmHg.</param>
    /// <returns>The equivalent value in atm.</returns>
    public static double MmHgToAtm(double value) => value * Factor.MmHgToAtm;
    /// <summary>
    /// Converts a value in Millimeters of mercury (mmHg) to Pascal (Pa).
    /// </summary>
    /// <param name="value">The value in mmHg.</param>
    /// <returns>The equivalent value in Pa.</returns>
    public static double MmHgToPa(double value) => value * Factor.MmHgToPa;

    // atm conversions

    /// <summary>
    /// Converts a value in Standard Atmosphere (atm) to Bar.
    /// </summary>
    /// <param name="value">The value in atm.</param>
    /// <returns>The equivalent value in Bar.</returns>
    public static double AtmToBar(double value) => value * Factor.AtmToBar;
    /// <summary>
    /// Converts a value in Standard Atmosphere (atm) to Pounds per square inch (psi).
    /// </summary>
    /// <param name="value">The value in atm.</param>
    /// <returns>The equivalent value in psi.</returns>
    public static double AtmToPsi(double value) => value * Factor.AtmToPsi;
    /// <summary>
    /// Converts a value in Standard Atmosphere (atm) to KiloPascal (kPa).
    /// </summary>
    /// <param name="value">The value in atm.</param>
    /// <returns>The equivalent value in kPa.</returns>
    public static double AtmToKPa(double value) => value * Factor.AtmToKPa;
    /// <summary>
    /// Converts a value in Standard Atmosphere (atm) to MegaPascal (MPa).
    /// </summary>
    /// <param name="value">The value in atm.</param>
    /// <returns>The equivalent value in MPa.</returns>
    public static double AtmToMPa(double value) => value * Factor.AtmToMPa;
    /// <summary>
    /// Converts a value in Standard Atmosphere (atm) to Kilogram-force per square centimeter (Kgf/cm²).
    /// </summary>
    /// <param name="value">The value in atm.</param>
    /// <returns>The equivalent value in Kgf/cm².</returns>
    public static double AtmToKgfCm2(double value) => value * Factor.AtmToKgfCm2;
    /// <summary>
    /// Converts a value in Standard Atmosphere (atm) to Millimeters of mercury (mmHg).
    /// </summary>
    /// <param name="value">The value in atm.</param>
    /// <returns>The equivalent value in mmHg.</returns>
    public static double AtmToMmHg(double value) => value * Factor.AtmToMmHg;
    /// <summary>
    /// Converts a value in Standard Atmosphere (atm) to Pascal (Pa).
    /// </summary>
    /// <param name="value">The value in atm.</param>
    /// <returns>The equivalent value in Pa.</returns>
    public static double AtmToPa(double value) => value * Factor.AtmToPa;

    // Pa conversions

    /// <summary>
    /// Converts a value in Pascal (Pa) to Bar.
    /// </summary>
    /// <param name="value">The value in Pa.</param>
    /// <returns>The equivalent value in Bar.</returns>
    public static double PaToBar(double value) => value * Factor.PaToBar;
    /// <summary>
    /// Converts a value in Pascal (Pa) to Pounds per square inch (psi).
    /// </summary>
    /// <param name="value">The value in Pa.</param>
    /// <returns>The equivalent value in psi.</returns>
    public static double PaToPsi(double value) => value * Factor.PaToPsi;
    /// <summary>
    /// Converts a value in Pascal (Pa) to KiloPascal (kPa).
    /// </summary>
    /// <param name="value">The value in Pa.</param>
    /// <returns>The equivalent value in kPa.</returns>
    public static double PaToKPa(double value) => value * Factor.PaToKPa;
    /// <summary>
    /// Converts a value in Pascal (Pa) to MegaPascal (MPa).
    /// </summary>
    /// <param name="value">The value in Pa.</param>
    /// <returns>The equivalent value in MPa.</returns>
    public static double PaToMPa(double value) => value * Factor.PaToMPa;
    /// <summary>
    /// Converts a value in Pascal (Pa) to Kilogram-force per square centimeter (Kgf/cm²).
    /// </summary>
    /// <param name="value">The value in Pa.</param>
    /// <returns>The equivalent value in Kgf/cm².</returns>
    public static double PaToKgfCm2(double value) => value * Factor.PaToKgfCm2;
    /// <summary>
    /// Converts a value in Pascal (Pa) to Millimeters of mercury (mmHg).
    /// </summary>
    /// <param name="value">The value in Pa.</param>
    /// <returns>The equivalent value in mmHg.</returns>
    public static double PaToMmHg(double value) => value * Factor.PaToMmHg;
    /// <summary>
    /// Converts a value in Pascal (Pa) to Standard Atmosphere (atm).
    /// </summary>
    /// <param name="value">The value in Pa.</param>
    /// <returns>The equivalent value in atm.</returns>
    public static double PaToAtm(double value) => value * Factor.PaToAtm;

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