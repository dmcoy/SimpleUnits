using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class LengthTests
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
    public void CmToFt_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.CmToFt, Length.CmToFt(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToIn_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.CmToIn, Length.CmToIn(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToKm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.CmToKm, Length.CmToKm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToM_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.CmToM, Length.CmToM(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToMi_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.CmToMi, Length.CmToMi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToMm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.CmToMm, Length.CmToMm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToYd_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.CmToYd, Length.CmToYd(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToCm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.FtToCm, Length.FtToCm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToIn_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.FtToIn, Length.FtToIn(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToKm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.FtToKm, Length.FtToKm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToM_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.FtToM, Length.FtToM(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToMm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.FtToMm, Length.FtToMm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToCm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.InToCm, Length.InToCm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToKm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.InToKm, Length.InToKm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToM_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.InToM, Length.InToM(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToMm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.InToMm, Length.InToMm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToCm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.KmToCm, Length.KmToCm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToFt_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.KmToFt, Length.KmToFt(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToIn_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.KmToIn, Length.KmToIn(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToM_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.KmToM, Length.KmToM(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToMi_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.KmToMi, Length.KmToMi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToMm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.KmToMm, Length.KmToMm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToYd_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.KmToYd, Length.KmToYd(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToCm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MToCm, Length.MToCm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToFt_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MToFt, Length.MToFt(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToIn_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MToIn, Length.MToIn(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToKm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MToKm, Length.MToKm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToMi_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MToMi, Length.MToMi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToMm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MToMm, Length.MToMm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToYd_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MToYd, Length.MToYd(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToCm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MiToCm, Length.MiToCm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToFt_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MiToFt, Length.MiToFt(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToIn_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MiToIn, Length.MiToIn(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToKm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MiToKm, Length.MiToKm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToM_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MiToM, Length.MiToM(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToMm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MiToMm, Length.MiToMm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToYd_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MiToYd, Length.MiToYd(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToCm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MmToCm, Length.MmToCm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToFt_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MmToFt, Length.MmToFt(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToIn_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MmToIn, Length.MmToIn(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToKm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MmToKm, Length.MmToKm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToM_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MmToM, Length.MmToM(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToMi_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MmToMi, Length.MmToMi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToYd_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.MmToYd, Length.MmToYd(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToCm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.YdToCm, Length.YdToCm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToFt_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.YdToFt, Length.YdToFt(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToIn_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.YdToIn, Length.YdToIn(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToKm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.YdToKm, Length.YdToKm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToM_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.YdToM, Length.YdToM(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToMm_MatchesFactor(double value) =>
        Assert.Equal(value * Length.Factor.YdToMm, Length.YdToMm(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmToCm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToCm(value), Length.Convert(value, Length.Unit.Mm, Length.Unit.Cm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmToM_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToM(value), Length.Convert(value, Length.Unit.Mm, Length.Unit.M));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmToKm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToKm(value), Length.Convert(value, Length.Unit.Mm, Length.Unit.Km));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmToIn_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToIn(value), Length.Convert(value, Length.Unit.Mm, Length.Unit.In));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmToFt_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToFt(value), Length.Convert(value, Length.Unit.Mm, Length.Unit.Ft));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmToYd_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToYd(value), Length.Convert(value, Length.Unit.Mm, Length.Unit.Yd));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmToMi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToMi(value), Length.Convert(value, Length.Unit.Mm, Length.Unit.Mi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_CmToMm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToMm(value), Length.Convert(value, Length.Unit.Cm, Length.Unit.Mm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_CmToM_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToM(value), Length.Convert(value, Length.Unit.Cm, Length.Unit.M));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_CmToKm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToKm(value), Length.Convert(value, Length.Unit.Cm, Length.Unit.Km));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_CmToIn_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToIn(value), Length.Convert(value, Length.Unit.Cm, Length.Unit.In));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_CmToFt_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToFt(value), Length.Convert(value, Length.Unit.Cm, Length.Unit.Ft));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_CmToYd_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToYd(value), Length.Convert(value, Length.Unit.Cm, Length.Unit.Yd));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_CmToMi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToMi(value), Length.Convert(value, Length.Unit.Cm, Length.Unit.Mi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MToMm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToMm(value), Length.Convert(value, Length.Unit.M, Length.Unit.Mm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MToCm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToCm(value), Length.Convert(value, Length.Unit.M, Length.Unit.Cm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MToKm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToKm(value), Length.Convert(value, Length.Unit.M, Length.Unit.Km));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MToIn_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToIn(value), Length.Convert(value, Length.Unit.M, Length.Unit.In));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MToFt_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToFt(value), Length.Convert(value, Length.Unit.M, Length.Unit.Ft));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MToYd_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToYd(value), Length.Convert(value, Length.Unit.M, Length.Unit.Yd));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MToMi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToMi(value), Length.Convert(value, Length.Unit.M, Length.Unit.Mi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmToMm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToMm(value), Length.Convert(value, Length.Unit.Km, Length.Unit.Mm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmToCm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToCm(value), Length.Convert(value, Length.Unit.Km, Length.Unit.Cm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmToM_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToM(value), Length.Convert(value, Length.Unit.Km, Length.Unit.M));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmToIn_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToIn(value), Length.Convert(value, Length.Unit.Km, Length.Unit.In));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmToFt_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToFt(value), Length.Convert(value, Length.Unit.Km, Length.Unit.Ft));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmToYd_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToYd(value), Length.Convert(value, Length.Unit.Km, Length.Unit.Yd));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmToMi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToMi(value), Length.Convert(value, Length.Unit.Km, Length.Unit.Mi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InToMm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToMm(value), Length.Convert(value, Length.Unit.In, Length.Unit.Mm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InToCm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToCm(value), Length.Convert(value, Length.Unit.In, Length.Unit.Cm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InToM_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToM(value), Length.Convert(value, Length.Unit.In, Length.Unit.M));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InToKm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToKm(value), Length.Convert(value, Length.Unit.In, Length.Unit.Km));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InToFt_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToFt(value), Length.Convert(value, Length.Unit.In, Length.Unit.Ft));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InToYd_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToYd(value), Length.Convert(value, Length.Unit.In, Length.Unit.Yd));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InToMi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToMi(value), Length.Convert(value, Length.Unit.In, Length.Unit.Mi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtToMm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToMm(value), Length.Convert(value, Length.Unit.Ft, Length.Unit.Mm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtToCm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToCm(value), Length.Convert(value, Length.Unit.Ft, Length.Unit.Cm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtToM_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToM(value), Length.Convert(value, Length.Unit.Ft, Length.Unit.M));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtToKm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToKm(value), Length.Convert(value, Length.Unit.Ft, Length.Unit.Km));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtToIn_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToIn(value), Length.Convert(value, Length.Unit.Ft, Length.Unit.In));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtToYd_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToYd(value), Length.Convert(value, Length.Unit.Ft, Length.Unit.Yd));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtToMi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToMi(value), Length.Convert(value, Length.Unit.Ft, Length.Unit.Mi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_YdToMm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToMm(value), Length.Convert(value, Length.Unit.Yd, Length.Unit.Mm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_YdToCm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToCm(value), Length.Convert(value, Length.Unit.Yd, Length.Unit.Cm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_YdToM_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToM(value), Length.Convert(value, Length.Unit.Yd, Length.Unit.M));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_YdToKm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToKm(value), Length.Convert(value, Length.Unit.Yd, Length.Unit.Km));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_YdToIn_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToIn(value), Length.Convert(value, Length.Unit.Yd, Length.Unit.In));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_YdToFt_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToFt(value), Length.Convert(value, Length.Unit.Yd, Length.Unit.Ft));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_YdToMi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToMi(value), Length.Convert(value, Length.Unit.Yd, Length.Unit.Mi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MiToMm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToMm(value), Length.Convert(value, Length.Unit.Mi, Length.Unit.Mm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MiToCm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToCm(value), Length.Convert(value, Length.Unit.Mi, Length.Unit.Cm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MiToM_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToM(value), Length.Convert(value, Length.Unit.Mi, Length.Unit.M));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MiToKm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToKm(value), Length.Convert(value, Length.Unit.Mi, Length.Unit.Km));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MiToIn_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToIn(value), Length.Convert(value, Length.Unit.Mi, Length.Unit.In));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MiToFt_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToFt(value), Length.Convert(value, Length.Unit.Mi, Length.Unit.Ft));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MiToYd_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToYd(value), Length.Convert(value, Length.Unit.Mi, Length.Unit.Yd));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToFt_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToFt(value), value.CmToFt());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void CmToFt_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.CmToFt(value), value.CmToFt());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToIn_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToIn(value), value.CmToIn());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void CmToIn_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.CmToIn(value), value.CmToIn());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToKm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToKm(value), value.CmToKm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void CmToKm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.CmToKm(value), value.CmToKm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToM_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToM(value), value.CmToM());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void CmToM_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.CmToM(value), value.CmToM());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToMi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToMi(value), value.CmToMi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void CmToMi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.CmToMi(value), value.CmToMi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToMm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToMm(value), value.CmToMm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void CmToMm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.CmToMm(value), value.CmToMm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void CmToYd_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.CmToYd(value), value.CmToYd());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void CmToYd_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.CmToYd(value), value.CmToYd());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToCm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToCm(value), value.FtToCm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtToCm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.FtToCm(value), value.FtToCm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToIn_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToIn(value), value.FtToIn());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtToIn_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.FtToIn(value), value.FtToIn());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToKm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToKm(value), value.FtToKm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtToKm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.FtToKm(value), value.FtToKm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToM_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToM(value), value.FtToM());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtToM_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.FtToM(value), value.FtToM());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToMi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToMi(value), value.FtToMi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtToMi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.FtToMi(value), value.FtToMi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToMm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToMm(value), value.FtToMm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtToMm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.FtToMm(value), value.FtToMm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtToYd_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.FtToYd(value), value.FtToYd());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtToYd_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.FtToYd(value), value.FtToYd());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToCm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToCm(value), value.InToCm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InToCm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.InToCm(value), value.InToCm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToFt_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToFt(value), value.InToFt());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InToFt_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.InToFt(value), value.InToFt());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToKm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToKm(value), value.InToKm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InToKm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.InToKm(value), value.InToKm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToM_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToM(value), value.InToM());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InToM_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.InToM(value), value.InToM());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToMi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToMi(value), value.InToMi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InToMi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.InToMi(value), value.InToMi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToMm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToMm(value), value.InToMm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InToMm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.InToMm(value), value.InToMm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void InToYd_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.InToYd(value), value.InToYd());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void InToYd_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.InToYd(value), value.InToYd());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToCm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToCm(value), value.KmToCm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmToCm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.KmToCm(value), value.KmToCm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToFt_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToFt(value), value.KmToFt());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmToFt_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.KmToFt(value), value.KmToFt());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToIn_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToIn(value), value.KmToIn());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmToIn_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.KmToIn(value), value.KmToIn());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToM_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToM(value), value.KmToM());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmToM_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.KmToM(value), value.KmToM());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToMi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToMi(value), value.KmToMi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmToMi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.KmToMi(value), value.KmToMi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToMm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToMm(value), value.KmToMm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmToMm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.KmToMm(value), value.KmToMm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmToYd_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.KmToYd(value), value.KmToYd());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmToYd_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.KmToYd(value), value.KmToYd());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToCm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToCm(value), value.MToCm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MToCm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MToCm(value), value.MToCm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToFt_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToFt(value), value.MToFt());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MToFt_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MToFt(value), value.MToFt());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToIn_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToIn(value), value.MToIn());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MToIn_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MToIn(value), value.MToIn());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToKm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToKm(value), value.MToKm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MToKm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MToKm(value), value.MToKm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToMi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToMi(value), value.MToMi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MToMi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MToMi(value), value.MToMi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToMm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToMm(value), value.MToMm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MToMm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MToMm(value), value.MToMm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MToYd_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MToYd(value), value.MToYd());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MToYd_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MToYd(value), value.MToYd());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToCm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToCm(value), value.MiToCm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MiToCm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MiToCm(value), value.MiToCm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToFt_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToFt(value), value.MiToFt());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MiToFt_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MiToFt(value), value.MiToFt());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToIn_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToIn(value), value.MiToIn());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MiToIn_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MiToIn(value), value.MiToIn());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToKm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToKm(value), value.MiToKm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MiToKm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MiToKm(value), value.MiToKm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToM_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToM(value), value.MiToM());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MiToM_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MiToM(value), value.MiToM());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToMm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToMm(value), value.MiToMm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MiToMm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MiToMm(value), value.MiToMm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MiToYd_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MiToYd(value), value.MiToYd());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MiToYd_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MiToYd(value), value.MiToYd());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToCm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToCm(value), value.MmToCm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmToCm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MmToCm(value), value.MmToCm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToFt_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToFt(value), value.MmToFt());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmToFt_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MmToFt(value), value.MmToFt());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToIn_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToIn(value), value.MmToIn());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmToIn_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MmToIn(value), value.MmToIn());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToKm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToKm(value), value.MmToKm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmToKm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MmToKm(value), value.MmToKm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToM_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToM(value), value.MmToM());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmToM_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MmToM(value), value.MmToM());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToMi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToMi(value), value.MmToMi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmToMi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MmToMi(value), value.MmToMi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmToYd_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.MmToYd(value), value.MmToYd());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmToYd_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.MmToYd(value), value.MmToYd());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToCm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToCm(value), value.YdToCm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void YdToCm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.YdToCm(value), value.YdToCm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToFt_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToFt(value), value.YdToFt());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void YdToFt_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.YdToFt(value), value.YdToFt());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToIn_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToIn(value), value.YdToIn());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void YdToIn_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.YdToIn(value), value.YdToIn());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToKm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToKm(value), value.YdToKm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void YdToKm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.YdToKm(value), value.YdToKm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToM_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToM(value), value.YdToM());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void YdToM_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.YdToM(value), value.YdToM());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToMi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToMi(value), value.YdToMi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void YdToMi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.YdToMi(value), value.YdToMi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void YdToMm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Length.YdToMm(value), value.YdToMm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void YdToMm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Length.YdToMm(value), value.YdToMm());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmToMm_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Length.Convert(value, Length.Unit.Mm, Length.Unit.Mm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_CmToCm_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Length.Convert(value, Length.Unit.Cm, Length.Unit.Cm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MToM_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Length.Convert(value, Length.Unit.M, Length.Unit.M));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmToKm_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Length.Convert(value, Length.Unit.Km, Length.Unit.Km));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_InToIn_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Length.Convert(value, Length.Unit.In, Length.Unit.In));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtToFt_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Length.Convert(value, Length.Unit.Ft, Length.Unit.Ft));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_YdToYd_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Length.Convert(value, Length.Unit.Yd, Length.Unit.Yd));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MiToMi_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Length.Convert(value, Length.Unit.Mi, Length.Unit.Mi));

    #endregion
}
