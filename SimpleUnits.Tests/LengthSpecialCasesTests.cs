using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

/// <summary>
/// <see cref="Length"/> has a handful of conversions that don't just do a plain
/// <c>value * Factor.X</c> multiplication, so they're excluded from the generic
/// factor-echo theory in <see cref="LengthTests"/> and exercised here instead with
/// verified, hand-picked values.
///
/// <see cref="Length.InToFt"/>, <see cref="Length.InToMm"/>, and <see cref="Length.MmToIn"/>
/// route through <see cref="Calculate.TowardZero"/>, which is meant to correct
/// US-standard floating point drift (see the README's "US Standard conversion factors"
/// section) but currently never does: its "is this close to a whole number" branch
/// checks <c>value &gt; factor</c> and then, in the branch meant to handle the opposite
/// case, checks <c>factor &lt; value</c> -- the same condition -- so the correction path
/// is unreachable and these three methods behave identically to plain multiplication
/// today. That's a pre-existing bug, not something introduced or fixed here; these tests
/// document the current (buggy) behavior so a future fix shows up as an intentional,
/// visible test change rather than a silent regression.
///
/// <see cref="Length.InToYd"/>, <see cref="Length.InToMi"/>, <see cref="Length.FtToYd"/>,
/// <see cref="Length.FtToMi"/>, and <see cref="Length.YdToMi"/> use a working (not
/// dead-code) modulo check and correctly round to a whole number when the input is an
/// exact multiple of the target unit.
/// </summary>
public class LengthSpecialCasesTests
{
    #region InToFt / InToMm / MmToIn (Calculate.TowardZero's correction path is dead code)

    [Fact]
    public void InToFt_TwelveInches_MatchesPlainMultiplication() =>
        Assert.Equal(12 * Length.Factor.InToFt, Length.InToFt(12));

    [Fact]
    public void InToFt_TwentyFourInches_MatchesPlainMultiplication() =>
        Assert.Equal(24 * Length.Factor.InToFt, Length.InToFt(24));

    [Fact]
    public void InToMm_OneInch_MatchesPlainMultiplication() =>
        Assert.Equal(1 * Length.Factor.InToMm, Length.InToMm(1));

    [Fact]
    public void MmToIn_25Point4Millimeters_MatchesPlainMultiplication() =>
        Assert.Equal(25.4 * Length.Factor.MmToIn, Length.MmToIn(25.4));

    #endregion

    #region InToYd (modulo rounding for exact multiples)

    [Fact]
    public void InToYd_ThirtySixInches_RoundsToExactlyOneYard() =>
        Assert.Equal(1, Length.InToYd(36));

    [Fact]
    public void InToYd_TenInches_DoesNotRound() =>
        Assert.Equal(10 * Length.Factor.InToYd, Length.InToYd(10));

    #endregion

    #region InToMi (modulo rounding for exact multiples)

    [Fact]
    public void InToMi_63360Inches_RoundsToExactlyOneMile() =>
        Assert.Equal(1, Length.InToMi(63_360));

    [Fact]
    public void InToMi_OneInch_DoesNotRound() =>
        Assert.Equal(1 * Length.Factor.InToMi, Length.InToMi(1));

    #endregion

    #region FtToYd (modulo rounding for exact multiples)

    [Fact]
    public void FtToYd_ThreeFeet_RoundsToExactlyOneYard() =>
        Assert.Equal(1, Length.FtToYd(3));

    [Fact]
    public void FtToYd_TwoFeet_DoesNotRound() =>
        Assert.Equal(2 * Length.Factor.FtToYd, Length.FtToYd(2));

    #endregion

    #region FtToMi (modulo rounding for exact multiples)

    [Fact]
    public void FtToMi_5280Feet_RoundsToExactlyOneMile() =>
        Assert.Equal(1, Length.FtToMi(5_280));

    [Fact]
    public void FtToMi_OneFoot_DoesNotRound() =>
        Assert.Equal(1 * Length.Factor.FtToMi, Length.FtToMi(1));

    #endregion

    #region YdToMi (modulo rounding for exact multiples)

    [Fact]
    public void YdToMi_1760Yards_RoundsToExactlyOneMile() =>
        Assert.Equal(1, Length.YdToMi(1_760));

    [Fact]
    public void YdToMi_OneYard_DoesNotRound() =>
        Assert.Equal(1 * Length.Factor.YdToMi, Length.YdToMi(1));

    #endregion

    #region Known-exact real-world sanity checks (independent of the Factor constants)

    [Fact]
    public void FtToIn_OneFoot_EqualsTwelveInches() =>
        Assert.Equal(12, Length.FtToIn(1));

    [Fact]
    public void YdToFt_OneYard_EqualsThreeFeet() =>
        Assert.Equal(3, Length.YdToFt(1));

    [Fact]
    public void MiToYd_OneMile_Equals1760Yards() =>
        Assert.Equal(1_760, Length.MiToYd(1));

    [Fact]
    public void MToCm_OneMeter_Equals100Centimeters() =>
        Assert.Equal(100, Length.MToCm(1));

    #endregion
}
