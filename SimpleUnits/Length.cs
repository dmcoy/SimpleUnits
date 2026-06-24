using System;

namespace SimpleUnits
{
    /// <summary>
    /// Provides constants and methods for converting between different units of length.
    /// </summary>
    /// <remarks>
    /// The <c>Length</c> class defines conversion factors between common length units such as millimeters (mm), centimeters (cm), meters (m), kilometers (km), inches (in), feet (ft), yards (yd), and miles (mi).
    /// It also registers these conversions with the <see cref="UnitConverter"/> and exposes a method to perform conversions between supported units.
    /// </remarks>
    public static class Length
    {

        #region Units

        /// <summary>
        /// Specifies units of length for conversion operations.
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Millimeters (mm).
            /// </summary>
            Mm,
            /// <summary>
            /// Centimeters (cm).
            /// </summary>
            Cm,
            /// <summary>
            /// Meters (m).
            /// </summary>
            M,
            /// <summary>
            /// Kilometers (km).
            /// </summary>
            Km,
            /// <summary>
            /// Inches (in).
            /// </summary>
            In,
            /// <summary>
            /// Feet (ft).
            /// </summary>
            Ft,
            /// <summary>
            /// Yards (yd).
            /// </summary>
            Yd,
            /// <summary>
            /// Miles (mi).
            /// </summary>
            Mi
        }

        #endregion

        #region Unit Converter Registration

