namespace SimpleUnits;

/// <summary>
/// Provides constants and methods for converting between different units of length.
/// </summary>
/// <remarks>
/// The <c>Length</c> class defines conversion factors between common length units such as millimeters, centimeters, meters, kilometers, inches, feet, yards, and miles.
/// It also registers these conversions with the <see cref="UnitConverter"/> and exposes a method to perform conversions between supported units.
/// </remarks>
public static class Length
{
    #region Conversion Factors
    /// <summary>
    /// Conversion factor from millimeters to centimeters.
    /// </summary>
    public const double MillimetersToCentimeters = 0.1;
    /// <summary>
    /// Conversion factor from millimeters to meters.
    /// </summary>
    public const double MillimetersToMeters = 0.001;
    /// <summary>
    /// Conversion factor from millimeters to kilometers.
    /// </summary>
    public const double MillimetersToKilometers = 0.000_001;
    /// <summary>
    /// Conversion factor from millimeters to inches.
    /// </summary>
    public const double MillimetersToInches = 0.039_37;
    /// <summary>
    /// Conversion factor from millimeters to feet.
    /// </summary>
    public const double MillimetersToFeet = 0.003_281;
    /// <summary>
    /// Conversion factor from millimeters to yards.
    /// </summary>
    public const double MillimetersToYards = 0.001_094;
    /// <summary>
    /// Conversion factor from millimeters to miles.
    /// </summary>
    public const double MillimetersToMiles = 6.21e-07;

    /// <summary>
    /// Conversion factor from centimeters to millimeters.
    /// </summary>
    public const double CentimetersToMillimeters = 10;
    /// <summary>
    /// Conversion factor from centimeters to meters.
    /// </summary>
    public const double CentimetersToMeters = 0.01;
    /// <summary>
    /// Conversion factor from centimeters to kilometers.
    /// </summary>
    public const double CentimetersToKilometers = 0.000_1;
    /// <summary>
    /// Conversion factor from centimeters to inches.
    /// </summary>
    public const double CentimetersToInches = 0.393_701;
    /// <summary>
    /// Conversion factor from centimeters to feet.
    /// </summary>
    public const double CentimetersToFeet = 0.032_808;
    /// <summary>
    /// Conversion factor from centimeters to yards.
    /// </summary>
    public const double CentimetersToYards = 0.010_936;
    /// <summary>
    /// Conversion factor from centimeters to miles.
    /// </summary>
    public const double CentimetersToMiles = 0.000_006;

    /// <summary>
    /// Conversion factor from meters to millimeters.
    /// </summary>
    public const double MetersToMillimeters = 1_000;
    /// <summary>
    /// Conversion factor from meters to centimeters.
    /// </summary>
    public const double MetersToCentimeters = 100;
    /// <summary>
    /// Conversion factor from meters to kilometers.
    /// </summary>
    public const double MetersToKilometers = 0.001;
    /// <summary>
    /// Conversion factor from meters to inches.
    /// </summary>
    public const double MetersToInches = 39.370_08;
    /// <summary>
    /// Conversion factor from meters to feet.
    /// </summary>
    public const double MetersToFeet = 3.280_84;
    /// <summary>
    /// Conversion factor from meters to yards.
    /// </summary>
    public const double MetersToYards = 1.093_613;
    /// <summary>
    /// Conversion factor from meters to miles.
    /// </summary>
    public const double MetersToMiles = 0.000_621;

    /// <summary>
    /// Conversion factor from kilometers to millimeters.
    /// </summary>
    public const double KilometersToMillimeters = 1_000_000;
    /// <summary>
    /// Conversion factor from kilometers to centimeters.
    /// </summary>
    public const double KilometersToCentimeters = 100_000;
    /// <summary>
    /// Conversion factor from kilometers to meters.
    /// </summary>
    public const double KilometersToMeters = 1_000;
    /// <summary>
    /// Conversion factor from kilometers to inches.
    /// </summary>
    public const double KilometersToInches = 39_370.08;
    /// <summary>
    /// Conversion factor from kilometers to feet.
    /// </summary>
    public const double KilometersToFeet = 3_280.84;
    /// <summary>
    /// Conversion factor from kilometers to yards.
    /// </summary>
    public const double KilometersToYards = 1_093.613;
    /// <summary>
    /// Conversion factor from kilometers to miles.
    /// </summary>
    public const double KilometersToMiles = 0.621_371;

