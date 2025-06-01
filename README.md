# SimpleUnits
A lightweight static class library for unit conversions in dotnet projects. This was created to have simple methods for converting units.

## Development
- [ ] Create Nuget package

## How to use
``` csharp
using SimpleUnits;
```

## Converting units
``` csharp
// Converting a double value
double inches = 24;
double meters = Length.Convert(inches, LengthUnit.Inches, LengthUnit.Meters);

// Converting a float value
float psi = 14.7;
float bar = Pressure.Convert(psi, PressureUnit.Psi, PressureUnit.Bar);
```

## Conversion factors
``` csharp
double inchesToFeet = Length.InchesToFeet;
double feet = 12 * inchesToFeet;
```

### US Standard conversion factors
Some US Standard conversions such as converting inches to feet uses a conversion factor that will not produce a whole number. For example converting 12 inches to feet will not equal 1 when using the conversion factor. Using the Convert method takes this into account and produces the correct output.

For example
``` csharp
// Converting inches to feet using conversion factor
double inches = 12;
double feet = inches * Length.InchesToFeet;
// will output 0.9999960000000001

// Converting inches to feet using convert method
feet = Length.Convert(inches, LengthUnit.Inches, LenghtUnit.Feet);
// will output 1
```
