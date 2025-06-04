using System;

namespace SimpleUnits
{
    /// <summary>
    /// Provides constants and methods for converting between different units of torque.
    /// </summary>
    public static class Torque
    {
        /// <summary>
        /// Static constructor to register torque units and conversions with the <see cref="UnitConverter"/>.
        /// </summary>
        static Torque()
        {
            // Register Torque unit
            UnitConverter.RegisterUnit(typeof(TorqueUnit), BaseUnit.Torque);

            // Newton meter conversions
            UnitConverter.RegisterConversion(TorqueUnit.Nm, TorqueUnit.Kgfm, NmToKgfm);
            UnitConverter.RegisterConversion(TorqueUnit.Nm, TorqueUnit.Ftlb, NmToFtlb);
            UnitConverter.RegisterConversion(TorqueUnit.Nm, TorqueUnit.Inlb, NmToInlb);

            // Kilogram-force meter conversions
            UnitConverter.RegisterConversion(TorqueUnit.Kgfm, TorqueUnit.Nm, KgfmToNm);
            UnitConverter.RegisterConversion(TorqueUnit.Kgfm, TorqueUnit.Ftlb, KgfmToFtlb);
            UnitConverter.RegisterConversion(TorqueUnit.Kgfm, TorqueUnit.Inlb, KgfmToInlb);

            // Foot-pound conversions
            UnitConverter.RegisterConversion(TorqueUnit.Ftlb, TorqueUnit.Nm, FtlbToNm);
            UnitConverter.RegisterConversion(TorqueUnit.Ftlb, TorqueUnit.Kgfm, FtlbToKgfm);
            UnitConverter.RegisterConversion(TorqueUnit.Ftlb, TorqueUnit.Inlb, FtlbToInlb);

            // Inch-pound conversions
            UnitConverter.RegisterConversion(TorqueUnit.Inlb, TorqueUnit.Nm, InlbToNm);
            UnitConverter.RegisterConversion(TorqueUnit.Inlb, TorqueUnit.Kgfm, InlbToKgfm);
            UnitConverter.RegisterConversion(TorqueUnit.Inlb, TorqueUnit.Ftlb, InlbToFtlb);
        }

        #region Conversion Factors
        /// <summary>
        /// Collection of conversion factors for torque units.
        /// </summary>
        public struct Factor
        {
            /// <summary>
            /// Conversion factor from newton-meters to kilogram-force meters.
            /// </summary>
            public const double NmToKgfm = 0.101_972;

            /// <summary>
            /// Conversion factor from newton-meters to foot-pounds.
            /// </summary>
            public const double NmToFtlb = 0.737_561;

            /// <summary>
            /// Conversion factor from newton-meters to inch-pounds.
            /// </summary>
            public const double NmToInlb = 8.850_732;

            /// <summary>
            /// Conversion factor from kilogram-force meters to newton-meters.
            /// </summary>
            public const double KgfmToNm = 9.806_65;

            /// <summary>
            /// Conversion factor from kilogram-force meters to foot-pounds.
            /// </summary>
            public const double KgfmToFtlb = 7.233_003;

            /// <summary>
            /// Conversion factor from kilogram-force meters to inch-pounds.
            /// </summary>
            public const double KgfmToInlb = 86.796_03;

            /// <summary>
            /// Conversion factor from foot-pounds to newton-meters.
            /// </summary>
            public const double FtlbToNm = 1.355_82;

            /// <summary>
            /// Conversion factor from foot-pounds to kilogram-force meters.
            /// </summary>
            public const double FtlbToKgfm = 0.138_255;

            /// <summary>
            /// Conversion factor from foot-pounds to inch-pounds.
            /// </summary>
            public const double FtlbToInlb = 12;

            /// <summary>
            /// Conversion factor from inch-pounds to newton-meters.
            /// </summary>
            public const double InlbToNm = 0.112_985;

