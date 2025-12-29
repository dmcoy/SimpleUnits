using System;

namespace SimpleUnits
{
    /// <summary>
    /// Provides constants and methods for converting between different units of mass.
    /// </summary>
    public static class Mass
    {

        #region Units

        /// <summary>
        /// Units of mass measurement.
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Grams (g).
            /// </summary>
            G,
            /// <summary>
            /// Kilograms (kg).
            /// </summary>
            Kg,
            /// <summary>
            /// Metric tonnes (tonne).
            /// </summary>
            Tonne,
            /// <summary>
            /// Short ton (shton).
            /// </summary>
            Shton,
            /// <summary>
            /// Long ton (Lton).
            /// </summary>
            Lton,
            /// <summary>
            /// Pounds (lb).
            /// </summary>
            Lb,
            /// <summary>
            /// Ounces (oz).
            /// </summary>
            Oz
        }

        #endregion

        #region Unit Converter Registration

        /// <summary>
        /// Static constructor to register mass units and conversions with the <see cref="UnitConverter"/>.
        /// </summary>
        static Mass()
        {
            // Register Mass unit
            UnitConverter.RegisterUnit(typeof(Unit), BaseUnit.Mass);

            // g conversions
            UnitConverter.RegisterConversion(Unit.G, Unit.Kg, GToKg);
            UnitConverter.RegisterConversion(Unit.G, Unit.Tonne, GToTonne);
            UnitConverter.RegisterConversion(Unit.G, Unit.Shton, GToShton);
            UnitConverter.RegisterConversion(Unit.G, Unit.Lton, GToLton);
            UnitConverter.RegisterConversion(Unit.G, Unit.Lb, GToLb);
            UnitConverter.RegisterConversion(Unit.G, Unit.Oz, GToOz);

            // kg conversions
            UnitConverter.RegisterConversion(Unit.Kg, Unit.G, KgToG);
            UnitConverter.RegisterConversion(Unit.Kg, Unit.Tonne, KgToTonne);
            UnitConverter.RegisterConversion(Unit.Kg, Unit.Shton, KgToShton);
            UnitConverter.RegisterConversion(Unit.Kg, Unit.Lton, KgToLton);
            UnitConverter.RegisterConversion(Unit.Kg, Unit.Lb, KgToLb);
            UnitConverter.RegisterConversion(Unit.Kg, Unit.Oz, KgToOz);

            // tonne conversions
            UnitConverter.RegisterConversion(Unit.Tonne, Unit.G, TonneToG);
            UnitConverter.RegisterConversion(Unit.Tonne, Unit.Kg, TonneToKg);
            UnitConverter.RegisterConversion(Unit.Tonne, Unit.Shton, TonneToShton);
            UnitConverter.RegisterConversion(Unit.Tonne, Unit.Lton, TonneToLton);
            UnitConverter.RegisterConversion(Unit.Tonne, Unit.Lb, TonneToLb);
            UnitConverter.RegisterConversion(Unit.Tonne, Unit.Oz, TonneToOz);

            // short ton conversions
            UnitConverter.RegisterConversion(Unit.Shton, Unit.G, ShtonToG);
            UnitConverter.RegisterConversion(Unit.Shton, Unit.Kg, ShtonToKg);
            UnitConverter.RegisterConversion(Unit.Shton, Unit.Tonne, ShtonToTonne);
            UnitConverter.RegisterConversion(Unit.Shton, Unit.Lton, ShtonToLton);
            UnitConverter.RegisterConversion(Unit.Shton, Unit.Lb, ShtonToLb);
            UnitConverter.RegisterConversion(Unit.Shton, Unit.Oz, ShtonToOz);

            // long ton conversions
            UnitConverter.RegisterConversion(Unit.Lton, Unit.G, LtonToG);
            UnitConverter.RegisterConversion(Unit.Lton, Unit.Kg, LtonToKg);
            UnitConverter.RegisterConversion(Unit.Lton, Unit.Tonne, LtonToTonne);
            UnitConverter.RegisterConversion(Unit.Lton, Unit.Shton, LtonToShton);
            UnitConverter.RegisterConversion(Unit.Lton, Unit.Lb, LtonToLb);
            UnitConverter.RegisterConversion(Unit.Lton, Unit.Oz, LtonToOz);

            // lb conversions
            UnitConverter.RegisterConversion(Unit.Lb, Unit.G, LbToG);
            UnitConverter.RegisterConversion(Unit.Lb, Unit.Kg, LbToKg);
            UnitConverter.RegisterConversion(Unit.Lb, Unit.Tonne, LbToTonne);
            UnitConverter.RegisterConversion(Unit.Lb, Unit.Shton, LbToShton);
            UnitConverter.RegisterConversion(Unit.Lb, Unit.Lton, LbToLton);
            UnitConverter.RegisterConversion(Unit.Lb, Unit.Oz, LbToOz);

            // oz conversions
            UnitConverter.RegisterConversion(Unit.Oz, Unit.G, OzToG);
            UnitConverter.RegisterConversion(Unit.Oz, Unit.Kg, OzToKg);
            UnitConverter.RegisterConversion(Unit.Oz, Unit.Tonne, OzToTonne);
            UnitConverter.RegisterConversion(Unit.Oz, Unit.Shton, OzToShton);
            UnitConverter.RegisterConversion(Unit.Oz, Unit.Lton, OzToLton);
            UnitConverter.RegisterConversion(Unit.Oz, Unit.Lb, OzToLb);
        }