        /// <summary>
        /// Static constructor to register length units and conversions with the <see cref="UnitConverter"/>.
        /// </summary>
        static Length()
        {
            // Register Length unit
            UnitConverter.RegisterUnit(typeof(Unit), BaseUnit.Length);

            // Millimeter conversions
            UnitConverter.RegisterConversion(Unit.Mm, Unit.Cm, MmToCm);
            UnitConverter.RegisterConversion(Unit.Mm, Unit.M, MmToM);
            UnitConverter.RegisterConversion(Unit.Mm, Unit.Km, MmToKm);
            UnitConverter.RegisterConversion(Unit.Mm, Unit.In, MmToIn);
            UnitConverter.RegisterConversion(Unit.Mm, Unit.Ft, MmToFt);
            UnitConverter.RegisterConversion(Unit.Mm, Unit.Yd, MmToYd);
            UnitConverter.RegisterConversion(Unit.Mm, Unit.Mi, MmToMi);

            // Centimeter conversions
            UnitConverter.RegisterConversion(Unit.Cm, Unit.Mm, CmToMm);
            UnitConverter.RegisterConversion(Unit.Cm, Unit.M, CmToM);
            UnitConverter.RegisterConversion(Unit.Cm, Unit.Km, CmToKm);
            UnitConverter.RegisterConversion(Unit.Cm, Unit.In, CmToIn);
            UnitConverter.RegisterConversion(Unit.Cm, Unit.Ft, CmToFt);
            UnitConverter.RegisterConversion(Unit.Cm, Unit.Yd, CmToYd);
            UnitConverter.RegisterConversion(Unit.Cm, Unit.Mi, CmToMi);

            // Meter conversions
            UnitConverter.RegisterConversion(Unit.M, Unit.Mm, MToMm);
            UnitConverter.RegisterConversion(Unit.M, Unit.Cm, MToCm);
            UnitConverter.RegisterConversion(Unit.M, Unit.Km, MToKm);
            UnitConverter.RegisterConversion(Unit.M, Unit.In, MToIn);
            UnitConverter.RegisterConversion(Unit.M, Unit.Ft, MToFt);
            UnitConverter.RegisterConversion(Unit.M, Unit.Yd, MToYd);
            UnitConverter.RegisterConversion(Unit.M, Unit.Mi, MToMi);

            // Kilometer conversions
            UnitConverter.RegisterConversion(Unit.Km, Unit.Mm, KmToMm);
            UnitConverter.RegisterConversion(Unit.Km, Unit.Cm, KmToCm);
            UnitConverter.RegisterConversion(Unit.Km, Unit.M, KmToM);
            UnitConverter.RegisterConversion(Unit.Km, Unit.In, KmToIn);
            UnitConverter.RegisterConversion(Unit.Km, Unit.Ft, KmToFt);
            UnitConverter.RegisterConversion(Unit.Km, Unit.Yd, KmToYd);
            UnitConverter.RegisterConversion(Unit.Km, Unit.Mi, KmToMi);

            // Inch conversions
            UnitConverter.RegisterConversion(Unit.In, Unit.Mm, InToMm);
            UnitConverter.RegisterConversion(Unit.In, Unit.Cm, InToCm);
            UnitConverter.RegisterConversion(Unit.In, Unit.M, InToM);
            UnitConverter.RegisterConversion(Unit.In, Unit.Km, InToKm);
            UnitConverter.RegisterConversion(Unit.In, Unit.Ft, InToFt);
            UnitConverter.RegisterConversion(Unit.In, Unit.Yd, InToYd);
            UnitConverter.RegisterConversion(Unit.In, Unit.Mi, InToMi);

            // Feet conversions
            UnitConverter.RegisterConversion(Unit.Ft, Unit.Mm, FtToMm);
            UnitConverter.RegisterConversion(Unit.Ft, Unit.Cm, FtToCm);
            UnitConverter.RegisterConversion(Unit.Ft, Unit.M, FtToM);
            UnitConverter.RegisterConversion(Unit.Ft, Unit.Km, FtToKm);
            UnitConverter.RegisterConversion(Unit.Ft, Unit.In, FtToIn);
            UnitConverter.RegisterConversion(Unit.Ft, Unit.Yd, FtToYd);
            UnitConverter.RegisterConversion(Unit.Ft, Unit.Mi, FtToMi);

            // Yard conversions
            UnitConverter.RegisterConversion(Unit.Yd, Unit.Mm, YdToMm);
            UnitConverter.RegisterConversion(Unit.Yd, Unit.Cm, YdToCm);
            UnitConverter.RegisterConversion(Unit.Yd, Unit.M, YdToM);
            UnitConverter.RegisterConversion(Unit.Yd, Unit.Km, YdToKm);
            UnitConverter.RegisterConversion(Unit.Yd, Unit.In, YdToIn);
            UnitConverter.RegisterConversion(Unit.Yd, Unit.Ft, YdToFt);
            UnitConverter.RegisterConversion(Unit.Yd, Unit.Mi, YdToMi);

            // Mile conversions
            UnitConverter.RegisterConversion(Unit.Mi, Unit.Mm, MiToMm);
            UnitConverter.RegisterConversion(Unit.Mi, Unit.Cm, MiToCm);
            UnitConverter.RegisterConversion(Unit.Mi, Unit.M, MiToM);
            UnitConverter.RegisterConversion(Unit.Mi, Unit.Km, MiToKm);
            UnitConverter.RegisterConversion(Unit.Mi, Unit.In, MiToIn);
            UnitConverter.RegisterConversion(Unit.Mi, Unit.Ft, MiToFt);
            UnitConverter.RegisterConversion(Unit.Mi, Unit.Yd, MiToYd);
        }

        #endregion

        #region Conversion Factors

        /// <summary>
        /// Collection of conversion factors for length units.
        /// </summary>
        public struct Factor
        {
            /// <summary>
            /// Conversion factor from millimeters (mm) to centimeters (cm).
            /// </summary>
            public const double MmToCm = 0.1;
            /// <summary>
            /// Conversion factor from millimeters (mm) to meters (m).
            /// </summary>
            public const double MmToM = 0.001;
            /// <summary>
            /// Conversion factor from millimeters (mm) to kilometers (km).
            /// </summary>
            public const double MmToKm = 0.000_001;
            /// <summary>
            /// Conversion factor from millimeters (mm) to inches (in).
            /// </summary>
            public const double MmToIn = 0.039_37;
            /// <summary>
            /// Conversion factor from millimeters (mm) to feet (ft).
            /// </summary>
            public const double MmToFt = 0.003_281;
            /// <summary>
            /// Conversion factor from millimeters (mm) to yards (yd) (yd).
            /// </summary>
            public const double MmToYd = 0.001_094;
            /// <summary>
            /// Conversion factor from millimeters (mm) to miles (mi).
            /// </summary>
            public const double MmToMi = 6.21e-07;

