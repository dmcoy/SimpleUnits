using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class SpeedTests
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
    public void FtminToFtsec_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtminToFtsec, Speed.FtminToFtsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtminToKmh_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtminToKmh, Speed.FtminToKmh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtminToMmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtminToMmin, Speed.FtminToMmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtminToMph_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtminToMph, Speed.FtminToMph(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtminToMs_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtminToMs, Speed.FtminToMs(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToFtmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtsecToFtmin, Speed.FtsecToFtmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToKmh_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtsecToKmh, Speed.FtsecToKmh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToMmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtsecToMmin, Speed.FtsecToMmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToMph_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtsecToMph, Speed.FtsecToMph(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToMs_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.FtsecToMs, Speed.FtsecToMs(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToFtmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.KmhToFtmin, Speed.KmhToFtmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToFtsec_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.KmhToFtsec, Speed.KmhToFtsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToMmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.KmhToMmin, Speed.KmhToMmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToMph_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.KmhToMph, Speed.KmhToMph(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToMs_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.KmhToMs, Speed.KmhToMs(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToFtmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MminToFtmin, Speed.MminToFtmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToFtsec_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MminToFtsec, Speed.MminToFtsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToKmh_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MminToKmh, Speed.MminToKmh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToMph_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MminToMph, Speed.MminToMph(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToMs_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MminToMs, Speed.MminToMs(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToFtmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MphToFtmin, Speed.MphToFtmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToFtsec_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MphToFtsec, Speed.MphToFtsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToKmh_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MphToKmh, Speed.MphToKmh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToMmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MphToMmin, Speed.MphToMmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToMs_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MphToMs, Speed.MphToMs(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToFtmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MsecToFtmin, Speed.MsecToFtmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToFtsec_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MsecToFtsec, Speed.MsecToFtsec(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToKmh_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MsecToKmh, Speed.MsecToKmh(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToMmin_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MsecToMmin, Speed.MsecToMmin(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToMph_MatchesFactor(double value) =>
        Assert.Equal(value * Speed.Factor.MsecToMph, Speed.MsecToMph(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MsecToMmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToMmin(value), Speed.Convert(value, Speed.Unit.Msec, Speed.Unit.Mmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MsecToKmh_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToKmh(value), Speed.Convert(value, Speed.Unit.Msec, Speed.Unit.Kmh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MsecToFtsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToFtsec(value), Speed.Convert(value, Speed.Unit.Msec, Speed.Unit.Ftsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MsecToFtmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToFtmin(value), Speed.Convert(value, Speed.Unit.Msec, Speed.Unit.Ftmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MsecToMph_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToMph(value), Speed.Convert(value, Speed.Unit.Msec, Speed.Unit.Mph));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MminToMs_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToMs(value), Speed.Convert(value, Speed.Unit.Mmin, Speed.Unit.Msec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MminToKmh_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToKmh(value), Speed.Convert(value, Speed.Unit.Mmin, Speed.Unit.Kmh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MminToFtsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToFtsec(value), Speed.Convert(value, Speed.Unit.Mmin, Speed.Unit.Ftsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MminToFtmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToFtmin(value), Speed.Convert(value, Speed.Unit.Mmin, Speed.Unit.Ftmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MminToMph_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToMph(value), Speed.Convert(value, Speed.Unit.Mmin, Speed.Unit.Mph));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmhToMs_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToMs(value), Speed.Convert(value, Speed.Unit.Kmh, Speed.Unit.Msec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmhToMmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToMmin(value), Speed.Convert(value, Speed.Unit.Kmh, Speed.Unit.Mmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmhToFtsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToFtsec(value), Speed.Convert(value, Speed.Unit.Kmh, Speed.Unit.Ftsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmhToFtmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToFtmin(value), Speed.Convert(value, Speed.Unit.Kmh, Speed.Unit.Ftmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmhToMph_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToMph(value), Speed.Convert(value, Speed.Unit.Kmh, Speed.Unit.Mph));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtsecToMs_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToMs(value), Speed.Convert(value, Speed.Unit.Ftsec, Speed.Unit.Msec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtsecToMmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToMmin(value), Speed.Convert(value, Speed.Unit.Ftsec, Speed.Unit.Mmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtsecToKmh_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToKmh(value), Speed.Convert(value, Speed.Unit.Ftsec, Speed.Unit.Kmh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtsecToFtmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToFtmin(value), Speed.Convert(value, Speed.Unit.Ftsec, Speed.Unit.Ftmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtsecToMph_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToMph(value), Speed.Convert(value, Speed.Unit.Ftsec, Speed.Unit.Mph));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtminToMs_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToMs(value), Speed.Convert(value, Speed.Unit.Ftmin, Speed.Unit.Msec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtminToMmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToMmin(value), Speed.Convert(value, Speed.Unit.Ftmin, Speed.Unit.Mmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtminToKmh_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToKmh(value), Speed.Convert(value, Speed.Unit.Ftmin, Speed.Unit.Kmh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtminToFtsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToFtsec(value), Speed.Convert(value, Speed.Unit.Ftmin, Speed.Unit.Ftsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtminToMph_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToMph(value), Speed.Convert(value, Speed.Unit.Ftmin, Speed.Unit.Mph));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MphToMs_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToMs(value), Speed.Convert(value, Speed.Unit.Mph, Speed.Unit.Msec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MphToMmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToMmin(value), Speed.Convert(value, Speed.Unit.Mph, Speed.Unit.Mmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MphToKmh_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToKmh(value), Speed.Convert(value, Speed.Unit.Mph, Speed.Unit.Kmh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MphToFtsec_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToFtsec(value), Speed.Convert(value, Speed.Unit.Mph, Speed.Unit.Ftsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MphToFtmin_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToFtmin(value), Speed.Convert(value, Speed.Unit.Mph, Speed.Unit.Ftmin));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtminToFtsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToFtsec(value), value.FtminToFtsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtminToFtsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtminToFtsec(value), value.FtminToFtsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtminToKmh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToKmh(value), value.FtminToKmh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtminToKmh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtminToKmh(value), value.FtminToKmh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtminToMmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToMmin(value), value.FtminToMmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtminToMmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtminToMmin(value), value.FtminToMmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtminToMph_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToMph(value), value.FtminToMph());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtminToMph_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtminToMph(value), value.FtminToMph());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtminToMs_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtminToMs(value), value.FtminToMs());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtminToMs_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtminToMs(value), value.FtminToMs());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToFtmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToFtmin(value), value.FtsecToFtmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtsecToFtmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtsecToFtmin(value), value.FtsecToFtmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToKmh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToKmh(value), value.FtsecToKmh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtsecToKmh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtsecToKmh(value), value.FtsecToKmh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToMmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToMmin(value), value.FtsecToMmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtsecToMmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtsecToMmin(value), value.FtsecToMmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToMph_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToMph(value), value.FtsecToMph());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtsecToMph_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtsecToMph(value), value.FtsecToMph());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void FtsecToMs_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.FtsecToMs(value), value.FtsecToMs());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void FtsecToMs_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.FtsecToMs(value), value.FtsecToMs());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToFtmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToFtmin(value), value.KmhToFtmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmhToFtmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.KmhToFtmin(value), value.KmhToFtmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToFtsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToFtsec(value), value.KmhToFtsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmhToFtsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.KmhToFtsec(value), value.KmhToFtsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToMmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToMmin(value), value.KmhToMmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmhToMmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.KmhToMmin(value), value.KmhToMmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToMph_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToMph(value), value.KmhToMph());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmhToMph_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.KmhToMph(value), value.KmhToMph());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KmhToMs_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.KmhToMs(value), value.KmhToMs());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KmhToMs_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.KmhToMs(value), value.KmhToMs());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToFtmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToFtmin(value), value.MminToFtmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MminToFtmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MminToFtmin(value), value.MminToFtmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToFtsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToFtsec(value), value.MminToFtsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MminToFtsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MminToFtsec(value), value.MminToFtsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToKmh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToKmh(value), value.MminToKmh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MminToKmh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MminToKmh(value), value.MminToKmh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToMph_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToMph(value), value.MminToMph());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MminToMph_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MminToMph(value), value.MminToMph());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MminToMs_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MminToMs(value), value.MminToMs());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MminToMs_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MminToMs(value), value.MminToMs());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToFtmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToFtmin(value), value.MphToFtmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MphToFtmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MphToFtmin(value), value.MphToFtmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToFtsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToFtsec(value), value.MphToFtsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MphToFtsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MphToFtsec(value), value.MphToFtsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToKmh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToKmh(value), value.MphToKmh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MphToKmh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MphToKmh(value), value.MphToKmh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToMmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToMmin(value), value.MphToMmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MphToMmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MphToMmin(value), value.MphToMmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MphToMs_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MphToMs(value), value.MphToMs());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MphToMs_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MphToMs(value), value.MphToMs());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToFtmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToFtmin(value), value.MsecToFtmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MsecToFtmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MsecToFtmin(value), value.MsecToFtmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToFtsec_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToFtsec(value), value.MsecToFtsec());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MsecToFtsec_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MsecToFtsec(value), value.MsecToFtsec());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToKmh_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToKmh(value), value.MsecToKmh());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MsecToKmh_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MsecToKmh(value), value.MsecToKmh());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToMmin_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToMmin(value), value.MsecToMmin());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MsecToMmin_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MsecToMmin(value), value.MsecToMmin());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MsecToMph_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Speed.MsecToMph(value), value.MsecToMph());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MsecToMph_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Speed.MsecToMph(value), value.MsecToMph());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MsecToMsec_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Speed.Convert(value, Speed.Unit.Msec, Speed.Unit.Msec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MminToMmin_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Speed.Convert(value, Speed.Unit.Mmin, Speed.Unit.Mmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KmhToKmh_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Speed.Convert(value, Speed.Unit.Kmh, Speed.Unit.Kmh));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtsecToFtsec_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Speed.Convert(value, Speed.Unit.Ftsec, Speed.Unit.Ftsec));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_FtminToFtmin_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Speed.Convert(value, Speed.Unit.Ftmin, Speed.Unit.Ftmin));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MphToMph_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Speed.Convert(value, Speed.Unit.Mph, Speed.Unit.Mph));

    #endregion
}
