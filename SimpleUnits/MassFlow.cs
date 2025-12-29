using System;

namespace SimpleUnits
{
    /// <summary>
    /// Provides constants and methods for converting between different units of mass flow.
    /// </summary>
    public static class MassFlow
    {

        #region Units

        /// <summary>
        /// Units of mass flow measurement.
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Kilogram per hour (kg/h).
            /// </summary>
            Kgh,
            /// <summary>
            /// Pound per hour (lb/h).
            /// </summary>
            Lbh,
            /// <summary>
            /// Kilogram per second (kg/s).
            /// </summary>
            Kgs,
            /// <summary>
            /// Ton per hour (t/h).
            /// </summary>
            Th
        }

        #endregion

        #region Unit Registration

        /// <summary>
        /// Static constructor to register mass flow units and conversions with the <see cref="UnitConverter"/>.
        /// </summary>
        static MassFlow()
        {
            // Register MassFlow unit
            UnitConverter.RegisterUnit(typeof(Unit), BaseUnit.MassFlow);

            // kg/h conversions
            UnitConverter.RegisterConversion(Unit.Kgh, Unit.Lbh, KghToLbh);
            UnitConverter.RegisterConversion(Unit.Kgh, Unit.Kgs, KghToKgs);
            UnitConverter.RegisterConversion(Unit.Kgh, Unit.Th, KghToTh);

            // lb/h conversions
            UnitConverter.RegisterConversion(Unit.Lbh, Unit.Kgh, LbhToKgh);
            UnitConverter.RegisterConversion(Unit.Lbh, Unit.Kgs, LbhToKgs);
            UnitConverter.RegisterConversion(Unit.Lbh, Unit.Th, LbhToTh);

            // kg/s conversions
            UnitConverter.RegisterConversion(Unit.Kgs, Unit.Kgh, KgsToKgh);
            UnitConverter.RegisterConversion(Unit.Kgs, Unit.Lbh, KgsToLbh);
            UnitConverter.RegisterConversion(Unit.Kgs, Unit.Th, KgsToTh);

            // t/h conversions
            UnitConverter.RegisterConversion(Unit.Th, Unit.Kgh, ThToKgh);
            UnitConverter.RegisterConversion(Unit.Th, Unit.Lbh, ThToLbh);
            UnitConverter.RegisterConversion(Unit.Th, Unit.Kgs, ThToKgs);
        }

        #endregion

        #region Conversion Factors

        /// <summary>
        /// Collection of conversion factors
        /// </summary>
        public struct Factor
        {
            /// <summary>
            /// Conversion factor from kilogram per hour (kg/h) to pound per hour (lb/h).
            /// </summary>
            public const double KghToLbh = 2.204_586;
            /// <summary>
            /// Conversion factor from kilogram per hour (kg/h) to kilogram per second (kg/s).
            /// </summary>
            public const double KghToKgs = 0.000_278;
            /// <summary>
            /// Conversion factor from kilogram per hour (kg/h) to ton per hour (t/h).
            /// </summary>
            public const double KghToTh = 0.001;

            /// <summary>
            /// Conversion factor from pound per hour (lb/h) to kilogram per hour (kg/h).
            /// </summary>
            public const double LbhToKgh = 0.453_6;
            /// <summary>
            /// Conversion factor from pound per hour (lb/h) to kilogram per second (kg/s).
            /// </summary>
            public const double LbhToKgs = 0.000_126;
            /// <summary>
            /// Conversion factor from pound per hour (lb/h) to ton per hour (t/h).
            /// </summary>
            public const double LbhToTh = 0.000_454;

            /// <summary>
            /// Conversion factor from kilogram per second (kg/s) to kilogram per hour (kg/h).
            /// </summary>
            public const double KgsToKgh = 3_600;
            /// <summary>
            /// Conversion factor from kilogram per second (kg/s) to pound per hour (lb/h).
            /// </summary>
            public const double KgsToLbh = 7_936.508;
            /// <summary>
            /// Conversion factor from kilogram per second (kg/s) to ton per hour (t/h).
            /// </summary>
            public const double KgsToTh = 3.6;

            /// <summary>
            /// Conversion factor from ton per hour (t/h) to kilogram per hour (kg/h).
            /// </summary>
            public const double ThToKgh = 1_000;
            /// <summary>
            /// Conversion factor from ton per hour (t/h) to pound per hour (lb/h).
            /// </summary>
            public const double ThToLbh = 2_204.586;
            /// <summary>
            /// Conversion factor from ton per hour (t/h) to kilogram per second (kg/s).
            /// </summary>
            public const double ThToKgs = 0.277_778;
        }