            /// <summary>
            /// Conversion factor from inch-pounds to kilogram-force meters.
            /// </summary>
            public const double InlbToKgfm = 0.011_521;

            /// <summary>
            /// Conversion factor from inch-pounds to foot-pounds.
            /// </summary>
            public const double InlbToFtlb = 0.083_333;
        }
        #endregion

        // Newton meter conversions

        /// <summary>
        /// Converts newton-meters (Nm) to kilogram-force meters (kgfm).
        /// </summary>
        public static double NmToKgfm(double value) => value * Factor.NmToKgfm;

        /// <summary>
        /// Converts newton-meters (Nm) to foot-pounds (ftlb).
        /// </summary>
        public static double NmToFtlb(double value) => value * Factor.NmToFtlb;

        /// <summary>
        /// Converts newton-meters (Nm) to inch-pounds (inlb).
        /// </summary>
        public static double NmToInlb(double value) => value * Factor.NmToInlb;

        // Kilogram-force meter conversions

        /// <summary>
        /// Converts kilogram-force meters (kgfm) to newton-meters (Nm).
        /// </summary>
        public static double KgfmToNm(double value) => value * Factor.KgfmToNm;

        /// <summary>
        /// Converts kilogram-force meters (kgfm) to foot-pounds (ftlb).
        /// </summary>
        public static double KgfmToFtlb(double value) => value * Factor.KgfmToFtlb;

        /// <summary>
        /// Converts kilogram-force meters (kgfm) to inch-pounds (inlb).
        /// </summary>
        public static double KgfmToInlb(double value) => value * Factor.KgfmToInlb;

        // Foot-pound conversions

        /// <summary>
        /// Converts foot-pounds (ftlb) to newton-meters (Nm).
        /// </summary>
        public static double FtlbToNm(double value) => value * Factor.FtlbToNm;

        /// <summary>
        /// Converts foot-pounds (ftlb) to kilogram-force meters (kgfm).
        /// </summary>
        public static double FtlbToKgfm(double value) => value * Factor.FtlbToKgfm;

        /// <summary>
        /// Converts foot-pounds (ftlb) to inch-pounds (inlb).
        /// </summary>
        public static double FtlbToInlb(double value) => value * Factor.FtlbToInlb;

        // Inch-pound conversions

        /// <summary>
        /// Converts inch-pounds (inlb) to newton-meters (Nm).
        /// </summary>
        public static double InlbToNm(double value) => value * Factor.InlbToNm;

        /// <summary>
        /// Converts inch-pounds (inlb) to kilogram-force meters (kgfm).
        /// </summary>
        public static double InlbToKgfm(double value) => value * Factor.InlbToKgfm;

        /// <summary>
        /// Converts inch-pounds (inlb) to foot-pounds (ftlb).
        /// </summary>
        public static double InlbToFtlb(double value) => value * Factor.InlbToFtlb;

        /// <summary>
        /// Converts a value from one torque unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of torque.</param>
        /// <param name="to">The target unit of torque.</param>
        /// <returns>The converted value in the target unit as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static double Convert(double value, TorqueUnit from, TorqueUnit to)
        {
            return UnitConverter.Convert(value, from, to);
        }

        /// <summary>
        /// Converts a value from one torque unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of torque.</param>
        /// <param name="to">The target unit of torque.</param>
        /// <returns>The converted value in the target unit as a float.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static float Convert(float value, TorqueUnit from, TorqueUnit to)
        {
            return (float)UnitConverter.Convert(value, from, to);
        }
    }

    /// <summary>
    /// Units of torque measurement.
    /// </summary>
    public enum TorqueUnit
    {
        /// <summary>
        /// Newton meters (Nm).
        /// </summary>
        Nm,
        /// <summary>
        /// Kilogram force meters (kgfm).
        /// </summary>
        Kgfm,
        /// <summary>
        /// Foot pounds (ftlb).
        /// </summary>
        Ftlb,
        /// <summary>
        /// Inch pounds (inlb).
        /// </summary>
        Inlb
    }
}
