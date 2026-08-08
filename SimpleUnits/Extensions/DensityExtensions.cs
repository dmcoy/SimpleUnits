namespace SimpleUnits
{
    /// <summary>
    /// Provides extension methods for converting between different units of density.
    /// </summary>
    public static class DensityExtensions
    {
        /// <summary>
        /// Converts a value from gram per milliliter (g/ml) to kilogram per cubic meter (kg/m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double GmlToKgm3(this double value) => Density.GmlToKgm3(value);

        /// <summary>
        /// Converts a value from gram per milliliter (g/ml) to kilogram per cubic meter (kg/m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float GmlToKgm3(this float value) => (float)Density.GmlToKgm3(value);

        /// <summary>
        /// Converts a value from gram per milliliter (g/ml) to pound per cubic foot (lb/ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double GmlToLbft3(this double value) => Density.GmlToLbft3(value);

        /// <summary>
        /// Converts a value from gram per milliliter (g/ml) to pound per cubic foot (lb/ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float GmlToLbft3(this float value) => (float)Density.GmlToLbft3(value);

        /// <summary>
        /// Converts a value from gram per milliliter (g/ml) to pound per cubic inch (lb/in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double GmlToLbin3(this double value) => Density.GmlToLbin3(value);

        /// <summary>
        /// Converts a value from gram per milliliter (g/ml) to pound per cubic inch (lb/in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float GmlToLbin3(this float value) => (float)Density.GmlToLbin3(value);

        /// <summary>
        /// Converts a value from kilogram per cubic meter (kg/m³) to gram per milliliter (g/ml).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Kgm3ToGml(this double value) => Density.Kgm3ToGml(value);

        /// <summary>
        /// Converts a value from kilogram per cubic meter (kg/m³) to gram per milliliter (g/ml).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Kgm3ToGml(this float value) => (float)Density.Kgm3ToGml(value);

        /// <summary>
        /// Converts a value from kilogram per cubic meter (kg/m³) to pound per cubic foot (lb/ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Kgm3ToLbft3(this double value) => Density.Kgm3ToLbft3(value);

        /// <summary>
        /// Converts a value from kilogram per cubic meter (kg/m³) to pound per cubic foot (lb/ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Kgm3ToLbft3(this float value) => (float)Density.Kgm3ToLbft3(value);

        /// <summary>
        /// Converts a value from kilogram per cubic meter (kg/m³) to pound per cubic inch (lb/in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Kgm3ToLbin3(this double value) => Density.Kgm3ToLbin3(value);

        /// <summary>
        /// Converts a value from kilogram per cubic meter (kg/m³) to pound per cubic inch (lb/in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Kgm3ToLbin3(this float value) => (float)Density.Kgm3ToLbin3(value);

        /// <summary>
        /// Converts a value from pound per cubic foot (lb/ft³) to gram per milliliter (g/ml).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Lbft3ToGml(this double value) => Density.Lbft3ToGml(value);

        /// <summary>
        /// Converts a value from pound per cubic foot (lb/ft³) to gram per milliliter (g/ml).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Lbft3ToGml(this float value) => (float)Density.Lbft3ToGml(value);

        /// <summary>
        /// Converts a value from pound per cubic foot (lb/ft³) to kilogram per cubic meter (kg/m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Lbft3ToKgm3(this double value) => Density.Lbft3ToKgm3(value);

        /// <summary>
        /// Converts a value from pound per cubic foot (lb/ft³) to kilogram per cubic meter (kg/m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Lbft3ToKgm3(this float value) => (float)Density.Lbft3ToKgm3(value);

        /// <summary>
        /// Converts a value from pound per cubic foot (lb/ft³) to pound per cubic inch (lb/in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Lbft3ToLbin3(this double value) => Density.Lbft3ToLbin3(value);

        /// <summary>
        /// Converts a value from pound per cubic foot (lb/ft³) to pound per cubic inch (lb/in³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Lbft3ToLbin3(this float value) => (float)Density.Lbft3ToLbin3(value);

        /// <summary>
        /// Converts a value from pound per cubic inch (lb/in³) to gram per milliliter (g/ml).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Lbin3ToGml(this double value) => Density.Lbin3ToGml(value);

        /// <summary>
        /// Converts a value from pound per cubic inch (lb/in³) to gram per milliliter (g/ml).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Lbin3ToGml(this float value) => (float)Density.Lbin3ToGml(value);

        /// <summary>
        /// Converts a value from pound per cubic inch (lb/in³) to kilogram per cubic meter (kg/m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Lbin3ToKgm3(this double value) => Density.Lbin3ToKgm3(value);

        /// <summary>
        /// Converts a value from pound per cubic inch (lb/in³) to kilogram per cubic meter (kg/m³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Lbin3ToKgm3(this float value) => (float)Density.Lbin3ToKgm3(value);

        /// <summary>
        /// Converts a value from pound per cubic inch (lb/in³) to pound per cubic foot (lb/ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a double.</returns>
        public static double Lbin3ToLbft3(this double value) => Density.Lbin3ToLbft3(value);

        /// <summary>
        /// Converts a value from pound per cubic inch (lb/in³) to pound per cubic foot (lb/ft³).
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value as a float.</returns>
        public static float Lbin3ToLbft3(this float value) => (float)Density.Lbin3ToLbft3(value);
    }
}
