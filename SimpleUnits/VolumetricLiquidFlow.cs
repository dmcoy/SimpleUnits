using System;

namespace SimpleUnits
{
    /// <summary>
    /// Provides constants and methods for converting between different units of volumetric liquid flow.
    /// </summary>
    public static class VolumetricLiquidFlow
    {

        #region Units

        /// <summary>
        /// Units of volumetric liquid flow measurement.
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Liter per second (L/sec).
            /// </summary>
            Lsec,
            /// <summary>
            /// Liter per minute (L/min).
            /// </summary>
            Lmin,
            /// <summary>
            /// Meter cube per hour (m³/hr).
            /// </summary>
            M3hr,
            /// <summary>
            /// Foot cube per minute (ft³/min).
            /// </summary>
            Ft3min,
            /// <summary>
            /// Foot cube per hour (ft³/hr).
            /// </summary>
            Ft3hr,
            /// <summary>
            /// US gallons per minute (gal/min).
            /// </summary>
            Galmin,
            /// <summary>
            /// US barrels (oil) per day (US brl/d).
            /// </summary>
            Brld
        }

        #endregion

        #region Unit Registration

        /// <summary>
        /// Static constructor to register volumetric liquid flow units and conversions with the <see cref="UnitConverter"/>.
        /// </summary>
        static VolumetricLiquidFlow()
        {
            // Register VolumetricLiquidFlow unit
            UnitConverter.RegisterUnit(typeof(Unit), BaseUnit.VolumetricLiquidFlow);

            // L/sec conversions
            UnitConverter.RegisterConversion(Unit.Lsec, Unit.Lmin, LsecToLmin);
            UnitConverter.RegisterConversion(Unit.Lsec, Unit.M3hr, LsecToM3hr);
            UnitConverter.RegisterConversion(Unit.Lsec, Unit.Ft3min, LsecToFt3min);
            UnitConverter.RegisterConversion(Unit.Lsec, Unit.Ft3hr, LsecToFt3hr);
            UnitConverter.RegisterConversion(Unit.Lsec, Unit.Galmin, LsecToGalmin);
            UnitConverter.RegisterConversion(Unit.Lsec, Unit.Brld, LsecToBrld);

            // L/min conversions
            UnitConverter.RegisterConversion(Unit.Lmin, Unit.Lsec, LminToLsec);
            UnitConverter.RegisterConversion(Unit.Lmin, Unit.M3hr, LminToM3hr);
            UnitConverter.RegisterConversion(Unit.Lmin, Unit.Ft3min, LminToFt3min);
            UnitConverter.RegisterConversion(Unit.Lmin, Unit.Ft3hr, LminToFt3hr);
            UnitConverter.RegisterConversion(Unit.Lmin, Unit.Galmin, LminToGalmin);
            UnitConverter.RegisterConversion(Unit.Lmin, Unit.Brld, LminToBrld);

            // m³/hr conversions
            UnitConverter.RegisterConversion(Unit.M3hr, Unit.Lsec, M3hrToLsec);
            UnitConverter.RegisterConversion(Unit.M3hr, Unit.Lmin, M3hrToLmin);
            UnitConverter.RegisterConversion(Unit.M3hr, Unit.Ft3min, M3hrToFt3min);
            UnitConverter.RegisterConversion(Unit.M3hr, Unit.Ft3hr, M3hrToFt3hr);
            UnitConverter.RegisterConversion(Unit.M3hr, Unit.Galmin, M3hrToGalmin);
            UnitConverter.RegisterConversion(Unit.M3hr, Unit.Brld, M3hrToBrld);

            // ft³/min conversions
            UnitConverter.RegisterConversion(Unit.Ft3min, Unit.Lsec, Ft3minToLsec);
            UnitConverter.RegisterConversion(Unit.Ft3min, Unit.Lmin, Ft3minToLmin);
            UnitConverter.RegisterConversion(Unit.Ft3min, Unit.M3hr, Ft3minToM3hr);
            UnitConverter.RegisterConversion(Unit.Ft3min, Unit.Ft3hr, Ft3minToFt3hr);
            UnitConverter.RegisterConversion(Unit.Ft3min, Unit.Galmin, Ft3minToGalmin);
            UnitConverter.RegisterConversion(Unit.Ft3min, Unit.Brld, Ft3minToBrld);

            // ft³/hr conversions
            UnitConverter.RegisterConversion(Unit.Ft3hr, Unit.Lsec, Ft3hrToLsec);
            UnitConverter.RegisterConversion(Unit.Ft3hr, Unit.Lmin, Ft3hrToLmin);
            UnitConverter.RegisterConversion(Unit.Ft3hr, Unit.M3hr, Ft3hrToM3hr);
            UnitConverter.RegisterConversion(Unit.Ft3hr, Unit.Ft3min, Ft3hrToFt3min);
            UnitConverter.RegisterConversion(Unit.Ft3hr, Unit.Galmin, Ft3hrToGalmin);
            UnitConverter.RegisterConversion(Unit.Ft3hr, Unit.Brld, Ft3hrToBrld);

            // gal/min conversions
            UnitConverter.RegisterConversion(Unit.Galmin, Unit.Lsec, GalminToLsec);
            UnitConverter.RegisterConversion(Unit.Galmin, Unit.Lmin, GalminToLmin);
            UnitConverter.RegisterConversion(Unit.Galmin, Unit.M3hr, GalminToM3hr);
            UnitConverter.RegisterConversion(Unit.Galmin, Unit.Ft3min, GalminToFt3min);
            UnitConverter.RegisterConversion(Unit.Galmin, Unit.Ft3hr, GalminToFt3hr);
            UnitConverter.RegisterConversion(Unit.Galmin, Unit.Brld, GalminToBrld);

            // US brl/d conversions
            UnitConverter.RegisterConversion(Unit.Brld, Unit.Lsec, BrldToLsec);
            UnitConverter.RegisterConversion(Unit.Brld, Unit.Lmin, BrldToLmin);
            UnitConverter.RegisterConversion(Unit.Brld, Unit.M3hr, BrldToM3hr);
            UnitConverter.RegisterConversion(Unit.Brld, Unit.Ft3min, BrldToFt3min);
            UnitConverter.RegisterConversion(Unit.Brld, Unit.Ft3hr, BrldToFt3hr);
            UnitConverter.RegisterConversion(Unit.Brld, Unit.Galmin, BrldToGalmin);
        }

