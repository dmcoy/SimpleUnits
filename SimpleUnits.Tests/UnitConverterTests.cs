using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class UnitConverterTests
{
    // Deliberately never registered via UnitConverter.RegisterUnit, so it can stand in
    // for "someone added a new unit class but forgot to register it" without needing to
    // touch any of the library's real unit types.
    private enum UnregisteredUnit
    {
        A,
        B,
    }

    [Fact]
    public void Convert_UnregisteredFromUnit_ThrowsArgumentExceptionNamingIt()
    {
        var ex = Assert.Throws<ArgumentException>(
            () => UnitConverter.Convert(1.0, UnregisteredUnit.A, UnregisteredUnit.B));

        Assert.Contains("A", ex.Message);
        Assert.Contains("not registered", ex.Message);
    }

    [Fact]
    public void Convert_UnregisteredToUnit_ThrowsArgumentExceptionNamingIt()
    {
        // Length.Unit.Mm is registered; UnregisteredUnit.A is not -- so the "to" side
        // is the one that should be reported as missing.
        var ex = Assert.Throws<ArgumentException>(
            () => UnitConverter.Convert(1.0, Length.Unit.Mm, UnregisteredUnit.A));

        Assert.Contains("A", ex.Message);
        Assert.Contains("not registered", ex.Message);
    }

    [Fact]
    public void Convert_SameUnregisteredUnit_ReturnsValueWithoutThrowing()
    {
        // The fromUnit.Equals(toUnit) short-circuit in Convert runs before
        // BaseUnitsMatch, so this never touches the registration check at all.
        Assert.Equal(5.0, UnitConverter.Convert(5.0, UnregisteredUnit.A, UnregisteredUnit.A));
    }

    [Fact]
    public void Convert_IncompatibleRegisteredUnits_ThrowsArgumentException()
    {
        // Length.Unit and Mass.Unit are both registered, but with different BaseUnit
        // values, so BaseUnitsMatch should return false rather than throw.
        var ex = Assert.Throws<ArgumentException>(
            () => UnitConverter.Convert(1.0, Length.Unit.Mm, Mass.Unit.G));

        Assert.Contains("Cannot convert", ex.Message);
    }

    [Fact]
    public void Convert_CompatibleRegisteredUnits_ReturnsConvertedValue() =>
        Assert.Equal(Length.MmToCm(10), UnitConverter.Convert(10, Length.Unit.Mm, Length.Unit.Cm));
}