    /// <summary>
    /// Conversion factor from inches to millimeters.
    /// </summary>
    public const double InchesToMillimeters = 25.4;
    /// <summary>
    /// Conversion factor from inches to centimeters.
    /// </summary>
    public const double InchesToCentimeters = 2.54;
    /// <summary>
    /// Conversion factor from inches to meters.
    /// </summary>
    public const double InchesToMeters = 0.025_4;
    /// <summary>
    /// Conversion factor from inches to kilometers.
    /// </summary>
    public const double InchesToKilometers = 0.000_025;
    /// <summary>
    /// Conversion factor from inches to feet.
    /// </summary>
    public const double InchesToFeet = 0.083_333;
    /// <summary>
    /// Conversion factor from inches to yards.
    /// </summary>
    public const double InchesToYards = 0.027_778;
    /// <summary>
    /// Conversion factor from inches to miles.
    /// </summary>
    public const double InchesToMiles = 0.000_016;

    /// <summary>
    /// Conversion factor from feet to millimeters.
    /// </summary>
    public const double FeetToMillimeters = 304.8;
    /// <summary>
    /// Conversion factor from feet to centimeters.
    /// </summary>
    public const double FeetToCentimeters = 30.48;
    /// <summary>
    /// Conversion factor from feet to meters.
    /// </summary>
    public const double FeetToMeters = 0.304_8;
    /// <summary>
    /// Conversion factor from feet to kilometers.
    /// </summary>
    public const double FeetToKilometers = 0.000_304_8;
    /// <summary>
    /// Conversion factor from feet to inches.
    /// </summary>
    public const double FeetToInches = 12;
    /// <summary>
    /// Conversion factor from feet to yards.
    /// </summary>
    public const double FeetToYards = 0.333_333;
    /// <summary>
    /// Conversion factor from feet to miles.
    /// </summary>
    public const double FeetToMiles = 0.000_189;

    /// <summary>
    /// Conversion factor from yards to millimeters.
    /// </summary>
    public const double YardsToMillimeters = 914.4;
    /// <summary>
    /// Conversion factor from yards to centimeters.
    /// </summary>
    public const double YardsToCentimeters = 91.44;
    /// <summary>
    /// Conversion factor from yards to meters.
    /// </summary>
    public const double YardsToMeters = 0.914_4;
    /// <summary>
    /// Conversion factor from yards to kilometers.
    /// </summary>
    public const double YardsToKilometers = 0.000_914;
    /// <summary>
    /// Conversion factor from yards to inches.
    /// </summary>
    public const double YardsToInches = 36;
    /// <summary>
    /// Conversion factor from yards to feet.
    /// </summary>
    public const double YardsToFeet = 3;
    /// <summary>
    /// Conversion factor from yards to miles.
    /// </summary>
    public const double YardsToMiles = 0.000_568;

    /// <summary>
    /// Conversion factor from miles to millimeters.
    /// </summary>
    public const double MilesToMillimeters = 1_609_344;
    /// <summary>
    /// Conversion factor from miles to centimeters.
    /// </summary>
    public const double MilesToCentimeters = 160_934.4;
    /// <summary>
    /// Conversion factor from miles to meters.
    /// </summary>
    public const double MilesToMeters = 1_609.344;
    /// <summary>
    /// Conversion factor from miles to kilometers.
    /// </summary>
    public const double MilesToKilometers = 1.609_344;
    /// <summary>
    /// Conversion factor from miles to inches.
    /// </summary>
    public const double MilesToInches = 63_360;
    /// <summary>
    /// Conversion factor from miles to feet.
    /// </summary>
    public const double MilesToFeet = 5_280;
    /// <summary>
    /// Conversion factor from miles to yards.
    /// </summary>
    public const double MilesToYards = 1_760;
    #endregion

