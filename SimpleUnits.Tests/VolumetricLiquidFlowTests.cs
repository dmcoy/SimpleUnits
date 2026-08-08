using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class VolumetricLiquidFlowTests
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
    public void BrldToFt3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.BrldToFt3hr, VolumetricLiquidFlow.BrldToFt3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToFt3min_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.BrldToFt3min, VolumetricLiquidFlow.BrldToFt3min(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToGalmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.BrldToGalmin, VolumetricLiquidFlow.BrldToGalmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToLmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.BrldToLmin, VolumetricLiquidFlow.BrldToLmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToLsec_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.BrldToLsec, VolumetricLiquidFlow.BrldToLsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToM3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.BrldToM3hr, VolumetricLiquidFlow.BrldToM3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToBrld_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3hrToBrld, VolumetricLiquidFlow.Ft3hrToBrld(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToFt3min_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3hrToFt3min, VolumetricLiquidFlow.Ft3hrToFt3min(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToGalmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3hrToGalmin, VolumetricLiquidFlow.Ft3hrToGalmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToLmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3hrToLmin, VolumetricLiquidFlow.Ft3hrToLmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToLsec_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3hrToLsec, VolumetricLiquidFlow.Ft3hrToLsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToM3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3hrToM3hr, VolumetricLiquidFlow.Ft3hrToM3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToBrld_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3minToBrld, VolumetricLiquidFlow.Ft3minToBrld(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToFt3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3minToFt3hr, VolumetricLiquidFlow.Ft3minToFt3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToGalmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3minToGalmin, VolumetricLiquidFlow.Ft3minToGalmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToLmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3minToLmin, VolumetricLiquidFlow.Ft3minToLmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToLsec_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3minToLsec, VolumetricLiquidFlow.Ft3minToLsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToM3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.Ft3minToM3hr, VolumetricLiquidFlow.Ft3minToM3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToBrld_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.GalminToBrld, VolumetricLiquidFlow.GalminToBrld(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToFt3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.GalminToFt3hr, VolumetricLiquidFlow.GalminToFt3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToFt3min_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.GalminToFt3min, VolumetricLiquidFlow.GalminToFt3min(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToLmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.GalminToLmin, VolumetricLiquidFlow.GalminToLmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToLsec_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.GalminToLsec, VolumetricLiquidFlow.GalminToLsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToM3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.GalminToM3hr, VolumetricLiquidFlow.GalminToM3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToBrld_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LminToBrld, VolumetricLiquidFlow.LminToBrld(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToFt3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LminToFt3hr, VolumetricLiquidFlow.LminToFt3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToFt3min_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LminToFt3min, VolumetricLiquidFlow.LminToFt3min(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToGalmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LminToGalmin, VolumetricLiquidFlow.LminToGalmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToLsec_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LminToLsec, VolumetricLiquidFlow.LminToLsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToM3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LminToM3hr, VolumetricLiquidFlow.LminToM3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToBrld_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LsecToBrld, VolumetricLiquidFlow.LsecToBrld(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToFt3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LsecToFt3hr, VolumetricLiquidFlow.LsecToFt3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToFt3min_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LsecToFt3min, VolumetricLiquidFlow.LsecToFt3min(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToGalmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LsecToGalmin, VolumetricLiquidFlow.LsecToGalmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToLmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LsecToLmin, VolumetricLiquidFlow.LsecToLmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToM3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.LsecToM3hr, VolumetricLiquidFlow.LsecToM3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToBrld_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.M3hrToBrld, VolumetricLiquidFlow.M3hrToBrld(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToFt3hr_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.M3hrToFt3hr, VolumetricLiquidFlow.M3hrToFt3hr(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToFt3min_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.M3hrToFt3min, VolumetricLiquidFlow.M3hrToFt3min(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToGalmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.M3hrToGalmin, VolumetricLiquidFlow.M3hrToGalmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToLmin_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.M3hrToLmin, VolumetricLiquidFlow.M3hrToLmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToLsec_MatchesFactor(double value) =>
        Assert.Equal(value * VolumetricLiquidFlow.Factor.M3hrToLsec, VolumetricLiquidFlow.M3hrToLsec(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LsecToLmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToLmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lsec, VolumetricLiquidFlow.Unit.Lmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LsecToM3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToM3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lsec, VolumetricLiquidFlow.Unit.M3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LsecToFt3min_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToFt3min(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lsec, VolumetricLiquidFlow.Unit.Ft3min));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LsecToFt3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToFt3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lsec, VolumetricLiquidFlow.Unit.Ft3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LsecToGalmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToGalmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lsec, VolumetricLiquidFlow.Unit.Galmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LsecToBrld_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToBrld(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lsec, VolumetricLiquidFlow.Unit.Brld));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LminToLsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToLsec(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lmin, VolumetricLiquidFlow.Unit.Lsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LminToM3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToM3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lmin, VolumetricLiquidFlow.Unit.M3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LminToFt3min_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToFt3min(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lmin, VolumetricLiquidFlow.Unit.Ft3min));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LminToFt3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToFt3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lmin, VolumetricLiquidFlow.Unit.Ft3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LminToGalmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToGalmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lmin, VolumetricLiquidFlow.Unit.Galmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LminToBrld_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToBrld(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lmin, VolumetricLiquidFlow.Unit.Brld));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3hrToLsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToLsec(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.M3hr, VolumetricLiquidFlow.Unit.Lsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3hrToLmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToLmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.M3hr, VolumetricLiquidFlow.Unit.Lmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3hrToFt3min_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToFt3min(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.M3hr, VolumetricLiquidFlow.Unit.Ft3min));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3hrToFt3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToFt3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.M3hr, VolumetricLiquidFlow.Unit.Ft3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3hrToGalmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToGalmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.M3hr, VolumetricLiquidFlow.Unit.Galmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3hrToBrld_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToBrld(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.M3hr, VolumetricLiquidFlow.Unit.Brld));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3minToLsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToLsec(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3min, VolumetricLiquidFlow.Unit.Lsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3minToLmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToLmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3min, VolumetricLiquidFlow.Unit.Lmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3minToM3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToM3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3min, VolumetricLiquidFlow.Unit.M3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3minToFt3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToFt3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3min, VolumetricLiquidFlow.Unit.Ft3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3minToGalmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToGalmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3min, VolumetricLiquidFlow.Unit.Galmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3minToBrld_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToBrld(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3min, VolumetricLiquidFlow.Unit.Brld));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3hrToLsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToLsec(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3hr, VolumetricLiquidFlow.Unit.Lsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3hrToLmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToLmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3hr, VolumetricLiquidFlow.Unit.Lmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3hrToM3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToM3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3hr, VolumetricLiquidFlow.Unit.M3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3hrToFt3min_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToFt3min(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3hr, VolumetricLiquidFlow.Unit.Ft3min));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3hrToGalmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToGalmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3hr, VolumetricLiquidFlow.Unit.Galmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3hrToBrld_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToBrld(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3hr, VolumetricLiquidFlow.Unit.Brld));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GalminToLsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToLsec(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Galmin, VolumetricLiquidFlow.Unit.Lsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GalminToLmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToLmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Galmin, VolumetricLiquidFlow.Unit.Lmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GalminToM3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToM3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Galmin, VolumetricLiquidFlow.Unit.M3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GalminToFt3min_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToFt3min(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Galmin, VolumetricLiquidFlow.Unit.Ft3min));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GalminToFt3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToFt3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Galmin, VolumetricLiquidFlow.Unit.Ft3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GalminToBrld_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToBrld(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Galmin, VolumetricLiquidFlow.Unit.Brld));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BrldToLsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToLsec(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Brld, VolumetricLiquidFlow.Unit.Lsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BrldToLmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToLmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Brld, VolumetricLiquidFlow.Unit.Lmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BrldToM3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToM3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Brld, VolumetricLiquidFlow.Unit.M3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BrldToFt3min_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToFt3min(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Brld, VolumetricLiquidFlow.Unit.Ft3min));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BrldToFt3hr_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToFt3hr(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Brld, VolumetricLiquidFlow.Unit.Ft3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BrldToGalmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToGalmin(value), VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Brld, VolumetricLiquidFlow.Unit.Galmin));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToFt3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToFt3hr(value), value.BrldToFt3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BrldToFt3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.BrldToFt3hr(value), value.BrldToFt3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToFt3min_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToFt3min(value), value.BrldToFt3min());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BrldToFt3min_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.BrldToFt3min(value), value.BrldToFt3min());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToGalmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToGalmin(value), value.BrldToGalmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BrldToGalmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.BrldToGalmin(value), value.BrldToGalmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToLmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToLmin(value), value.BrldToLmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BrldToLmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.BrldToLmin(value), value.BrldToLmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToLsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToLsec(value), value.BrldToLsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BrldToLsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.BrldToLsec(value), value.BrldToLsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BrldToM3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.BrldToM3hr(value), value.BrldToM3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BrldToM3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.BrldToM3hr(value), value.BrldToM3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToBrld_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToBrld(value), value.Ft3hrToBrld());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3hrToBrld_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3hrToBrld(value), value.Ft3hrToBrld());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToFt3min_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToFt3min(value), value.Ft3hrToFt3min());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3hrToFt3min_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3hrToFt3min(value), value.Ft3hrToFt3min());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToGalmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToGalmin(value), value.Ft3hrToGalmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3hrToGalmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3hrToGalmin(value), value.Ft3hrToGalmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToLmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToLmin(value), value.Ft3hrToLmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3hrToLmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3hrToLmin(value), value.Ft3hrToLmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToLsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToLsec(value), value.Ft3hrToLsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3hrToLsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3hrToLsec(value), value.Ft3hrToLsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3hrToM3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3hrToM3hr(value), value.Ft3hrToM3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3hrToM3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3hrToM3hr(value), value.Ft3hrToM3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToBrld_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToBrld(value), value.Ft3minToBrld());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3minToBrld_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3minToBrld(value), value.Ft3minToBrld());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToFt3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToFt3hr(value), value.Ft3minToFt3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3minToFt3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3minToFt3hr(value), value.Ft3minToFt3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToGalmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToGalmin(value), value.Ft3minToGalmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3minToGalmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3minToGalmin(value), value.Ft3minToGalmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToLmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToLmin(value), value.Ft3minToLmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3minToLmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3minToLmin(value), value.Ft3minToLmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToLsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToLsec(value), value.Ft3minToLsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3minToLsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3minToLsec(value), value.Ft3minToLsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft3minToM3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.Ft3minToM3hr(value), value.Ft3minToM3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft3minToM3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.Ft3minToM3hr(value), value.Ft3minToM3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToBrld_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToBrld(value), value.GalminToBrld());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GalminToBrld_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.GalminToBrld(value), value.GalminToBrld());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToFt3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToFt3hr(value), value.GalminToFt3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GalminToFt3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.GalminToFt3hr(value), value.GalminToFt3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToFt3min_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToFt3min(value), value.GalminToFt3min());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GalminToFt3min_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.GalminToFt3min(value), value.GalminToFt3min());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToLmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToLmin(value), value.GalminToLmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GalminToLmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.GalminToLmin(value), value.GalminToLmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToLsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToLsec(value), value.GalminToLsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GalminToLsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.GalminToLsec(value), value.GalminToLsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GalminToM3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.GalminToM3hr(value), value.GalminToM3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GalminToM3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.GalminToM3hr(value), value.GalminToM3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToBrld_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToBrld(value), value.LminToBrld());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LminToBrld_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LminToBrld(value), value.LminToBrld());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToFt3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToFt3hr(value), value.LminToFt3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LminToFt3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LminToFt3hr(value), value.LminToFt3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToFt3min_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToFt3min(value), value.LminToFt3min());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LminToFt3min_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LminToFt3min(value), value.LminToFt3min());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToGalmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToGalmin(value), value.LminToGalmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LminToGalmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LminToGalmin(value), value.LminToGalmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToLsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToLsec(value), value.LminToLsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LminToLsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LminToLsec(value), value.LminToLsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LminToM3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LminToM3hr(value), value.LminToM3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LminToM3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LminToM3hr(value), value.LminToM3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToBrld_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToBrld(value), value.LsecToBrld());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LsecToBrld_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LsecToBrld(value), value.LsecToBrld());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToFt3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToFt3hr(value), value.LsecToFt3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LsecToFt3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LsecToFt3hr(value), value.LsecToFt3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToFt3min_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToFt3min(value), value.LsecToFt3min());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LsecToFt3min_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LsecToFt3min(value), value.LsecToFt3min());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToGalmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToGalmin(value), value.LsecToGalmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LsecToGalmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LsecToGalmin(value), value.LsecToGalmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToLmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToLmin(value), value.LsecToLmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LsecToLmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LsecToLmin(value), value.LsecToLmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LsecToM3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.LsecToM3hr(value), value.LsecToM3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LsecToM3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.LsecToM3hr(value), value.LsecToM3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToBrld_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToBrld(value), value.M3hrToBrld());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3hrToBrld_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.M3hrToBrld(value), value.M3hrToBrld());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToFt3hr_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToFt3hr(value), value.M3hrToFt3hr());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3hrToFt3hr_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.M3hrToFt3hr(value), value.M3hrToFt3hr());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToFt3min_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToFt3min(value), value.M3hrToFt3min());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3hrToFt3min_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.M3hrToFt3min(value), value.M3hrToFt3min());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToGalmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToGalmin(value), value.M3hrToGalmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3hrToGalmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.M3hrToGalmin(value), value.M3hrToGalmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToLmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToLmin(value), value.M3hrToLmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3hrToLmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.M3hrToLmin(value), value.M3hrToLmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M3hrToLsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(VolumetricLiquidFlow.M3hrToLsec(value), value.M3hrToLsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M3hrToLsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)VolumetricLiquidFlow.M3hrToLsec(value), value.M3hrToLsec());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LsecToLsec_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lsec, VolumetricLiquidFlow.Unit.Lsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LminToLmin_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Lmin, VolumetricLiquidFlow.Unit.Lmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M3hrToM3hr_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.M3hr, VolumetricLiquidFlow.Unit.M3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3minToFt3min_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3min, VolumetricLiquidFlow.Unit.Ft3min));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft3hrToFt3hr_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Ft3hr, VolumetricLiquidFlow.Unit.Ft3hr));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GalminToGalmin_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Galmin, VolumetricLiquidFlow.Unit.Galmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BrldToBrld_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, VolumetricLiquidFlow.Convert(value, VolumetricLiquidFlow.Unit.Brld, VolumetricLiquidFlow.Unit.Brld));

    #endregion
}
