using System;

namespace SimpleUnits
{
    /// <summary>
    /// Provides constants and methods for converting between different units of speed.
    /// </summary>
    public static class Speed
    {

        #region Units

        /// <summary>
        /// Units of speed measurement.
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Meter per second (m/s).
            /// </summary>
            Msec,
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
            Ftsec,
            /// <summary>
            /// Foot per minute (ft/min).
            /// </summary>
            Ftmin,
            /// <summary>
            /// Mile per hour (mph).
            /// </summary>
            Mph
        }

        #endregion

        #region Unit Registration

        /// <summary>
        /// Static constructor to register speed units and conversions with the <see cref="UnitConverter"/>.
        /// </summary>
        static Speed()
        {
            // Register Speed unit
            UnitConverter.RegisterUnit(typeof(Unit), BaseUnit.Speed);

            // m/s conversions
            UnitConverter.RegisterConversion(Unit.Msec, Unit.Mmin, MsecToMmin);
            UnitConverter.RegisterConversion(Unit.Msec, Unit.Kmh, MsecToKmh);
            UnitConverter.RegisterConversion(Unit.Msec, Unit.Ftsec, MsecToFtsec);
            UnitConverter.RegisterConversion(Unit.Msec, Unit.Ftmin, MsecToFtmin);
            UnitConverter.RegisterConversion(Unit.Msec, Unit.Mph, MsecToMph);

            // m/min conversions
            UnitConverter.RegisterConversion(Unit.Mmin, Unit.Msec, MminToMs);
            UnitConverter.RegisterConversion(Unit.Mmin, Unit.Kmh, MminToKmh);
            UnitConverter.RegisterConversion(Unit.Mmin, Unit.Ftsec, MminToFtsec);
            UnitConverter.RegisterConversion(Unit.Mmin, Unit.Ftmin, MminToFtmin);
            UnitConverter.RegisterConversion(Unit.Mmin, Unit.Mph, MminToMph);

            // km/h conversions
            UnitConverter.RegisterConversion(Unit.Kmh, Unit.Msec, KmhToMs);
            UnitConverter.RegisterConversion(Unit.Kmh, Unit.Mmin, KmhToMmin);
            UnitConverter.RegisterConversion(Unit.Kmh, Unit.Ftsec, KmhToFtsec);
            UnitConverter.RegisterConversion(Unit.Kmh, Unit.Ftmin, KmhToFtmin);
            UnitConverter.RegisterConversion(Unit.Kmh, Unit.Mph, KmhToMph);

            // ft/s conversions
            UnitConverter.RegisterConversion(Unit.Ftsec, Unit.Msec, FtsecToMs);
            UnitConverter.RegisterConversion(Unit.Ftsec, Unit.Mmin, FtsecToMmin);
            UnitConverter.RegisterConversion(Unit.Ftsec, Unit.Kmh, FtsecToKmh);
            UnitConverter.RegisterConversion(Unit.Ftsec, Unit.Ftmin, FtsecToFtmin);
            UnitConverter.RegisterConversion(Unit.Ftsec, Unit.Mph, FtsecToMph);

            // ft/min conversions
            UnitConverter.RegisterConversion(Unit.Ftmin, Unit.Msec, FtminToMs);
            UnitConverter.RegisterConversion(Unit.Ftmin, Unit.Mmin, FtminToMmin);
            UnitConverter.RegisterConversion(Unit.Ftmin, Unit.Kmh, FtminToKmh);
            UnitConverter.RegisterConversion(Unit.Ftmin, Unit.Ftsec, FtminToFtsec);
            UnitConverter.RegisterConversion(Unit.Ftmin, Unit.Mph, FtminToMph);

            // mi/h conversions
            UnitConverter.RegisterConversion(Unit.Mph, Unit.Msec, MphToMs);
            UnitConverter.RegisterConversion(Unit.Mph, Unit.Mmin, MphToMmin);
            UnitConverter.RegisterConversion(Unit.Mph, Unit.Kmh, MphToKmh);
            UnitConverter.RegisterConversion(Unit.Mph, Unit.Ftsec, MphToFtsec);
            UnitConverter.RegisterConversion(Unit.Mph, Unit.Ftmin, MphToFtmin);
        }

