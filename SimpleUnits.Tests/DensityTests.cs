using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class DensityTests
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
    public void GmlToKgm3_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.GmlToKgm3, Density.GmlToKgm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GmlToLbft3_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.GmlToLbft3, Density.GmlToLbft3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GmlToLbin3_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.GmlToLbin3, Density.GmlToLbin3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Kgm3ToGml_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.Kgm3ToGml, Density.Kgm3ToGml(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Kgm3ToLbft3_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.Kgm3ToLbft3, Density.Kgm3ToLbft3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Kgm3ToLbin3_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.Kgm3ToLbin3, Density.Kgm3ToLbin3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbft3ToGml_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.Lbft3ToGml, Density.Lbft3ToGml(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbft3ToKgm3_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.Lbft3ToKgm3, Density.Lbft3ToKgm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbft3ToLbin3_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.Lbft3ToLbin3, Density.Lbft3ToLbin3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbin3ToGml_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.Lbin3ToGml, Density.Lbin3ToGml(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbin3ToKgm3_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.Lbin3ToKgm3, Density.Lbin3ToKgm3(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbin3ToLbft3_MatchesFactor(double value) =>
        Assert.Equal(value * Density.Factor.Lbin3ToLbft3, Density.Lbin3ToLbft3(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GmlToKgm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.GmlToKgm3(value), Density.Convert(value, Density.Unit.Gml, Density.Unit.Kgm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GmlToLbft3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.GmlToLbft3(value), Density.Convert(value, Density.Unit.Gml, Density.Unit.Lbft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GmlToLbin3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.GmlToLbin3(value), Density.Convert(value, Density.Unit.Gml, Density.Unit.Lbin3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Kgm3ToGml_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Kgm3ToGml(value), Density.Convert(value, Density.Unit.Kgm3, Density.Unit.Gml));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Kgm3ToLbft3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Kgm3ToLbft3(value), Density.Convert(value, Density.Unit.Kgm3, Density.Unit.Lbft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Kgm3ToLbin3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Kgm3ToLbin3(value), Density.Convert(value, Density.Unit.Kgm3, Density.Unit.Lbin3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Lbft3ToGml_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbft3ToGml(value), Density.Convert(value, Density.Unit.Lbft3, Density.Unit.Gml));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Lbft3ToKgm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbft3ToKgm3(value), Density.Convert(value, Density.Unit.Lbft3, Density.Unit.Kgm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Lbft3ToLbin3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbft3ToLbin3(value), Density.Convert(value, Density.Unit.Lbft3, Density.Unit.Lbin3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Lbin3ToGml_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbin3ToGml(value), Density.Convert(value, Density.Unit.Lbin3, Density.Unit.Gml));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Lbin3ToKgm3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbin3ToKgm3(value), Density.Convert(value, Density.Unit.Lbin3, Density.Unit.Kgm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Lbin3ToLbft3_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbin3ToLbft3(value), Density.Convert(value, Density.Unit.Lbin3, Density.Unit.Lbft3));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GmlToKgm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.GmlToKgm3(value), value.GmlToKgm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GmlToKgm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.GmlToKgm3(value), value.GmlToKgm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GmlToLbft3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.GmlToLbft3(value), value.GmlToLbft3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GmlToLbft3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.GmlToLbft3(value), value.GmlToLbft3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GmlToLbin3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.GmlToLbin3(value), value.GmlToLbin3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GmlToLbin3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.GmlToLbin3(value), value.GmlToLbin3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Kgm3ToGml_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Kgm3ToGml(value), value.Kgm3ToGml());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Kgm3ToGml_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.Kgm3ToGml(value), value.Kgm3ToGml());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Kgm3ToLbft3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Kgm3ToLbft3(value), value.Kgm3ToLbft3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Kgm3ToLbft3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.Kgm3ToLbft3(value), value.Kgm3ToLbft3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Kgm3ToLbin3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Kgm3ToLbin3(value), value.Kgm3ToLbin3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Kgm3ToLbin3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.Kgm3ToLbin3(value), value.Kgm3ToLbin3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbft3ToGml_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbft3ToGml(value), value.Lbft3ToGml());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Lbft3ToGml_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.Lbft3ToGml(value), value.Lbft3ToGml());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbft3ToKgm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbft3ToKgm3(value), value.Lbft3ToKgm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Lbft3ToKgm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.Lbft3ToKgm3(value), value.Lbft3ToKgm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbft3ToLbin3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbft3ToLbin3(value), value.Lbft3ToLbin3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Lbft3ToLbin3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.Lbft3ToLbin3(value), value.Lbft3ToLbin3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbin3ToGml_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbin3ToGml(value), value.Lbin3ToGml());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Lbin3ToGml_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.Lbin3ToGml(value), value.Lbin3ToGml());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbin3ToKgm3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbin3ToKgm3(value), value.Lbin3ToKgm3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Lbin3ToKgm3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.Lbin3ToKgm3(value), value.Lbin3ToKgm3());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Lbin3ToLbft3_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Density.Lbin3ToLbft3(value), value.Lbin3ToLbft3());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Lbin3ToLbft3_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Density.Lbin3ToLbft3(value), value.Lbin3ToLbft3());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GmlToGml_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Density.Convert(value, Density.Unit.Gml, Density.Unit.Gml));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Kgm3ToKgm3_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Density.Convert(value, Density.Unit.Kgm3, Density.Unit.Kgm3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Lbft3ToLbft3_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Density.Convert(value, Density.Unit.Lbft3, Density.Unit.Lbft3));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Lbin3ToLbin3_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Density.Convert(value, Density.Unit.Lbin3, Density.Unit.Lbin3));

    #endregion
}
