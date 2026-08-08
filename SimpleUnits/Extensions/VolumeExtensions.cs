namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of volume.
    /// </summary>
    public static class VolumeExtensions
    {
        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Cm3ToM3(this double value) => Volume.Cm3ToM3(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Cm3ToM3(this float value) => (float)Volume.Cm3ToM3(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Cm3ToLtr(this double value) => Volume.Cm3ToLtr(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Cm3ToLtr(this float value) => (float)Volume.Cm3ToLtr(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Cm3ToIn3(this double value) => Volume.Cm3ToIn3(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Cm3ToIn3(this float value) => (float)Volume.Cm3ToIn3(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Cm3ToFt3(this double value) => Volume.Cm3ToFt3(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Cm3ToFt3(this float value) => (float)Volume.Cm3ToFt3(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Cm3ToUSGal(this double value) => Volume.Cm3ToUSGal(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Cm3ToUSGal(this float value) => (float)Volume.Cm3ToUSGal(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Cm3ToImpGal(this double value) => Volume.Cm3ToImpGal(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Cm3ToImpGal(this float value) => (float)Volume.Cm3ToImpGal(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Cm3ToUSBrl(this double value) => Volume.Cm3ToUSBrl(value);

        /// <summary>
        /// Converts a value in cubic centimeters (cm³) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Cm3ToUSBrl(this float value) => (float)Volume.Cm3ToUSBrl(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3ToCm3(this double value) => Volume.M3ToCm3(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3ToCm3(this float value) => (float)Volume.M3ToCm3(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3ToLtr(this double value) => Volume.M3ToLtr(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3ToLtr(this float value) => (float)Volume.M3ToLtr(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3ToIn3(this double value) => Volume.M3ToIn3(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3ToIn3(this float value) => (float)Volume.M3ToIn3(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3ToFt3(this double value) => Volume.M3ToFt3(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3ToFt3(this float value) => (float)Volume.M3ToFt3(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3ToUSGal(this double value) => Volume.M3ToUSGal(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3ToUSGal(this float value) => (float)Volume.M3ToUSGal(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3ToImpGal(this double value) => Volume.M3ToImpGal(value);

        /// <summary>
        /// Converts a value in cubic meters (m³) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3ToImpGal(this float value) => (float)Volume.M3ToImpGal(value);

        /// <summary>
        /// Converts a value in liters (L) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LtrToCm3(this double value) => Volume.LtrToCm3(value);

        /// <summary>
        /// Converts a value in liters (L) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LtrToCm3(this float value) => (float)Volume.LtrToCm3(value);

        /// <summary>
        /// Converts a value in liters (L) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LtrToM3(this double value) => Volume.LtrToM3(value);

        /// <summary>
        /// Converts a value in liters (L) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LtrToM3(this float value) => (float)Volume.LtrToM3(value);

        /// <summary>
        /// Converts a value in liters (L) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LtrToIn3(this double value) => Volume.LtrToIn3(value);

        /// <summary>
        /// Converts a value in liters (L) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LtrToIn3(this float value) => (float)Volume.LtrToIn3(value);

        /// <summary>
        /// Converts a value in liters (L) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LtrToFt3(this double value) => Volume.LtrToFt3(value);

        /// <summary>
        /// Converts a value in liters (L) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LtrToFt3(this float value) => (float)Volume.LtrToFt3(value);

        /// <summary>
        /// Converts a value in liters (L) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LtrToUSGal(this double value) => Volume.LtrToUSGal(value);

        /// <summary>
        /// Converts a value in liters (L) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LtrToUSGal(this float value) => (float)Volume.LtrToUSGal(value);

        /// <summary>
        /// Converts a value in liters (L) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LtrToImpGal(this double value) => Volume.LtrToImpGal(value);

        /// <summary>
        /// Converts a value in liters (L) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LtrToImpGal(this float value) => (float)Volume.LtrToImpGal(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double In3ToCm3(this double value) => Volume.In3ToCm3(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float In3ToCm3(this float value) => (float)Volume.In3ToCm3(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double In3ToM3(this double value) => Volume.In3ToM3(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float In3ToM3(this float value) => (float)Volume.In3ToM3(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double In3ToLtr(this double value) => Volume.In3ToLtr(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float In3ToLtr(this float value) => (float)Volume.In3ToLtr(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double In3ToFt3(this double value) => Volume.In3ToFt3(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float In3ToFt3(this float value) => (float)Volume.In3ToFt3(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double In3ToUSGal(this double value) => Volume.In3ToUSGal(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float In3ToUSGal(this float value) => (float)Volume.In3ToUSGal(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double In3ToImpGal(this double value) => Volume.In3ToImpGal(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float In3ToImpGal(this float value) => (float)Volume.In3ToImpGal(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double In3ToUSBrl(this double value) => Volume.In3ToUSBrl(value);

        /// <summary>
        /// Converts a value in cubic inches (in³) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float In3ToUSBrl(this float value) => (float)Volume.In3ToUSBrl(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3ToCm3(this double value) => Volume.Ft3ToCm3(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3ToCm3(this float value) => (float)Volume.Ft3ToCm3(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3ToM3(this double value) => Volume.Ft3ToM3(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3ToM3(this float value) => (float)Volume.Ft3ToM3(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3ToLtr(this double value) => Volume.Ft3ToLtr(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3ToLtr(this float value) => (float)Volume.Ft3ToLtr(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3ToIn3(this double value) => Volume.Ft3ToIn3(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3ToIn3(this float value) => (float)Volume.Ft3ToIn3(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3ToUSGal(this double value) => Volume.Ft3ToUSGal(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3ToUSGal(this float value) => (float)Volume.Ft3ToUSGal(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3ToImpGal(this double value) => Volume.Ft3ToImpGal(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3ToImpGal(this float value) => (float)Volume.Ft3ToImpGal(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3ToUSBrl(this double value) => Volume.Ft3ToUSBrl(value);

        /// <summary>
        /// Converts a value in cubic feet (ft³) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3ToUSBrl(this float value) => (float)Volume.Ft3ToUSBrl(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USGalToCm3(this double value) => Volume.USGalToCm3(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USGalToCm3(this float value) => (float)Volume.USGalToCm3(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USGalToM3(this double value) => Volume.USGalToM3(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USGalToM3(this float value) => (float)Volume.USGalToM3(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USGalToLtr(this double value) => Volume.USGalToLtr(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USGalToLtr(this float value) => (float)Volume.USGalToLtr(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USGalToIn3(this double value) => Volume.USGalToIn3(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USGalToIn3(this float value) => (float)Volume.USGalToIn3(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USGalToFt3(this double value) => Volume.USGalToFt3(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USGalToFt3(this float value) => (float)Volume.USGalToFt3(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USGalToImpGal(this double value) => Volume.USGalToImpGal(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USGalToImpGal(this float value) => (float)Volume.USGalToImpGal(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USGalToUSBrl(this double value) => Volume.USGalToUSBrl(value);

        /// <summary>
        /// Converts a value in US gallons (US gal) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USGalToUSBrl(this float value) => (float)Volume.USGalToUSBrl(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ImpGalToCm3(this double value) => Volume.ImpGalToCm3(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ImpGalToCm3(this float value) => (float)Volume.ImpGalToCm3(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ImpGalToM3(this double value) => Volume.ImpGalToM3(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ImpGalToM3(this float value) => (float)Volume.ImpGalToM3(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ImpGalToLtr(this double value) => Volume.ImpGalToLtr(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ImpGalToLtr(this float value) => (float)Volume.ImpGalToLtr(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ImpGalToIn3(this double value) => Volume.ImpGalToIn3(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ImpGalToIn3(this float value) => (float)Volume.ImpGalToIn3(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ImpGalToFt3(this double value) => Volume.ImpGalToFt3(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ImpGalToFt3(this float value) => (float)Volume.ImpGalToFt3(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ImpGalToUSGal(this double value) => Volume.ImpGalToUSGal(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ImpGalToUSGal(this float value) => (float)Volume.ImpGalToUSGal(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ImpGalToUSBrl(this double value) => Volume.ImpGalToUSBrl(value);

        /// <summary>
        /// Converts a value in Imperial gallons (Imp gal) to US barrels (oil) (US brl).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ImpGalToUSBrl(this float value) => (float)Volume.ImpGalToUSBrl(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USBrlToCm3(this double value) => Volume.USBrlToCm3(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to cubic centimeters (cm³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USBrlToCm3(this float value) => (float)Volume.USBrlToCm3(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USBrlToM3(this double value) => Volume.USBrlToM3(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to cubic meters (m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USBrlToM3(this float value) => (float)Volume.USBrlToM3(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USBrlToLtr(this double value) => Volume.USBrlToLtr(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to liters (L).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USBrlToLtr(this float value) => (float)Volume.USBrlToLtr(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USBrlToIn3(this double value) => Volume.USBrlToIn3(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to cubic inches (in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USBrlToIn3(this float value) => (float)Volume.USBrlToIn3(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USBrlToFt3(this double value) => Volume.USBrlToFt3(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to cubic feet (ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USBrlToFt3(this float value) => (float)Volume.USBrlToFt3(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USBrlToUSGal(this double value) => Volume.USBrlToUSGal(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to US gallons (US gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USBrlToUSGal(this float value) => (float)Volume.USBrlToUSGal(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double USBrlToImpGal(this double value) => Volume.USBrlToImpGal(value);

        /// <summary>
        /// Converts a value in US barrels (oil) (US brl) to Imperial gallons (Imp gal).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float USBrlToImpGal(this float value) => (float)Volume.USBrlToImpGal(value);
    }
}
