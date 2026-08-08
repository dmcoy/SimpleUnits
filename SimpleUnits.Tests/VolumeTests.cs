using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class VolumeTests
{
    public static IEnumerable<object[]> SampleValues() => new[]
    {
        new object[] { 1d },
        new object[] { 12.5d },
        new object[] { -3.75d },
    };

    public static IEnumerable<object[]> SampleFloatValues() => new[]
    {
        new object[] { 1f },
        new object[] { 12.5f },
        new object[] { -3.75f },
    };

    #region Conversion methods match their published Factor constant

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToFt3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Cm3ToFt3, Volume.Cm3ToFt3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToImpGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Cm3ToImpGal, Volume.Cm3ToImpGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToIn3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Cm3ToIn3, Volume.Cm3ToIn3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToLtr_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Cm3ToLtr, Volume.Cm3ToLtr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToM3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Cm3ToM3, Volume.Cm3ToM3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToUSBrl_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Cm3ToUSBrl, Volume.Cm3ToUSBrl(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToUSGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Cm3ToUSGal, Volume.Cm3ToUSGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToCm3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Ft3ToCm3, Volume.Ft3ToCm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToImpGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Ft3ToImpGal, Volume.Ft3ToImpGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToIn3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Ft3ToIn3, Volume.Ft3ToIn3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToLtr_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Ft3ToLtr, Volume.Ft3ToLtr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToM3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Ft3ToM3, Volume.Ft3ToM3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToUSBrl_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Ft3ToUSBrl, Volume.Ft3ToUSBrl(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToUSGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.Ft3ToUSGal, Volume.Ft3ToUSGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToCm3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.ImpGalToCm3, Volume.ImpGalToCm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToFt3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.ImpGalToFt3, Volume.ImpGalToFt3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToIn3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.ImpGalToIn3, Volume.ImpGalToIn3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToLtr_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.ImpGalToLtr, Volume.ImpGalToLtr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToM3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.ImpGalToM3, Volume.ImpGalToM3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToUSBrl_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.ImpGalToUSBrl, Volume.ImpGalToUSBrl(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToUSGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.ImpGalToUSGal, Volume.ImpGalToUSGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToCm3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.In3ToCm3, Volume.In3ToCm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToFt3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.In3ToFt3, Volume.In3ToFt3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToImpGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.In3ToImpGal, Volume.In3ToImpGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToLtr_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.In3ToLtr, Volume.In3ToLtr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToM3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.In3ToM3, Volume.In3ToM3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToUSBrl_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.In3ToUSBrl, Volume.In3ToUSBrl(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToUSGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.In3ToUSGal, Volume.In3ToUSGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToCm3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.LtrToCm3, Volume.LtrToCm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToFt3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.LtrToFt3, Volume.LtrToFt3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToImpGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.LtrToImpGal, Volume.LtrToImpGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToIn3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.LtrToIn3, Volume.LtrToIn3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToM3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.LtrToM3, Volume.LtrToM3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToUSGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.LtrToUSGal, Volume.LtrToUSGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToCm3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.M3ToCm3, Volume.M3ToCm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToFt3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.M3ToFt3, Volume.M3ToFt3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToImpGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.M3ToImpGal, Volume.M3ToImpGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToIn3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.M3ToIn3, Volume.M3ToIn3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToLtr_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.M3ToLtr, Volume.M3ToLtr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToUSGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.M3ToUSGal, Volume.M3ToUSGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToCm3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USBrlToCm3, Volume.USBrlToCm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToFt3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USBrlToFt3, Volume.USBrlToFt3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToImpGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USBrlToImpGal, Volume.USBrlToImpGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToIn3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USBrlToIn3, Volume.USBrlToIn3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToLtr_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USBrlToLtr, Volume.USBrlToLtr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToM3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USBrlToM3, Volume.USBrlToM3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToUSGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USBrlToUSGal, Volume.USBrlToUSGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToCm3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USGalToCm3, Volume.USGalToCm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToFt3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USGalToFt3, Volume.USGalToFt3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToImpGal_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USGalToImpGal, Volume.USGalToImpGal(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToIn3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USGalToIn3, Volume.USGalToIn3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToLtr_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USGalToLtr, Volume.USGalToLtr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToM3_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USGalToM3, Volume.USGalToM3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToUSBrl_MatchesFactor(double value) =>
        Assert.Equal(value * Volume.Factor.USGalToUSBrl, Volume.USGalToUSBrl(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm3ToM3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToM3(value), Volume.Convert(value, Volume.Unit.Cm3, Volume.Unit.M3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm3ToLtr_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToLtr(value), Volume.Convert(value, Volume.Unit.Cm3, Volume.Unit.Ltr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm3ToIn3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToIn3(value), Volume.Convert(value, Volume.Unit.Cm3, Volume.Unit.In3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm3ToFt3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToFt3(value), Volume.Convert(value, Volume.Unit.Cm3, Volume.Unit.Ft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm3ToUSGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToUSGal(value), Volume.Convert(value, Volume.Unit.Cm3, Volume.Unit.USGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm3ToImpGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToImpGal(value), Volume.Convert(value, Volume.Unit.Cm3, Volume.Unit.ImpGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm3ToUSBrl_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToUSBrl(value), Volume.Convert(value, Volume.Unit.Cm3, Volume.Unit.USBrl));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3ToCm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToCm3(value), Volume.Convert(value, Volume.Unit.M3, Volume.Unit.Cm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3ToLtr_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToLtr(value), Volume.Convert(value, Volume.Unit.M3, Volume.Unit.Ltr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3ToIn3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToIn3(value), Volume.Convert(value, Volume.Unit.M3, Volume.Unit.In3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3ToFt3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToFt3(value), Volume.Convert(value, Volume.Unit.M3, Volume.Unit.Ft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3ToUSGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToUSGal(value), Volume.Convert(value, Volume.Unit.M3, Volume.Unit.USGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3ToImpGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToImpGal(value), Volume.Convert(value, Volume.Unit.M3, Volume.Unit.ImpGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtrToCm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToCm3(value), Volume.Convert(value, Volume.Unit.Ltr, Volume.Unit.Cm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtrToM3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToM3(value), Volume.Convert(value, Volume.Unit.Ltr, Volume.Unit.M3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtrToIn3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToIn3(value), Volume.Convert(value, Volume.Unit.Ltr, Volume.Unit.In3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtrToFt3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToFt3(value), Volume.Convert(value, Volume.Unit.Ltr, Volume.Unit.Ft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtrToUSGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToUSGal(value), Volume.Convert(value, Volume.Unit.Ltr, Volume.Unit.USGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtrToImpGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToImpGal(value), Volume.Convert(value, Volume.Unit.Ltr, Volume.Unit.ImpGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In3ToCm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToCm3(value), Volume.Convert(value, Volume.Unit.In3, Volume.Unit.Cm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In3ToM3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToM3(value), Volume.Convert(value, Volume.Unit.In3, Volume.Unit.M3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In3ToLtr_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToLtr(value), Volume.Convert(value, Volume.Unit.In3, Volume.Unit.Ltr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In3ToFt3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToFt3(value), Volume.Convert(value, Volume.Unit.In3, Volume.Unit.Ft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In3ToUSGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToUSGal(value), Volume.Convert(value, Volume.Unit.In3, Volume.Unit.USGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In3ToImpGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToImpGal(value), Volume.Convert(value, Volume.Unit.In3, Volume.Unit.ImpGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In3ToUSBrl_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToUSBrl(value), Volume.Convert(value, Volume.Unit.In3, Volume.Unit.USBrl));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3ToCm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToCm3(value), Volume.Convert(value, Volume.Unit.Ft3, Volume.Unit.Cm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3ToM3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToM3(value), Volume.Convert(value, Volume.Unit.Ft3, Volume.Unit.M3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3ToLtr_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToLtr(value), Volume.Convert(value, Volume.Unit.Ft3, Volume.Unit.Ltr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3ToIn3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToIn3(value), Volume.Convert(value, Volume.Unit.Ft3, Volume.Unit.In3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3ToUSGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToUSGal(value), Volume.Convert(value, Volume.Unit.Ft3, Volume.Unit.USGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3ToImpGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToImpGal(value), Volume.Convert(value, Volume.Unit.Ft3, Volume.Unit.ImpGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3ToUSBrl_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToUSBrl(value), Volume.Convert(value, Volume.Unit.Ft3, Volume.Unit.USBrl));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USGalToCm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToCm3(value), Volume.Convert(value, Volume.Unit.USGal, Volume.Unit.Cm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USGalToM3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToM3(value), Volume.Convert(value, Volume.Unit.USGal, Volume.Unit.M3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USGalToLtr_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToLtr(value), Volume.Convert(value, Volume.Unit.USGal, Volume.Unit.Ltr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USGalToIn3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToIn3(value), Volume.Convert(value, Volume.Unit.USGal, Volume.Unit.In3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USGalToFt3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToFt3(value), Volume.Convert(value, Volume.Unit.USGal, Volume.Unit.Ft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USGalToImpGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToImpGal(value), Volume.Convert(value, Volume.Unit.USGal, Volume.Unit.ImpGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USGalToUSBrl_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToUSBrl(value), Volume.Convert(value, Volume.Unit.USGal, Volume.Unit.USBrl));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ImpGalToCm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToCm3(value), Volume.Convert(value, Volume.Unit.ImpGal, Volume.Unit.Cm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ImpGalToM3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToM3(value), Volume.Convert(value, Volume.Unit.ImpGal, Volume.Unit.M3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ImpGalToLtr_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToLtr(value), Volume.Convert(value, Volume.Unit.ImpGal, Volume.Unit.Ltr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ImpGalToIn3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToIn3(value), Volume.Convert(value, Volume.Unit.ImpGal, Volume.Unit.In3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ImpGalToFt3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToFt3(value), Volume.Convert(value, Volume.Unit.ImpGal, Volume.Unit.Ft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ImpGalToUSGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToUSGal(value), Volume.Convert(value, Volume.Unit.ImpGal, Volume.Unit.USGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ImpGalToUSBrl_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToUSBrl(value), Volume.Convert(value, Volume.Unit.ImpGal, Volume.Unit.USBrl));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USBrlToCm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToCm3(value), Volume.Convert(value, Volume.Unit.USBrl, Volume.Unit.Cm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USBrlToM3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToM3(value), Volume.Convert(value, Volume.Unit.USBrl, Volume.Unit.M3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USBrlToLtr_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToLtr(value), Volume.Convert(value, Volume.Unit.USBrl, Volume.Unit.Ltr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USBrlToIn3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToIn3(value), Volume.Convert(value, Volume.Unit.USBrl, Volume.Unit.In3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USBrlToFt3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToFt3(value), Volume.Convert(value, Volume.Unit.USBrl, Volume.Unit.Ft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USBrlToUSGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToUSGal(value), Volume.Convert(value, Volume.Unit.USBrl, Volume.Unit.USGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USBrlToImpGal_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToImpGal(value), Volume.Convert(value, Volume.Unit.USBrl, Volume.Unit.ImpGal));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToFt3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToFt3(value), value.Cm3ToFt3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm3ToFt3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Cm3ToFt3(value), value.Cm3ToFt3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToImpGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToImpGal(value), value.Cm3ToImpGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm3ToImpGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Cm3ToImpGal(value), value.Cm3ToImpGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToIn3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToIn3(value), value.Cm3ToIn3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm3ToIn3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Cm3ToIn3(value), value.Cm3ToIn3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToLtr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToLtr(value), value.Cm3ToLtr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm3ToLtr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Cm3ToLtr(value), value.Cm3ToLtr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToM3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToM3(value), value.Cm3ToM3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm3ToM3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Cm3ToM3(value), value.Cm3ToM3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToUSBrl_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToUSBrl(value), value.Cm3ToUSBrl());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm3ToUSBrl_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Cm3ToUSBrl(value), value.Cm3ToUSBrl());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm3ToUSGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Cm3ToUSGal(value), value.Cm3ToUSGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm3ToUSGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Cm3ToUSGal(value), value.Cm3ToUSGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToCm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToCm3(value), value.Ft3ToCm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3ToCm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Ft3ToCm3(value), value.Ft3ToCm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToImpGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToImpGal(value), value.Ft3ToImpGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3ToImpGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Ft3ToImpGal(value), value.Ft3ToImpGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToIn3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToIn3(value), value.Ft3ToIn3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3ToIn3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Ft3ToIn3(value), value.Ft3ToIn3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToLtr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToLtr(value), value.Ft3ToLtr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3ToLtr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Ft3ToLtr(value), value.Ft3ToLtr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToM3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToM3(value), value.Ft3ToM3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3ToM3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Ft3ToM3(value), value.Ft3ToM3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToUSBrl_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToUSBrl(value), value.Ft3ToUSBrl());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3ToUSBrl_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Ft3ToUSBrl(value), value.Ft3ToUSBrl());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3ToUSGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.Ft3ToUSGal(value), value.Ft3ToUSGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3ToUSGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.Ft3ToUSGal(value), value.Ft3ToUSGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToCm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToCm3(value), value.ImpGalToCm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ImpGalToCm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.ImpGalToCm3(value), value.ImpGalToCm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToFt3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToFt3(value), value.ImpGalToFt3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ImpGalToFt3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.ImpGalToFt3(value), value.ImpGalToFt3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToIn3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToIn3(value), value.ImpGalToIn3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ImpGalToIn3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.ImpGalToIn3(value), value.ImpGalToIn3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToLtr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToLtr(value), value.ImpGalToLtr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ImpGalToLtr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.ImpGalToLtr(value), value.ImpGalToLtr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToM3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToM3(value), value.ImpGalToM3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ImpGalToM3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.ImpGalToM3(value), value.ImpGalToM3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToUSBrl_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToUSBrl(value), value.ImpGalToUSBrl());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ImpGalToUSBrl_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.ImpGalToUSBrl(value), value.ImpGalToUSBrl());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ImpGalToUSGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.ImpGalToUSGal(value), value.ImpGalToUSGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ImpGalToUSGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.ImpGalToUSGal(value), value.ImpGalToUSGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToCm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToCm3(value), value.In3ToCm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In3ToCm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.In3ToCm3(value), value.In3ToCm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToFt3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToFt3(value), value.In3ToFt3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In3ToFt3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.In3ToFt3(value), value.In3ToFt3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToImpGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToImpGal(value), value.In3ToImpGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In3ToImpGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.In3ToImpGal(value), value.In3ToImpGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToLtr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToLtr(value), value.In3ToLtr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In3ToLtr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.In3ToLtr(value), value.In3ToLtr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToM3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToM3(value), value.In3ToM3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In3ToM3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.In3ToM3(value), value.In3ToM3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToUSBrl_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToUSBrl(value), value.In3ToUSBrl());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In3ToUSBrl_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.In3ToUSBrl(value), value.In3ToUSBrl());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In3ToUSGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.In3ToUSGal(value), value.In3ToUSGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In3ToUSGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.In3ToUSGal(value), value.In3ToUSGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToCm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToCm3(value), value.LtrToCm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtrToCm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.LtrToCm3(value), value.LtrToCm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToFt3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToFt3(value), value.LtrToFt3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtrToFt3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.LtrToFt3(value), value.LtrToFt3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToImpGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToImpGal(value), value.LtrToImpGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtrToImpGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.LtrToImpGal(value), value.LtrToImpGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToIn3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToIn3(value), value.LtrToIn3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtrToIn3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.LtrToIn3(value), value.LtrToIn3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToM3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToM3(value), value.LtrToM3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtrToM3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.LtrToM3(value), value.LtrToM3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtrToUSGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.LtrToUSGal(value), value.LtrToUSGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtrToUSGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.LtrToUSGal(value), value.LtrToUSGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToCm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToCm3(value), value.M3ToCm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3ToCm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.M3ToCm3(value), value.M3ToCm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToFt3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToFt3(value), value.M3ToFt3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3ToFt3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.M3ToFt3(value), value.M3ToFt3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToImpGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToImpGal(value), value.M3ToImpGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3ToImpGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.M3ToImpGal(value), value.M3ToImpGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToIn3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToIn3(value), value.M3ToIn3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3ToIn3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.M3ToIn3(value), value.M3ToIn3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToLtr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToLtr(value), value.M3ToLtr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3ToLtr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.M3ToLtr(value), value.M3ToLtr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3ToUSGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.M3ToUSGal(value), value.M3ToUSGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3ToUSGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.M3ToUSGal(value), value.M3ToUSGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToCm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToCm3(value), value.USBrlToCm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USBrlToCm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USBrlToCm3(value), value.USBrlToCm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToFt3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToFt3(value), value.USBrlToFt3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USBrlToFt3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USBrlToFt3(value), value.USBrlToFt3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToImpGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToImpGal(value), value.USBrlToImpGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USBrlToImpGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USBrlToImpGal(value), value.USBrlToImpGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToIn3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToIn3(value), value.USBrlToIn3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USBrlToIn3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USBrlToIn3(value), value.USBrlToIn3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToLtr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToLtr(value), value.USBrlToLtr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USBrlToLtr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USBrlToLtr(value), value.USBrlToLtr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToM3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToM3(value), value.USBrlToM3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USBrlToM3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USBrlToM3(value), value.USBrlToM3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USBrlToUSGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USBrlToUSGal(value), value.USBrlToUSGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USBrlToUSGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USBrlToUSGal(value), value.USBrlToUSGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToCm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToCm3(value), value.USGalToCm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USGalToCm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USGalToCm3(value), value.USGalToCm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToFt3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToFt3(value), value.USGalToFt3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USGalToFt3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USGalToFt3(value), value.USGalToFt3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToImpGal_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToImpGal(value), value.USGalToImpGal());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USGalToImpGal_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USGalToImpGal(value), value.USGalToImpGal());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToIn3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToIn3(value), value.USGalToIn3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USGalToIn3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USGalToIn3(value), value.USGalToIn3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToLtr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToLtr(value), value.USGalToLtr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USGalToLtr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USGalToLtr(value), value.USGalToLtr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToM3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToM3(value), value.USGalToM3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USGalToM3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USGalToM3(value), value.USGalToM3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void USGalToUSBrl_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Volume.USGalToUSBrl(value), value.USGalToUSBrl());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void USGalToUSBrl_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Volume.USGalToUSBrl(value), value.USGalToUSBrl());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm3ToCm3_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Volume.Convert(value, Volume.Unit.Cm3, Volume.Unit.Cm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3ToM3_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Volume.Convert(value, Volume.Unit.M3, Volume.Unit.M3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtrToLtr_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Volume.Convert(value, Volume.Unit.Ltr, Volume.Unit.Ltr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In3ToIn3_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Volume.Convert(value, Volume.Unit.In3, Volume.Unit.In3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3ToFt3_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Volume.Convert(value, Volume.Unit.Ft3, Volume.Unit.Ft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USGalToUSGal_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Volume.Convert(value, Volume.Unit.USGal, Volume.Unit.USGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ImpGalToImpGal_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Volume.Convert(value, Volume.Unit.ImpGal, Volume.Unit.ImpGal));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_USBrlToUSBrl_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Volume.Convert(value, Volume.Unit.USBrl, Volume.Unit.USBrl));

    #endregion
}
