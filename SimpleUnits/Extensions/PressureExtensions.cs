namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of pressure.
    /// </summary>
    public static class PressureExtensions
    {
        /// <summary>
        /// Converts a value in Bar to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BarToPsi(this double value) => Pressure.BarToPsi(value);

        /// <summary>
        /// Converts a value in Bar to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BarToPsi(this float value) => (float)Pressure.BarToPsi(value);

        /// <summary>
        /// Converts a value in Bar to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BarToKPa(this double value) => Pressure.BarToKPa(value);

        /// <summary>
        /// Converts a value in Bar to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BarToKPa(this float value) => (float)Pressure.BarToKPa(value);

        /// <summary>
        /// Converts a value in Bar to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BarToMPa(this double value) => Pressure.BarToMPa(value);

        /// <summary>
        /// Converts a value in Bar to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BarToMPa(this float value) => (float)Pressure.BarToMPa(value);

        /// <summary>
        /// Converts a value in Bar to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BarToKgfCm2(this double value) => Pressure.BarToKgfCm2(value);

        /// <summary>
        /// Converts a value in Bar to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BarToKgfCm2(this float value) => (float)Pressure.BarToKgfCm2(value);

        /// <summary>
        /// Converts a value in Bar to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BarToMmHg(this double value) => Pressure.BarToMmHg(value);

        /// <summary>
        /// Converts a value in Bar to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BarToMmHg(this float value) => (float)Pressure.BarToMmHg(value);

        /// <summary>
        /// Converts a value in Bar to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BarToAtm(this double value) => Pressure.BarToAtm(value);

        /// <summary>
        /// Converts a value in Bar to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BarToAtm(this float value) => (float)Pressure.BarToAtm(value);

        /// <summary>
        /// Converts a value in Bar to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BarToPa(this double value) => Pressure.BarToPa(value);

        /// <summary>
        /// Converts a value in Bar to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BarToPa(this float value) => (float)Pressure.BarToPa(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PsiToBar(this double value) => Pressure.PsiToBar(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PsiToBar(this float value) => (float)Pressure.PsiToBar(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PsiToKPa(this double value) => Pressure.PsiToKPa(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PsiToKPa(this float value) => (float)Pressure.PsiToKPa(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PsiToMPa(this double value) => Pressure.PsiToMPa(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PsiToMPa(this float value) => (float)Pressure.PsiToMPa(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PsiToKgfCm2(this double value) => Pressure.PsiToKgfCm2(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PsiToKgfCm2(this float value) => (float)Pressure.PsiToKgfCm2(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PsiToMmHg(this double value) => Pressure.PsiToMmHg(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PsiToMmHg(this float value) => (float)Pressure.PsiToMmHg(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PsiToAtm(this double value) => Pressure.PsiToAtm(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PsiToAtm(this float value) => (float)Pressure.PsiToAtm(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PsiToPa(this double value) => Pressure.PsiToPa(value);

        /// <summary>
        /// Converts a value in Pounds per square inch (psi) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PsiToPa(this float value) => (float)Pressure.PsiToPa(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KPaToBar(this double value) => Pressure.KPaToBar(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KPaToBar(this float value) => (float)Pressure.KPaToBar(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KPaToPsi(this double value) => Pressure.KPaToPsi(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KPaToPsi(this float value) => (float)Pressure.KPaToPsi(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KPaToMPa(this double value) => Pressure.KPaToMPa(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KPaToMPa(this float value) => (float)Pressure.KPaToMPa(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KPaToKgfCm2(this double value) => Pressure.KPaToKgfCm2(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KPaToKgfCm2(this float value) => (float)Pressure.KPaToKgfCm2(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KPaToMmHg(this double value) => Pressure.KPaToMmHg(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KPaToMmHg(this float value) => (float)Pressure.KPaToMmHg(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KPaToAtm(this double value) => Pressure.KPaToAtm(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KPaToAtm(this float value) => (float)Pressure.KPaToAtm(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KPaToPa(this double value) => Pressure.KPaToPa(value);

        /// <summary>
        /// Converts a value in KiloPascal (kPa) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KPaToPa(this float value) => (float)Pressure.KPaToPa(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MPaToBar(this double value) => Pressure.MPaToBar(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MPaToBar(this float value) => (float)Pressure.MPaToBar(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MPaToPsi(this double value) => Pressure.MPaToPsi(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MPaToPsi(this float value) => (float)Pressure.MPaToPsi(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MPaToKPa(this double value) => Pressure.MPaToKPa(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MPaToKPa(this float value) => (float)Pressure.MPaToKPa(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MPaToKgfCm2(this double value) => Pressure.MPaToKgfCm2(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MPaToKgfCm2(this float value) => (float)Pressure.MPaToKgfCm2(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MPaToMmHg(this double value) => Pressure.MPaToMmHg(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MPaToMmHg(this float value) => (float)Pressure.MPaToMmHg(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MPaToAtm(this double value) => Pressure.MPaToAtm(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MPaToAtm(this float value) => (float)Pressure.MPaToAtm(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MPaToPa(this double value) => Pressure.MPaToPa(value);

        /// <summary>
        /// Converts a value in MegaPascal (MPa) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MPaToPa(this float value) => (float)Pressure.MPaToPa(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfCm2ToBar(this double value) => Pressure.KgfCm2ToBar(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfCm2ToBar(this float value) => (float)Pressure.KgfCm2ToBar(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfCm2ToPsi(this double value) => Pressure.KgfCm2ToPsi(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfCm2ToPsi(this float value) => (float)Pressure.KgfCm2ToPsi(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfCm2ToKPa(this double value) => Pressure.KgfCm2ToKPa(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfCm2ToKPa(this float value) => (float)Pressure.KgfCm2ToKPa(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfCm2ToMPa(this double value) => Pressure.KgfCm2ToMPa(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfCm2ToMPa(this float value) => (float)Pressure.KgfCm2ToMPa(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfCm2ToMmHg(this double value) => Pressure.KgfCm2ToMmHg(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfCm2ToMmHg(this float value) => (float)Pressure.KgfCm2ToMmHg(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfCm2ToAtm(this double value) => Pressure.KgfCm2ToAtm(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfCm2ToAtm(this float value) => (float)Pressure.KgfCm2ToAtm(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfCm2ToPa(this double value) => Pressure.KgfCm2ToPa(value);

        /// <summary>
        /// Converts a value in Kilogram-force per square centimeter (Kgf/cm²) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfCm2ToPa(this float value) => (float)Pressure.KgfCm2ToPa(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmHgToBar(this double value) => Pressure.MmHgToBar(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmHgToBar(this float value) => (float)Pressure.MmHgToBar(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmHgToPsi(this double value) => Pressure.MmHgToPsi(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmHgToPsi(this float value) => (float)Pressure.MmHgToPsi(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmHgToKPa(this double value) => Pressure.MmHgToKPa(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmHgToKPa(this float value) => (float)Pressure.MmHgToKPa(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmHgToMPa(this double value) => Pressure.MmHgToMPa(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmHgToMPa(this float value) => (float)Pressure.MmHgToMPa(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmHgToKgfCm2(this double value) => Pressure.MmHgToKgfCm2(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmHgToKgfCm2(this float value) => (float)Pressure.MmHgToKgfCm2(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmHgToAtm(this double value) => Pressure.MmHgToAtm(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmHgToAtm(this float value) => (float)Pressure.MmHgToAtm(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmHgToPa(this double value) => Pressure.MmHgToPa(value);

        /// <summary>
        /// Converts a value in Millimeters of mercury (mmHg) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmHgToPa(this float value) => (float)Pressure.MmHgToPa(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double AtmToBar(this double value) => Pressure.AtmToBar(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float AtmToBar(this float value) => (float)Pressure.AtmToBar(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double AtmToPsi(this double value) => Pressure.AtmToPsi(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float AtmToPsi(this float value) => (float)Pressure.AtmToPsi(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double AtmToKPa(this double value) => Pressure.AtmToKPa(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float AtmToKPa(this float value) => (float)Pressure.AtmToKPa(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double AtmToMPa(this double value) => Pressure.AtmToMPa(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float AtmToMPa(this float value) => (float)Pressure.AtmToMPa(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double AtmToKgfCm2(this double value) => Pressure.AtmToKgfCm2(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float AtmToKgfCm2(this float value) => (float)Pressure.AtmToKgfCm2(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double AtmToMmHg(this double value) => Pressure.AtmToMmHg(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float AtmToMmHg(this float value) => (float)Pressure.AtmToMmHg(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double AtmToPa(this double value) => Pressure.AtmToPa(value);

        /// <summary>
        /// Converts a value in Standard Atmosphere (atm) to Pascal (Pa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float AtmToPa(this float value) => (float)Pressure.AtmToPa(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PaToBar(this double value) => Pressure.PaToBar(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Bar.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PaToBar(this float value) => (float)Pressure.PaToBar(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PaToPsi(this double value) => Pressure.PaToPsi(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Pounds per square inch (psi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PaToPsi(this float value) => (float)Pressure.PaToPsi(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PaToKPa(this double value) => Pressure.PaToKPa(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to KiloPascal (kPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PaToKPa(this float value) => (float)Pressure.PaToKPa(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PaToMPa(this double value) => Pressure.PaToMPa(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to MegaPascal (MPa).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PaToMPa(this float value) => (float)Pressure.PaToMPa(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PaToKgfCm2(this double value) => Pressure.PaToKgfCm2(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Kilogram-force per square centimeter (Kgf/cm²).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PaToKgfCm2(this float value) => (float)Pressure.PaToKgfCm2(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PaToMmHg(this double value) => Pressure.PaToMmHg(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Millimeters of mercury (mmHg).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PaToMmHg(this float value) => (float)Pressure.PaToMmHg(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double PaToAtm(this double value) => Pressure.PaToAtm(value);

        /// <summary>
        /// Converts a value in Pascal (Pa) to Standard Atmosphere (atm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float PaToAtm(this float value) => (float)Pressure.PaToAtm(value);
    }
}
