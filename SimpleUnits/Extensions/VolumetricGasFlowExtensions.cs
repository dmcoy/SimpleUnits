namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of volumetric gas flow.
    /// </summary>
    public static class VolumetricGasFlowExtensions
    {
        /// <summary>
        /// Converts normal meter cube per hour (Nm³/hr) to standard cubic feet per hour (scfh).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Nm3hrToScfh(this double value) => VolumetricGasFlow.Nm3hrToScfh(value);

        /// <summary>
        /// Converts normal meter cube per hour (Nm³/hr) to standard cubic feet per hour (scfh).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Nm3hrToScfh(this float value) => (float)VolumetricGasFlow.Nm3hrToScfh(value);

        /// <summary>
        /// Converts normal meter cube per hour (Nm³/hr) to standard cubic feet per minute (scfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Nm3hrToScfm(this double value) => VolumetricGasFlow.Nm3hrToScfm(value);

        /// <summary>
        /// Converts normal meter cube per hour (Nm³/hr) to standard cubic feet per minute (scfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Nm3hrToScfm(this float value) => (float)VolumetricGasFlow.Nm3hrToScfm(value);

        /// <summary>
        /// Converts standard cubic feet per hour (scfh) to normal meter cube per hour (Nm³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ScfhToNm3hr(this double value) => VolumetricGasFlow.ScfhToNm3hr(value);

        /// <summary>
        /// Converts standard cubic feet per hour (scfh) to normal meter cube per hour (Nm³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ScfhToNm3hr(this float value) => (float)VolumetricGasFlow.ScfhToNm3hr(value);

        /// <summary>
        /// Converts standard cubic feet per hour (scfh) to standard cubic feet per minute (scfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ScfhToScfm(this double value) => VolumetricGasFlow.ScfhToScfm(value);

        /// <summary>
        /// Converts standard cubic feet per hour (scfh) to standard cubic feet per minute (scfm).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ScfhToScfm(this float value) => (float)VolumetricGasFlow.ScfhToScfm(value);

        /// <summary>
        /// Converts standard cubic feet per minute (scfm) to normal meter cube per hour (Nm³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ScfmToNm3hr(this double value) => VolumetricGasFlow.ScfmToNm3hr(value);

        /// <summary>
        /// Converts standard cubic feet per minute (scfm) to normal meter cube per hour (Nm³/hr).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ScfmToNm3hr(this float value) => (float)VolumetricGasFlow.ScfmToNm3hr(value);

        /// <summary>
        /// Converts standard cubic feet per minute (scfm) to standard cubic feet per hour (scfh).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ScfmToScfh(this double value) => VolumetricGasFlow.ScfmToScfh(value);

        /// <summary>
        /// Converts standard cubic feet per minute (scfm) to standard cubic feet per hour (scfh).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ScfmToScfh(this float value) => (float)VolumetricGasFlow.ScfmToScfh(value);
    }
}
