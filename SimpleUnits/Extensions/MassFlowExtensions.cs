namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of mass flow.
    /// </summary>
    public static class MassFlowExtensions
    {
        /// <summary>
        /// Converts a value from kilogram per hour (kg/h) to pound per hour (lb/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KghToLbh(this double value) => MassFlow.KghToLbh(value);

        /// <summary>
        /// Converts a value from kilogram per hour (kg/h) to pound per hour (lb/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KghToLbh(this float value) => (float)MassFlow.KghToLbh(value);

        /// <summary>
        /// Converts a value from kilogram per hour (kg/h) to kilogram per second (kg/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KghToKgs(this double value) => MassFlow.KghToKgs(value);

        /// <summary>
        /// Converts a value from kilogram per hour (kg/h) to kilogram per second (kg/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KghToKgs(this float value) => (float)MassFlow.KghToKgs(value);

        /// <summary>
        /// Converts a value from kilogram per hour (kg/h) to ton per hour (t/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KghToTh(this double value) => MassFlow.KghToTh(value);

        /// <summary>
        /// Converts a value from kilogram per hour (kg/h) to ton per hour (t/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KghToTh(this float value) => (float)MassFlow.KghToTh(value);

        /// <summary>
        /// Converts a value from pound per hour (lb/h) to kilogram per hour (kg/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LbhToKgh(this double value) => MassFlow.LbhToKgh(value);

        /// <summary>
        /// Converts a value from pound per hour (lb/h) to kilogram per hour (kg/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LbhToKgh(this float value) => (float)MassFlow.LbhToKgh(value);

        /// <summary>
        /// Converts a value from pound per hour (lb/h) to kilogram per second (kg/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LbhToKgs(this double value) => MassFlow.LbhToKgs(value);

        /// <summary>
        /// Converts a value from pound per hour (lb/h) to kilogram per second (kg/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LbhToKgs(this float value) => (float)MassFlow.LbhToKgs(value);

        /// <summary>
        /// Converts a value from pound per hour (lb/h) to ton per hour (t/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double LbhToTh(this double value) => MassFlow.LbhToTh(value);

        /// <summary>
        /// Converts a value from pound per hour (lb/h) to ton per hour (t/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float LbhToTh(this float value) => (float)MassFlow.LbhToTh(value);

        /// <summary>
        /// Converts a value from kilogram per second (kg/s) to kilogram per hour (kg/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgsToKgh(this double value) => MassFlow.KgsToKgh(value);

        /// <summary>
        /// Converts a value from kilogram per second (kg/s) to kilogram per hour (kg/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgsToKgh(this float value) => (float)MassFlow.KgsToKgh(value);

        /// <summary>
        /// Converts a value from kilogram per second (kg/s) to pound per hour (lb/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgsToLbh(this double value) => MassFlow.KgsToLbh(value);

        /// <summary>
        /// Converts a value from kilogram per second (kg/s) to pound per hour (lb/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgsToLbh(this float value) => (float)MassFlow.KgsToLbh(value);

        /// <summary>
        /// Converts a value from kilogram per second (kg/s) to ton per hour (t/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double KgsToTh(this double value) => MassFlow.KgsToTh(value);

        /// <summary>
        /// Converts a value from kilogram per second (kg/s) to ton per hour (t/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float KgsToTh(this float value) => (float)MassFlow.KgsToTh(value);

        /// <summary>
        /// Converts a value from ton per hour (t/h) to kilogram per hour (kg/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ThToKgh(this double value) => MassFlow.ThToKgh(value);

        /// <summary>
        /// Converts a value from ton per hour (t/h) to kilogram per hour (kg/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ThToKgh(this float value) => (float)MassFlow.ThToKgh(value);

        /// <summary>
        /// Converts a value from ton per hour (t/h) to pound per hour (lb/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ThToLbh(this double value) => MassFlow.ThToLbh(value);

        /// <summary>
        /// Converts a value from ton per hour (t/h) to pound per hour (lb/h).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ThToLbh(this float value) => (float)MassFlow.ThToLbh(value);

        /// <summary>
        /// Converts a value from ton per hour (t/h) to kilogram per second (kg/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double ThToKgs(this double value) => MassFlow.ThToKgs(value);

        /// <summary>
        /// Converts a value from ton per hour (t/h) to kilogram per second (kg/s).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float ThToKgs(this float value) => (float)MassFlow.ThToKgs(value);
    }
}
