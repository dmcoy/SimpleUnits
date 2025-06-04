using System;

namespace SimpleUnits
{
    /// <summary>
    /// Provides constants and methods for converting between different units of mass.
    /// </summary>
    public static class Mass
    {
        /// <summary>
        /// Static constructor to register mass units and conversions with the <see cref="UnitConverter"/>.
        /// </summary>
        static Mass()
        {
            // Register Mass unit
            UnitConverter.RegisterUnit(typeof(MassUnit), BaseUnit.Mass);

            // g conversions
            UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Kg, GToKg);
            UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Tonne, GToTonne);
            UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Shton, GToShton);
            UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Lton, GToLton);
            UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Lb, GToLb);
            UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Oz, GToOz);

            // kg conversions
            UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.G, KgToG);
            UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Tonne, KgToTonne);
            UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Shton, KgToShton);
            UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Lton, KgToLton);
            UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Lb, KgToLb);
            UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Oz, KgToOz);

            // tonne conversions
            UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.G, TonneToG);
            UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Kg, TonneToKg);
            UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Shton, TonneToShton);
            UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Lton, TonneToLton);
            UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Lb, TonneToLb);
            UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Oz, TonneToOz);

            // short ton conversions
            UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.G, ShtonToG);
            UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Kg, ShtonToKg);
            UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Tonne, ShtonToTonne);
            UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Lton, ShtonToLton);
            UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Lb, ShtonToLb);
            UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Oz, ShtonToOz);

            // long ton conversions
            UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.G, LtonToG);
            UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Kg, LtonToKg);
            UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Tonne, LtonToTonne);
            UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Shton, LtonToShton);
            UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Lb, LtonToLb);
            UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Oz, LtonToOz);

            // lb conversions
            UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.G, LbToG);
            UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Kg, LbToKg);
            UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Tonne, LbToTonne);
            UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Shton, LbToShton);
            UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Lton, LbToLton);
            UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Oz, LbToOz);

            // oz conversions
            UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.G, OzToG);
            UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Kg, OzToKg);
            UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Tonne, OzToTonne);
            UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Shton, OzToShton);
            UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Lton, OzToLton);
            UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Lb, OzToLb);
        }

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

        // g conversions
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

        // kg conversions
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

        // tonne conversions
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

        // short ton conversions
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

        // long ton conversions
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

        // lb conversions
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

        // oz conversions
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
        public static double Convert(double value, MassUnit from, MassUnit to)
        {
            return UnitConverter.Convert(value, from, to);
        }

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
        public static float Convert(float value, MassUnit from, MassUnit to)
        {
            return (float)UnitConverter.Convert(value, from, to);
        }
    }

    /// <summary>
    /// Units of mass measurement.
    /// </summary>
    public enum MassUnit
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
}
