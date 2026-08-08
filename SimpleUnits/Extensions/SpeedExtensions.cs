namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of speed.
    /// </summary>
    public static class SpeedExtensions
    {
        /// <summary>
        /// Converts meter per second (m/s) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MsecToMmin(this double value) => Speed.MsecToMmin(value);

        /// <summary>
        /// Converts meter per second (m/s) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MsecToMmin(this float value) => (float)Speed.MsecToMmin(value);

        /// <summary>
        /// Converts meter per second (m/s) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MsecToKmh(this double value) => Speed.MsecToKmh(value);

        /// <summary>
        /// Converts meter per second (m/s) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MsecToKmh(this float value) => (float)Speed.MsecToKmh(value);

        /// <summary>
        /// Converts meter per second (m/s) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MsecToFtsec(this double value) => Speed.MsecToFtsec(value);

        /// <summary>
        /// Converts meter per second (m/s) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MsecToFtsec(this float value) => (float)Speed.MsecToFtsec(value);

        /// <summary>
        /// Converts meter per second (m/s) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MsecToFtmin(this double value) => Speed.MsecToFtmin(value);

        /// <summary>
        /// Converts meter per second (m/s) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MsecToFtmin(this float value) => (float)Speed.MsecToFtmin(value);

        /// <summary>
        /// Converts meter per second (m/s) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MsecToMph(this double value) => Speed.MsecToMph(value);

        /// <summary>
        /// Converts meter per second (m/s) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MsecToMph(this float value) => (float)Speed.MsecToMph(value);

        /// <summary>
        /// Converts meter per minute (m/min) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MminToMs(this double value) => Speed.MminToMs(value);

        /// <summary>
        /// Converts meter per minute (m/min) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MminToMs(this float value) => (float)Speed.MminToMs(value);

        /// <summary>
        /// Converts meter per minute (m/min) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MminToKmh(this double value) => Speed.MminToKmh(value);

        /// <summary>
        /// Converts meter per minute (m/min) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MminToKmh(this float value) => (float)Speed.MminToKmh(value);

        /// <summary>
        /// Converts meter per minute (m/min) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MminToFtsec(this double value) => Speed.MminToFtsec(value);

        /// <summary>
        /// Converts meter per minute (m/min) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MminToFtsec(this float value) => (float)Speed.MminToFtsec(value);

        /// <summary>
        /// Converts meter per minute (m/min) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MminToFtmin(this double value) => Speed.MminToFtmin(value);

        /// <summary>
        /// Converts meter per minute (m/min) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MminToFtmin(this float value) => (float)Speed.MminToFtmin(value);

        /// <summary>
        /// Converts meter per minute (m/min) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MminToMph(this double value) => Speed.MminToMph(value);

        /// <summary>
        /// Converts meter per minute (m/min) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MminToMph(this float value) => (float)Speed.MminToMph(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmhToMs(this double value) => Speed.KmhToMs(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmhToMs(this float value) => (float)Speed.KmhToMs(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmhToMmin(this double value) => Speed.KmhToMmin(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmhToMmin(this float value) => (float)Speed.KmhToMmin(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmhToFtsec(this double value) => Speed.KmhToFtsec(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmhToFtsec(this float value) => (float)Speed.KmhToFtsec(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmhToFtmin(this double value) => Speed.KmhToFtmin(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmhToFtmin(this float value) => (float)Speed.KmhToFtmin(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KmhToMph(this double value) => Speed.KmhToMph(value);

        /// <summary>
        /// Converts kilometer per hour (km/h) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KmhToMph(this float value) => (float)Speed.KmhToMph(value);

        /// <summary>
        /// Converts foot per second (ft/s) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtsecToMs(this double value) => Speed.FtsecToMs(value);

        /// <summary>
        /// Converts foot per second (ft/s) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtsecToMs(this float value) => (float)Speed.FtsecToMs(value);

        /// <summary>
        /// Converts foot per second (ft/s) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtsecToMmin(this double value) => Speed.FtsecToMmin(value);

        /// <summary>
        /// Converts foot per second (ft/s) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtsecToMmin(this float value) => (float)Speed.FtsecToMmin(value);

        /// <summary>
        /// Converts foot per second (ft/s) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtsecToKmh(this double value) => Speed.FtsecToKmh(value);

        /// <summary>
        /// Converts foot per second (ft/s) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtsecToKmh(this float value) => (float)Speed.FtsecToKmh(value);

        /// <summary>
        /// Converts foot per second (ft/s) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtsecToFtmin(this double value) => Speed.FtsecToFtmin(value);

        /// <summary>
        /// Converts foot per second (ft/s) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtsecToFtmin(this float value) => (float)Speed.FtsecToFtmin(value);

        /// <summary>
        /// Converts foot per second (ft/s) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtsecToMph(this double value) => Speed.FtsecToMph(value);

        /// <summary>
        /// Converts foot per second (ft/s) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtsecToMph(this float value) => (float)Speed.FtsecToMph(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtminToMs(this double value) => Speed.FtminToMs(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtminToMs(this float value) => (float)Speed.FtminToMs(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtminToMmin(this double value) => Speed.FtminToMmin(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtminToMmin(this float value) => (float)Speed.FtminToMmin(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtminToKmh(this double value) => Speed.FtminToKmh(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtminToKmh(this float value) => (float)Speed.FtminToKmh(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtminToFtsec(this double value) => Speed.FtminToFtsec(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtminToFtsec(this float value) => (float)Speed.FtminToFtsec(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double FtminToMph(this double value) => Speed.FtminToMph(value);

        /// <summary>
        /// Converts foot per minute (ft/min) to mile per hour (mph).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float FtminToMph(this float value) => (float)Speed.FtminToMph(value);

        /// <summary>
        /// Converts mile per hour (mph) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MphToMs(this double value) => Speed.MphToMs(value);

        /// <summary>
        /// Converts mile per hour (mph) to meter per second (m/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MphToMs(this float value) => (float)Speed.MphToMs(value);

        /// <summary>
        /// Converts mile per hour (mph) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MphToMmin(this double value) => Speed.MphToMmin(value);

        /// <summary>
        /// Converts mile per hour (mph) to meter per minute (m/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MphToMmin(this float value) => (float)Speed.MphToMmin(value);

        /// <summary>
        /// Converts mile per hour (mph) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MphToKmh(this double value) => Speed.MphToKmh(value);

        /// <summary>
        /// Converts mile per hour (mph) to kilometer per hour (km/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MphToKmh(this float value) => (float)Speed.MphToKmh(value);

        /// <summary>
        /// Converts mile per hour (mph) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MphToFtsec(this double value) => Speed.MphToFtsec(value);

        /// <summary>
        /// Converts mile per hour (mph) to foot per second (ft/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MphToFtsec(this float value) => (float)Speed.MphToFtsec(value);

        /// <summary>
        /// Converts mile per hour (mph) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double MphToFtmin(this double value) => Speed.MphToFtmin(value);

        /// <summary>
        /// Converts mile per hour (mph) to foot per minute (ft/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float MphToFtmin(this float value) => (float)Speed.MphToFtmin(value);
    }
}