        #endregion

        #region Conversion Factors

        /// <summary>
        /// Collection of conversion factors for volumetric liquid flow units.
        /// </summary>
        public struct Factor
        {
            /// <summary>
            /// Conversion factor from liters per second (L/sec) to liters per minute (L/min).
            /// </summary>
            public const double LsecToLmin = 60;
            /// <summary>
            /// Conversion factor from liters per second (L/sec) to cubic meters per hour (m³/hr).
            /// </summary>
            public const double LsecToM3hr = 3.6;
            /// <summary>
            /// Conversion factor from liters per second (L/sec) to cubic feet per minute (ft³/min).
            /// </summary>
            public const double LsecToFt3min = 2.119_093;
            /// <summary>
            /// Conversion factor from liters per second (L/sec) to cubic feet per hour (ft³/hr).
            /// </summary>
            public const double LsecToFt3hr = 127.119_7;
            /// <summary>
            /// Conversion factor from liters per second (L/sec) to US gallons per minute (gal/min).
            /// </summary>
            public const double LsecToGalmin = 15.850_37;
            /// <summary>
            /// Conversion factor from liters per second (L/sec) to US barrels per day (US brl/d).
            /// </summary>
            public const double LsecToBrld = 543.478_3;

            /// <summary>
            /// Conversion factor from liters per minute (L/min) to liters per second (L/sec).
            /// </summary>
            public const double LminToLsec = 0.0166_66;
            /// <summary>
            /// Conversion factor from liters per minute (L/min) to cubic meters per hour (m³/hr).
            /// </summary>
            public const double LminToM3hr = 0.06;
            /// <summary>
            /// Conversion factor from liters per minute (L/min) to cubic feet per minute (ft³/min).
            /// </summary>
            public const double LminToFt3min = 0.035_317;
            /// <summary>
            /// Conversion factor from liters per minute (L/min) to cubic feet per hour (ft³/hr).
            /// </summary>
            public const double LminToFt3hr = 2.118_577;
            /// <summary>
            /// Conversion factor from liters per minute (L/min) to US gallons per minute (gal/min).
            /// </summary>
            public const double LminToGalmin = 0.264_162;
            /// <summary>
            /// Conversion factor from liters per minute (L/min) to US barrels per day (US brl/d).
            /// </summary>
            public const double LminToBrld = 9.057_609;