        #endregion

        /// <summary>
        /// Converts a value from kilogram per hour (kg/h) to pound per hour (lb/h).
        /// </summary>
        /// <param name="value">The value in kilogram per hour.</param>
        /// <returns>The equivalent value in pound per hour.</returns>
        public static double KghToLbh(double value) => value * Factor.KghToLbh;

        /// <summary>
        /// Converts a value from kilogram per hour (kg/h) to kilogram per second (kg/s).
        /// </summary>
        /// <param name="value">The value in kilogram per hour.</param>
        /// <returns>The equivalent value in kilogram per second.</returns>
        public static double KghToKgs(double value) => value * Factor.KghToKgs;

        /// <summary>
        /// Converts a value from kilogram per hour (kg/h) to ton per hour (t/h).
        /// </summary>
        /// <param name="value">The value in kilogram per hour.</param>
        /// <returns>The equivalent value in ton per hour.</returns>
        public static double KghToTh(double value) => value * Factor.KghToTh;

        /// <summary>
        /// Converts a value from pound per hour (lb/h) to kilogram per hour (kg/h).
        /// </summary>
        /// <param name="value">The value in pound per hour.</param>
        /// <returns>The equivalent value in kilogram per hour.</returns>
        public static double LbhToKgh(double value) => value * Factor.LbhToKgh;

        /// <summary>
        /// Converts a value from pound per hour (lb/h) to kilogram per second (kg/s).
        /// </summary>
        /// <param name="value">The value in pound per hour.</param>
        /// <returns>The equivalent value in kilogram per second.</returns>
        public static double LbhToKgs(double value) => value * Factor.LbhToKgs;

        /// <summary>
        /// Converts a value from pound per hour (lb/h) to ton per hour (t/h).
        /// </summary>
        /// <param name="value">The value in pound per hour.</param>
        /// <returns>The equivalent value in ton per hour.</returns>
        public static double LbhToTh(double value) => value * Factor.LbhToTh;

        /// <summary>
        /// Converts a value from kilogram per second (kg/s) to kilogram per hour (kg/h).
        /// </summary>
        /// <param name="value">The value in kilogram per second.</param>
        /// <returns>The equivalent value in kilogram per hour.</returns>
        public static double KgsToKgh(double value) => value * Factor.KgsToKgh;

        /// <summary>
        /// Converts a value from kilogram per second (kg/s) to pound per hour (lb/h).
        /// </summary>
        /// <param name="value">The value in kilogram per second.</param>
        /// <returns>The equivalent value in pound per hour.</returns>
        public static double KgsToLbh(double value) => value * Factor.KgsToLbh;

        /// <summary>
        /// Converts a value from kilogram per second (kg/s) to ton per hour (t/h).
        /// </summary>
        /// <param name="value">The value in kilogram per second.</param>
        /// <returns>The equivalent value in ton per hour.</returns>
        public static double KgsToTh(double value) => value * Factor.KgsToTh;

        #region Ton per Hour Conversions

        /// <summary>
        /// Converts a value from ton per hour (t/h) to kilogram per hour (kg/h).
        /// </summary>
        /// <param name="value">The value in ton per hour.</param>
        /// <returns>The equivalent value in kilogram per hour.</returns>
        public static double ThToKgh(double value) => value * Factor.ThToKgh;

        /// <summary>
        /// Converts a value from ton per hour (t/h) to pound per hour (lb/h).
        /// </summary>
        /// <param name="value">The value in ton per hour.</param>
        /// <returns>The equivalent value in pound per hour.</returns>
        public static double ThToLbh(double value) => value * Factor.ThToLbh;

        /// <summary>
        /// Converts a value from ton per hour (t/h) to kilogram per second (kg/s).
        /// </summary>
        /// <param name="value">The value in ton per hour.</param>
        /// <returns>The equivalent value in kilogram per second.</returns>
        public static double ThToKgs(double value) => value * Factor.ThToKgs;

        #endregion

        #region Unit Converter

        /// <summary>
        /// Converts a value from one mass flow unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of mass flow.</param>
        /// <param name="to">The target unit of mass flow.</param>
        /// <returns>The converted value in the target unit as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static double Convert(double value, Unit from, Unit to) => UnitConverter.Convert(value, from, to);

        /// <summary>
        /// Converts a value from one mass flow unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of mass flow.</param>
        /// <param name="to">The target unit of mass flow.</param>
        /// <returns>The converted value in the target unit as a float.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static float Convert(float value, Unit from, Unit to) => (float)UnitConverter.Convert(value, from, to);

        #endregion
    }
}
