namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of mass.
/// </summary>
public static class Mass
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from grams (g) to kilograms (kg).
    /// </summary>
    public const double G_to_Kg = 0.001;
    /// <summary>
    /// Conversion factor from grams (g) to metric tonnes (tonne).
    /// </summary>
    public const double G_to_Tonne = 0.000001;
    /// <summary>
    /// Conversion factor from grams (g) to short tons (shton).
    /// </summary>
    public const double G_to_Shton = 0.000001;
    /// <summary>
    /// Conversion factor from grams (g) to long tons (Lton).
    /// </summary>
    public const double G_to_Lton = 0.000000984;
    /// <summary>
    /// Conversion factor from grams (g) to pounds (lb).
    /// </summary>
    public const double G_to_Lb = 0.002205;
    /// <summary>
    /// Conversion factor from grams (g) to ounces (oz).
    /// </summary>
    public const double G_to_Oz = 0.035273;

    /// <summary>
    /// Conversion factor from kilograms (kg) to grams (g).
    /// </summary>
    public const double Kg_to_G = 1000;
    /// <summary>
    /// Conversion factor from kilograms (kg) to metric tonnes (tonne).
    /// </summary>
    public const double Kg_to_Tonne = 0.001;
    /// <summary>
    /// Conversion factor from kilograms (kg) to short tons (shton).
    /// </summary>
    public const double Kg_to_Shton = 0.001102;
    /// <summary>
    /// Conversion factor from kilograms (kg) to long tons (Lton).
    /// </summary>
    public const double Kg_to_Lton = 0.000984;
    /// <summary>
    /// Conversion factor from kilograms (kg) to pounds (lb).
    /// </summary>
    public const double Kg_to_Lb = 2.204586;
    /// <summary>
    /// Conversion factor from kilograms (kg) to ounces (oz).
    /// </summary>
    public const double Kg_to_Oz = 35.27337;

    /// <summary>
    /// Conversion factor from metric tonnes (tonne) to grams (g).
    /// </summary>
    public const double Tonne_to_G = 1000000;
    /// <summary>
    /// Conversion factor from metric tonnes (tonne) to kilograms (kg).
    /// </summary>
    public const double Tonne_to_Kg = 1000;
    /// <summary>
    /// Conversion factor from metric tonnes (tonne) to short tons (shton).
    /// </summary>
    public const double Tonne_to_Shton = 1.102293;
    /// <summary>
    /// Conversion factor from metric tonnes (tonne) to long tons (Lton).
    /// </summary>
    public const double Tonne_to_Lton = 0.984252;
    /// <summary>
    /// Conversion factor from metric tonnes (tonne) to pounds (lb).
    /// </summary>
    public const double Tonne_to_Lb = 2204.586;
    /// <summary>
    /// Conversion factor from metric tonnes (tonne) to ounces (oz).
    /// </summary>
    public const double Tonne_to_Oz = 35273.37;

    /// <summary>
    /// Conversion factor from short tons (shton) to grams (g).
    /// </summary>
    public const double Shton_to_G = 907200;
    /// <summary>
    /// Conversion factor from short tons (shton) to kilograms (kg).
    /// </summary>
    public const double Shton_to_Kg = 907.2;
    /// <summary>
    /// Conversion factor from short tons (shton) to metric tonnes (tonne).
    /// </summary>
    public const double Shton_to_Tonne = 0.9072;
    /// <summary>
    /// Conversion factor from short tons (shton) to long tons (Lton).
    /// </summary>
    public const double Shton_to_Lton = 0.892913;
    /// <summary>
    /// Conversion factor from short tons (shton) to pounds (lb).
    /// </summary>
    public const double Shton_to_Lb = 2000;
    /// <summary>
    /// Conversion factor from short tons (shton) to ounces (oz).
    /// </summary>
    public const double Shton_to_Oz = 32000;

    /// <summary>
    /// Conversion factor from long tons (Lton) to grams (g).
    /// </summary>
    public const double Lton_to_G = 1016000;
    /// <summary>
    /// Conversion factor from long tons (Lton) to kilograms (kg).
    /// </summary>
    public const double Lton_to_Kg = 1016;
    /// <summary>
    /// Conversion factor from long tons (Lton) to metric tonnes (tonne).
    /// </summary>
    public const double Lton_to_Tonne = 1.016;
    /// <summary>
    /// Conversion factor from long tons (Lton) to short tons (shton).
    /// </summary>
    public const double Lton_to_Shton = 1.119929;
    /// <summary>
    /// Conversion factor from long tons (Lton) to pounds (lb).
    /// </summary>
    public const double Lton_to_Lb = 2239.859;
    /// <summary>
    /// Conversion factor from long tons (Lton) to ounces (oz).
    /// </summary>
    public const double Lton_to_Oz = 35837.74;

    /// <summary>
    /// Conversion factor from pounds (lb) to grams (g).
    /// </summary>
    public const double Lb_to_G = 453.6;
    /// <summary>
    /// Conversion factor from pounds (lb) to kilograms (kg).
    /// </summary>
    public const double Lb_to_Kg = 0.4536;
    /// <summary>
    /// Conversion factor from pounds (lb) to metric tonnes (tonne).
    /// </summary>
    public const double Lb_to_Tonne = 0.000454;
    /// <summary>
    /// Conversion factor from pounds (lb) to short tons (shton).
    /// </summary>
    public const double Lb_to_Shton = 0.0005;
    /// <summary>
    /// Conversion factor from pounds (lb) to long tons (Lton).
    /// </summary>
    public const double Lb_to_Lton = 0.000446;
    /// <summary>
    /// Conversion factor from pounds (lb) to ounces (oz).
    /// </summary>
    public const double Lb_to_Oz = 16;

    /// <summary>
    /// Conversion factor from ounces (oz) to grams (g).
    /// </summary>
    public const double Oz_to_G = 28;
    /// <summary>
    /// Conversion factor from ounces (oz) to kilograms (kg).
    /// </summary>
    public const double Oz_to_Kg = 0.02835;
    /// <summary>
    /// Conversion factor from ounces (oz) to metric tonnes (tonne).
    /// </summary>
    public const double Oz_to_Tonne = 0.000028;
    /// <summary>
    /// Conversion factor from ounces (oz) to short tons (shton).
    /// </summary>
    public const double Oz_to_Shton = 0.000031;
    /// <summary>
    /// Conversion factor from ounces (oz) to long tons (Lton).
    /// </summary>
    public const double Oz_to_Lton = 0.000028;
    /// <summary>
    /// Conversion factor from ounces (oz) to pounds (lb).
    /// </summary>
    public const double Oz_to_Lb = 0.0625;
    #endregion

    static Mass()
    {
        // Register Mass unit
        UnitConverter.RegisterUnit(typeof(MassUnit), BaseUnit.Mass);

        // g conversions
        UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Kg, value => value * G_to_Kg);
        UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Tonne, value => value * G_to_Tonne);
        UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Shton, value => value * G_to_Shton);
        UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Lton, value => value * G_to_Lton);
        UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Lb, value => value * G_to_Lb);
        UnitConverter.RegisterConversion(MassUnit.G, MassUnit.Oz, value => value * G_to_Oz);

        // kg conversions
        UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.G, value => value * Kg_to_G);
        UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Tonne, value => value * Kg_to_Tonne);
        UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Shton, value => value * Kg_to_Shton);
        UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Lton, value => value * Kg_to_Lton);
        UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Lb, value => value * Kg_to_Lb);
        UnitConverter.RegisterConversion(MassUnit.Kg, MassUnit.Oz, value => value * Kg_to_Oz);

        // tonne conversions
        UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.G, value => value * Tonne_to_G);
        UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Kg, value => value * Tonne_to_Kg);
        UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Shton, value => value * Tonne_to_Shton);
        UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Lton, value => value * Tonne_to_Lton);
        UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Lb, value => value * Tonne_to_Lb);
        UnitConverter.RegisterConversion(MassUnit.Tonne, MassUnit.Oz, value => value * Tonne_to_Oz);

        // short ton conversions
        UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.G, value => value * Shton_to_G);
        UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Kg, value => value * Shton_to_Kg);
        UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Tonne, value => value * Shton_to_Tonne);
        UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Lton, value => value * Shton_to_Lton);
        UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Lb, value => value * Shton_to_Lb);
        UnitConverter.RegisterConversion(MassUnit.Shton, MassUnit.Oz, value => value * Shton_to_Oz);

        // long ton conversions
        UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.G, value => value * Lton_to_G);
        UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Kg, value => value * Lton_to_Kg);
        UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Tonne, value => value * Lton_to_Tonne);
        UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Shton, value => value * Lton_to_Shton);
        UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Lb, value => value * Lton_to_Lb);
        UnitConverter.RegisterConversion(MassUnit.Lton, MassUnit.Oz, value => value * Lton_to_Oz);

        // lb conversions
        UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.G, value => value * Lb_to_G);
        UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Kg, value => value * Lb_to_Kg);
        UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Tonne, value => value * Lb_to_Tonne);
        UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Shton, value => value * Lb_to_Shton);
        UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Lton, value => value * Lb_to_Lton);
        UnitConverter.RegisterConversion(MassUnit.Lb, MassUnit.Oz, value => value * Lb_to_Oz);

        // oz conversions
        UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.G, value => value * Oz_to_G);
        UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Kg, value => value * Oz_to_Kg);
        UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Tonne, value => value * Oz_to_Tonne);
        UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Shton, value => value * Oz_to_Shton);
        UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Lton, value => value * Oz_to_Lton);
        UnitConverter.RegisterConversion(MassUnit.Oz, MassUnit.Lb, value => value * Oz_to_Lb);
    }

    /// <summary>
    /// Converts a value from one mass unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of mass.</param>
    /// <param name="to">The target unit of mass.</param>
    /// <returns>The converted value in the target unit as a double.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static double Convert(double value, MassUnit from, MassUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }

    /// <summary>
    /// Converts a value from one mass unit to another.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="from">The source unit of mass.</param>
    /// <param name="to">The target unit of mass.</param>
    /// <returns>The converted value in the target unit as a float.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
    /// </exception>
    public static float Convert(float value, MassUnit from, MassUnit to)
    {
        return (float)UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Units of mass measurement.
/// </summary>
public enum MassUnit
{
    /// <summary>
    /// Grams (g).
    /// </summary>
    G,
    /// <summary>
    /// Kilograms (kg).
    /// </summary>
    Kg,
    /// <summary>
    /// Metric tonnes (tonne).
    /// </summary>
    Tonne,
    /// <summary>
    /// Short ton (shton).
    /// </summary>
    Shton,
    /// <summary>
    /// Long ton (Lton).
    /// </summary>
    Lton,
    /// <summary>
    /// Pounds (lb).
    /// </summary>
    Lb,
    /// <summary>
    /// Ounces (oz).
    /// </summary>
    Oz
}