            /// <summary>
            /// Conversion factor from cubic meters per hour (m³/hr) to liters per second (L/sec).
            /// </summary>
            public const double M3hrToLsec = 0.277_778;
            /// <summary>
            /// Conversion factor from cubic meters per hour (m³/hr) to liters per minute (L/min).
            /// </summary>
            public const double M3hrToLmin = 16.666_7;
            /// <summary>
            /// Conversion factor from cubic meters per hour (m³/hr) to cubic feet per minute (ft³/min).
            /// </summary>
            public const double M3hrToFt3min = 0.588_637;
            /// <summary>
            /// Conversion factor from cubic meters per hour (m³/hr) to cubic feet per hour (ft³/hr).
            /// </summary>
            public const double M3hrToFt3hr = 35.311_02;
            /// <summary>
            /// Conversion factor from cubic meters per hour (m³/hr) to US gallons per minute (gal/min).
            /// </summary>
            public const double M3hrToGalmin = 4.402_88;
            /// <summary>
            /// Conversion factor from cubic meters per hour (m³/hr) to US barrels per day (US brl/d).
            /// </summary>
            public const double M3hrToBrld = 150.966_1;

            /// <summary>
            /// Conversion factor from cubic feet per minute (ft³/min) to liters per second (L/sec).
            /// </summary>
            public const double Ft3minToLsec = 0.471_9;
            /// <summary>
            /// Conversion factor from cubic feet per minute (ft³/min) to liters per minute (L/min).
            /// </summary>
            public const double Ft3minToLmin = 28.315_13;
            /// <summary>
            /// Conversion factor from cubic feet per minute (ft³/min) to cubic meters per hour (m³/hr).
            /// </summary>
            public const double Ft3minToM3hr = 1.698_84;
            /// <summary>
            /// Conversion factor from cubic feet per minute (ft³/min) to cubic feet per hour (ft³/hr).
            /// </summary>
            public const double Ft3minToFt3hr = 60;
            /// <summary>
            /// Conversion factor from cubic feet per minute (ft³/min) to US gallons per minute (gal/min).
            /// </summary>
            public const double Ft3minToGalmin = 7.479_791;
            /// <summary>
            /// Conversion factor from cubic feet per minute (ft³/min) to US barrels per day (US brl/d).
            /// </summary>
            public const double Ft3minToBrld = 256.467_4;

            /// <summary>
            /// Conversion factor from cubic feet per hour (ft³/hr) to liters per second (L/sec).
            /// </summary>
            public const double Ft3hrToLsec = 0.007_867;
            /// <summary>
            /// Conversion factor from cubic feet per hour (ft³/hr) to liters per minute (L/min).
            /// </summary>
            public const double Ft3hrToLmin = 0.472_015;
            /// <summary>
            /// Conversion factor from cubic feet per hour (ft³/hr) to cubic meters per hour (m³/hr).
            /// </summary>
            public const double Ft3hrToM3hr = 0.028_32;
            /// <summary>
            /// Conversion factor from cubic feet per hour (ft³/hr) to cubic feet per minute (ft³/min).
            /// </summary>
            public const double Ft3hrToFt3min = 0.016_667;
            /// <summary>
            /// Conversion factor from cubic feet per hour (ft³/hr) to US gallons per minute (gal/min).
            /// </summary>
            public const double Ft3hrToGalmin = 0.124_689;
            /// <summary>
            /// Conversion factor from cubic feet per hour (ft³/hr) to US barrels per day (US brl/d).
            /// </summary>
            public const double Ft3hrToBrld = 4.275_326;

