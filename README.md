# SimpleUnits
A lightweight static class library for unit conversions in dotnet projects.

## Development
- [ ] Create Nuget package

## How to use
``` csharp
using SimpleUnits;
```

## Converting units
You have two options for converting units.

If you know what unit you want to convert from and to, there are explicit methods in each class for doing so.
```csharp
// Converting bar to psi
double barToPsi = Pressure.BarToPsi(9.7);

// Converting kilometers to miles
double kmToMi = Length.KmToMi(71);

// Converting foot pounds to newton meters
double ftlbToNm = Torque.FtlbToNm(815);
```

Otherwise, each class contains a convert method, which lets you plug in which units you want to convert from and to using a unit enum available for each unit type. This is helpful in cases where you may want to dynamically pass in different arguments for your own use case.
``` csharp
// Converting bar to psi
double barToPsi = Pressure.Convert(9.7, PressureUnit.Psi, PressureUnit.Bar);

// Converting kilometers to miles
double kmToMi = Length.Convert(71, LengthUnit.Km, LengthUnit.Mi);

// Converting foot pounds to newton meters
double ftlbToNm = Torque.Convert(815, TorqueUnit.Ftlb, TorqueUnit.Nm);
```

## Conversion factors
You can also retrieve each conversion factor by accessing the constant value from the Factor struct in each class (with the exception of Temperature).
``` csharp
// Returns the conversion factor for bar to psi (14.50326)
double barToPsiFactor = Pressure.Factor.BarToPsi;
```

### US Standard conversion factors
Some US Standard conversions such as converting inches to feet uses a conversion factor that will not produce the correct output. For example converting 12 inches to feet will not equal 1 when using the conversion factor. Using the Convert method takes this into account and produces the correct output.

For example
``` csharp
// Converting using the conversion factor outputs 0.9999960000000001
double inches = 12;
double feet = inches * Length.Factor.InToFt;

// Converting using the Convert method outputs 1
feet = Length.Convert(inches, LengthUnit.Inches, LenghtUnit.Feet);
```

## Double vs. Float
Each of the explicit methods only returns type double. Only the Convert method for each class contains an overload to pass in a float value and return type float. You'll need to cast float if that's what you need when using the explicitly named methods.
``` csharp
double squareFeetDouble = Area.M2ToFt2(1.2);
float squareFeetFloat = (float)Area.M2ToFt2(1.2);

squareFeetDouble = Area.Convert(1.2, AreaUnit.M2, AreaUnit.Ft2);
squareFeetFloat = Area.Convert(1.2f, AreaUnit.M2, AreaUnit.Ft2);
```

## Available Units
``` shell
Area: Square millimeter (mm²), Square centimeter (cm²), Square meter (m²), Square kilometer (km²), Square inch (in²), Square feet (ft²), Square yard (yd²)
Density: Gram per millimeter (g/ml), Kilogram per cubic meter (kg/m³), Pound per cubic foot (lb/ft³), Pound per cubic inch (lb/in³)
Length: Millimeter (mm), Centimeter (cm), Meter (m), Kilometer (km), Inch (in), Feet (ft), Yard (yd), Mile (mi)
Mass: Gram (g), Kilogram (kg), Metric Tonne (Tonne), Short Ton (Shton), Long Ton (LTon), Pound (lb), Ounce (oz)
Pressure: Bar (bar), pounds per square inch (psi), Pascal (Pa), KiloPascal (KPa), MegaPascal (MPa), Kilogram-force per square centimeter (Kgf/cm²), Millimeters of mercury (mmHg), Standard atmosphere (atm)
Speed: Meter per second (m/s), Meter per minute (M/min), Kilometer per hour (Km/h), Foot per second (ft/s), Foot per minute (ft/min), Mile per hour (mph)
Temperature: Celsius (C), Fahrenheit (F), Kelvin (K)
Torque: Newton meter (Nm), Kilogram force meter (kgfm), Foot pound (ftlb), Inch pound (inlb)
Volume: Cubic centimeters (cm³), Cubic meters (m³), Liter (ltr), Cubic inch (in³), Cubic feet (ft³), US Gallons (USGal), ImpGal (Imp. Gal), US Barrel oil (US brl)
Volumetric Gas Flow: Normal meter cube per hour (Nm³/hr), Standard cubic feet per hour (scfh), Standard cubic feet per minute (scfm)
Volumetric Liquid Flow: Liter per second (L/sec), Liter per minute (L/min), Meter cube per hour (m³/hr), Foot cube per minute (ft³/min), Foot cube per hour (ft³/hr), US gallons per minute (gal/min), US barrels (oil) per day (US brl/d)
```