            /// <summary>
            /// Conversion factor from centimeters (cm) to millimeters (mm).
            /// </summary>
            public const double CmToMm = 10;
            /// <summary>
            /// Conversion factor from centimeters (cm) to meters (m).
            /// </summary>
            public const double CmToM = 0.01;
            /// <summary>
            /// Conversion factor from centimeters (cm) to kilometers (km).
            /// </summary>
            public const double CmToKm = 0.000_1;
            /// <summary>
            /// Conversion factor from centimeters (cm) to inches (in).
            /// </summary>
            public const double CmToIn = 0.393_701;
            /// <summary>
            /// Conversion factor from centimeters (cm) to feet (ft).
            /// </summary>
            public const double CmToFt = 0.032_808;
            /// <summary>
            /// Conversion factor from centimeters (cm) to yards (yd).
            /// </summary>
            public const double CmToYd = 0.010_936;
            /// <summary>
            /// Conversion factor from centimeters (cm) to miles (mi).
            /// </summary>
            public const double CmToMi = 0.000_006;

            /// <summary>
            /// Conversion factor from meters (m) to millimeters (mm).
            /// </summary>
            public const double MToMm = 1_000;
            /// <summary>
            /// Conversion factor from meters (m) to centimeters (cm).
            /// </summary>
            public const double MToCm = 100;
            /// <summary>
            /// Conversion factor from meters (m) to kilometers (km).
            /// </summary>
            public const double MToKm = 0.001;
            /// <summary>
            /// Conversion factor from meters (m) to inches (in).
            /// </summary>
            public const double MToIn = 39.370_08;
            /// <summary>
            /// Conversion factor from meters (m) to feet (ft).
            /// </summary>
            public const double MToFt = 3.280_84;
            /// <summary>
            /// Conversion factor from meters (m) to yards (yd).
            /// </summary>
            public const double MToYd = 1.093_613;
            /// <summary>
            /// Conversion factor from meters (m) to miles (mi).
            /// </summary>
            public const double MToMi = 0.000_621;

            /// <summary>
            /// Conversion factor from kilometers (km) to millimeters (mm).
            /// </summary>
            public const double KmToMm = 1_000_000;
            /// <summary>
            /// Conversion factor from kilometers (km) to centimeters (cm).
            /// </summary>
            public const double KmToCm = 100_000;
            /// <summary>
            /// Conversion factor from kilometers (km) to meters (m).
            /// </summary>
            public const double KmToM = 1_000;
            /// <summary>
            /// Conversion factor from kilometers (km) to inches (in).
            /// </summary>
            public const double KmToIn = 39_370.08;
            /// <summary>
            /// Conversion factor from kilometers (km) to feet (ft).
            /// </summary>
            public const double KmToFt = 3_280.84;
            /// <summary>
            /// Conversion factor from kilometers (km) to yards (yd).
            /// </summary>
            public const double KmToYd = 1_093.613;
            /// <summary>
            /// Conversion factor from kilometers (km) to miles (mi).
            /// </summary>
            public const double KmToMi = 0.621_371;

            /// <summary>
            /// Conversion factor from inches (in) to millimeters (mm).
            /// </summary>
            public const double InToMm = 25.4;
            /// <summary>
            /// Conversion factor from inches (in) to centimeters (cm).
            /// </summary>
            public const double InToCm = 2.54;
            /// <summary>
            /// Conversion factor from inches (in) to meters (m).
            /// </summary>
            public const double InToM = 0.025_4;
            /// <summary>
            /// Conversion factor from inches (in) to kilometers (km).
            /// </summary>
            public const double InToKm = 0.000_025;
            /// <summary>
            /// Conversion factor from inches (in) to feet (ft).
            /// </summary>
            public const double InToFt = 0.083_333;
            /// <summary>
            /// Conversion factor from inches (in) to yards (yd).
            /// </summary>
            public const double InToYd = 0.027_778;
            /// <summary>
            /// Conversion factor from inches (in) to miles (mi).
            /// </summary>
            public const double InToMi = 0.000_016;

