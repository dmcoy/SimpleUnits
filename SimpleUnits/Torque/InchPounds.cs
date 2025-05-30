namespace SimpleUnits.Convert
{
    /// <summary>
    /// Provides static methods for converting inch-pounds to other torque units.
    /// </summary>
    public static class InchPounds
    {
        /// <summary>
        /// Converts a value from inch-pounds to Newton-meters (float).
        /// </summary>
        /// <param name="value">The value in inch-pounds.</param>
        /// <returns>The value in Newton-meters as a float.</returns>
        public static float ToNewtonMeters(float value) => value * (float)Conversions.Inlb_to_Nm;

        /// <summary>
        /// Converts a value from inch-pounds to Newton-meters.
        /// </summary>
        /// <param name="value">The value in inch-pounds.</param>
        /// <returns>The value in Newton-meters as a double.</returns>
        public static double ToNewtonMeters(double value) => value * Conversions.Inlb_to_Nm;

        /// <summary>
        /// Converts a value from inch-pounds to kilogram-force meters (float).
        /// </summary>
        /// <param name="value">The value in inch-pounds.</param>
        /// <returns>The value in kilogram-force meters as a float.</returns>
        public static float ToKilogramForceMeters(float value) => value * (float)Conversions.Inlb_to_Kgfm;

        /// <summary>
        /// Converts a value from inch-pounds to kilogram-force meters.
        /// </summary>
        /// <param name="value">The value in inch-pounds.</param>
        /// <returns>The value in kilogram-force meters as a double.</returns>
        public static double ToKilogramForceMeters(double value) => value * Conversions.Inlb_to_Kgfm;

        /// <summary>
        /// Converts a value from inch-pounds to foot-pounds (float).
        /// </summary>
        /// <param name="value">The value in inch-pounds.</param>
        /// <returns>The value in foot-pounds as a float.</returns>
        public static float ToFootPounds(float value) => value * (float)Conversions.Inlb_to_Ftlb;

        /// <summary>
        /// Converts a value from inch-pounds to foot-pounds.
        /// </summary>
        /// <param name="value">The value in inch-pounds.</param>
        /// <returns>The value in foot-pounds as a double.</returns>
        public static double ToFootPounds(double value) => value * Conversions.Inlb_to_Ftlb;
    }
}
