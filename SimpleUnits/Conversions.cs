namespace SimpleUnits;
/// <summary>
/// Provides constant conversion factors for various units of length and torque.
/// </summary>
public static class Conversions
{
    #region Length
    /// <summary>Conversion factor from millimeters to centimeters.</summary>
    public const double MillimetersToCentimeters = 0.1;
    /// <summary>Conversion factor from millimeters to meters.</summary>
    public const double MillimetersToMeters = 0.001;
    /// <summary>Conversion factor from millimeters to kilometers.</summary>
    public const double MillimetersToKilometers = 0.000001;
    /// <summary>Conversion factor from millimeters to inches.</summary>
    public const double MillimetersToInches = 0.03937;
    /// <summary>Conversion factor from millimeters to feet.</summary>
    public const double MillimetersToFeet = 0.003281;
    /// <summary>Conversion factor from millimeters to yards.</summary>
    public const double MillimetersToYards = 0.001094;
    /// <summary>Conversion factor from millimeters to miles.</summary>
    public const double MillimetersToMiles = 6.21e-07;

    /// <summary>Conversion factor from centimeters to millimeters.</summary>
    public const double CentimetersToMillimeters = 10;
    /// <summary>Conversion factor from centimeters to meters.</summary>
    public const double CentimetersToMeters = 0.01;
    /// <summary>Conversion factor from centimeters to kilometers.</summary>
    public const double CentimetersToKilometers = 0.0001;
    /// <summary>Conversion factor from centimeters to inches.</summary>
    public const double CentimetersToInches = 0.393701;
    /// <summary>Conversion factor from centimeters to feet.</summary>
    public const double CentimetersToFeet = 0.032808;
    /// <summary>Conversion factor from centimeters to yards.</summary>
    public const double CentimetersToYards = 0.010936;
    /// <summary>Conversion factor from centimeters to miles.</summary>
    public const double CentimetersToMiles = 0.000006;

    /// <summary>Conversion factor from meters to millimeters.</summary>
    public const double MetersToMillimeters = 1000;
    /// <summary>Conversion factor from meters to centimeters.</summary>
    public const double MetersToCentimeters = 100;
    /// <summary>Conversion factor from meters to kilometers.</summary>
    public const double MetersToKilometers = 0.001;
    /// <summary>Conversion factor from meters to inches.</summary>
    public const double MetersToInches = 39.37008;
    /// <summary>Conversion factor from meters to feet.</summary>
    public const double MetersToFeet = 3.28084;
    /// <summary>Conversion factor from meters to yards.</summary>
    public const double MetersToYards = 1.093613;
    /// <summary>Conversion factor from meters to miles.</summary>
    public const double MetersToMiles = 0.000621;

    /// <summary>Conversion factor from kilometers to millimeters.</summary>
    public const double KilometersToMillimeters = 1000000;
    /// <summary>Conversion factor from kilometers to centimeters.</summary>
    public const double KilometersToCentimeters = 100000;
    /// <summary>Conversion factor from kilometers to meters.</summary>
    public const double KilometersToMeters = 1000;
    /// <summary>Conversion factor from kilometers to inches.</summary>
    public const double KilometersToInches = 39370.08;
    /// <summary>Conversion factor from kilometers to feet.</summary>
    public const double KilometersToFeet = 3280.84;
    /// <summary>Conversion factor from kilometers to yards.</summary>
    public const double KilometersToYards = 1093.613;
    /// <summary>Conversion factor from kilometers to miles.</summary>
    public const double KilometersToMiles = 0.621371;

    /// <summary>Conversion factor from inches to millimeters.</summary>
    public const double InchesToMillimeters = 25.4;
    /// <summary>Conversion factor from inches to centimeters.</summary>
    public const double InchesToCentimeters = 2.54;
    /// <summary>Conversion factor from inches to meters.</summary>
    public const double InchesToMeters = 0.0254;
    /// <summary>Conversion factor from inches to kilometers.</summary>
    public const double InchesToKilometers = 0.000025;
    /// <summary>Conversion factor from inches to feet.</summary>
    public const double InchesToFeet = 0.08333;
    /// <summary>Conversion factor from inches to yards.</summary>
    public const double InchesToYards = 0.027778;
    /// <summary>Conversion factor from inches to miles.</summary>
    public const double InchesToMiles = 0.000016;

