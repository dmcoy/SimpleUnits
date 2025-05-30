using SimpleUnits;
using SimpleUnits.Convert;

namespace UnitConsoleApp;
internal class Program
{
    static void Main(string[] args)
    {
        double inchesToMeters = Inches.ToMeters(3632121d);
        float inchesToMeters2 = Inches.ToMeters(3632121);
        float anyMeasurementToMeters = AnyLength.ToMeters(36, Length.Inches);
        Console.WriteLine(inchesToMeters);
        Console.WriteLine(inchesToMeters2);
        Console.WriteLine(anyMeasurementToMeters);
        Console.ReadKey();
    }
}
