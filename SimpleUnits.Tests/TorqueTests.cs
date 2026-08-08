using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class TorqueTests
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
    public void FtlbToInlb_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.FtlbToInlb, Torque.FtlbToInlb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtlbToKgfm_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.FtlbToKgfm, Torque.FtlbToKgfm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtlbToNm_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.FtlbToNm, Torque.FtlbToNm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InlbToFtlb_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.InlbToFtlb, Torque.InlbToFtlb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InlbToKgfm_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.InlbToKgfm, Torque.InlbToKgfm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InlbToNm_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.InlbToNm, Torque.InlbToNm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfmToFtlb_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.KgfmToFtlb, Torque.KgfmToFtlb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfmToInlb_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.KgfmToInlb, Torque.KgfmToInlb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfmToNm_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.KgfmToNm, Torque.KgfmToNm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void NmToFtlb_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.NmToFtlb, Torque.NmToFtlb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void NmToInlb_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.NmToInlb, Torque.NmToInlb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void NmToKgfm_MatchesFactor(double value) =>
        Assert.Equal(value * Torque.Factor.NmToKgfm, Torque.NmToKgfm(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_NmToKgfm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.NmToKgfm(value), Torque.Convert(value, Torque.Unit.Nm, Torque.Unit.Kgfm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_NmToFtlb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.NmToFtlb(value), Torque.Convert(value, Torque.Unit.Nm, Torque.Unit.Ftlb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_NmToInlb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.NmToInlb(value), Torque.Convert(value, Torque.Unit.Nm, Torque.Unit.Inlb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfmToNm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.KgfmToNm(value), Torque.Convert(value, Torque.Unit.Kgfm, Torque.Unit.Nm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfmToFtlb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.KgfmToFtlb(value), Torque.Convert(value, Torque.Unit.Kgfm, Torque.Unit.Ftlb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfmToInlb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.KgfmToInlb(value), Torque.Convert(value, Torque.Unit.Kgfm, Torque.Unit.Inlb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtlbToNm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.FtlbToNm(value), Torque.Convert(value, Torque.Unit.Ftlb, Torque.Unit.Nm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtlbToKgfm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.FtlbToKgfm(value), Torque.Convert(value, Torque.Unit.Ftlb, Torque.Unit.Kgfm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtlbToInlb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.FtlbToInlb(value), Torque.Convert(value, Torque.Unit.Ftlb, Torque.Unit.Inlb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InlbToNm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.InlbToNm(value), Torque.Convert(value, Torque.Unit.Inlb, Torque.Unit.Nm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InlbToKgfm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.InlbToKgfm(value), Torque.Convert(value, Torque.Unit.Inlb, Torque.Unit.Kgfm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InlbToFtlb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.InlbToFtlb(value), Torque.Convert(value, Torque.Unit.Inlb, Torque.Unit.Ftlb));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtlbToInlb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.FtlbToInlb(value), value.FtlbToInlb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtlbToInlb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.FtlbToInlb(value), value.FtlbToInlb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtlbToKgfm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.FtlbToKgfm(value), value.FtlbToKgfm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtlbToKgfm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.FtlbToKgfm(value), value.FtlbToKgfm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtlbToNm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.FtlbToNm(value), value.FtlbToNm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtlbToNm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.FtlbToNm(value), value.FtlbToNm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InlbToFtlb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.InlbToFtlb(value), value.InlbToFtlb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InlbToFtlb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.InlbToFtlb(value), value.InlbToFtlb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InlbToKgfm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.InlbToKgfm(value), value.InlbToKgfm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InlbToKgfm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.InlbToKgfm(value), value.InlbToKgfm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InlbToNm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.InlbToNm(value), value.InlbToNm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InlbToNm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.InlbToNm(value), value.InlbToNm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfmToFtlb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.KgfmToFtlb(value), value.KgfmToFtlb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfmToFtlb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.KgfmToFtlb(value), value.KgfmToFtlb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfmToInlb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.KgfmToInlb(value), value.KgfmToInlb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfmToInlb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.KgfmToInlb(value), value.KgfmToInlb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfmToNm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.KgfmToNm(value), value.KgfmToNm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfmToNm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.KgfmToNm(value), value.KgfmToNm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void NmToFtlb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.NmToFtlb(value), value.NmToFtlb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void NmToFtlb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.NmToFtlb(value), value.NmToFtlb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void NmToInlb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.NmToInlb(value), value.NmToInlb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void NmToInlb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.NmToInlb(value), value.NmToInlb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void NmToKgfm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Torque.NmToKgfm(value), value.NmToKgfm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void NmToKgfm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Torque.NmToKgfm(value), value.NmToKgfm());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_NmToNm_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Torque.Convert(value, Torque.Unit.Nm, Torque.Unit.Nm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfmToKgfm_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Torque.Convert(value, Torque.Unit.Kgfm, Torque.Unit.Kgfm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtlbToFtlb_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Torque.Convert(value, Torque.Unit.Ftlb, Torque.Unit.Ftlb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InlbToInlb_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Torque.Convert(value, Torque.Unit.Inlb, Torque.Unit.Inlb));

    #endregion
}