            /// <summary>
            /// Conversion factor from feet (ft) to millimeters (mm).
            /// </summary>
            public const double FtToMm = 304.8;
            /// <summary>
            /// Conversion factor from feet (ft) to centimeters (cm).
            /// </summary>
            public const double FtToCm = 30.48;
            /// <summary>
            /// Conversion factor from feet (ft) to meters (m).
            /// </summary>
            public const double FtToM = 0.304_8;
            /// <summary>
            /// Conversion factor from feet (ft) to kilometers (km).
            /// </summary>
            public const double FtToKm = 0.000_304_8;
            /// <summary>
            /// Conversion factor from feet (ft) to inches (in).
            /// </summary>
            public const double FtToIn = 12;
            /// <summary>
            /// Conversion factor from feet (ft) to yards (yd).
            /// </summary>
            public const double FtToYd = 0.333_333;
            /// <summary>
            /// Conversion factor from feet (ft) to miles (mi).
            /// </summary>
            public const double FtToMi = 0.000_189;

            /// <summary>
            /// Conversion factor from yards (yd) to millimeters (mm).
            /// </summary>
            public const double YdToMm = 914.4;
            /// <summary>
            /// Conversion factor from yards (yd) to centimeters (cm).
            /// </summary>
            public const double YdToCm = 91.44;
            /// <summary>
            /// Conversion factor from yards (yd) to meters (m).
            /// </summary>
            public const double YdToM = 0.914_4;
            /// <summary>
            /// Conversion factor from yards (yd) to kilometers (km).
            /// </summary>
            public const double YdToKm = 0.000_914;
            /// <summary>
            /// Conversion factor from yards (yd) to inches (in).
            /// </summary>
            public const double YdToIn = 36;
            /// <summary>
            /// Conversion factor from yards (yd) to feet (ft).
            /// </summary>
            public const double YdToFt = 3;
            /// <summary>
            /// Conversion factor from yards (yd) to miles (mi).
            /// </summary>
            public const double YdToMi = 0.000_568;

            /// <summary>
            /// Conversion factor from miles (mi) to millimeters (mm).
            /// </summary>
            public const double MiToMm = 1_609_344;
            /// <summary>
            /// Conversion factor from miles (mi) to centimeters (cm).
            /// </summary>
            public const double MiToCm = 160_934.4;
            /// <summary>
            /// Conversion factor from miles (mi) to meters (m).
            /// </summary>
            public const double MiToM = 1_609.344;
            /// <summary>
            /// Conversion factor from miles (mi) to kilometers (km).
            /// </summary>
            public const double MiToKm = 1.609_344;
            /// <summary>
            /// Conversion factor from miles (mi) to inches (in).
            /// </summary>
            public const double MiToIn = 63_360;
            /// <summary>
            /// Conversion factor from miles (mi) to feet (ft).
            /// </summary>
            public const double MiToFt = 5_280;
            /// <summary>
            /// Conversion factor from miles (mi) to yards (yd).
            /// </summary>
            public const double MiToYd = 1_760;
        }

        #endregion

        #region Millimeter conversions

        /// <summary>
        /// Converts a value from millimeters (mm) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value in millimeters (mm).</param>
        /// <returns>The equivalent value in centimeters (cm).</returns>
        public static double MmToCm(double value) => value * Factor.MmToCm;

        /// <summary>
        /// Converts a value from millimeters (mm) to meters (m).
        /// </summary>
        /// <param name="value">The value in millimeters (mm).</param>
        /// <returns>The equivalent value in meters (m).</returns>
        public static double MmToM(double value) => value * Factor.MmToM;

