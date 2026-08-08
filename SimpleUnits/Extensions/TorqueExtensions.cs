namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of torque.
    /// </summary>
    public static class TorqueExtensions
    {
        /// <summary>
        /// Converts newton-meters (Nm) to kilogram-force meters (kgfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double NmToKgfm(this double value) => Torque.NmToKgfm(value);

        /// <summary>
        /// Converts newton-meters (Nm) to kilogram-force meters (kgfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float NmToKgfm(this float value) => (float)Torque.NmToKgfm(value);

        /// <summary>
        /// Converts newton-meters (Nm) to foot-pounds (ftlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double NmToFtlb(this double value) => Torque.NmToFtlb(value);

        /// <summary>
        /// Converts newton-meters (Nm) to foot-pounds (ftlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float NmToFtlb(this float value) => (float)Torque.NmToFtlb(value);

        /// <summary>
        /// Converts newton-meters (Nm) to inch-pounds (inlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double NmToInlb(this double value) => Torque.NmToInlb(value);

        /// <summary>
        /// Converts newton-meters (Nm) to inch-pounds (inlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float NmToInlb(this float value) => (float)Torque.NmToInlb(value);

        /// <summary>
        /// Converts kilogram-force meters (kgfm) to newton-meters (Nm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfmToNm(this double value) => Torque.KgfmToNm(value);

        /// <summary>
        /// Converts kilogram-force meters (kgfm) to newton-meters (Nm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfmToNm(this float value) => (float)Torque.KgfmToNm(value);

        /// <summary>
        /// Converts kilogram-force meters (kgfm) to foot-pounds (ftlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfmToFtlb(this double value) => Torque.KgfmToFtlb(value);

        /// <summary>
        /// Converts kilogram-force meters (kgfm) to foot-pounds (ftlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfmToFtlb(this float value) => (float)Torque.KgfmToFtlb(value);

        /// <summary>
        /// Converts kilogram-force meters (kgfm) to inch-pounds (inlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgfmToInlb(this double value) => Torque.KgfmToInlb(value);

        /// <summary>
        /// Converts kilogram-force meters (kgfm) to inch-pounds (inlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgfmToInlb(this float value) => (float)Torque.KgfmToInlb(value);

        /// <summary>
        /// Converts foot-pounds (ftlb) to newton-meters (Nm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtlbToNm(this double value) => Torque.FtlbToNm(value);

        /// <summary>
        /// Converts foot-pounds (ftlb) to newton-meters (Nm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtlbToNm(this float value) => (float)Torque.FtlbToNm(value);

        /// <summary>
        /// Converts foot-pounds (ftlb) to kilogram-force meters (kgfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtlbToKgfm(this double value) => Torque.FtlbToKgfm(value);

        /// <summary>
        /// Converts foot-pounds (ftlb) to kilogram-force meters (kgfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtlbToKgfm(this float value) => (float)Torque.FtlbToKgfm(value);

        /// <summary>
        /// Converts foot-pounds (ftlb) to inch-pounds (inlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtlbToInlb(this double value) => Torque.FtlbToInlb(value);

        /// <summary>
        /// Converts foot-pounds (ftlb) to inch-pounds (inlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtlbToInlb(this float value) => (float)Torque.FtlbToInlb(value);

        /// <summary>
        /// Converts inch-pounds (inlb) to newton-meters (Nm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InlbToNm(this double value) => Torque.InlbToNm(value);

        /// <summary>
        /// Converts inch-pounds (inlb) to newton-meters (Nm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InlbToNm(this float value) => (float)Torque.InlbToNm(value);

        /// <summary>
        /// Converts inch-pounds (inlb) to kilogram-force meters (kgfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InlbToKgfm(this double value) => Torque.InlbToKgfm(value);

        /// <summary>
        /// Converts inch-pounds (inlb) to kilogram-force meters (kgfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InlbToKgfm(this float value) => (float)Torque.InlbToKgfm(value);

        /// <summary>
        /// Converts inch-pounds (inlb) to foot-pounds (ftlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double InlbToFtlb(this double value) => Torque.InlbToFtlb(value);

        /// <summary>
        /// Converts inch-pounds (inlb) to foot-pounds (ftlb).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float InlbToFtlb(this float value) => (float)Torque.InlbToFtlb(value);
    }
}
