using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class TemperatureTests
{
    #region Celsius to Fahrenheit

    [Fact]
    public void CtoF_WaterFreezingPoint() => Assert.Equal(32.0, Temperature.CtoF(0));

    [Fact]
    public void CtoF_WaterBoilingPoint() => Assert.Equal(212.0, Temperature.CtoF(100));

    [Fact]
    public void CtoF_StandardRoomTemp() => Assert.Equal(77.0, Temperature.CtoF(25));

    [Fact]
    public void CtoF_AbsoluteZeroCelsius() => Assert.Equal(-459.67, Temperature.CtoF(-273.15), 2);

    [Fact]
    public void CtoF_NegativeValue() => Assert.Equal(14.0, Temperature.CtoF(-10));

    [Fact]
    public void CtoF_DecimalValue() => Assert.Equal(99.5, Temperature.CtoF(37.5));

    #endregion

    #region Celsius to Kelvin

    [Fact]
    public void CtoK_WaterFreezingPoint() => Assert.Equal(273.15, Temperature.CtoK(0));

    [Fact]
    public void CtoK_WaterBoilingPoint() => Assert.Equal(373.15, Temperature.CtoK(100));

    [Fact]
    public void CtoK_AbsoluteZeroCelsius() => Assert.Equal(0.0, Temperature.CtoK(-273.15));

    [Fact]
    public void CtoK_DecimalValue() => Assert.Equal(298.65, Temperature.CtoK(25.5));

    #endregion

    #region Fahrenheit to Celsius

    [Fact]
    public void FtoC_WaterFreezingPoint() => Assert.Equal(0.0, Temperature.FtoC(32));

    [Fact]
    public void FtoC_WaterBoilingPoint() => Assert.Equal(100.0, Temperature.FtoC(212));

    [Fact]
    public void FtoC_AverageBodyTemp() => Assert.Equal(37.0, Temperature.FtoC(98.6), 3);

    [Fact]
    public void FtoC_NegativeValue() => Assert.Equal(-40.0, Temperature.FtoC(-40));

    #endregion

    #region Fahrenheit to Kelvin

    [Fact]
    public void FtoK_WaterFreezingPoint() => Assert.Equal(273.15, Temperature.FtoK(32));

    [Fact]
    public void FtoK_WaterBoilingPoint() => Assert.Equal(373.15, Temperature.FtoK(212));

    #endregion

    #region Kelvin to Celsius

    [Fact]
    public void KtoC_WaterFreezingPoint() => Assert.Equal(0.0, Temperature.KtoC(273.15));

    [Fact]
    public void KtoC_WaterBoilingPoint() => Assert.Equal(100.0, Temperature.KtoC(373.15));

    [Fact]
    public void KtoC_AbsoluteZeroKelvin() => Assert.Equal(-273.15, Temperature.KtoC(0));

    [Fact]
    public void KtoC_RoomTemp() => Assert.Equal(25.0, Temperature.KtoC(298.15));

    #endregion

    #region Kelvin to Fahrenheit

    [Fact]
    public void KtoF_AbsoluteZeroKelvin() => Assert.Equal(-459.67, Temperature.KtoF(0), 2);

    [Fact]
    public void KtoF_WaterFreezingPoint() => Assert.Equal(32.0, Temperature.KtoF(273.15));

    [Fact]
    public void KtoF_WaterBoilingPoint() => Assert.Equal(212.0, Temperature.KtoF(373.15));

    #endregion

    #region Round-trip conversions

    [Fact]
    public void C_K_C_RoundTrip()
    {
        double celsius = 50.0;
        double roundTripped = Temperature.KtoC(Temperature.CtoK(celsius));
        Assert.Equal(celsius, roundTripped);
    }

    [Fact]
    public void F_C_F_RoundTrip()
    {
        double fahrenheit = 104.0;
        double roundTripped = Temperature.CtoF(Temperature.FtoC(fahrenheit));
        Assert.Equal(fahrenheit, roundTripped, 9);
    }

    [Fact]
    public void F_K_F_RoundTrip()
    {
        double fahrenheit = 104.0;
        double roundTripped = Temperature.KtoF(Temperature.FtoK(fahrenheit));
        Assert.Equal(fahrenheit, roundTripped, 9);
    }

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [InlineData(0)]
    [InlineData(37.5)]
    [InlineData(-40)]
    public void Convert_CtoF_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.CtoF(value), Temperature.Convert(value, Temperature.Unit.C, Temperature.Unit.F));

    [Theory]
    [InlineData(0)]
    [InlineData(37.5)]
    [InlineData(-40)]
    public void Convert_CtoK_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.CtoK(value), Temperature.Convert(value, Temperature.Unit.C, Temperature.Unit.K));

    [Theory]
    [InlineData(32)]
    [InlineData(98.6)]
    [InlineData(-40)]
    public void Convert_FtoC_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.FtoC(value), Temperature.Convert(value, Temperature.Unit.F, Temperature.Unit.C));

    [Theory]
    [InlineData(32)]
    [InlineData(98.6)]
    [InlineData(-40)]
    public void Convert_FtoK_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.FtoK(value), Temperature.Convert(value, Temperature.Unit.F, Temperature.Unit.K));

    [Theory]
    [InlineData(0)]
    [InlineData(273.15)]
    [InlineData(373.15)]
    public void Convert_KtoC_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.KtoC(value), Temperature.Convert(value, Temperature.Unit.K, Temperature.Unit.C));

    [Theory]
    [InlineData(0)]
    [InlineData(273.15)]
    [InlineData(373.15)]
    public void Convert_KtoF_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.KtoF(value), Temperature.Convert(value, Temperature.Unit.K, Temperature.Unit.F));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [InlineData(0)]
    [InlineData(37.5)]
    [InlineData(-40)]
    public void CtoF_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.CtoF(value), value.CtoF());

    [Theory]
    [InlineData(0f)]
    [InlineData(37.5f)]
    [InlineData(-40f)]
    public void CtoF_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Temperature.CtoF(value), value.CtoF());

    [Theory]
    [InlineData(0)]
    [InlineData(37.5)]
    [InlineData(-40)]
    public void CtoK_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.CtoK(value), value.CtoK());

    [Theory]
    [InlineData(0f)]
    [InlineData(37.5f)]
    [InlineData(-40f)]
    public void CtoK_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Temperature.CtoK(value), value.CtoK());

    [Theory]
    [InlineData(32)]
    [InlineData(98.6)]
    [InlineData(-40)]
    public void FtoC_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.FtoC(value), value.FtoC());

    [Theory]
    [InlineData(32f)]
    [InlineData(98.6f)]
    [InlineData(-40f)]
    public void FtoC_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Temperature.FtoC(value), value.FtoC());

    [Theory]
    [InlineData(32)]
    [InlineData(98.6)]
    [InlineData(-40)]
    public void FtoK_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.FtoK(value), value.FtoK());

    [Theory]
    [InlineData(32f)]
    [InlineData(98.6f)]
    [InlineData(-40f)]
    public void FtoK_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Temperature.FtoK(value), value.FtoK());

    [Theory]
    [InlineData(0)]
    [InlineData(273.15)]
    [InlineData(373.15)]
    public void KtoC_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.KtoC(value), value.KtoC());

    [Theory]
    [InlineData(0f)]
    [InlineData(273.15f)]
    [InlineData(373.15f)]
    public void KtoC_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Temperature.KtoC(value), value.KtoC());

    [Theory]
    [InlineData(0)]
    [InlineData(273.15)]
    [InlineData(373.15)]
    public void KtoF_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Temperature.KtoF(value), value.KtoF());

    [Theory]
    [InlineData(0f)]
    [InlineData(273.15f)]
    [InlineData(373.15f)]
    public void KtoF_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Temperature.KtoF(value), value.KtoF());

    #endregion
}
