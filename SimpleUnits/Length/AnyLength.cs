namespace SimpleUnits.Convert;

/// <summary>
/// Provides static methods for converting between different units of length.
/// </summary>
public static class AnyLength
{
    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to millimeters.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to millimeters.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already millimeters or unsupported.</exception>
    public static float ToMillimeters(float value, Length unit)
    {
        return unit switch
        {
            Length.Centimeters => Inches.ToMillimeters(value),
            Length.Millimeters => throw new ArgumentException($"Cannot convert the same units"),
            Length.Meters => Meters.ToMillimeters(value),
            Length.Kilometers => Kilometers.ToMillimeters(value),
            Length.Inches => Inches.ToMillimeters(value),
            Length.Feet => Feet.ToMillimeters(value),
            Length.Yards => Yards.ToMillimeters(value),
            Length.Miles => Miles.ToMillimeters(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to millimeters.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to millimeters.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already millimeters or unsupported.</exception>
    public static double ToMillimeters(double value, Length unit)
    {
        return unit switch
        {
            Length.Centimeters => Inches.ToMillimeters(value),
            Length.Millimeters => throw new ArgumentException($"Cannot convert the same units"),
            Length.Meters => Meters.ToMillimeters(value),
            Length.Kilometers => Kilometers.ToMillimeters(value),
            Length.Inches => Inches.ToMillimeters(value),
            Length.Feet => Feet.ToMillimeters(value),
            Length.Yards => Yards.ToMillimeters(value),
            Length.Miles => Miles.ToMillimeters(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to centimeters.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to centimeters.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already centimeters or unsupported.</exception>
    public static float ToCentimeters(float value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToCentimeters(value),
            Length.Centimeters => throw new ArgumentException($"Cannot convert the same units"),
            Length.Meters => Meters.ToCentimeters(value),
            Length.Kilometers => Kilometers.ToCentimeters(value),
            Length.Inches => Inches.ToCentimeters(value),
            Length.Feet => Feet.ToCentimeters(value),
            Length.Yards => Yards.ToCentimeters(value),
            Length.Miles => Miles.ToCentimeters(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to centimeters.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to centimeters.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already centimeters or unsupported.</exception>
    public static double ToCentimeters(double value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToCentimeters(value),
            Length.Centimeters => throw new ArgumentException($"Cannot convert the same units"),
            Length.Meters => Meters.ToCentimeters(value),
            Length.Kilometers => Kilometers.ToCentimeters(value),
            Length.Inches => Inches.ToCentimeters(value),
            Length.Feet => Feet.ToCentimeters(value),
            Length.Yards => Yards.ToCentimeters(value),
            Length.Miles => Miles.ToCentimeters(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to meters.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to meters.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already meters or unsupported.</exception>
    public static float ToMeters(float value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToMeters(value),
            Length.Centimeters => Centimeters.ToMeters(value),
            Length.Meters => throw new ArgumentException($"Cannot convert the same units"),
            Length.Kilometers => Kilometers.ToMeters(value),
            Length.Inches => Inches.ToMeters(value),
            Length.Feet => Feet.ToMeters(value),
            Length.Yards => Yards.ToMeters(value),
            Length.Miles => Miles.ToMeters(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to meters.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to meters.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already meters or unsupported.</exception>
    public static double ToMeters(double value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToMeters(value),
            Length.Centimeters => Centimeters.ToMeters(value),
            Length.Meters => throw new ArgumentException($"Cannot convert the same units"),
            Length.Kilometers => Kilometers.ToMeters(value),
            Length.Inches => Inches.ToMeters(value),
            Length.Feet => Feet.ToMeters(value),
            Length.Yards => Yards.ToMeters(value),
            Length.Miles => Miles.ToMeters(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to kilometers.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to kilometers.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already kilometers or unsupported.</exception>
    public static float ToKilometers(float value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToKilometers(value),
            Length.Centimeters => Centimeters.ToKilometers(value),
            Length.Meters => Meters.ToKilometers(value),
            Length.Kilometers => throw new ArgumentException($"Cannot convert the same units"),
            Length.Inches => Inches.ToKilometers(value),
            Length.Feet => Feet.ToKilometers(value),
            Length.Yards => Yards.ToKilometers(value),
            Length.Miles => Miles.ToKilometers(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to kilometers.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to kilometers.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already kilometers or unsupported.</exception>
    public static double ToKilometers(double value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToKilometers(value),
            Length.Centimeters => Centimeters.ToKilometers(value),
            Length.Meters => Meters.ToKilometers(value),
            Length.Kilometers => throw new ArgumentException($"Cannot convert the same units"),
            Length.Inches => Inches.ToKilometers(value),
            Length.Feet => Feet.ToKilometers(value),
            Length.Yards => Yards.ToKilometers(value),
            Length.Miles => Miles.ToKilometers(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to inches.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to inches.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already inches or unsupported.</exception>
    public static float ToInches(float value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToInches(value),
            Length.Centimeters => Centimeters.ToInches(value),
            Length.Meters => Meters.ToInches(value),
            Length.Kilometers => Kilometers.ToInches(value),
            Length.Inches => throw new ArgumentException($"Cannot convert the same units"),
            Length.Feet => Feet.ToInches(value),
            Length.Yards => Yards.ToInches(value),
            Length.Miles => Miles.ToInches(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to inches.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to inches.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already inches or unsupported.</exception>
    public static double ToInches(double value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToInches(value),
            Length.Centimeters => Centimeters.ToInches(value),
            Length.Meters => Meters.ToInches(value),
            Length.Kilometers => Kilometers.ToInches(value),
            Length.Inches => throw new ArgumentException($"Cannot convert the same units"),
            Length.Feet => Feet.ToInches(value),
            Length.Yards => Yards.ToInches(value),
            Length.Miles => Miles.ToInches(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to feet.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to feet.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already feet or unsupported.</exception>
    public static float ToFeet(float value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToFeet(value),
            Length.Centimeters => Centimeters.ToFeet(value),
            Length.Meters => Meters.ToFeet(value),
            Length.Kilometers => Kilometers.ToFeet(value),
            Length.Inches => Inches.ToFeet(value),
            Length.Feet => throw new ArgumentException($"Cannot convert the same units"),
            Length.Yards => Yards.ToFeet(value),
            Length.Miles => Miles.ToFeet(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to feet.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to feet.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already feet or unsupported.</exception>
    public static double ToFeet(double value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToFeet(value),
            Length.Centimeters => Centimeters.ToFeet(value),
            Length.Meters => Meters.ToFeet(value),
            Length.Kilometers => Kilometers.ToFeet(value),
            Length.Inches => Inches.ToFeet(value),
            Length.Feet => throw new ArgumentException($"Cannot convert the same units"),
            Length.Yards => Yards.ToFeet(value),
            Length.Miles => Miles.ToFeet(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to yards.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to yards.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already yards or unsupported.</exception>
    public static float ToYards(float value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToYards(value),
            Length.Centimeters => Centimeters.ToYards(value),
            Length.Meters => Meters.ToYards(value),
            Length.Kilometers => Kilometers.ToYards(value),
            Length.Inches => Inches.ToYards(value),
            Length.Feet => Feet.ToYards(value),
            Length.Yards => throw new ArgumentException($"Cannot convert the same units"),
            Length.Miles => Miles.ToYards(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to yards.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to yards.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already yards or unsupported.</exception>
    public static double ToYards(double value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToYards(value),
            Length.Centimeters => Centimeters.ToYards(value),
            Length.Meters => Meters.ToYards(value),
            Length.Kilometers => Kilometers.ToYards(value),
            Length.Inches => Inches.ToYards(value),
            Length.Feet => Feet.ToYards(value),
            Length.Yards => throw new ArgumentException($"Cannot convert the same units"),
            Length.Miles => Miles.ToYards(value),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to miles.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to miles.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already miles or unsupported.</exception>
    public static float ToMiles(float value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToMiles(value),
            Length.Centimeters => Centimeters.ToMiles(value),
            Length.Meters => Meters.ToMiles(value),
            Length.Kilometers => Kilometers.ToMiles(value),
            Length.Inches => Inches.ToMiles(value),
            Length.Feet => Feet.ToMiles(value),
            Length.Yards => Yards.ToMiles(value),
            Length.Miles => throw new ArgumentException($"Cannot convert the same units"),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }

    /// <summary>
    /// Converts a value from the specified <see cref="Length"/> unit to miles.
    /// </summary>
    /// <param name="value">The numeric value to convert.</param>
    /// <param name="unit">The unit of the input value.</param>
    /// <returns>The value converted to miles.</returns>
    /// <exception cref="ArgumentException">Thrown if the unit is already miles or unsupported.</exception>
    public static double ToMiles(double value, Length unit)
    {
        return unit switch
        {
            Length.Millimeters => Millimeters.ToMiles(value),
            Length.Centimeters => Centimeters.ToMiles(value),
            Length.Meters => Meters.ToMiles(value),
            Length.Kilometers => Kilometers.ToMiles(value),
            Length.Inches => Inches.ToMiles(value),
            Length.Feet => Feet.ToMiles(value),
            Length.Yards => Yards.ToMiles(value),
            Length.Miles => throw new ArgumentException($"Cannot convert the same units"),
            _ => throw new ArgumentException($"Unsupported length unit: {unit}")
        };
    }
}