        #endregion

        #region Conversion Factors

        /// <summary>
        /// Collection of conversion factors for speed units.
        /// </summary>
        public struct Factor
        {
            /// <summary>
            /// Conversion factor from meter per second (m/s) to meter per minute (m/min).
            /// </summary>
            public const double MsecToMmin = 59.988;

            /// <summary>
            /// Conversion factor from meter per second (m/s) to kilometer per hour (km/h).
            /// </summary>
            public const double MsecToKmh = 3.599_712;

            /// <summary>
            /// Conversion factor from meter per second (m/s) to foot per second (ft/s).
            /// </summary>
            public const double MsecToFtsec = 3.280_84;

            /// <summary>
            /// Conversion factor from meter per second (m/s) to foot per minute (ft/min).
            /// </summary>
            public const double MsecToFtmin = 196.850_4;

            /// <summary>
            /// Conversion factor from meter per second (m/s) to mile per hour (mph).
            /// </summary>
            public const double MsecToMph = 2.237_136;

            /// <summary>
            /// Conversion factor from meter per minute (m/min) to meter per second (m/s).
            /// </summary>
            public const double MminToMs = 0.016_67;

            /// <summary>
            /// Conversion factor from meter per minute (m/min) to kilometer per hour (km/h).
            /// </summary>
            public const double MminToKmh = 0.060_007;

            /// <summary>
            /// Conversion factor from meter per minute (m/min) to foot per second (ft/s).
            /// </summary>
            public const double MminToFtsec = 0.054_692;

            /// <summary>
            /// Conversion factor from meter per minute (m/min) to foot per minute (ft/min).
            /// </summary>
            public const double MminToFtmin = 3.281_496;

            /// <summary>
            /// Conversion factor from meter per minute (m/min) to mile per hour (mph).
            /// </summary>
            public const double MminToMph = 0.037_293;

            /// <summary>
            /// Conversion factor from kilometer per hour (km/h) to meter per second (m/s).
            /// </summary>
            public const double KmhToMs = 0.277_8;

            /// <summary>
            /// Conversion factor from kilometer per hour (km/h) to meter per minute (m/min).
            /// </summary>
            public const double KmhToMmin = 16.664_67;

            /// <summary>
            /// Conversion factor from kilometer per hour (km/h) to foot per second (ft/s).
            /// </summary>
            public const double KmhToFtsec = 0.911_417;

            /// <summary>
            /// Conversion factor from kilometer per hour (km/h) to foot per minute (ft/min).
            /// </summary>
            public const double KmhToFtmin = 54.685_04;

            /// <summary>
            /// Conversion factor from kilometer per hour (km/h) to mile per hour (mph).
            /// </summary>
            public const double KmhToMph = 0.621_477;

            /// <summary>
            /// Conversion factor from foot per second (ft/s) to meter per second (m/s).
            /// </summary>
            public const double FtsecToMs = 0.304_8;

            /// <summary>
            /// Conversion factor from foot per second (ft/s) to meter per minute (m/min).
            /// </summary>
            public const double FtsecToMmin = 18.284_34;

            /// <summary>
            /// Conversion factor from foot per second (ft/s) to kilometer per hour (km/h).
            /// </summary>
            public const double FtsecToKmh = 1.097_192;

            /// <summary>
            /// Conversion factor from foot per second (ft/s) to foot per minute (ft/min).
            /// </summary>
            public const double FtsecToFtmin = 60;

            /// <summary>
            /// Conversion factor from foot per second (ft/s) to mile per hour (mph).
            /// </summary>
            public const double FtsecToMph = 0.681_879;