        #endregion

        #region Conversion Factors

        /// <summary>
        /// Collection of conversion factors for mass units.
        /// </summary>
        public struct Factor
        {
            /// <summary>
            /// Conversion factor from grams (g) to kilograms (kg).
            /// </summary>
            public const double GToKg = 0.001;
            /// <summary>
            /// Conversion factor from grams (g) to metric tonnes (tonne).
            /// </summary>
            public const double GToTonne = 0.000001;
            /// <summary>
            /// Conversion factor from grams (g) to short tons (shton).
            /// </summary>
            public const double GToShton = 0.000001;
            /// <summary>
            /// Conversion factor from grams (g) to long tons (Lton).
            /// </summary>
            public const double GToLton = 0.000000984;
            /// <summary>
            /// Conversion factor from grams (g) to pounds (lb).
            /// </summary>
            public const double GToLb = 0.002205;
            /// <summary>
            /// Conversion factor from grams (g) to ounces (oz).
            /// </summary>
            public const double GToOz = 0.035273;

            /// <summary>
            /// Conversion factor from kilograms (kg) to grams (g).
            /// </summary>
            public const double KgToG = 1000;
            /// <summary>
            /// Conversion factor from kilograms (kg) to metric tonnes (tonne).
            /// </summary>
            public const double KgToTonne = 0.001;
            /// <summary>
            /// Conversion factor from kilograms (kg) to short tons (shton).
            /// </summary>
            public const double KgToShton = 0.001102;
            /// <summary>
            /// Conversion factor from kilograms (kg) to long tons (Lton).
            /// </summary>
            public const double KgToLton = 0.000984;
            /// <summary>
            /// Conversion factor from kilograms (kg) to pounds (lb).
            /// </summary>
            public const double KgToLb = 2.204586;
            /// <summary>
            /// Conversion factor from kilograms (kg) to ounces (oz).
            /// </summary>
            public const double KgToOz = 35.27337;

            /// <summary>
            /// Conversion factor from metric tonnes (tonne) to grams (g).
            /// </summary>
            public const double TonneToG = 1000000;
            /// <summary>
            /// Conversion factor from metric tonnes (tonne) to kilograms (kg).
            /// </summary>
            public const double TonneToKg = 1000;
            /// <summary>
            /// Conversion factor from metric tonnes (tonne) to short tons (shton).
            /// </summary>
            public const double TonneToShton = 1.102293;
            /// <summary>
            /// Conversion factor from metric tonnes (tonne) to long tons (Lton).
            /// </summary>
            public const double TonneToLton = 0.984252;
            /// <summary>
            /// Conversion factor from metric tonnes (tonne) to pounds (lb).
            /// </summary>
            public const double TonneToLb = 2204.586;
            /// <summary>
            /// Conversion factor from metric tonnes (tonne) to ounces (oz).
            /// </summary>
            public const double TonneToOz = 35273.37;

            /// <summary>
            /// Conversion factor from short tons (shton) to grams (g).
            /// </summary>
            public const double ShtonToG = 907200;
            /// <summary>
            /// Conversion factor from short tons (shton) to kilograms (kg).
            /// </summary>
            public const double ShtonToKg = 907.2;
            /// <summary>
            /// Conversion factor from short tons (shton) to metric tonnes (tonne).
            /// </summary>
            public const double ShtonToTonne = 0.9072;
            /// <summary>
            /// Conversion factor from short tons (shton) to long tons (Lton).
            /// </summary>
            public const double ShtonToLton = 0.892913;
            /// <summary>
            /// Conversion factor from short tons (shton) to pounds (lb).
            /// </summary>
            public const double ShtonToLb = 2000;
            /// <summary>
            /// Conversion factor from short tons (shton) to ounces (oz).
            /// </summary>
            public const double ShtonToOz = 32000;

