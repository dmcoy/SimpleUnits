namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of volumetric liquid flow.
    /// </summary>
    public static class VolumetricLiquidFlowExtensions
    {
        /// <summary>
        /// Converts a value in liters per second (L/sec) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LsecToLmin(this double value) => VolumetricLiquidFlow.LsecToLmin(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LsecToLmin(this float value) => (float)VolumetricLiquidFlow.LsecToLmin(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LsecToM3hr(this double value) => VolumetricLiquidFlow.LsecToM3hr(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LsecToM3hr(this float value) => (float)VolumetricLiquidFlow.LsecToM3hr(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LsecToFt3min(this double value) => VolumetricLiquidFlow.LsecToFt3min(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LsecToFt3min(this float value) => (float)VolumetricLiquidFlow.LsecToFt3min(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LsecToFt3hr(this double value) => VolumetricLiquidFlow.LsecToFt3hr(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LsecToFt3hr(this float value) => (float)VolumetricLiquidFlow.LsecToFt3hr(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LsecToGalmin(this double value) => VolumetricLiquidFlow.LsecToGalmin(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LsecToGalmin(this float value) => (float)VolumetricLiquidFlow.LsecToGalmin(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LsecToBrld(this double value) => VolumetricLiquidFlow.LsecToBrld(value);

        /// <summary>
        /// Converts a value in liters per second (L/sec) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LsecToBrld(this float value) => (float)VolumetricLiquidFlow.LsecToBrld(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LminToLsec(this double value) => VolumetricLiquidFlow.LminToLsec(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LminToLsec(this float value) => (float)VolumetricLiquidFlow.LminToLsec(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LminToM3hr(this double value) => VolumetricLiquidFlow.LminToM3hr(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LminToM3hr(this float value) => (float)VolumetricLiquidFlow.LminToM3hr(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LminToFt3min(this double value) => VolumetricLiquidFlow.LminToFt3min(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LminToFt3min(this float value) => (float)VolumetricLiquidFlow.LminToFt3min(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LminToFt3hr(this double value) => VolumetricLiquidFlow.LminToFt3hr(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LminToFt3hr(this float value) => (float)VolumetricLiquidFlow.LminToFt3hr(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LminToGalmin(this double value) => VolumetricLiquidFlow.LminToGalmin(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LminToGalmin(this float value) => (float)VolumetricLiquidFlow.LminToGalmin(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LminToBrld(this double value) => VolumetricLiquidFlow.LminToBrld(value);

        /// <summary>
        /// Converts a value in liters per minute (L/min) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LminToBrld(this float value) => (float)VolumetricLiquidFlow.LminToBrld(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3hrToLsec(this double value) => VolumetricLiquidFlow.M3hrToLsec(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3hrToLsec(this float value) => (float)VolumetricLiquidFlow.M3hrToLsec(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3hrToLmin(this double value) => VolumetricLiquidFlow.M3hrToLmin(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3hrToLmin(this float value) => (float)VolumetricLiquidFlow.M3hrToLmin(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3hrToFt3min(this double value) => VolumetricLiquidFlow.M3hrToFt3min(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3hrToFt3min(this float value) => (float)VolumetricLiquidFlow.M3hrToFt3min(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3hrToFt3hr(this double value) => VolumetricLiquidFlow.M3hrToFt3hr(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3hrToFt3hr(this float value) => (float)VolumetricLiquidFlow.M3hrToFt3hr(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3hrToGalmin(this double value) => VolumetricLiquidFlow.M3hrToGalmin(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3hrToGalmin(this float value) => (float)VolumetricLiquidFlow.M3hrToGalmin(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double M3hrToBrld(this double value) => VolumetricLiquidFlow.M3hrToBrld(value);

        /// <summary>
        /// Converts a value in cubic meters per hour (m³/hr) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float M3hrToBrld(this float value) => (float)VolumetricLiquidFlow.M3hrToBrld(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3minToLsec(this double value) => VolumetricLiquidFlow.Ft3minToLsec(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3minToLsec(this float value) => (float)VolumetricLiquidFlow.Ft3minToLsec(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3minToLmin(this double value) => VolumetricLiquidFlow.Ft3minToLmin(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3minToLmin(this float value) => (float)VolumetricLiquidFlow.Ft3minToLmin(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3minToM3hr(this double value) => VolumetricLiquidFlow.Ft3minToM3hr(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3minToM3hr(this float value) => (float)VolumetricLiquidFlow.Ft3minToM3hr(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3minToFt3hr(this double value) => VolumetricLiquidFlow.Ft3minToFt3hr(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3minToFt3hr(this float value) => (float)VolumetricLiquidFlow.Ft3minToFt3hr(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3minToGalmin(this double value) => VolumetricLiquidFlow.Ft3minToGalmin(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3minToGalmin(this float value) => (float)VolumetricLiquidFlow.Ft3minToGalmin(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3minToBrld(this double value) => VolumetricLiquidFlow.Ft3minToBrld(value);

        /// <summary>
        /// Converts a value in cubic feet per minute (ft³/min) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3minToBrld(this float value) => (float)VolumetricLiquidFlow.Ft3minToBrld(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3hrToLsec(this double value) => VolumetricLiquidFlow.Ft3hrToLsec(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3hrToLsec(this float value) => (float)VolumetricLiquidFlow.Ft3hrToLsec(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3hrToLmin(this double value) => VolumetricLiquidFlow.Ft3hrToLmin(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3hrToLmin(this float value) => (float)VolumetricLiquidFlow.Ft3hrToLmin(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3hrToM3hr(this double value) => VolumetricLiquidFlow.Ft3hrToM3hr(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3hrToM3hr(this float value) => (float)VolumetricLiquidFlow.Ft3hrToM3hr(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3hrToFt3min(this double value) => VolumetricLiquidFlow.Ft3hrToFt3min(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3hrToFt3min(this float value) => (float)VolumetricLiquidFlow.Ft3hrToFt3min(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3hrToGalmin(this double value) => VolumetricLiquidFlow.Ft3hrToGalmin(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3hrToGalmin(this float value) => (float)VolumetricLiquidFlow.Ft3hrToGalmin(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Ft3hrToBrld(this double value) => VolumetricLiquidFlow.Ft3hrToBrld(value);

        /// <summary>
        /// Converts a value in cubic feet per hour (ft³/hr) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Ft3hrToBrld(this float value) => (float)VolumetricLiquidFlow.Ft3hrToBrld(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double GalminToLsec(this double value) => VolumetricLiquidFlow.GalminToLsec(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float GalminToLsec(this float value) => (float)VolumetricLiquidFlow.GalminToLsec(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double GalminToLmin(this double value) => VolumetricLiquidFlow.GalminToLmin(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float GalminToLmin(this float value) => (float)VolumetricLiquidFlow.GalminToLmin(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double GalminToM3hr(this double value) => VolumetricLiquidFlow.GalminToM3hr(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float GalminToM3hr(this float value) => (float)VolumetricLiquidFlow.GalminToM3hr(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double GalminToFt3min(this double value) => VolumetricLiquidFlow.GalminToFt3min(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float GalminToFt3min(this float value) => (float)VolumetricLiquidFlow.GalminToFt3min(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double GalminToFt3hr(this double value) => VolumetricLiquidFlow.GalminToFt3hr(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float GalminToFt3hr(this float value) => (float)VolumetricLiquidFlow.GalminToFt3hr(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double GalminToBrld(this double value) => VolumetricLiquidFlow.GalminToBrld(value);

        /// <summary>
        /// Converts a value in US gallons per minute (gal/min) to US barrels per day (US brl/d).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float GalminToBrld(this float value) => (float)VolumetricLiquidFlow.GalminToBrld(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BrldToLsec(this double value) => VolumetricLiquidFlow.BrldToLsec(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to liters per second (L/sec).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BrldToLsec(this float value) => (float)VolumetricLiquidFlow.BrldToLsec(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BrldToLmin(this double value) => VolumetricLiquidFlow.BrldToLmin(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to liters per minute (L/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BrldToLmin(this float value) => (float)VolumetricLiquidFlow.BrldToLmin(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BrldToM3hr(this double value) => VolumetricLiquidFlow.BrldToM3hr(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to cubic meters per hour (m³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BrldToM3hr(this float value) => (float)VolumetricLiquidFlow.BrldToM3hr(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BrldToFt3min(this double value) => VolumetricLiquidFlow.BrldToFt3min(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to cubic feet per minute (ft³/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BrldToFt3min(this float value) => (float)VolumetricLiquidFlow.BrldToFt3min(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BrldToFt3hr(this double value) => VolumetricLiquidFlow.BrldToFt3hr(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to cubic feet per hour (ft³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BrldToFt3hr(this float value) => (float)VolumetricLiquidFlow.BrldToFt3hr(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double BrldToGalmin(this double value) => VolumetricLiquidFlow.BrldToGalmin(value);

        /// <summary>
        /// Converts a value in US barrels per day (US brl/d) to US gallons per minute (gal/min).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float BrldToGalmin(this float value) => (float)VolumetricLiquidFlow.BrldToGalmin(value);
    }
}