            /// <summary>
            /// Conversion factor from US gallons per minute (gal/min) to liters per second (L/sec).
            /// </summary>
            public const double GalminToLsec = 0.063_09;
            /// <summary>
            /// Conversion factor from US gallons per minute (gal/min) to liters per minute (L/min).
            /// </summary>
            public const double GalminToLmin = 3.785_551;
            /// <summary>
            /// Conversion factor from US gallons per minute (gal/min) to cubic meters per hour (m³/hr).
            /// </summary>
            public const double GalminToM3hr = 0.227_124;
            /// <summary>
            /// Conversion factor from US gallons per minute (gal/min) to cubic feet per minute (ft³/min).
            /// </summary>
            public const double GalminToFt3min = 0.133_694;
            /// <summary>
            /// Conversion factor from US gallons per minute (gal/min) to cubic feet per hour (ft³/hr).
            /// </summary>
            public const double GalminToFt3hr = 8.019_983;
            /// <summary>
            /// Conversion factor from US gallons per minute (gal/min) to US barrels per day (US brl/d).
            /// </summary>
            public const double GalminToBrld = 34.288_04;

            /// <summary>
            /// Conversion factor from US barrels per day (US brl/d) to liters per second (L/sec).
            /// </summary>
            public const double BrldToLsec = 0.001_84;
            /// <summary>
            /// Conversion factor from US barrels per day (US brl/d) to liters per minute (L/min).
            /// </summary>
            public const double BrldToLmin = 0.110_404;
            /// <summary>
            /// Conversion factor from US barrels per day (US brl/d) to cubic meters per hour (m³/hr).
            /// </summary>
            public const double BrldToM3hr = 0.006_624;
            /// <summary>
            /// Conversion factor from US barrels per day (US brl/d) to cubic feet per minute (ft³/min).
            /// </summary>
            public const double BrldToFt3min = 0.003_899;
            /// <summary>
            /// Conversion factor from US barrels per day (US brl/d) to cubic feet per hour (ft³/hr).
            /// </summary>
            public const double BrldToFt3hr = 0.233_9;
            /// <summary>
            /// Conversion factor from US barrels per day (US brl/d) to US gallons per minute (gal/min).
            /// </summary>
            public const double BrldToGalmin = 0.029_165;
        }

        #endregion

        #region Liters Per Second Conversions

        /// <summary>
        /// Converts a value in liters per second (L/sec) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value in liters per second.</param>
        /// <returns>The equivalent value in liters per minute.</returns>
        public static double LsecToLmin(double value) => value * Factor.LsecToLmin;

        /// <summary>
        /// Converts a value in liters per second (L/sec) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value in liters per second.</param>
        /// <returns>The equivalent value in cubic meters per hour.</returns>
        public static double LsecToM3hr(double value) => value * Factor.LsecToM3hr;

        /// <summary>
        /// Converts a value in liters per second (L/sec) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value in liters per second.</param>
        /// <returns>The equivalent value in cubic feet per minute.</returns>
        public static double LsecToFt3min(double value) => value * Factor.LsecToFt3min;

        /// <summary>
        /// Converts a value in liters per second (L/sec) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value in liters per second.</param>
        /// <returns>The equivalent value in cubic feet per hour.</returns>
        public static double LsecToFt3hr(double value) => value * Factor.LsecToFt3hr;

        /// <summary>
        /// Converts a value in liters per second (L/sec) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value in liters per second.</param>
        /// <returns>The equivalent value in US gallons per minute.</returns>
        public static double LsecToGalmin(double value) => value * Factor.LsecToGalmin;

        /// <summary>
        /// Converts a value in liters per second (L/sec) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value in liters per second.</param>
        /// <returns>The equivalent value in US barrels per day.</returns>
        public static double LsecToBrld(double value) => value * Factor.LsecToBrld;

        #endregion

        #region Liters Per Minute Conversions