            /// <summary>
            /// Conversion factor from long tons (Lton) to grams (g).
            /// </summary>
            public const double LtonToG = 1016000;
            /// <summary>
            /// Conversion factor from long tons (Lton) to kilograms (kg).
            /// </summary>
            public const double LtonToKg = 1016;
            /// <summary>
            /// Conversion factor from long tons (Lton) to metric tonnes (tonne).
            /// </summary>
            public const double LtonToTonne = 1.016;
            /// <summary>
            /// Conversion factor from long tons (Lton) to short tons (shton).
            /// </summary>
            public const double LtonToShton = 1.119929;
            /// <summary>
            /// Conversion factor from long tons (Lton) to pounds (lb).
            /// </summary>
            public const double LtonToLb = 2239.859;
            /// <summary>
            /// Conversion factor from long tons (Lton) to ounces (oz).
            /// </summary>
            public const double LtonToOz = 35837.74;

            /// <summary>
            /// Conversion factor from pounds (lb) to grams (g).
            /// </summary>
            public const double LbToG = 453.6;
            /// <summary>
            /// Conversion factor from pounds (lb) to kilograms (kg).
            /// </summary>
            public const double LbToKg = 0.4536;
            /// <summary>
            /// Conversion factor from pounds (lb) to metric tonnes (tonne).
            /// </summary>
            public const double LbToTonne = 0.000454;
            /// <summary>
            /// Conversion factor from pounds (lb) to short tons (shton).
            /// </summary>
            public const double LbToShton = 0.0005;
            /// <summary>
            /// Conversion factor from pounds (lb) to long tons (Lton).
            /// </summary>
            public const double LbToLton = 0.000446;
            /// <summary>
            /// Conversion factor from pounds (lb) to ounces (oz).
            /// </summary>
            public const double LbToOz = 16;

            /// <summary>
            /// Conversion factor from ounces (oz) to grams (g).
            /// </summary>
            public const double OzToG = 28;
            /// <summary>
            /// Conversion factor from ounces (oz) to kilograms (kg).
            /// </summary>
            public const double OzToKg = 0.02835;
            /// <summary>
            /// Conversion factor from ounces (oz) to metric tonnes (tonne).
            /// </summary>
            public const double OzToTonne = 0.000028;
            /// <summary>
            /// Conversion factor from ounces (oz) to short tons (shton).
            /// </summary>
            public const double OzToShton = 0.000031;
            /// <summary>
            /// Conversion factor from ounces (oz) to long tons (Lton).
            /// </summary>
            public const double OzToLton = 0.000028;
            /// <summary>
            /// Conversion factor from ounces (oz) to pounds (lb).
            /// </summary>
            public const double OzToLb = 0.0625;
        }
        #endregion

        #region Gram Conversions

        /// <summary>Converts grams (g) to kilograms (kg).</summary>
        public static double GToKg(double value) => value * Factor.GToKg;

        /// <summary>Converts grams (g) to metric tonnes (tonne).</summary>
        public static double GToTonne(double value) => value * Factor.GToTonne;

        /// <summary>Converts grams (g) to short tons (shton).</summary>
        public static double GToShton(double value) => value * Factor.GToShton;

        /// <summary>Converts grams (g) to long tons (Lton).</summary>
        public static double GToLton(double value) => value * Factor.GToLton;

        /// <summary>Converts grams (g) to pounds (lb).</summary>
        public static double GToLb(double value) => value * Factor.GToLb;

        /// <summary>Converts grams (g) to ounces (oz).</summary>
        public static double GToOz(double value) => value * Factor.GToOz;

        #endregion

        #region Kilogram Conversions

        /// <summary>Converts kilograms (kg) to grams (g).</summary>
        public static double KgToG(double value) => value * Factor.KgToG;

        /// <summary>Converts kilograms (kg) to metric tonnes (tonne).</summary>
        public static double KgToTonne(double value) => value * Factor.KgToTonne;

        /// <summary>Converts kilograms (kg) to short tons (shton).</summary>
        public static double KgToShton(double value) => value * Factor.KgToShton;

        /// <summary>Converts kilograms (kg) to long tons (Lton).</summary>
        public static double KgToLton(double value) => value * Factor.KgToLton;

        /// <summary>Converts kilograms (kg) to pounds (lb).</summary>
        public static double KgToLb(double value) => value * Factor.KgToLb;

        /// <summary>Converts kilograms (kg) to ounces (oz).</summary>
        public static double KgToOz(double value) => value * Factor.KgToOz;

        #endregion

        #region Tonne Conversions

        /// <summary>Converts metric tonnes (tonne) to grams (g).</summary>
        public static double TonneToG(double value) => value * Factor.TonneToG;

        /// <summary>Converts metric tonnes (tonne) to kilograms (kg).</summary>
        public static double TonneToKg(double value) => value * Factor.TonneToKg;

        /// <summary>Converts metric tonnes (tonne) to short tons (shton).</summary>
        public static double TonneToShton(double value) => value * Factor.TonneToShton;

