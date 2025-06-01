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