            /// <summary>
            /// Conversion factor from foot per minute (ft/min) to meter per second (m/s).
            /// </summary>
            public const double FtminToMs = 0.005_08;

            /// <summary>
            /// Conversion factor from foot per minute (ft/min) to meter per minute (m/min).
            /// </summary>
            public const double FtminToMmin = 0.304_739;

            /// <summary>
            /// Conversion factor from foot per minute (ft/min) to kilometer per hour (km/h).
            /// </summary>
            public const double FtminToKmh = 0.018_287;

            /// <summary>
            /// Conversion factor from foot per minute (ft/min) to foot per second (ft/s).
            /// </summary>
            public const double FtminToFtsec = 0.016_667;

            /// <summary>
            /// Conversion factor from foot per minute (ft/min) to mile per hour (mph).
            /// </summary>
            public const double FtminToMph = 0.011_365;

            /// <summary>
            /// Conversion factor from mile per hour (mph) to meter per second (m/s).
            /// </summary>
            public const double MphToMs = 0.447;

            /// <summary>
            /// Conversion factor from mile per hour (mph) to meter per minute (m/min).
            /// </summary>
            public const double MphToMmin = 26.814_64;

            /// <summary>
            /// Conversion factor from mile per hour (mph) to kilometer per hour (km/h).
            /// </summary>
            public const double MphToKmh = 1.609_071;

            /// <summary>
            /// Conversion factor from mile per hour (mph) to foot per second (ft/s).
            /// </summary>
            public const double MphToFtsec = 1.466_535;

            /// <summary>
            /// Conversion factor from mile per hour (mph) to foot per minute (ft/min).
            /// </summary>
            public const double MphToFtmin = 87.992_13;
        }

        #endregion

        #region m/s Conversions

        /// <summary>
        /// Converts meter per second (m/s) to meter per minute (m/min).
        /// </summary>
        public static double MsecToMmin(double value) => value * Factor.MsecToMmin;

        /// <summary>
        /// Converts meter per second (m/s) to kilometer per hour (km/h).
        /// </summary>
        public static double MsecToKmh(double value) => value * Factor.MsecToKmh;

        /// <summary>
        /// Converts meter per second (m/s) to foot per second (ft/s).
        /// </summary>
        public static double MsecToFtsec(double value) => value * Factor.MsecToFtsec;

        /// <summary>
        /// Converts meter per second (m/s) to foot per minute (ft/min).
        /// </summary>
        public static double MsecToFtmin(double value) => value * Factor.MsecToFtmin;

        /// <summary>
        /// Converts meter per second (m/s) to mile per hour (mph).
        /// </summary>
        public static double MsecToMph(double value) => value * Factor.MsecToMph;

        #endregion

        #region m/min Conversions

        /// <summary>
        /// Converts meter per minute (m/min) to meter per second (m/s).
        /// </summary>
        public static double MminToMs(double value) => value * Factor.MminToMs;

        /// <summary>
        /// Converts meter per minute (m/min) to kilometer per hour (km/h).
        /// </summary>
        public static double MminToKmh(double value) => value * Factor.MminToKmh;

        /// <summary>
        /// Converts meter per minute (m/min) to foot per second (ft/s).
        /// </summary>
        public static double MminToFtsec(double value) => value * Factor.MminToFtsec;

        /// <summary>
        /// Converts meter per minute (m/min) to foot per minute (ft/min).
        /// </summary>
        public static double MminToFtmin(double value) => value * Factor.MminToFtmin;

        /// <summary>
        /// Converts meter per minute (m/min) to mile per hour (mph).
        /// </summary>
        public static double MminToMph(double value) => value * Factor.MminToMph;

        #endregion

        #region km/h Conversions

        /// <summary
        /// >Converts kilometer per hour (km/h) to meter per second (m/s).
        /// </summary>
        public static double KmhToMs(double value) => value * Factor.KmhToMs;

        /// <summary>
        /// Converts kilometer per hour (km/h) to meter per minute (m/min).
        /// </summary>
        public static double KmhToMmin(double value) => value * Factor.KmhToMmin;