        /// <summary>
        /// Converts a value from millimeters (mm) to kilometers (km).
        /// </summary>
        /// <param name="value">The value in millimeters (mm).</param>
        /// <returns>The equivalent value in kilometers (km).</returns>
        public static double MmToKm(double value) => value * Factor.MmToKm;

        /// <summary>
        /// Converts a value from millimeters (mm) to inches (in).
        /// </summary>
        /// <param name="value">The value in millimeters (mm).</param>
        /// <returns>The equivalent value in inches (in).</returns>
        public static double MmToIn(double value) => value * Factor.MmToIn;

        /// <summary>
        /// Converts a value from millimeters (mm) to feet (ft).
        /// </summary>
        /// <param name="value">The value in millimeters (mm).</param>
        /// <returns>The equivalent value in feet (ft).</returns>
        public static double MmToFt(double value) => value * Factor.MmToFt;

        /// <summary>
        /// Converts a value from millimeters (mm) to yards (yd).
        /// </summary>
        /// <param name="value">The value in millimeters (mm).</param>
        /// <returns>The equivalent value in yards (yd).</returns>
        public static double MmToYd(double value) => value * Factor.MmToYd;

        /// <summary>
        /// Converts a value from millimeters (mm) to miles (mi).
        /// </summary>
        /// <param name="value">The value in millimeters (mm).</param>
        /// <returns>The equivalent value in miles (mi).</returns>
        public static double MmToMi(double value) => value * Factor.MmToMi;

        #endregion

        #region Centimeter conversions

        /// <summary>
        /// Converts a value from centimeters (cm) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value in centimeters (m).</param>
        /// <returns>The equivalent value in millimeters (mm).</returns>
        public static double CmToMm(double value) => value * Factor.CmToMm;

        /// <summary>
        /// Converts a value from centimeters (cm) to meters (m).
        /// </summary>
        /// <param name="value">The value in centimeters (m).</param>
        /// <returns>The equivalent value in meters (m).</returns>
        public static double CmToM(double value) => value * Factor.CmToM;

        /// <summary>
        /// Converts a value from centimeters (cm) to kilometers (km).
        /// </summary>
        /// <param name="value">The value in centimeters (m).</param>
        /// <returns>The equivalent value in kilometers (km).</returns>
        public static double CmToKm(double value) => value * Factor.CmToKm;

        /// <summary>
        /// Converts a value from centimeters (cm) to inches (in).
        /// </summary>
        /// <param name="value">The value in centimeters (cm).</param>
        /// <returns>The equivalent value in inches (in).</returns>
        public static double CmToIn(double value) => value * Factor.CmToIn;

        /// <summary>
        /// Converts a value from centimeters (cm) to feet (ft).
        /// </summary>
        /// <param name="value">The value in centimeters (cm).</param>
        /// <returns>The equivalent value in feet (ft).</returns>
        public static double CmToFt(double value) => value * Factor.CmToFt;

        /// <summary>
        /// Converts a value from centimeters (cm) to yards (yd).
        /// </summary>
        /// <param name="value">The value in centimeters (cm).</param>
        /// <returns>The equivalent value in yards (yd).</returns>
        public static double CmToYd(double value) => value * Factor.CmToYd;

        /// <summary>
        /// Converts a value from centimeters (cm) to miles (mi).
        /// </summary>
        /// <param name="value">The value in centimeters (cm).</param>
        /// <returns>The equivalent value in miles (mi).</returns>
        public static double CmToMi(double value) => value * Factor.CmToMi;

        #endregion

        #region Meter conversions

        /// <summary>
        /// Converts a value from meters (m) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value in meters (m).</param>
        /// <returns>The equivalent value in millimeters (mm).</returns>
        public static double MToMm(double value) => value * Factor.MToMm;

        /// <summary>
        /// Converts a value from meters (m) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value in meters (m).</param>
        /// <returns>The equivalent value in centimeters (cm).</returns>
        public static double MToCm(double value) => value * Factor.MToCm;

        /// <summary>
        /// Converts a value from meters (m) to kilometers (km).
        /// </summary>
        /// <param name="value">The value in meters (m).</param>
        /// <returns>The equivalent value in kilometers (km).</returns>
        public static double MToKm(double value) => value * Factor.MToKm;

