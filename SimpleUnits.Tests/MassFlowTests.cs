using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class MassFlowTests
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
    public void KghToKgs_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.KghToKgs, MassFlow.KghToKgs(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KghToLbh_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.KghToLbh, MassFlow.KghToLbh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KghToTh_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.KghToTh, MassFlow.KghToTh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgsToKgh_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.KgsToKgh, MassFlow.KgsToKgh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgsToLbh_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.KgsToLbh, MassFlow.KgsToLbh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgsToTh_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.KgsToTh, MassFlow.KgsToTh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbhToKgh_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.LbhToKgh, MassFlow.LbhToKgh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbhToKgs_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.LbhToKgs, MassFlow.LbhToKgs(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbhToTh_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.LbhToTh, MassFlow.LbhToTh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ThToKgh_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.ThToKgh, MassFlow.ThToKgh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ThToKgs_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.ThToKgs, MassFlow.ThToKgs(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ThToLbh_MatchesFactor(double value) =>
        Assert.Equal(value * MassFlow.Factor.ThToLbh, MassFlow.ThToLbh(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KghToLbh_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KghToLbh(value), MassFlow.Convert(value, MassFlow.Unit.Kgh, MassFlow.Unit.Lbh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KghToKgs_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KghToKgs(value), MassFlow.Convert(value, MassFlow.Unit.Kgh, MassFlow.Unit.Kgs));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KghToTh_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KghToTh(value), MassFlow.Convert(value, MassFlow.Unit.Kgh, MassFlow.Unit.Th));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbhToKgh_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.LbhToKgh(value), MassFlow.Convert(value, MassFlow.Unit.Lbh, MassFlow.Unit.Kgh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbhToKgs_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.LbhToKgs(value), MassFlow.Convert(value, MassFlow.Unit.Lbh, MassFlow.Unit.Kgs));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbhToTh_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.LbhToTh(value), MassFlow.Convert(value, MassFlow.Unit.Lbh, MassFlow.Unit.Th));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgsToKgh_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KgsToKgh(value), MassFlow.Convert(value, MassFlow.Unit.Kgs, MassFlow.Unit.Kgh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgsToLbh_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KgsToLbh(value), MassFlow.Convert(value, MassFlow.Unit.Kgs, MassFlow.Unit.Lbh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgsToTh_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KgsToTh(value), MassFlow.Convert(value, MassFlow.Unit.Kgs, MassFlow.Unit.Th));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ThToKgh_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.ThToKgh(value), MassFlow.Convert(value, MassFlow.Unit.Th, MassFlow.Unit.Kgh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ThToLbh_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.ThToLbh(value), MassFlow.Convert(value, MassFlow.Unit.Th, MassFlow.Unit.Lbh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ThToKgs_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.ThToKgs(value), MassFlow.Convert(value, MassFlow.Unit.Th, MassFlow.Unit.Kgs));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KghToKgs_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KghToKgs(value), value.KghToKgs());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KghToKgs_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.KghToKgs(value), value.KghToKgs());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KghToLbh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KghToLbh(value), value.KghToLbh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KghToLbh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.KghToLbh(value), value.KghToLbh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KghToTh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KghToTh(value), value.KghToTh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KghToTh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.KghToTh(value), value.KghToTh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgsToKgh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KgsToKgh(value), value.KgsToKgh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgsToKgh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.KgsToKgh(value), value.KgsToKgh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgsToLbh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KgsToLbh(value), value.KgsToLbh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgsToLbh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.KgsToLbh(value), value.KgsToLbh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgsToTh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.KgsToTh(value), value.KgsToTh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgsToTh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.KgsToTh(value), value.KgsToTh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbhToKgh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.LbhToKgh(value), value.LbhToKgh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LbhToKgh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.LbhToKgh(value), value.LbhToKgh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbhToKgs_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.LbhToKgs(value), value.LbhToKgs());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LbhToKgs_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.LbhToKgs(value), value.LbhToKgs());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbhToTh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.LbhToTh(value), value.LbhToTh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LbhToTh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.LbhToTh(value), value.LbhToTh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ThToKgh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.ThToKgh(value), value.ThToKgh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ThToKgh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.ThToKgh(value), value.ThToKgh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ThToKgs_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.ThToKgs(value), value.ThToKgs());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ThToKgs_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.ThToKgs(value), value.ThToKgs());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ThToLbh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(MassFlow.ThToLbh(value), value.ThToLbh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ThToLbh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)MassFlow.ThToLbh(value), value.ThToLbh());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KghToKgh_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, MassFlow.Convert(value, MassFlow.Unit.Kgh, MassFlow.Unit.Kgh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbhToLbh_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, MassFlow.Convert(value, MassFlow.Unit.Lbh, MassFlow.Unit.Lbh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgsToKgs_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, MassFlow.Convert(value, MassFlow.Unit.Kgs, MassFlow.Unit.Kgs));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ThToTh_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, MassFlow.Convert(value, MassFlow.Unit.Th, MassFlow.Unit.Th));

    #endregion
}