    static Length()
    {
        // Register Length unit
        UnitConverter.RegisterUnit(typeof(LengthUnit), BaseUnit.Length);

        // Millimeter conversions
        UnitConverter.RegisterConversion(LengthUnit.Millimeters, LengthUnit.Centimeters, value => value * MillimetersToCentimeters);
        UnitConverter.RegisterConversion(LengthUnit.Millimeters, LengthUnit.Meters, value => value * MillimetersToMeters);
        UnitConverter.RegisterConversion(LengthUnit.Millimeters, LengthUnit.Kilometers, value => value * MillimetersToKilometers);
        UnitConverter.RegisterConversion(LengthUnit.Millimeters, LengthUnit.Inches, value => value * MillimetersToInches);
        UnitConverter.RegisterConversion(LengthUnit.Millimeters, LengthUnit.Feet, value => value * MillimetersToFeet);
        UnitConverter.RegisterConversion(LengthUnit.Millimeters, LengthUnit.Yards, value => value * MillimetersToYards);
        UnitConverter.RegisterConversion(LengthUnit.Millimeters, LengthUnit.Miles, value => value * MillimetersToMiles);

        // Centimeters conversions
        UnitConverter.RegisterConversion(LengthUnit.Centimeters, LengthUnit.Millimeters, value => value * CentimetersToMillimeters);
        UnitConverter.RegisterConversion(LengthUnit.Centimeters, LengthUnit.Meters, value => value * CentimetersToMeters);
        UnitConverter.RegisterConversion(LengthUnit.Centimeters, LengthUnit.Kilometers, value => value * CentimetersToKilometers);
        UnitConverter.RegisterConversion(LengthUnit.Centimeters, LengthUnit.Inches, value => value * CentimetersToInches);
        UnitConverter.RegisterConversion(LengthUnit.Centimeters, LengthUnit.Feet, value => value * CentimetersToFeet);
        UnitConverter.RegisterConversion(LengthUnit.Centimeters, LengthUnit.Yards, value => value * CentimetersToYards);
        UnitConverter.RegisterConversion(LengthUnit.Centimeters, LengthUnit.Miles, value => value * CentimetersToMiles);
        // Meter conversions
        UnitConverter.RegisterConversion(LengthUnit.Meters, LengthUnit.Millimeters, value => value * MetersToMillimeters);
        UnitConverter.RegisterConversion(LengthUnit.Meters, LengthUnit.Centimeters, value => value * MetersToCentimeters);
        UnitConverter.RegisterConversion(LengthUnit.Meters, LengthUnit.Kilometers, value => value * MetersToKilometers);
        UnitConverter.RegisterConversion(LengthUnit.Meters, LengthUnit.Inches, value => value * MetersToInches);
        UnitConverter.RegisterConversion(LengthUnit.Meters, LengthUnit.Feet, value => value * MetersToFeet);
        UnitConverter.RegisterConversion(LengthUnit.Meters, LengthUnit.Yards, value => value * MetersToYards);
        UnitConverter.RegisterConversion(LengthUnit.Meters, LengthUnit.Miles, value => value * MetersToMiles);

        // Kilometer conversions
        UnitConverter.RegisterConversion(LengthUnit.Kilometers, LengthUnit.Millimeters, value => value * KilometersToMillimeters);
        UnitConverter.RegisterConversion(LengthUnit.Kilometers, LengthUnit.Centimeters, value => value * KilometersToCentimeters);
        UnitConverter.RegisterConversion(LengthUnit.Kilometers, LengthUnit.Meters, value => value * KilometersToMeters);
        UnitConverter.RegisterConversion(LengthUnit.Kilometers, LengthUnit.Inches, value => value * KilometersToInches);
        UnitConverter.RegisterConversion(LengthUnit.Kilometers, LengthUnit.Feet, value => value * KilometersToFeet);
        UnitConverter.RegisterConversion(LengthUnit.Kilometers, LengthUnit.Yards, value => value * KilometersToYards);
        UnitConverter.RegisterConversion(LengthUnit.Kilometers, LengthUnit.Miles, value => value * KilometersToMiles);

        // Inch conversions
        UnitConverter.RegisterConversion(LengthUnit.Inches, LengthUnit.Millimeters, value => value * InchesToMillimeters);
        UnitConverter.RegisterConversion(LengthUnit.Inches, LengthUnit.Centimeters, value => value * InchesToCentimeters);
        UnitConverter.RegisterConversion(LengthUnit.Inches, LengthUnit.Meters, value => value * InchesToMeters);
        UnitConverter.RegisterConversion(LengthUnit.Inches, LengthUnit.Kilometers, value => value * InchesToKilometers);
        UnitConverter.RegisterConversion(LengthUnit.Inches, LengthUnit.Feet, value => value % FeetToInches == 0 ? Math.Round(value * InchesToFeet) : value * InchesToFeet);
        UnitConverter.RegisterConversion(LengthUnit.Inches, LengthUnit.Yards, value => value % YardsToInches == 0 ? Math.Round(value * InchesToYards) : value * InchesToYards);
        UnitConverter.RegisterConversion(LengthUnit.Inches, LengthUnit.Miles, value => value % MilesToInches == 0 ? Math.Round(value * InchesToMiles) : value * InchesToMiles);

        // Feet conversions
        UnitConverter.RegisterConversion(LengthUnit.Feet, LengthUnit.Millimeters, value => value * FeetToMillimeters);
        UnitConverter.RegisterConversion(LengthUnit.Feet, LengthUnit.Centimeters, value => value * FeetToCentimeters);
        UnitConverter.RegisterConversion(LengthUnit.Feet, LengthUnit.Meters, value => value * FeetToMeters);
        UnitConverter.RegisterConversion(LengthUnit.Feet, LengthUnit.Kilometers, value => value * FeetToKilometers);
        UnitConverter.RegisterConversion(LengthUnit.Feet, LengthUnit.Inches, value => value * FeetToInches);
        UnitConverter.RegisterConversion(LengthUnit.Feet, LengthUnit.Yards, value => value % YardsToFeet == 0 ? Math.Round(value * FeetToYards) : value * FeetToYards);
        UnitConverter.RegisterConversion(LengthUnit.Feet, LengthUnit.Miles, value => value % MilesToFeet == 0 ? Math.Round(value * FeetToMiles) : value * FeetToMiles);

        // Yard conversions
        UnitConverter.RegisterConversion(LengthUnit.Yards, LengthUnit.Millimeters, value => value * YardsToMillimeters);
        UnitConverter.RegisterConversion(LengthUnit.Yards, LengthUnit.Centimeters, value => value * YardsToCentimeters);
        UnitConverter.RegisterConversion(LengthUnit.Yards, LengthUnit.Meters, value => value * YardsToMeters);
        UnitConverter.RegisterConversion(LengthUnit.Yards, LengthUnit.Kilometers, value => value * YardsToKilometers);
        UnitConverter.RegisterConversion(LengthUnit.Yards, LengthUnit.Inches, value => value * YardsToInches);
        UnitConverter.RegisterConversion(LengthUnit.Yards, LengthUnit.Feet, value => value * YardsToFeet);
        UnitConverter.RegisterConversion(LengthUnit.Yards, LengthUnit.Miles, value => value % MilesToYards == 0 ? Math.Round(value * YardsToMiles) : value * YardsToMiles);

        // Miles
        UnitConverter.RegisterConversion(LengthUnit.Miles, LengthUnit.Millimeters, value => value * MilesToMillimeters);
        UnitConverter.RegisterConversion(LengthUnit.Miles, LengthUnit.Centimeters, value => value * MilesToCentimeters);
        UnitConverter.RegisterConversion(LengthUnit.Miles, LengthUnit.Meters, value => value * MilesToMeters);
        UnitConverter.RegisterConversion(LengthUnit.Miles, LengthUnit.Kilometers, value => value * MilesToKilometers);
        UnitConverter.RegisterConversion(LengthUnit.Miles, LengthUnit.Inches, value => value * MilesToInches);
        UnitConverter.RegisterConversion(LengthUnit.Miles, LengthUnit.Feet, value => value * MilesToFeet);
        UnitConverter.RegisterConversion(LengthUnit.Miles, LengthUnit.Yards, value => value * MilesToYards);
    }

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
    public static double Convert(double value, LengthUnit from, LengthUnit to)
    {
        return UnitConverter.Convert(value, from, to);
    }
}

/// <summary>
/// Specifies units of length for conversion operations.
/// </summary>
public enum LengthUnit
{
    /// <summary>
    /// Length in millimeters.
    /// </summary>
    Millimeters,
    /// <summary>
    /// Length in centimeters.
    /// </summary>
    Centimeters,
    /// <summary>
    /// Length in meters.
    /// </summary>
    Meters,
    /// <summary>
    /// Length in kilometers.
    /// </summary>
    Kilometers,
    /// <summary>
    /// Length in inches.
    /// </summary>
    Inches,
    /// <summary>
    /// Length in feet.
    /// </summary>
    Feet,
    /// <summary>
    /// Length in yards.
    /// </summary>
    Yards,
    /// <summary>
    /// Length in miles.
    /// </summary>
    Miles
}