    /// <summary>Conversion factor from feet to millimeters.</summary>
    public const double FeetToMillimeters = 304.8;
    /// <summary>Conversion factor from feet to centimeters.</summary>
    public const double FeetToCentimeters = 30.48;
    /// <summary>Conversion factor from feet to meters.</summary>
    public const double FeetToMeters = 0.3048;
    /// <summary>Conversion factor from feet to kilometers.</summary>
    public const double FeetToKilometers = 0.0003048;
    /// <summary>Conversion factor from feet to inches.</summary>
    public const double FeetToInches = 12;
    /// <summary>Conversion factor from feet to yards.</summary>
    public const double FeetToYards = 0.333333;
    /// <summary>Conversion factor from feet to miles.</summary>
    public const double FeetToMiles = 0.000189;

    /// <summary>Conversion factor from yards to millimeters.</summary>
    public const double YardsToMillimeters = 914.4;
    /// <summary>Conversion factor from yards to centimeters.</summary>
    public const double YardsToCentimeters = 91.44;
    /// <summary>Conversion factor from yards to meters.</summary>
    public const double YardsToMeters = 0.9144;
    /// <summary>Conversion factor from yards to kilometers.</summary>
    public const double YardsToKilometers = 0.000914;
    /// <summary>Conversion factor from yards to inches.</summary>
    public const double YardsToInches = 36;
    /// <summary>Conversion factor from yards to feet.</summary>
    public const double YardsToFeet = 3;
    /// <summary>Conversion factor from yards to miles.</summary>
    public const double YardsToMiles = 0.000568;

    /// <summary>Conversion factor from miles to millimeters.</summary>
    public const double MilesToMillimeters = 1609344;
    /// <summary>Conversion factor from miles to centimeters.</summary>
    public const double MilesToCentimeters = 160934.4;
    /// <summary>Conversion factor from miles to meters.</summary>
    public const double MilesToMeters = 1609.344;
    /// <summary>Conversion factor from miles to kilometers.</summary>
    public const double MilesToKilometers = 1.609344;
    /// <summary>Conversion factor from miles to inches.</summary>
    public const double MilesToInches = 63360;
    /// <summary>Conversion factor from miles to feet.</summary>
    public const double MilesToFeet = 5280;
    /// <summary>Conversion factor from miles to yards.</summary>
    public const double MilesToYards = 1760;
    #endregion

    #region Torque
    /// <summary>Conversion factor from newton-meters to kilogram-force meters.</summary>
    public const double Nm_to_Kgfm = 0.101972;
    /// <summary>Conversion factor from newton-meters to foot-pounds.</summary>
    public const double Nm_to_Ftlb = 0.737561;
    /// <summary>Conversion factor from newton-meters to inch-pounds.</summary>
    public const double Nm_to_Inlb = 8.850732;

    /// <summary>Conversion factor from kilogram-force meters to newton-meters.</summary>
    public const double Kgfm_to_Nm = 9.80665;
    /// <summary>Conversion factor from kilogram-force meters to foot-pounds.</summary>
    public const double Kgfm_to_Ftlb = 7.233003;
    /// <summary>Conversion factor from kilogram-force meters to inch-pounds.</summary>
    public const double Kgfm_to_Inlb = 86.79603;

    /// <summary>Conversion factor from foot-pounds to newton-meters.</summary>
    public const double Ftlb_to_Nm = 1.35582;
    /// <summary>Conversion factor from foot-pounds to kilogram-force meters.</summary>
    public const double Ftlb_to_Kgfm = 0.138255;
    /// <summary>Conversion factor from foot-pounds to inch-pounds.</summary>
    public const double Ftlb_to_Inlb = 12;

    /// <summary>Conversion factor from inch-pounds to newton-meters.</summary>
    public const double Inlb_to_Nm = 0.112985;
    /// <summary>Conversion factor from inch-pounds to kilogram-force meters.</summary>
    public const double Inlb_to_Kgfm = 0.011521;
    /// <summary>Conversion factor from inch-pounds to foot-pounds.</summary>
    public const double Inlb_to_Ftlb = 0.083333;
    #endregion
}