        /// <summary>
        /// Converts a value from meters (m) to inches (in).
        /// </summary>
        /// <param name="value">The value in meters (m).</param>
        /// <returns>The equivalent value in inches (in).</returns>
        public static double MToIn(double value) => value * Factor.MToIn;

        /// <summary>
        /// Converts a value from meters (m) to feet (ft).
        /// </summary>
        /// <param name="value">The value in meters (m).</param>
        /// <returns>The equivalent value in feet (ft).</returns>
        public static double MToFt(double value) => value * Factor.MToFt;

        /// <summary>
        /// Converts a value from meters (m) to yards (yd).
        /// </summary>
        /// <param name="value">The value in meters (m).</param>
        /// <returns>The equivalent value in yards (yd).</returns>
        public static double MToYd(double value) => value * Factor.MToYd;

        /// <summary>
        /// Converts a value from meters (m) to miles (mi).
        /// </summary>
        /// <param name="value">The value in meters (m).</param>
        /// <returns>The equivalent value in miles (mi).</returns>
        public static double MToMi(double value) => value * Factor.MToMi;

        #endregion

        #region Kilometer conversions

        /// <summary>
        /// Converts a value from kilometers (km) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value in kilometers (km).</param>
        /// <returns>The equivalent value in millimeters (mm).</returns>
        public static double KmToMm(double value) => value * Factor.KmToMm;

        /// <summary>
        /// Converts a value from kilometers (km) to centimeters (m).
        /// </summary>
        /// <param name="value">The value in kilometers (km).</param>
        /// <returns>The equivalent value in centimeters (m).</returns>
        public static double KmToCm(double value) => value * Factor.KmToCm;

        /// <summary>
        /// Converts a value from kilometers (km) to meters (m).
        /// </summary>
        /// <param name="value">The value in kilometers (km).</param>
        /// <returns>The equivalent value in meters (m).</returns>
        public static double KmToM(double value) => value * Factor.KmToM;

        /// <summary>
        /// Converts a value from kilometers (km) to inches (in).
        /// </summary>
        /// <param name="value">The value in kilometers (km).</param>
        /// <returns>The equivalent value in inches (in).</returns>
        public static double KmToIn(double value) => value * Factor.KmToIn;

        /// <summary>
        /// Converts a value from kilometers (km) to feet (ft).
        /// </summary>
        /// <param name="value">The value in kilometers (km).</param>
        /// <returns>The equivalent value in feet (ft).</returns>
        public static double KmToFt(double value) => value * Factor.KmToFt;

        /// <summary>
        /// Converts a value from kilometers (km) to yards (yd).
        /// </summary>
        /// <param name="value">The value in kilometers (km).</param>
        /// <returns>The equivalent value in yards (yd).</returns>
        public static double KmToYd(double value) => value * Factor.KmToYd;

        /// <summary>
        /// Converts a value from kilometers (km) to miles (mi).
        /// </summary>
        /// <param name="value">The value in kilometers (km).</param>
        /// <returns>The equivalent value in miles (mi).</returns>
        public static double KmToMi(double value) => value * Factor.KmToMi;

        #endregion

        #region Inch conversions

        /// <summary>
        /// Converts a value from inches (in) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value in inches (in).</param>
        /// <returns>The equivalent value in millimeters (mm).</returns>
        public static double InToMm(double value) => value * Factor.InToMm;

        /// <summary>
        /// Converts a value from inches (in) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value in inches (in).</param>
        /// <returns>The equivalent value in centimeters (cm).</returns>
        public static double InToCm(double value) => value * Factor.InToCm;

        /// <summary>
        /// Converts a value from inches (in) to meters (m).
        /// </summary>
        /// <param name="value">The value in inches (in).</param>
        /// <returns>The equivalent value in meters (m).</returns>
        public static double InToM(double value) => value * Factor.InToM;