        /// <summary>
        /// Converts a value in liters per minute (L/min) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value in liters per minute.</param>
        /// <returns>The equivalent value in liters per second.</returns>
        public static double LminToLsec(double value) => value * Factor.LminToLsec;

        /// <summary>
        /// Converts a value in liters per minute (L/min) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value in liters per minute.</param>
        /// <returns>The equivalent value in cubic meters per hour.</returns>
        public static double LminToM3hr(double value) => value * Factor.LminToM3hr;

        /// <summary>
        /// Converts a value in liters per minute (L/min) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value in liters per minute.</param>
        /// <returns>The equivalent value in cubic feet per minute.</returns>
        public static double LminToFt3min(double value) => value * Factor.LminToFt3min;

        /// <summary>
        /// Converts a value in liters per minute (L/min) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value in liters per minute.</param>
        /// <returns>The equivalent value in cubic feet per hour.</returns>
        public static double LminToFt3hr(double value) => value * Factor.LminToFt3hr;

        /// <summary>
        /// Converts a value in liters per minute (L/min) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value in liters per minute.</param>
        /// <returns>The equivalent value in US gallons per minute.</returns>
        public static double LminToGalmin(double value) => value * Factor.LminToGalmin;

        /// <summary>
        /// Converts a value in liters per minute (L/min) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value in liters per minute.</param>
        /// <returns>The equivalent value in US barrels per day.</returns>
        public static double LminToBrld(double value) => value * Factor.LminToBrld;

        #endregion

        #region Meters Per Hour Conversions

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value in cubic meters per hour.</param>
        /// <returns>The equivalent value in liters per second.</returns>
        public static double M3hrToLsec(double value) => value * Factor.M3hrToLsec;

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value in cubic meters per hour.</param>
        /// <returns>The equivalent value in liters per minute.</returns>
        public static double M3hrToLmin(double value) => value * Factor.M3hrToLmin;

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value in cubic meters per hour.</param>
        /// <returns>The equivalent value in cubic feet per minute.</returns>
        public static double M3hrToFt3min(double value) => value * Factor.M3hrToFt3min;

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value in cubic meters per hour.</param>
        /// <returns>The equivalent value in cubic feet per hour.</returns>
        public static double M3hrToFt3hr(double value) => value * Factor.M3hrToFt3hr;

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value in cubic meters per hour.</param>
        /// <returns>The equivalent value in US gallons per minute.</returns>
        public static double M3hrToGalmin(double value) => value * Factor.M3hrToGalmin;

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value in cubic meters per hour.</param>
        /// <returns>The equivalent value in US barrels per day.</returns>
        public static double M3hrToBrld(double value) => value * Factor.M3hrToBrld;

        #endregion

        #region Cubic Feet Per Minute Conversions

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value in cubic feet per minute.</param>
        /// <returns>The equivalent value in liters per second.</returns>
        public static double Ft3minToLsec(double value) => value * Factor.Ft3minToLsec;

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value in cubic feet per minute.</param>
        /// <returns>The equivalent value in liters per minute.</returns>
        public static double Ft3minToLmin(double value) => value * Factor.Ft3minToLmin;

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value in cubic feet per minute.</param>
        /// <returns>The equivalent value in cubic meters per hour.</returns>
        public static double Ft3minToM3hr(double value) => value * Factor.Ft3minToM3hr;

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value in cubic feet per minute.</param>
        /// <returns>The equivalent value in cubic feet per hour.</returns>
        public static double Ft3minToFt3hr(double value) => value * Factor.Ft3minToFt3hr;

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value in cubic feet per minute.</param>
        /// <returns>The equivalent value in US gallons per minute.</returns>
        public static double Ft3minToGalmin(double value) => value * Factor.Ft3minToGalmin;

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value in cubic feet per minute.</param>
        /// <returns>The equivalent value in US barrels per day.</returns>
        public static double Ft3minToBrld(double value) => value * Factor.Ft3minToBrld;

        #endregion

