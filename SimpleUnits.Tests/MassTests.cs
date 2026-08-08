using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class MassTests
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
    public void GToKg_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.GToKg, Mass.GToKg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToLb_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.GToLb, Mass.GToLb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToLton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.GToLton, Mass.GToLton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToOz_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.GToOz, Mass.GToOz(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToShton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.GToShton, Mass.GToShton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToTonne_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.GToTonne, Mass.GToTonne(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToG_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.KgToG, Mass.KgToG(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToLb_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.KgToLb, Mass.KgToLb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToLton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.KgToLton, Mass.KgToLton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToOz_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.KgToOz, Mass.KgToOz(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToShton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.KgToShton, Mass.KgToShton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToTonne_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.KgToTonne, Mass.KgToTonne(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToG_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LbToG, Mass.LbToG(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToKg_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LbToKg, Mass.LbToKg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToLton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LbToLton, Mass.LbToLton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToOz_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LbToOz, Mass.LbToOz(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToShton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LbToShton, Mass.LbToShton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToTonne_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LbToTonne, Mass.LbToTonne(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToG_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LtonToG, Mass.LtonToG(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToKg_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LtonToKg, Mass.LtonToKg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToLb_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LtonToLb, Mass.LtonToLb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToOz_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LtonToOz, Mass.LtonToOz(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToShton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LtonToShton, Mass.LtonToShton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToTonne_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.LtonToTonne, Mass.LtonToTonne(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToG_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.OzToG, Mass.OzToG(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToKg_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.OzToKg, Mass.OzToKg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToLb_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.OzToLb, Mass.OzToLb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToLton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.OzToLton, Mass.OzToLton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToShton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.OzToShton, Mass.OzToShton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToTonne_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.OzToTonne, Mass.OzToTonne(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToG_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.ShtonToG, Mass.ShtonToG(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToKg_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.ShtonToKg, Mass.ShtonToKg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToLb_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.ShtonToLb, Mass.ShtonToLb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToLton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.ShtonToLton, Mass.ShtonToLton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToOz_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.ShtonToOz, Mass.ShtonToOz(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToTonne_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.ShtonToTonne, Mass.ShtonToTonne(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToG_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.TonneToG, Mass.TonneToG(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToKg_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.TonneToKg, Mass.TonneToKg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToLb_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.TonneToLb, Mass.TonneToLb(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToLton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.TonneToLton, Mass.TonneToLton(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToOz_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.TonneToOz, Mass.TonneToOz(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToShton_MatchesFactor(double value) =>
        Assert.Equal(value * Mass.Factor.TonneToShton, Mass.TonneToShton(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GToKg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToKg(value), Mass.Convert(value, Mass.Unit.G, Mass.Unit.Kg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GToTonne_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToTonne(value), Mass.Convert(value, Mass.Unit.G, Mass.Unit.Tonne));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GToShton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToShton(value), Mass.Convert(value, Mass.Unit.G, Mass.Unit.Shton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GToLton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToLton(value), Mass.Convert(value, Mass.Unit.G, Mass.Unit.Lton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GToLb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToLb(value), Mass.Convert(value, Mass.Unit.G, Mass.Unit.Lb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GToOz_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToOz(value), Mass.Convert(value, Mass.Unit.G, Mass.Unit.Oz));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgToG_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToG(value), Mass.Convert(value, Mass.Unit.Kg, Mass.Unit.G));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgToTonne_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToTonne(value), Mass.Convert(value, Mass.Unit.Kg, Mass.Unit.Tonne));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgToShton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToShton(value), Mass.Convert(value, Mass.Unit.Kg, Mass.Unit.Shton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgToLton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToLton(value), Mass.Convert(value, Mass.Unit.Kg, Mass.Unit.Lton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgToLb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToLb(value), Mass.Convert(value, Mass.Unit.Kg, Mass.Unit.Lb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgToOz_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToOz(value), Mass.Convert(value, Mass.Unit.Kg, Mass.Unit.Oz));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_TonneToG_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToG(value), Mass.Convert(value, Mass.Unit.Tonne, Mass.Unit.G));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_TonneToKg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToKg(value), Mass.Convert(value, Mass.Unit.Tonne, Mass.Unit.Kg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_TonneToShton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToShton(value), Mass.Convert(value, Mass.Unit.Tonne, Mass.Unit.Shton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_TonneToLton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToLton(value), Mass.Convert(value, Mass.Unit.Tonne, Mass.Unit.Lton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_TonneToLb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToLb(value), Mass.Convert(value, Mass.Unit.Tonne, Mass.Unit.Lb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_TonneToOz_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToOz(value), Mass.Convert(value, Mass.Unit.Tonne, Mass.Unit.Oz));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ShtonToG_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToG(value), Mass.Convert(value, Mass.Unit.Shton, Mass.Unit.G));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ShtonToKg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToKg(value), Mass.Convert(value, Mass.Unit.Shton, Mass.Unit.Kg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ShtonToTonne_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToTonne(value), Mass.Convert(value, Mass.Unit.Shton, Mass.Unit.Tonne));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ShtonToLton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToLton(value), Mass.Convert(value, Mass.Unit.Shton, Mass.Unit.Lton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ShtonToLb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToLb(value), Mass.Convert(value, Mass.Unit.Shton, Mass.Unit.Lb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ShtonToOz_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToOz(value), Mass.Convert(value, Mass.Unit.Shton, Mass.Unit.Oz));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtonToG_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToG(value), Mass.Convert(value, Mass.Unit.Lton, Mass.Unit.G));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtonToKg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToKg(value), Mass.Convert(value, Mass.Unit.Lton, Mass.Unit.Kg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtonToTonne_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToTonne(value), Mass.Convert(value, Mass.Unit.Lton, Mass.Unit.Tonne));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtonToShton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToShton(value), Mass.Convert(value, Mass.Unit.Lton, Mass.Unit.Shton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtonToLb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToLb(value), Mass.Convert(value, Mass.Unit.Lton, Mass.Unit.Lb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtonToOz_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToOz(value), Mass.Convert(value, Mass.Unit.Lton, Mass.Unit.Oz));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbToG_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToG(value), Mass.Convert(value, Mass.Unit.Lb, Mass.Unit.G));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbToKg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToKg(value), Mass.Convert(value, Mass.Unit.Lb, Mass.Unit.Kg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbToTonne_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToTonne(value), Mass.Convert(value, Mass.Unit.Lb, Mass.Unit.Tonne));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbToShton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToShton(value), Mass.Convert(value, Mass.Unit.Lb, Mass.Unit.Shton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbToLton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToLton(value), Mass.Convert(value, Mass.Unit.Lb, Mass.Unit.Lton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbToOz_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToOz(value), Mass.Convert(value, Mass.Unit.Lb, Mass.Unit.Oz));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_OzToG_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToG(value), Mass.Convert(value, Mass.Unit.Oz, Mass.Unit.G));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_OzToKg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToKg(value), Mass.Convert(value, Mass.Unit.Oz, Mass.Unit.Kg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_OzToTonne_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToTonne(value), Mass.Convert(value, Mass.Unit.Oz, Mass.Unit.Tonne));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_OzToShton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToShton(value), Mass.Convert(value, Mass.Unit.Oz, Mass.Unit.Shton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_OzToLton_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToLton(value), Mass.Convert(value, Mass.Unit.Oz, Mass.Unit.Lton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_OzToLb_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToLb(value), Mass.Convert(value, Mass.Unit.Oz, Mass.Unit.Lb));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToKg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToKg(value), value.GToKg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GToKg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.GToKg(value), value.GToKg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToLb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToLb(value), value.GToLb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GToLb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.GToLb(value), value.GToLb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToLton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToLton(value), value.GToLton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GToLton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.GToLton(value), value.GToLton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToOz_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToOz(value), value.GToOz());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GToOz_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.GToOz(value), value.GToOz());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToShton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToShton(value), value.GToShton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GToShton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.GToShton(value), value.GToShton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void GToTonne_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.GToTonne(value), value.GToTonne());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void GToTonne_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.GToTonne(value), value.GToTonne());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToG_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToG(value), value.KgToG());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgToG_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.KgToG(value), value.KgToG());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToLb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToLb(value), value.KgToLb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgToLb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.KgToLb(value), value.KgToLb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToLton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToLton(value), value.KgToLton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgToLton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.KgToLton(value), value.KgToLton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToOz_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToOz(value), value.KgToOz());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgToOz_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.KgToOz(value), value.KgToOz());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToShton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToShton(value), value.KgToShton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgToShton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.KgToShton(value), value.KgToShton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgToTonne_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.KgToTonne(value), value.KgToTonne());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgToTonne_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.KgToTonne(value), value.KgToTonne());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToG_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToG(value), value.LbToG());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LbToG_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LbToG(value), value.LbToG());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToKg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToKg(value), value.LbToKg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LbToKg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LbToKg(value), value.LbToKg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToLton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToLton(value), value.LbToLton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LbToLton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LbToLton(value), value.LbToLton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToOz_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToOz(value), value.LbToOz());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LbToOz_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LbToOz(value), value.LbToOz());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToShton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToShton(value), value.LbToShton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LbToShton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LbToShton(value), value.LbToShton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LbToTonne_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LbToTonne(value), value.LbToTonne());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LbToTonne_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LbToTonne(value), value.LbToTonne());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToG_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToG(value), value.LtonToG());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtonToG_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LtonToG(value), value.LtonToG());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToKg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToKg(value), value.LtonToKg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtonToKg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LtonToKg(value), value.LtonToKg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToLb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToLb(value), value.LtonToLb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtonToLb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LtonToLb(value), value.LtonToLb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToOz_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToOz(value), value.LtonToOz());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtonToOz_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LtonToOz(value), value.LtonToOz());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToShton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToShton(value), value.LtonToShton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtonToShton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LtonToShton(value), value.LtonToShton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void LtonToTonne_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.LtonToTonne(value), value.LtonToTonne());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void LtonToTonne_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.LtonToTonne(value), value.LtonToTonne());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToG_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToG(value), value.OzToG());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void OzToG_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.OzToG(value), value.OzToG());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToKg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToKg(value), value.OzToKg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void OzToKg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.OzToKg(value), value.OzToKg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToLb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToLb(value), value.OzToLb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void OzToLb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.OzToLb(value), value.OzToLb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToLton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToLton(value), value.OzToLton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void OzToLton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.OzToLton(value), value.OzToLton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToShton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToShton(value), value.OzToShton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void OzToShton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.OzToShton(value), value.OzToShton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void OzToTonne_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.OzToTonne(value), value.OzToTonne());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void OzToTonne_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.OzToTonne(value), value.OzToTonne());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToG_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToG(value), value.ShtonToG());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ShtonToG_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.ShtonToG(value), value.ShtonToG());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToKg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToKg(value), value.ShtonToKg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ShtonToKg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.ShtonToKg(value), value.ShtonToKg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToLb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToLb(value), value.ShtonToLb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ShtonToLb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.ShtonToLb(value), value.ShtonToLb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToLton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToLton(value), value.ShtonToLton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ShtonToLton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.ShtonToLton(value), value.ShtonToLton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToOz_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToOz(value), value.ShtonToOz());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ShtonToOz_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.ShtonToOz(value), value.ShtonToOz());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void ShtonToTonne_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.ShtonToTonne(value), value.ShtonToTonne());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void ShtonToTonne_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.ShtonToTonne(value), value.ShtonToTonne());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToG_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToG(value), value.TonneToG());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void TonneToG_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.TonneToG(value), value.TonneToG());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToKg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToKg(value), value.TonneToKg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void TonneToKg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.TonneToKg(value), value.TonneToKg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToLb_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToLb(value), value.TonneToLb());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void TonneToLb_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.TonneToLb(value), value.TonneToLb());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToLton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToLton(value), value.TonneToLton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void TonneToLton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.TonneToLton(value), value.TonneToLton());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToOz_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToOz(value), value.TonneToOz());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void TonneToOz_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.TonneToOz(value), value.TonneToOz());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void TonneToShton_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Mass.TonneToShton(value), value.TonneToShton());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void TonneToShton_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Mass.TonneToShton(value), value.TonneToShton());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_GToG_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Mass.Convert(value, Mass.Unit.G, Mass.Unit.G));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgToKg_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Mass.Convert(value, Mass.Unit.Kg, Mass.Unit.Kg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_TonneToTonne_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Mass.Convert(value, Mass.Unit.Tonne, Mass.Unit.Tonne));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_ShtonToShton_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Mass.Convert(value, Mass.Unit.Shton, Mass.Unit.Shton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LtonToLton_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Mass.Convert(value, Mass.Unit.Lton, Mass.Unit.Lton));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_LbToLb_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Mass.Convert(value, Mass.Unit.Lb, Mass.Unit.Lb));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_OzToOz_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Mass.Convert(value, Mass.Unit.Oz, Mass.Unit.Oz));

    #endregion
}