        /// <summary>
        /// Converts a value from inches (in) to kilometers (km).
        /// </summary>
        /// <param name="value">The value in inches (in).</param>
        /// <returns>The equivalent value in kilometers (km).</returns>
        public static double InToKm(double value) => value * Factor.InToKm;

        /// <summary>
        /// Converts a value from inches (in) to feet (ft).
        /// </summary>
        /// <param name="value">The value in inches (in).</param>
        /// <returns>The equivalent value in feet (ft).</returns>
        public static double InToFt(double value) => value % Factor.FtToIn == 0 ? Math.Round(value * Factor.InToFt) : value * Factor.InToFt;

        /// <summary>
        /// Converts a value from inches (in) to yards (yd).
        /// </summary>
        /// <param name="value">The value in inches (in).</param>
        /// <returns>The equivalent value in yards (yd).</returns>
        public static double InToYd(double value) => value % Factor.YdToIn == 0 ? Math.Round(value * Factor.InToYd) : value * Factor.InToYd;

        /// <summary>
        /// Converts a value from inches (in) to miles (mi).
        /// </summary>
        /// <param name="value">The value in inches (in).</param>
        /// <returns>The equivalent value in miles (mi).</returns>
        public static double InToMi(double value) => value % Factor.MiToIn == 0 ? Math.Round(value * Factor.InToMi) : value * Factor.InToMi;

        #endregion

        #region Feet conversions

        /// <summary>
        /// Converts a value from feet (ft) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value in feet (ft).</param>
        /// <returns>The equivalent value in millimeters (mm).</returns>
        public static double FtToMm(double value) => value * Factor.FtToMm;

        /// <summary>
        /// Converts a value from feet (ft) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value in feet (ft).</param>
        /// <returns>The equivalent value in centimeters (cm).</returns>
        public static double FtToCm(double value) => value * Factor.FtToCm;

        /// <summary>
        /// Converts a value from feet (ft) to meters (m).
        /// </summary>
        /// <param name="value">The value in feet (ft).</param>
        /// <returns>The equivalent value in meters (m).</returns>
        public static double FtToM(double value) => value * Factor.FtToM;

        /// <summary>
        /// Converts a value from feet (ft) to kilometers (km).
        /// </summary>
        /// <param name="value">The value in feet (ft).</param>
        /// <returns>The equivalent value in kilometers (km).</returns>
        public static double FtToKm(double value) => value * Factor.FtToKm;

        /// <summary>
        /// Converts a value from feet (ft) to inches (in).
        /// </summary>
        /// <param name="value">The value in feet (ft).</param>
        /// <returns>The equivalent value in inches (in).</returns>
        public static double FtToIn(double value) => value * Factor.FtToIn;

        /// <summary>
        /// Converts a value from feet (ft) to yards (yd).
        /// </summary>
        /// <param name="value">The value in feet (ft).</param>
        /// <returns>The equivalent value in yards (yd).</returns>
        public static double FtToYd(double value) => value % Factor.YdToFt == 0 ? Math.Round(value * Factor.FtToYd) : value * Factor.FtToYd;

        /// <summary>
        /// Converts a value from feet (ft) to miles (mi).
        /// </summary>
        /// <param name="value">The value in feet (ft).</param>
        /// <returns>The equivalent value in miles (mi).</returns>
        public static double FtToMi(double value) => value % Factor.MiToFt == 0 ? Math.Round(value * Factor.FtToMi) : value * Factor.FtToMi;

        #endregion

        #region Yard conversions

        /// <summary>
        /// Converts a value from yards (yd) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value in yards (yd).</param>
        /// <returns>The equivalent value in millimeters (mm).</returns>
        public static double YdToMm(double value) => value * Factor.YdToMm;

        /// <summary>
        /// Converts a value from yards (yd) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value in yards (yd).</param>
        /// <returns>The equivalent value in centimeters (cm).</returns>
        public static double YdToCm(double value) => value * Factor.YdToCm;