        #region Cubic Feet Per Hour Conversions

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value in cubic feet per hour.</param>
        /// <returns>The equivalent value in liters per second.</returns>
        public static double Ft3hrToLsec(double value) => value * Factor.Ft3hrToLsec;

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value in cubic feet per hour.</param>
        /// <returns>The equivalent value in liters per minute.</returns>
        public static double Ft3hrToLmin(double value) => value * Factor.Ft3hrToLmin;

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value in cubic feet per hour.</param>
        /// <returns>The equivalent value in cubic meters per hour.</returns>
        public static double Ft3hrToM3hr(double value) => value * Factor.Ft3hrToM3hr;

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value in cubic feet per hour.</param>
        /// <returns>The equivalent value in cubic feet per minute.</returns>
        public static double Ft3hrToFt3min(double value) => value * Factor.Ft3hrToFt3min;

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value in cubic feet per hour.</param>
        /// <returns>The equivalent value in US gallons per minute.</returns>
        public static double Ft3hrToGalmin(double value) => value * Factor.Ft3hrToGalmin;

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value in cubic feet per hour.</param>
        /// <returns>The equivalent value in US barrels per day.</returns>
        public static double Ft3hrToBrld(double value) => value * Factor.Ft3hrToBrld;

        #endregion

        #region US Gallon Conversions

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value in US gallons per minute.</param>
        /// <returns>The equivalent value in liters per second.</returns>
        public static double GalminToLsec(double value) => value * Factor.GalminToLsec;

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value in US gallons per minute.</param>
        /// <returns>The equivalent value in liters per minute.</returns>
        public static double GalminToLmin(double value) => value * Factor.GalminToLmin;

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value in US gallons per minute.</param>
        /// <returns>The equivalent value in cubic meters per hour.</returns>
        public static double GalminToM3hr(double value) => value * Factor.GalminToM3hr;

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value in US gallons per minute.</param>
        /// <returns>The equivalent value in cubic feet per minute.</returns>
        public static double GalminToFt3min(double value) => value * Factor.GalminToFt3min;

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value in US gallons per minute.</param>
        /// <returns>The equivalent value in cubic feet per hour.</returns>
        public static double GalminToFt3hr(double value) => value * Factor.GalminToFt3hr;

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value in US gallons per minute.</param>
        /// <returns>The equivalent value in US barrels per day.</returns>
        public static double GalminToBrld(double value) => value * Factor.GalminToBrld;

        #endregion

        #region US Barrel Conversions

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value in US barrels per day.</param>
        /// <returns>The equivalent value in liters per second.</returns>
        public static double BrldToLsec(double value) => value * Factor.BrldToLsec;

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value in US barrels per day.</param>
        /// <returns>The equivalent value in liters per minute.</returns>
        public static double BrldToLmin(double value) => value * Factor.BrldToLmin;

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value in US barrels per day.</param>
        /// <returns>The equivalent value in cubic meters per hour.</returns>
        public static double BrldToM3hr(double value) => value * Factor.BrldToM3hr;

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value in US barrels per day.</param>
        /// <returns>The equivalent value in cubic feet per minute.</returns>
        public static double BrldToFt3min(double value) => value * Factor.BrldToFt3min;

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value in US barrels per day.</param>
        /// <returns>The equivalent value in cubic feet per hour.</returns>
        public static double BrldToFt3hr(double value) => value * Factor.BrldToFt3hr;

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value in US barrels per day.</param>
        /// <returns>The equivalent value in US gallons per minute.</returns>
        public static double BrldToGalmin(double value) => value * Factor.BrldToGalmin;

        #endregion

        #region Unit Converter

        /// <summary>
        /// Converts a value from one volumetric liquid flow unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of volumetric liquid flow.</param>
        /// <param name="to">The target unit of volumetric liquid flow.</param>
        /// <returns>The converted value in the target unit as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static double Convert(double value, Unit from, Unit to) => UnitConverter.Convert(value, from, to);

        /// <summary>
        /// Converts a value from one volumetric liquid flow unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of volumetric liquid flow.</param>
        /// <param name="to">The target unit of volumetric liquid flow.</param>
        /// <returns>The converted value in the target unit as a float.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static float Convert(float value, Unit from, Unit to) => (float)UnitConverter.Convert(value, from, to);

        #endregion
    }
}
