using System;

namespace SimpleUnits
{
    /// <summary>
    /// Provides constants and methods for converting between different units of temperature.
    /// </summary>
    public static class Temperature
    {

        #region Units

        /// <summary>
        /// Represents temperature measurement units.
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Celsius (C).
            /// </summary>
            C,
            /// <summary>
            /// Fahrenheit (F).
            /// </summary>
            F,
            /// <summary>
            /// Kelvin (K).
            /// </summary>
            K
        }

        #endregion

        #region Unit Registration

        /// <summary>
        /// Static constructor to register temperature units and conversions with the <see cref="UnitConverter"/>.
        /// </summary>
        static Temperature()
        {
            // Register Temperature unit
            UnitConverter.RegisterUnit(typeof(Unit), BaseUnit.Temperature);
            // Celsius conversions
            UnitConverter.RegisterConversion(Unit.C, Unit.F, CtoF);
            UnitConverter.RegisterConversion(Unit.C, Unit.K, CtoK);
            // Fahrenheit conversions
            UnitConverter.RegisterConversion(Unit.F, Unit.C, FtoC);
            UnitConverter.RegisterConversion(Unit.F, Unit.K, FtoK);
            // Kelvin conversions
            UnitConverter.RegisterConversion(Unit.K, Unit.C, KtoC);
            UnitConverter.RegisterConversion(Unit.K, Unit.F, KtoF);
        }

        #endregion

        #region Celsius Conversions

        /// <summary>
        /// Converts a temperature from Celsius to Fahrenheit.
        /// </summary>
        /// <param name="c">The temperature in degrees Celsius.</param>
        /// <returns>The equivalent temperature in degrees Fahrenheit.</returns>
        public static double CtoF(double c) => (c * 9.0 / 5.0) + 32.0;

        /// <summary>
        /// Converts a temperature from Celsius to Kelvin.
        /// </summary>
        /// <param name="c">The temperature in degrees Celsius.</param>
        /// <returns>The equivalent temperature in Kelvin.</returns>
        public static double CtoK(double c) => c + 273.15;

        #endregion

        #region Fahrenheit Conversions

        /// <summary>
        /// Converts a temperature from Fahrenheit to Celsius.
        /// </summary>
        /// <param name="f">The temperature in degrees Fahrenheit.</param>
        /// <returns>The equivalent temperature in degrees Celsius.</returns>
        public static double FtoC(double f) => (f - 32.0) * 5.0 / 9.0;

        /// <summary>
        /// Converts a temperature from Fahrenheit to Kelvin.
        /// </summary>
        /// <param name="f">The temperature in degrees Fahrenheit.</param>
        /// <returns>The equivalent temperature in Kelvin.</returns>
        public static double FtoK(double f) => (f - 32.0) * 5.0 / 9.0 + 273.15;

        #endregion

        #region Kelvin Conversions

        /// <summary>
        /// Converts a temperature from Kelvin to Celsius.
        /// </summary>
        /// <param name="k">The temperature in Kelvin.</param>
        /// <returns>The equivalent temperature in degrees Celsius.</returns>
        public static double KtoC(double k) => k - 273.15;

        /// <summary>
        /// Converts a temperature from Kelvin to Fahrenheit.
        /// </summary>
        /// <param name="k">The temperature in Kelvin.</param>
        /// <returns>The equivalent temperature in degrees Fahrenheit.</returns>
        public static double KtoF(double k) => (k - 273.15) * 9.0 / 5.0 + 32.0;

        #endregion

        #region Unit Converter

        /// <summary>
        /// Converts a value from one temperature unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of temperature.</param>
        /// <param name="to">The target unit of temperature.</param>
        /// <returns>The converted value in the target unit as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static double Convert(double value, Unit from, Unit to) => UnitConverter.Convert(value, from, to);

        /// <summary>
        /// Converts a value from one temperature unit to another.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="from">The source unit of temperature.</param>
        /// <param name="to">The target unit of temperature.</param>
        /// <returns>The converted value in the target unit as a float.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        public static float Convert(float value, Unit from, Unit to) => (float)UnitConverter.Convert(value, from, to);

        #endregion
    }
}
