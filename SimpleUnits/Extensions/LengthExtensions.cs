namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of length.
    /// </summary>
    public static class LengthExtensions
    {
        /// <summary>
        /// Converts a value from millimeters (mm) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmToCm(this double value) => Length.MmToCm(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmToCm(this float value) => (float)Length.MmToCm(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmToM(this double value) => Length.MmToM(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmToM(this float value) => (float)Length.MmToM(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmToKm(this double value) => Length.MmToKm(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmToKm(this float value) => (float)Length.MmToKm(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmToIn(this double value) => Length.MmToIn(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmToIn(this float value) => (float)Length.MmToIn(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmToFt(this double value) => Length.MmToFt(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmToFt(this float value) => (float)Length.MmToFt(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmToYd(this double value) => Length.MmToYd(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmToYd(this float value) => (float)Length.MmToYd(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MmToMi(this double value) => Length.MmToMi(value);

        /// <summary>
        /// Converts a value from millimeters (mm) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MmToMi(this float value) => (float)Length.MmToMi(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double CmToMm(this double value) => Length.CmToMm(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float CmToMm(this float value) => (float)Length.CmToMm(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double CmToM(this double value) => Length.CmToM(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float CmToM(this float value) => (float)Length.CmToM(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double CmToKm(this double value) => Length.CmToKm(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float CmToKm(this float value) => (float)Length.CmToKm(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double CmToIn(this double value) => Length.CmToIn(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float CmToIn(this float value) => (float)Length.CmToIn(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double CmToFt(this double value) => Length.CmToFt(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float CmToFt(this float value) => (float)Length.CmToFt(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double CmToYd(this double value) => Length.CmToYd(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float CmToYd(this float value) => (float)Length.CmToYd(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double CmToMi(this double value) => Length.CmToMi(value);

        /// <summary>
        /// Converts a value from centimeters (cm) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float CmToMi(this float value) => (float)Length.CmToMi(value);

        /// <summary>
        /// Converts a value from meters (m) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MToMm(this double value) => Length.MToMm(value);

        /// <summary>
        /// Converts a value from meters (m) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MToMm(this float value) => (float)Length.MToMm(value);

        /// <summary>
        /// Converts a value from meters (m) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MToCm(this double value) => Length.MToCm(value);

        /// <summary>
        /// Converts a value from meters (m) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MToCm(this float value) => (float)Length.MToCm(value);

        /// <summary>
        /// Converts a value from meters (m) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MToKm(this double value) => Length.MToKm(value);

        /// <summary>
        /// Converts a value from meters (m) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MToKm(this float value) => (float)Length.MToKm(value);

        /// <summary>
        /// Converts a value from meters (m) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MToIn(this double value) => Length.MToIn(value);

        /// <summary>
        /// Converts a value from meters (m) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MToIn(this float value) => (float)Length.MToIn(value);

        /// <summary>
        /// Converts a value from meters (m) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MToFt(this double value) => Length.MToFt(value);

        /// <summary>
        /// Converts a value from meters (m) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MToFt(this float value) => (float)Length.MToFt(value);

        /// <summary>
        /// Converts a value from meters (m) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MToYd(this double value) => Length.MToYd(value);

        /// <summary>
        /// Converts a value from meters (m) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MToYd(this float value) => (float)Length.MToYd(value);

        /// <summary>
        /// Converts a value from meters (m) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MToMi(this double value) => Length.MToMi(value);

        /// <summary>
        /// Converts a value from meters (m) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MToMi(this float value) => (float)Length.MToMi(value);

        /// <summary>
        /// Converts a value from kilometers (km) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmToMm(this double value) => Length.KmToMm(value);

        /// <summary>
        /// Converts a value from kilometers (km) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmToMm(this float value) => (float)Length.KmToMm(value);

        /// <summary>
        /// Converts a value from kilometers (km) to centimeters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmToCm(this double value) => Length.KmToCm(value);

        /// <summary>
        /// Converts a value from kilometers (km) to centimeters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmToCm(this float value) => (float)Length.KmToCm(value);

        /// <summary>
        /// Converts a value from kilometers (km) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmToM(this double value) => Length.KmToM(value);

        /// <summary>
        /// Converts a value from kilometers (km) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmToM(this float value) => (float)Length.KmToM(value);

        /// <summary>
        /// Converts a value from kilometers (km) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmToIn(this double value) => Length.KmToIn(value);

        /// <summary>
        /// Converts a value from kilometers (km) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmToIn(this float value) => (float)Length.KmToIn(value);

        /// <summary>
        /// Converts a value from kilometers (km) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmToFt(this double value) => Length.KmToFt(value);

        /// <summary>
        /// Converts a value from kilometers (km) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmToFt(this float value) => (float)Length.KmToFt(value);

        /// <summary>
        /// Converts a value from kilometers (km) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmToYd(this double value) => Length.KmToYd(value);

        /// <summary>
        /// Converts a value from kilometers (km) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmToYd(this float value) => (float)Length.KmToYd(value);

        /// <summary>
        /// Converts a value from kilometers (km) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmToMi(this double value) => Length.KmToMi(value);

        /// <summary>
        /// Converts a value from kilometers (km) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmToMi(this float value) => (float)Length.KmToMi(value);

        /// <summary>
        /// Converts a value from inches (in) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InToMm(this double value) => Length.InToMm(value);

        /// <summary>
        /// Converts a value from inches (in) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InToMm(this float value) => (float)Length.InToMm(value);

        /// <summary>
        /// Converts a value from inches (in) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InToCm(this double value) => Length.InToCm(value);

        /// <summary>
        /// Converts a value from inches (in) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InToCm(this float value) => (float)Length.InToCm(value);

        /// <summary>
        /// Converts a value from inches (in) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InToM(this double value) => Length.InToM(value);

        /// <summary>
        /// Converts a value from inches (in) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InToM(this float value) => (float)Length.InToM(value);

        /// <summary>
        /// Converts a value from inches (in) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InToKm(this double value) => Length.InToKm(value);

        /// <summary>
        /// Converts a value from inches (in) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InToKm(this float value) => (float)Length.InToKm(value);

        /// <summary>
        /// Converts a value from inches (in) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InToFt(this double value) => Length.InToFt(value);

        /// <summary>
        /// Converts a value from inches (in) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InToFt(this float value) => (float)Length.InToFt(value);

        /// <summary>
        /// Converts a value from inches (in) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InToYd(this double value) => Length.InToYd(value);

        /// <summary>
        /// Converts a value from inches (in) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InToYd(this float value) => (float)Length.InToYd(value);

        /// <summary>
        /// Converts a value from inches (in) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InToMi(this double value) => Length.InToMi(value);

        /// <summary>
        /// Converts a value from inches (in) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InToMi(this float value) => (float)Length.InToMi(value);

        /// <summary>
        /// Converts a value from feet (ft) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtToMm(this double value) => Length.FtToMm(value);

        /// <summary>
        /// Converts a value from feet (ft) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtToMm(this float value) => (float)Length.FtToMm(value);

        /// <summary>
        /// Converts a value from feet (ft) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtToCm(this double value) => Length.FtToCm(value);

        /// <summary>
        /// Converts a value from feet (ft) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtToCm(this float value) => (float)Length.FtToCm(value);

        /// <summary>
        /// Converts a value from feet (ft) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtToM(this double value) => Length.FtToM(value);

        /// <summary>
        /// Converts a value from feet (ft) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtToM(this float value) => (float)Length.FtToM(value);

        /// <summary>
        /// Converts a value from feet (ft) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtToKm(this double value) => Length.FtToKm(value);

        /// <summary>
        /// Converts a value from feet (ft) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtToKm(this float value) => (float)Length.FtToKm(value);

        /// <summary>
        /// Converts a value from feet (ft) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtToIn(this double value) => Length.FtToIn(value);

        /// <summary>
        /// Converts a value from feet (ft) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtToIn(this float value) => (float)Length.FtToIn(value);

        /// <summary>
        /// Converts a value from feet (ft) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtToYd(this double value) => Length.FtToYd(value);

        /// <summary>
        /// Converts a value from feet (ft) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtToYd(this float value) => (float)Length.FtToYd(value);

        /// <summary>
        /// Converts a value from feet (ft) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtToMi(this double value) => Length.FtToMi(value);

        /// <summary>
        /// Converts a value from feet (ft) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtToMi(this float value) => (float)Length.FtToMi(value);

        /// <summary>
        /// Converts a value from yards (yd) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double YdToMm(this double value) => Length.YdToMm(value);

        /// <summary>
        /// Converts a value from yards (yd) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float YdToMm(this float value) => (float)Length.YdToMm(value);

        /// <summary>
        /// Converts a value from yards (yd) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double YdToCm(this double value) => Length.YdToCm(value);

        /// <summary>
        /// Converts a value from yards (yd) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float YdToCm(this float value) => (float)Length.YdToCm(value);

        /// <summary>
        /// Converts a value from yards (yd) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double YdToM(this double value) => Length.YdToM(value);

        /// <summary>
        /// Converts a value from yards (yd) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float YdToM(this float value) => (float)Length.YdToM(value);

        /// <summary>
        /// Converts a value from yards (yd) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double YdToKm(this double value) => Length.YdToKm(value);

        /// <summary>
        /// Converts a value from yards (yd) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float YdToKm(this float value) => (float)Length.YdToKm(value);

        /// <summary>
        /// Converts a value from yards (yd) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double YdToIn(this double value) => Length.YdToIn(value);

        /// <summary>
        /// Converts a value from yards (yd) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float YdToIn(this float value) => (float)Length.YdToIn(value);

        /// <summary>
        /// Converts a value from yards (yd) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double YdToFt(this double value) => Length.YdToFt(value);

        /// <summary>
        /// Converts a value from yards (yd) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float YdToFt(this float value) => (float)Length.YdToFt(value);

        /// <summary>
        /// Converts a value from yards (yd) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double YdToMi(this double value) => Length.YdToMi(value);

        /// <summary>
        /// Converts a value from yards (yd) to miles (mi).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float YdToMi(this float value) => (float)Length.YdToMi(value);

        /// <summary>
        /// Converts a value from miles (mi) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MiToMm(this double value) => Length.MiToMm(value);

        /// <summary>
        /// Converts a value from miles (mi) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MiToMm(this float value) => (float)Length.MiToMm(value);

        /// <summary>
        /// Converts a value from miles (mi) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MiToCm(this double value) => Length.MiToCm(value);

        /// <summary>
        /// Converts a value from miles (mi) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MiToCm(this float value) => (float)Length.MiToCm(value);

        /// <summary>
        /// Converts a value from miles (mi) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MiToM(this double value) => Length.MiToM(value);

        /// <summary>
        /// Converts a value from miles (mi) to meters (m).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MiToM(this float value) => (float)Length.MiToM(value);

        /// <summary>
        /// Converts a value from miles (mi) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MiToKm(this double value) => Length.MiToKm(value);

        /// <summary>
        /// Converts a value from miles (mi) to kilometers (km).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MiToKm(this float value) => (float)Length.MiToKm(value);

        /// <summary>
        /// Converts a value from miles (mi) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MiToIn(this double value) => Length.MiToIn(value);

        /// <summary>
        /// Converts a value from miles (mi) to inches (in).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MiToIn(this float value) => (float)Length.MiToIn(value);

        /// <summary>
        /// Converts a value from miles (mi) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MiToFt(this double value) => Length.MiToFt(value);

        /// <summary>
        /// Converts a value from miles (mi) to feet (ft).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MiToFt(this float value) => (float)Length.MiToFt(value);

        /// <summary>
        /// Converts a value from miles (mi) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MiToYd(this double value) => Length.MiToYd(value);

        /// <summary>
        /// Converts a value from miles (mi) to yards (yd).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MiToYd(this float value) => (float)Length.MiToYd(value);
    }
}