        /// <summary>
        /// Converts kilometer per hour (km/h) to foot per second (ft/s).
        /// </summary>
        public static double KmhToFtsec(double value) => value * Factor.KmhToFtsec;

        /// <summary>
        /// Converts kilometer per hour (km/h) to foot per minute (ft/min).
        /// </summary>
        public static double KmhToFtmin(double value) => value * Factor.KmhToFtmin;

        /// <summary>
        /// Converts kilometer per hour (km/h) to mile per hour (mph).
        /// </summary>
        public static double KmhToMph(double value) => value * Factor.KmhToMph;

        #endregion

        #region ft/s Conversions

        /// <summary>
        /// Converts foot per second (ft/s) to meter per second (m/s).
        /// </summary>
        public static double FtsecToMs(double value) => value * Factor.FtsecToMs;

        /// <summary>
        /// Converts foot per second (ft/s) to meter per minute (m/min).
        /// </summary>
        public static double FtsecToMmin(double value) => value * Factor.FtsecToMmin;

        /// <summary>
        /// Converts foot per second (ft/s) to kilometer per hour (km/h).
        /// </summary>
        public static double FtsecToKmh(double value) => value * Factor.FtsecToKmh;

        /// <summary>
        /// Converts foot per second (ft/s) to foot per minute (ft/min).
        /// </summary>
        public static double FtsecToFtmin(double value) => value * Factor.FtsecToFtmin;

        /// <summary>
        /// Converts foot per second (ft/s) to mile per hour (mph).
        /// </summary>
        public static double FtsecToMph(double value) => value * Factor.FtsecToMph;

        #endregion

        #region  ft/min Conversions

        /// <summary>
        /// Converts foot per minute (ft/min) to meter per second (m/s).
        /// </summary>
        public static double FtminToMs(double value) => value * Factor.FtminToMs;

        /// <summary>
        /// Converts foot per minute (ft/min) to meter per minute (m/min).
        /// </summary>
        public static double FtminToMmin(double value) => value * Factor.FtminToMmin;

        /// <summary>
        /// Converts foot per minute (ft/min) to kilometer per hour (km/h).
        /// </summary>
        public static double FtminToKmh(double value) => value * Factor.FtminToKmh;

        /// <summary>
        /// Converts foot per minute (ft/min) to foot per second (ft/s).
        /// </summary>
        public static double FtminToFtsec(double value) => value * Factor.FtminToFtsec;

        /// <summary>
        /// Converts foot per minute (ft/min) to mile per hour (mph).
        /// </summary>
        public static double FtminToMph(double value) => value * Factor.FtminToMph;

        #endregion

        #region Mph Conversions

        /// <summary>
        /// Converts mile per hour (mph) to meter per second (m/s).
        /// </summary>
        public static double MphToMs(double value) => value * Factor.MphToMs;

        /// <summary>
        /// Converts mile per hour (mph) to meter per minute (m/min).
        /// </summary>
        public static double MphToMmin(double value) => value * Factor.MphToMmin;

        /// <summary>
        /// Converts mile per hour (mph) to kilometer per hour (km/h).
        /// </summary>
        public static double MphToKmh(double value) => value * Factor.MphToKmh;

        /// <summary>
        /// Converts mile per hour (mph) to foot per second (ft/s).
        /// </summary>
        public static double MphToFtsec(double value) => value * Factor.MphToFtsec;

        /// <summary>
        /// Converts mile per hour (mph) to foot per minute (ft/min).
        /// </summary>
        public static double MphToFtmin(double value) => value * Factor.MphToFtmin;

        #endregion

        #region Unit Converter

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
        public static double Convert(double value, Unit from, Unit to) => UnitConverter.Convert(value, from, to);

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
        public static float Convert(float value, Unit from, Unit to) => (float)UnitConverter.Convert(value, from, to);

        #endregion
    }
}
