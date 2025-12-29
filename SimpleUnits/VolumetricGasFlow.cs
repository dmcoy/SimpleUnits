using System;

namespace SimpleUnits
{
    /// <summary>
    /// Provides constants and methods for converting between different units of volumetric gas flow.
    /// </summary>
    public static class VolumetricGasFlow
    {

        /// <summary>
        /// Units of volumetric gas flow measurement.
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Normal meter cube per hour (Nm³/hr).
            /// </summary>
            Nm3hr,
            /// <summary>
            /// Standard cubic feet per hour (scfh).
            /// </summary>
            Scfh,
            /// <summary>
            /// Standard cubic feet per minute (scfm).
            /// </summary>
            Scfm
        }

        /// <summary>
        /// Static constructor to register volumetric gas flow units and conversions with the <see cref="UnitConverter"/>.
        /// </summary>
        static VolumetricGasFlow()
        {
            // Register VolumetricGasFlow unit
            UnitConverter.RegisterUnit(typeof(Unit), BaseUnit.VolumetricGasFlow);

            // Nm³/hr conversions
            UnitConverter.RegisterConversion(Unit.Nm3hr, Unit.Scfh, Nm3hrToScfh);
            UnitConverter.RegisterConversion(Unit.Nm3hr, Unit.Scfm, Nm3hrToScfm);

            // scfh conversions
            UnitConverter.RegisterConversion(Unit.Scfh, Unit.Nm3hr, ScfhToNm3hr);
            UnitConverter.RegisterConversion(Unit.Scfh, Unit.Scfm, ScfhToScfm);

            // scfm conversions
            UnitConverter.RegisterConversion(Unit.Scfm, Unit.Nm3hr, ScfmToNm3hr);
            UnitConverter.RegisterConversion(Unit.Scfm, Unit.Scfh, ScfmToScfh);
        }

        #region Conversion Factors

        /// <summary>
        /// Collection of conversion factors for volumetric gas flow units.
        /// </summary>
        public struct Factor
        {
            /// <summary>
            /// Conversion factor from normal meter cube per hour (Nm³/hr) to standard cubic feet per hour (scfh).
            /// </summary>
            public const double Nm3hrToScfh = 35.310_73;

            /// <summary>
            /// Conversion factor from normal meter cube per hour (Nm³/hr) to standard cubic feet per minute (scfm).
            /// </summary>
            public const double Nm3hrToScfm = 0.588_582;

            /// <summary>
            /// Conversion factor from standard cubic feet per hour (scfh) to normal meter cube per hour (Nm³/hr).
            /// </summary>
            public const double ScfhToNm3hr = 0.028_32;

            /// <summary>
            /// Conversion factor from standard cubic feet per hour (scfh) to standard cubic feet per minute (scfm).
            /// </summary>
            public const double ScfhToScfm = 0.016_669;

            /// <summary>
            /// Conversion factor from standard cubic feet per minute (scfm) to normal meter cube per hour (Nm³/hr).
            /// </summary>
            public const double ScfmToNm3hr = 1.699;

            /// <summary>
            /// Conversion factor from standard cubic feet per minute (scfm) to standard cubic feet per hour (scfh).
            /// </summary>
            public const double ScfmToScfh = 59.992_94;
        }

        #endregion

        #region Nm³/hr Conversions

        /// <summary>
        /// Converts normal meter cube per hour (Nm³/hr) to standard cubic feet per hour (scfh).
        /// </summary>
        public static double Nm3hrToScfh(double value) => value * Factor.Nm3hrToScfh;

        /// <summary>
        /// Converts normal meter cube per hour (Nm³/hr) to standard cubic feet per minute (scfm).
        /// </summary>
        public static double Nm3hrToScfm(double value) => value * Factor.Nm3hrToScfm;

        #endregion

        #region SCFH Conversions

        /// <summary>
        /// Converts standard cubic feet per hour (scfh) to normal meter cube per hour (Nm³/hr).
        /// </summary>
        public static double ScfhToNm3hr(double value) => value * Factor.ScfhToNm3hr;

        /// <summary>
        /// Converts standard cubic feet per hour (scfh) to standard cubic feet per minute (scfm).
        /// </summary>
        public static double ScfhToScfm(double value) => value * Factor.ScfhToScfm;

        #endregion

        #region SCFM Conversions

        /// <summary>
        /// Converts standard cubic feet per minute (scfm) to normal meter cube per hour (Nm³/hr).
        /// </summary>
        public static double ScfmToNm3hr(double value) => value * Factor.ScfmToNm3hr;

        /// <summary>
        /// Converts standard cubic feet per minute (scfm) to standard cubic feet per hour (scfh).
        /// </summary>
        public static double ScfmToScfh(double value) => value * Factor.ScfmToScfh;

        #endregion

        #region Unit Converter

        /// <summary>
        /// Converts a value from one volumetric gas flow unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of volumetric gas flow.</param>
        /// <param name="to">The target unit of volumetric gas flow.</param>
        /// <returns>The converted value in the target unit as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static double Convert(double value, Unit from, Unit to) => UnitConverter.Convert(value, from, to);

        /// <summary>
        /// Converts a value from one volumetric gas flow unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of volumetric gas flow.</param>
        /// <param name="to">The target unit of volumetric gas flow.</param>
        /// <returns>The converted value in the target unit as a float.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static float Convert(float value, Unit from, Unit to) => (float)UnitConverter.Convert(value, from, to);

        #endregion
    }
}