        /// <summary>Converts metric tonnes (tonne) to long tons (Lton).</summary>
        public static double TonneToLton(double value) => value * Factor.TonneToLton;

        /// <summary>Converts metric tonnes (tonne) to pounds (lb).</summary>
        public static double TonneToLb(double value) => value * Factor.TonneToLb;

        /// <summary>Converts metric tonnes (tonne) to ounces (oz).</summary>
        public static double TonneToOz(double value) => value * Factor.TonneToOz;

        #endregion

        #region Short Ton Conversions

        /// <summary>Converts short tons (shton) to grams (g).</summary>
        public static double ShtonToG(double value) => value * Factor.ShtonToG;

        /// <summary>Converts short tons (shton) to kilograms (kg).</summary>
        public static double ShtonToKg(double value) => value * Factor.ShtonToKg;

        /// <summary>Converts short tons (shton) to metric tonnes (tonne).</summary>
        public static double ShtonToTonne(double value) => value * Factor.ShtonToTonne;

        /// <summary>Converts short tons (shton) to long tons (Lton).</summary>
        public static double ShtonToLton(double value) => value * Factor.ShtonToLton;

        /// <summary>Converts short tons (shton) to pounds (lb).</summary>
        public static double ShtonToLb(double value) => value * Factor.ShtonToLb;

        /// <summary>Converts short tons (shton) to ounces (oz).</summary>
        public static double ShtonToOz(double value) => value * Factor.ShtonToOz;

        #endregion

        #region Long Ton Conversions

        /// <summary>Converts long tons (Lton) to grams (g).</summary>
        public static double LtonToG(double value) => value * Factor.LtonToG;

        /// <summary>Converts long tons (Lton) to kilograms (kg).</summary>
        public static double LtonToKg(double value) => value * Factor.LtonToKg;

        /// <summary>Converts long tons (Lton) to metric tonnes (tonne).</summary>
        public static double LtonToTonne(double value) => value * Factor.LtonToTonne;

        /// <summary>Converts long tons (Lton) to short tons (shton).</summary>
        public static double LtonToShton(double value) => value * Factor.LtonToShton;

        /// <summary>Converts long tons (Lton) to pounds (lb).</summary>
        public static double LtonToLb(double value) => value * Factor.LtonToLb;

        /// <summary>Converts long tons (Lton) to ounces (oz).</summary>
        public static double LtonToOz(double value) => value * Factor.LtonToOz;

        #endregion

        #region Pound Conversions

        /// <summary>Converts pounds (lb) to grams (g).</summary>
        public static double LbToG(double value) => value * Factor.LbToG;

        /// <summary>Converts pounds (lb) to kilograms (kg).</summary>
        public static double LbToKg(double value) => value * Factor.LbToKg;

        /// <summary>Converts pounds (lb) to metric tonnes (tonne).</summary>
        public static double LbToTonne(double value) => value * Factor.LbToTonne;

        /// <summary>Converts pounds (lb) to short tons (shton).</summary>
        public static double LbToShton(double value) => value * Factor.LbToShton;

        /// <summary>Converts pounds (lb) to long tons (Lton).</summary>
        public static double LbToLton(double value) => value * Factor.LbToLton;

        /// <summary>Converts pounds (lb) to ounces (oz).</summary>
        public static double LbToOz(double value) => value * Factor.LbToOz;

        #endregion

        #region Ounce Conversions

        /// <summary>Converts ounces (oz) to grams (g).</summary>
        public static double OzToG(double value) => value * Factor.OzToG;

        /// <summary>Converts ounces (oz) to kilograms (kg).</summary>
        public static double OzToKg(double value) => value * Factor.OzToKg;

        /// <summary>Converts ounces (oz) to metric tonnes (tonne).</summary>
        public static double OzToTonne(double value) => value * Factor.OzToTonne;

        /// <summary>Converts ounces (oz) to short tons (shton).</summary>
        public static double OzToShton(double value) => value * Factor.OzToShton;

        /// <summary>Converts ounces (oz) to long tons (Lton).</summary>
        public static double OzToLton(double value) => value * Factor.OzToLton;

        /// <summary>Converts ounces (oz) to pounds (lb).</summary>
        public static double OzToLb(double value) => value * Factor.OzToLb;

        #endregion

        #region Unit Converter

        /// <summary>
        /// Converts a value from one mass unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of mass.</param>
        /// <param name="to">The target unit of mass.</param>
        /// <returns>The converted value in the target unit as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static double Convert(double value, Unit from, Unit to) => UnitConverter.Convert(value, from, to);

        /// <summary>
        /// Converts a value from one mass unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of mass.</param>
        /// <param name="to">The target unit of mass.</param>
        /// <returns>The converted value in the target unit as a float.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static float Convert(float value, Unit from, Unit to) => (float)UnitConverter.Convert(value, from, to);

        #endregion
    }
}
