using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class VolumetricGasFlowTests
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
    public void Nm3hrToScfh_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricGasFlow.Factor.Nm3hrToScfh, VolumetricGasFlow.Nm3hrToScfh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Nm3hrToScfm_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricGasFlow.Factor.Nm3hrToScfm, VolumetricGasFlow.Nm3hrToScfm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ScfhToNm3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricGasFlow.Factor.ScfhToNm3hr, VolumetricGasFlow.ScfhToNm3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ScfhToScfm_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricGasFlow.Factor.ScfhToScfm, VolumetricGasFlow.ScfhToScfm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ScfmToNm3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricGasFlow.Factor.ScfmToNm3hr, VolumetricGasFlow.ScfmToNm3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ScfmToScfh_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricGasFlow.Factor.ScfmToScfh, VolumetricGasFlow.ScfmToScfh(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Nm3hrToScfh_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.Nm3hrToScfh(value), VolumetricGasFlow.Convert(value, VolumetricGasFlow.Unit.Nm3hr, VolumetricGasFlow.Unit.Scfh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Nm3hrToScfm_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.Nm3hrToScfm(value), VolumetricGasFlow.Convert(value, VolumetricGasFlow.Unit.Nm3hr, VolumetricGasFlow.Unit.Scfm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ScfhToNm3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.ScfhToNm3hr(value), VolumetricGasFlow.Convert(value, VolumetricGasFlow.Unit.Scfh, VolumetricGasFlow.Unit.Nm3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ScfhToScfm_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.ScfhToScfm(value), VolumetricGasFlow.Convert(value, VolumetricGasFlow.Unit.Scfh, VolumetricGasFlow.Unit.Scfm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ScfmToNm3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.ScfmToNm3hr(value), VolumetricGasFlow.Convert(value, VolumetricGasFlow.Unit.Scfm, VolumetricGasFlow.Unit.Nm3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ScfmToScfh_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.ScfmToScfh(value), VolumetricGasFlow.Convert(value, VolumetricGasFlow.Unit.Scfm, VolumetricGasFlow.Unit.Scfh));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Nm3hrToScfh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.Nm3hrToScfh(value), value.Nm3hrToScfh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Nm3hrToScfh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricGasFlow.Nm3hrToScfh(value), value.Nm3hrToScfh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Nm3hrToScfm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.Nm3hrToScfm(value), value.Nm3hrToScfm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Nm3hrToScfm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricGasFlow.Nm3hrToScfm(value), value.Nm3hrToScfm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ScfhToNm3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.ScfhToNm3hr(value), value.ScfhToNm3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ScfhToNm3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricGasFlow.ScfhToNm3hr(value), value.ScfhToNm3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ScfhToScfm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.ScfhToScfm(value), value.ScfhToScfm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ScfhToScfm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricGasFlow.ScfhToScfm(value), value.ScfhToScfm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ScfmToNm3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.ScfmToNm3hr(value), value.ScfmToNm3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ScfmToNm3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricGasFlow.ScfmToNm3hr(value), value.ScfmToNm3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ScfmToScfh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricGasFlow.ScfmToScfh(value), value.ScfmToScfh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ScfmToScfh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricGasFlow.ScfmToScfh(value), value.ScfmToScfh());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Nm3hrToNm3hr_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricGasFlow.Convert(value, VolumetricGasFlow.Unit.Nm3hr, VolumetricGasFlow.Unit.Nm3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ScfhToScfh_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricGasFlow.Convert(value, VolumetricGasFlow.Unit.Scfh, VolumetricGasFlow.Unit.Scfh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ScfmToScfm_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricGasFlow.Convert(value, VolumetricGasFlow.Unit.Scfm, VolumetricGasFlow.Unit.Scfm));

    #endregion
}
