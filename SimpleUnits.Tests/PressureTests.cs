using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class PressureTests
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
    public void AtmToBar_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.AtmToBar, Pressure.AtmToBar(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToKPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.AtmToKPa, Pressure.AtmToKPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToKgfCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.AtmToKgfCm2, Pressure.AtmToKgfCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToMPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.AtmToMPa, Pressure.AtmToMPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToMmHg_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.AtmToMmHg, Pressure.AtmToMmHg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.AtmToPa, Pressure.AtmToPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToPsi_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.AtmToPsi, Pressure.AtmToPsi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToAtm_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.BarToAtm, Pressure.BarToAtm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToKPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.BarToKPa, Pressure.BarToKPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToKgfCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.BarToKgfCm2, Pressure.BarToKgfCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToMPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.BarToMPa, Pressure.BarToMPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToMmHg_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.BarToMmHg, Pressure.BarToMmHg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.BarToPa, Pressure.BarToPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToPsi_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.BarToPsi, Pressure.BarToPsi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToAtm_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KPaToAtm, Pressure.KPaToAtm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToBar_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KPaToBar, Pressure.KPaToBar(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToKgfCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KPaToKgfCm2, Pressure.KPaToKgfCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToMPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KPaToMPa, Pressure.KPaToMPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToMmHg_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KPaToMmHg, Pressure.KPaToMmHg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KPaToPa, Pressure.KPaToPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToPsi_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KPaToPsi, Pressure.KPaToPsi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToAtm_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KgfCm2ToAtm, Pressure.KgfCm2ToAtm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToBar_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KgfCm2ToBar, Pressure.KgfCm2ToBar(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToKPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KgfCm2ToKPa, Pressure.KgfCm2ToKPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToMPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KgfCm2ToMPa, Pressure.KgfCm2ToMPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToMmHg_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KgfCm2ToMmHg, Pressure.KgfCm2ToMmHg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KgfCm2ToPa, Pressure.KgfCm2ToPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToPsi_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.KgfCm2ToPsi, Pressure.KgfCm2ToPsi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToAtm_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MPaToAtm, Pressure.MPaToAtm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToBar_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MPaToBar, Pressure.MPaToBar(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToKPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MPaToKPa, Pressure.MPaToKPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToKgfCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MPaToKgfCm2, Pressure.MPaToKgfCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToMmHg_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MPaToMmHg, Pressure.MPaToMmHg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MPaToPa, Pressure.MPaToPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToPsi_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MPaToPsi, Pressure.MPaToPsi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToAtm_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MmHgToAtm, Pressure.MmHgToAtm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToBar_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MmHgToBar, Pressure.MmHgToBar(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToKPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MmHgToKPa, Pressure.MmHgToKPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToKgfCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MmHgToKgfCm2, Pressure.MmHgToKgfCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToMPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MmHgToMPa, Pressure.MmHgToMPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MmHgToPa, Pressure.MmHgToPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToPsi_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.MmHgToPsi, Pressure.MmHgToPsi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToAtm_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PaToAtm, Pressure.PaToAtm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToBar_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PaToBar, Pressure.PaToBar(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToKPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PaToKPa, Pressure.PaToKPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToKgfCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PaToKgfCm2, Pressure.PaToKgfCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToMPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PaToMPa, Pressure.PaToMPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToMmHg_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PaToMmHg, Pressure.PaToMmHg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToPsi_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PaToPsi, Pressure.PaToPsi(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToAtm_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PsiToAtm, Pressure.PsiToAtm(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToBar_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PsiToBar, Pressure.PsiToBar(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToKPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PsiToKPa, Pressure.PsiToKPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToKgfCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PsiToKgfCm2, Pressure.PsiToKgfCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToMPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PsiToMPa, Pressure.PsiToMPa(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToMmHg_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PsiToMmHg, Pressure.PsiToMmHg(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToPa_MatchesFactor(double value) =>
        Assert.Equal(value * Pressure.Factor.PsiToPa, Pressure.PsiToPa(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BarToPsi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToPsi(value), Pressure.Convert(value, Pressure.Unit.Bar, Pressure.Unit.Psi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BarToPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToPa(value), Pressure.Convert(value, Pressure.Unit.Bar, Pressure.Unit.Pa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BarToKPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToKPa(value), Pressure.Convert(value, Pressure.Unit.Bar, Pressure.Unit.KPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BarToMPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToMPa(value), Pressure.Convert(value, Pressure.Unit.Bar, Pressure.Unit.MPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BarToKgfCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToKgfCm2(value), Pressure.Convert(value, Pressure.Unit.Bar, Pressure.Unit.Kgf_cm_2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BarToMmHg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToMmHg(value), Pressure.Convert(value, Pressure.Unit.Bar, Pressure.Unit.MmHg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BarToAtm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToAtm(value), Pressure.Convert(value, Pressure.Unit.Bar, Pressure.Unit.Atm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PsiToBar_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToBar(value), Pressure.Convert(value, Pressure.Unit.Psi, Pressure.Unit.Bar));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PsiToPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToPa(value), Pressure.Convert(value, Pressure.Unit.Psi, Pressure.Unit.Pa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PsiToKPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToKPa(value), Pressure.Convert(value, Pressure.Unit.Psi, Pressure.Unit.KPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PsiToMPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToMPa(value), Pressure.Convert(value, Pressure.Unit.Psi, Pressure.Unit.MPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PsiToKgfCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToKgfCm2(value), Pressure.Convert(value, Pressure.Unit.Psi, Pressure.Unit.Kgf_cm_2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PsiToMmHg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToMmHg(value), Pressure.Convert(value, Pressure.Unit.Psi, Pressure.Unit.MmHg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PsiToAtm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToAtm(value), Pressure.Convert(value, Pressure.Unit.Psi, Pressure.Unit.Atm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PaToBar_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToBar(value), Pressure.Convert(value, Pressure.Unit.Pa, Pressure.Unit.Bar));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PaToPsi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToPsi(value), Pressure.Convert(value, Pressure.Unit.Pa, Pressure.Unit.Psi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PaToKPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToKPa(value), Pressure.Convert(value, Pressure.Unit.Pa, Pressure.Unit.KPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PaToMPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToMPa(value), Pressure.Convert(value, Pressure.Unit.Pa, Pressure.Unit.MPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PaToKgfCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToKgfCm2(value), Pressure.Convert(value, Pressure.Unit.Pa, Pressure.Unit.Kgf_cm_2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PaToMmHg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToMmHg(value), Pressure.Convert(value, Pressure.Unit.Pa, Pressure.Unit.MmHg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PaToAtm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToAtm(value), Pressure.Convert(value, Pressure.Unit.Pa, Pressure.Unit.Atm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KPaToBar_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToBar(value), Pressure.Convert(value, Pressure.Unit.KPa, Pressure.Unit.Bar));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KPaToPsi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToPsi(value), Pressure.Convert(value, Pressure.Unit.KPa, Pressure.Unit.Psi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KPaToPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToPa(value), Pressure.Convert(value, Pressure.Unit.KPa, Pressure.Unit.Pa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KPaToMPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToMPa(value), Pressure.Convert(value, Pressure.Unit.KPa, Pressure.Unit.MPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KPaToKgfCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToKgfCm2(value), Pressure.Convert(value, Pressure.Unit.KPa, Pressure.Unit.Kgf_cm_2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KPaToMmHg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToMmHg(value), Pressure.Convert(value, Pressure.Unit.KPa, Pressure.Unit.MmHg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KPaToAtm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToAtm(value), Pressure.Convert(value, Pressure.Unit.KPa, Pressure.Unit.Atm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MPaToBar_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToBar(value), Pressure.Convert(value, Pressure.Unit.MPa, Pressure.Unit.Bar));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MPaToPsi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToPsi(value), Pressure.Convert(value, Pressure.Unit.MPa, Pressure.Unit.Psi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MPaToPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToPa(value), Pressure.Convert(value, Pressure.Unit.MPa, Pressure.Unit.Pa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MPaToKPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToKPa(value), Pressure.Convert(value, Pressure.Unit.MPa, Pressure.Unit.KPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MPaToKgfCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToKgfCm2(value), Pressure.Convert(value, Pressure.Unit.MPa, Pressure.Unit.Kgf_cm_2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MPaToMmHg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToMmHg(value), Pressure.Convert(value, Pressure.Unit.MPa, Pressure.Unit.MmHg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MPaToAtm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToAtm(value), Pressure.Convert(value, Pressure.Unit.MPa, Pressure.Unit.Atm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfCm2ToBar_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToBar(value), Pressure.Convert(value, Pressure.Unit.Kgf_cm_2, Pressure.Unit.Bar));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfCm2ToPsi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToPsi(value), Pressure.Convert(value, Pressure.Unit.Kgf_cm_2, Pressure.Unit.Psi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfCm2ToPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToPa(value), Pressure.Convert(value, Pressure.Unit.Kgf_cm_2, Pressure.Unit.Pa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfCm2ToKPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToKPa(value), Pressure.Convert(value, Pressure.Unit.Kgf_cm_2, Pressure.Unit.KPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfCm2ToMPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToMPa(value), Pressure.Convert(value, Pressure.Unit.Kgf_cm_2, Pressure.Unit.MPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfCm2ToMmHg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToMmHg(value), Pressure.Convert(value, Pressure.Unit.Kgf_cm_2, Pressure.Unit.MmHg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KgfCm2ToAtm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToAtm(value), Pressure.Convert(value, Pressure.Unit.Kgf_cm_2, Pressure.Unit.Atm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmHgToBar_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToBar(value), Pressure.Convert(value, Pressure.Unit.MmHg, Pressure.Unit.Bar));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmHgToPsi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToPsi(value), Pressure.Convert(value, Pressure.Unit.MmHg, Pressure.Unit.Psi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmHgToPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToPa(value), Pressure.Convert(value, Pressure.Unit.MmHg, Pressure.Unit.Pa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmHgToKPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToKPa(value), Pressure.Convert(value, Pressure.Unit.MmHg, Pressure.Unit.KPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmHgToMPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToMPa(value), Pressure.Convert(value, Pressure.Unit.MmHg, Pressure.Unit.MPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmHgToKgfCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToKgfCm2(value), Pressure.Convert(value, Pressure.Unit.MmHg, Pressure.Unit.Kgf_cm_2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmHgToAtm_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToAtm(value), Pressure.Convert(value, Pressure.Unit.MmHg, Pressure.Unit.Atm));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_AtmToBar_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToBar(value), Pressure.Convert(value, Pressure.Unit.Atm, Pressure.Unit.Bar));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_AtmToPsi_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToPsi(value), Pressure.Convert(value, Pressure.Unit.Atm, Pressure.Unit.Psi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_AtmToPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToPa(value), Pressure.Convert(value, Pressure.Unit.Atm, Pressure.Unit.Pa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_AtmToKPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToKPa(value), Pressure.Convert(value, Pressure.Unit.Atm, Pressure.Unit.KPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_AtmToMPa_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToMPa(value), Pressure.Convert(value, Pressure.Unit.Atm, Pressure.Unit.MPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_AtmToKgfCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToKgfCm2(value), Pressure.Convert(value, Pressure.Unit.Atm, Pressure.Unit.Kgf_cm_2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_AtmToMmHg_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToMmHg(value), Pressure.Convert(value, Pressure.Unit.Atm, Pressure.Unit.MmHg));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToBar_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToBar(value), value.AtmToBar());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void AtmToBar_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.AtmToBar(value), value.AtmToBar());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToKPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToKPa(value), value.AtmToKPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void AtmToKPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.AtmToKPa(value), value.AtmToKPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToKgfCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToKgfCm2(value), value.AtmToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void AtmToKgfCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.AtmToKgfCm2(value), value.AtmToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToMPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToMPa(value), value.AtmToMPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void AtmToMPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.AtmToMPa(value), value.AtmToMPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToMmHg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToMmHg(value), value.AtmToMmHg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void AtmToMmHg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.AtmToMmHg(value), value.AtmToMmHg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToPa(value), value.AtmToPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void AtmToPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.AtmToPa(value), value.AtmToPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void AtmToPsi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.AtmToPsi(value), value.AtmToPsi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void AtmToPsi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.AtmToPsi(value), value.AtmToPsi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToAtm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToAtm(value), value.BarToAtm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BarToAtm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.BarToAtm(value), value.BarToAtm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToKPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToKPa(value), value.BarToKPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BarToKPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.BarToKPa(value), value.BarToKPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToKgfCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToKgfCm2(value), value.BarToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BarToKgfCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.BarToKgfCm2(value), value.BarToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToMPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToMPa(value), value.BarToMPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BarToMPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.BarToMPa(value), value.BarToMPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToMmHg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToMmHg(value), value.BarToMmHg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BarToMmHg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.BarToMmHg(value), value.BarToMmHg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToPa(value), value.BarToPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BarToPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.BarToPa(value), value.BarToPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void BarToPsi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.BarToPsi(value), value.BarToPsi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void BarToPsi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.BarToPsi(value), value.BarToPsi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToAtm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToAtm(value), value.KPaToAtm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KPaToAtm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KPaToAtm(value), value.KPaToAtm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToBar_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToBar(value), value.KPaToBar());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KPaToBar_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KPaToBar(value), value.KPaToBar());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToKgfCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToKgfCm2(value), value.KPaToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KPaToKgfCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KPaToKgfCm2(value), value.KPaToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToMPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToMPa(value), value.KPaToMPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KPaToMPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KPaToMPa(value), value.KPaToMPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToMmHg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToMmHg(value), value.KPaToMmHg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KPaToMmHg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KPaToMmHg(value), value.KPaToMmHg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToPa(value), value.KPaToPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KPaToPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KPaToPa(value), value.KPaToPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KPaToPsi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KPaToPsi(value), value.KPaToPsi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KPaToPsi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KPaToPsi(value), value.KPaToPsi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToAtm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToAtm(value), value.KgfCm2ToAtm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfCm2ToAtm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KgfCm2ToAtm(value), value.KgfCm2ToAtm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToBar_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToBar(value), value.KgfCm2ToBar());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfCm2ToBar_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KgfCm2ToBar(value), value.KgfCm2ToBar());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToKPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToKPa(value), value.KgfCm2ToKPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfCm2ToKPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KgfCm2ToKPa(value), value.KgfCm2ToKPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToMPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToMPa(value), value.KgfCm2ToMPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfCm2ToMPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KgfCm2ToMPa(value), value.KgfCm2ToMPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToMmHg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToMmHg(value), value.KgfCm2ToMmHg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfCm2ToMmHg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KgfCm2ToMmHg(value), value.KgfCm2ToMmHg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToPa(value), value.KgfCm2ToPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfCm2ToPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KgfCm2ToPa(value), value.KgfCm2ToPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void KgfCm2ToPsi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.KgfCm2ToPsi(value), value.KgfCm2ToPsi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void KgfCm2ToPsi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.KgfCm2ToPsi(value), value.KgfCm2ToPsi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToAtm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToAtm(value), value.MPaToAtm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MPaToAtm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MPaToAtm(value), value.MPaToAtm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToBar_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToBar(value), value.MPaToBar());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MPaToBar_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MPaToBar(value), value.MPaToBar());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToKPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToKPa(value), value.MPaToKPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MPaToKPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MPaToKPa(value), value.MPaToKPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToKgfCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToKgfCm2(value), value.MPaToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MPaToKgfCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MPaToKgfCm2(value), value.MPaToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToMmHg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToMmHg(value), value.MPaToMmHg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MPaToMmHg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MPaToMmHg(value), value.MPaToMmHg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToPa(value), value.MPaToPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MPaToPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MPaToPa(value), value.MPaToPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MPaToPsi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MPaToPsi(value), value.MPaToPsi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MPaToPsi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MPaToPsi(value), value.MPaToPsi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToAtm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToAtm(value), value.MmHgToAtm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmHgToAtm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MmHgToAtm(value), value.MmHgToAtm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToBar_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToBar(value), value.MmHgToBar());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmHgToBar_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MmHgToBar(value), value.MmHgToBar());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToKPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToKPa(value), value.MmHgToKPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmHgToKPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MmHgToKPa(value), value.MmHgToKPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToKgfCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToKgfCm2(value), value.MmHgToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmHgToKgfCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MmHgToKgfCm2(value), value.MmHgToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToMPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToMPa(value), value.MmHgToMPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmHgToMPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MmHgToMPa(value), value.MmHgToMPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToPa(value), value.MmHgToPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmHgToPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MmHgToPa(value), value.MmHgToPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void MmHgToPsi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.MmHgToPsi(value), value.MmHgToPsi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void MmHgToPsi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.MmHgToPsi(value), value.MmHgToPsi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToAtm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToAtm(value), value.PaToAtm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PaToAtm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PaToAtm(value), value.PaToAtm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToBar_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToBar(value), value.PaToBar());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PaToBar_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PaToBar(value), value.PaToBar());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToKPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToKPa(value), value.PaToKPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PaToKPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PaToKPa(value), value.PaToKPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToKgfCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToKgfCm2(value), value.PaToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PaToKgfCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PaToKgfCm2(value), value.PaToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToMPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToMPa(value), value.PaToMPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PaToMPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PaToMPa(value), value.PaToMPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToMmHg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToMmHg(value), value.PaToMmHg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PaToMmHg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PaToMmHg(value), value.PaToMmHg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PaToPsi_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PaToPsi(value), value.PaToPsi());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PaToPsi_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PaToPsi(value), value.PaToPsi());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToAtm_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToAtm(value), value.PsiToAtm());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PsiToAtm_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PsiToAtm(value), value.PsiToAtm());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToBar_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToBar(value), value.PsiToBar());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PsiToBar_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PsiToBar(value), value.PsiToBar());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToKPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToKPa(value), value.PsiToKPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PsiToKPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PsiToKPa(value), value.PsiToKPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToKgfCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToKgfCm2(value), value.PsiToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PsiToKgfCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PsiToKgfCm2(value), value.PsiToKgfCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToMPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToMPa(value), value.PsiToMPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PsiToMPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PsiToMPa(value), value.PsiToMPa());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToMmHg_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToMmHg(value), value.PsiToMmHg());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PsiToMmHg_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PsiToMmHg(value), value.PsiToMmHg());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void PsiToPa_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Pressure.PsiToPa(value), value.PsiToPa());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void PsiToPa_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Pressure.PsiToPa(value), value.PsiToPa());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_BarToBar_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Pressure.Convert(value, Pressure.Unit.Bar, Pressure.Unit.Bar));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PsiToPsi_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Pressure.Convert(value, Pressure.Unit.Psi, Pressure.Unit.Psi));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_PaToPa_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Pressure.Convert(value, Pressure.Unit.Pa, Pressure.Unit.Pa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_KPaToKPa_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Pressure.Convert(value, Pressure.Unit.KPa, Pressure.Unit.KPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MPaToMPa_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Pressure.Convert(value, Pressure.Unit.MPa, Pressure.Unit.MPa));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Kgf_cm_2ToKgf_cm_2_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Pressure.Convert(value, Pressure.Unit.Kgf_cm_2, Pressure.Unit.Kgf_cm_2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_MmHgToMmHg_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Pressure.Convert(value, Pressure.Unit.MmHg, Pressure.Unit.MmHg));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_AtmToAtm_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Pressure.Convert(value, Pressure.Unit.Atm, Pressure.Unit.Atm));

    #endregion
}