        /// <summary>
        /// Converts a value from yards (yd) to meters (m).
        /// </summary>
        /// <param name="value">The value in yards (yd).</param>
        /// <returns>The equivalent value in meters (m).</returns>
        public static double YdToM(double value) => value * Factor.YdToM;

        /// <summary>
        /// Converts a value from yards (yd) to kilometers (km).
        /// </summary>
        /// <param name="value">The value in yards (yd).</param>
        /// <returns>The equivalent value in kilometers (km).</returns>
        public static double YdToKm(double value) => value * Factor.YdToKm;

        /// <summary>
        /// Converts a value from yards (yd) to inches (in).
        /// </summary>
        /// <param name="value">The value in yards (yd).</param>
        /// <returns>The equivalent value in inches (in).</returns>
        public static double YdToIn(double value) => value * Factor.YdToIn;

        /// <summary>
        /// Converts a value from yards (yd) to feet (ft).
        /// </summary>
        /// <param name="value">The value in yards (yd).</param>
        /// <returns>The equivalent value in feet (ft).</returns>
        public static double YdToFt(double value) => value * Factor.YdToFt;

        /// <summary>
        /// Converts a value from yards (yd) to miles (mi).
        /// </summary>
        /// <param name="value">The value in yards (yd).</param>
        /// <returns>The equivalent value in miles (mi).</returns>
        public static double YdToMi(double value) => value % Factor.MiToYd == 0 ? Math.Round(value * Factor.YdToMi) : value * Factor.YdToMi;

        #endregion

        #region Mile conversions

        /// <summary>
        /// Converts a value from miles (mi) to millimeters (mm).
        /// </summary>
        /// <param name="value">The value in miles (mi).</param>
        /// <returns>The equivalent value in millimeters (mm).</returns>
        public static double MiToMm(double value) => value * Factor.MiToMm;

        /// <summary>
        /// Converts a value from miles (mi) to centimeters (cm).
        /// </summary>
        /// <param name="value">The value in miles (mi).</param>
        /// <returns>The equivalent value in centimeters (cm).</returns>
        public static double MiToCm(double value) => value * Factor.MiToCm;

        /// <summary>
        /// Converts a value from miles (mi) to meters (m).
        /// </summary>
        /// <param name="value">The value in miles (mi).</param>
        /// <returns>The equivalent value in meters (m).</returns>
        public static double MiToM(double value) => value * Factor.MiToM;

        /// <summary>
        /// Converts a value from miles (mi) to kilometers (km).
        /// </summary>
        /// <param name="value">The value in miles (mi).</param>
        /// <returns>The equivalent value in kilometers (km).</returns>
        public static double MiToKm(double value) => value * Factor.MiToKm;

        /// <summary>
        /// Converts a value from miles (mi) to inches (in).
        /// </summary>
        /// <param name="value">The value in miles (mi).</param>
        /// <returns>The equivalent value in inches (in).</returns>
        public static double MiToIn(double value) => value * Factor.MiToIn;

        /// <summary>
        /// Converts a value from miles (mi) to feet (ft).
        /// </summary>
        /// <param name="value">The value in miles (mi).</param>
        /// <returns>The equivalent value in feet (ft).</returns>
        public static double MiToFt(double value) => value * Factor.MiToFt;

        /// <summary>
        /// Converts a value from miles (mi) to yards (yd).
        /// </summary>
        /// <param name="value">The value in miles (mi).</param>
        /// <returns>The equivalent value in yards (yd).</returns>
        public static double MiToYd(double value) => value * Factor.MiToYd;

        #endregion

        #region Unit Converter

        /// <summary>
        /// Converts a value from one length unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of length.</param>
        /// <param name="to">The target unit of length.</param>
        /// <returns>The converted value in the target unit as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static double Convert(double value, Unit from, Unit to) => UnitConverter.Convert(value, from, to);

        /// <summary>
        /// Converts a value from one length unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of length.</param>
        /// <param name="to">The target unit of length.</param>
        /// <returns>The converted value in the target unit as a float.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static float Convert(float value, Unit from, Unit to) => (float)UnitConverter.Convert(value, from, to);

        #endregion
    }
}
