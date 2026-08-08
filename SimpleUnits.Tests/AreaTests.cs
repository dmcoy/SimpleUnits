using SimpleUnits;
using Xunit;

namespace SimpleUnits.Tests;

public class AreaTests
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
    public void Cm2ToFt2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Cm2ToFt2, Area.Cm2ToFt2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm2ToIn2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Cm2ToIn2, Area.Cm2ToIn2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm2ToM2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Cm2ToM2, Area.Cm2ToM2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm2ToMm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Cm2ToMm2, Area.Cm2ToMm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm2ToYd2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Cm2ToYd2, Area.Cm2ToYd2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Ft2ToCm2, Area.Ft2ToCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToIn2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Ft2ToIn2, Area.Ft2ToIn2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToM2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Ft2ToM2, Area.Ft2ToM2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToMm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Ft2ToMm2, Area.Ft2ToMm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToYd2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Ft2ToYd2, Area.Ft2ToYd2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.In2ToCm2, Area.In2ToCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToFt2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.In2ToFt2, Area.In2ToFt2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToM2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.In2ToM2, Area.In2ToM2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToMm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.In2ToMm2, Area.In2ToMm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToYd2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.In2ToYd2, Area.In2ToYd2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.M2ToCm2, Area.M2ToCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToFt2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.M2ToFt2, Area.M2ToFt2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToIn2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.M2ToIn2, Area.M2ToIn2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToMm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.M2ToMm2, Area.M2ToMm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToYd2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.M2ToYd2, Area.M2ToYd2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Mm2ToCm2, Area.Mm2ToCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToFt2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Mm2ToFt2, Area.Mm2ToFt2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToIn2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Mm2ToIn2, Area.Mm2ToIn2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToM2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Mm2ToM2, Area.Mm2ToM2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToYd2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Mm2ToYd2, Area.Mm2ToYd2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToCm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Yd2ToCm2, Area.Yd2ToCm2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToFt2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Yd2ToFt2, Area.Yd2ToFt2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToIn2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Yd2ToIn2, Area.Yd2ToIn2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToM2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Yd2ToM2, Area.Yd2ToM2(value));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToMm2_MatchesFactor(double value) =>
        Assert.Equal(value * Area.Factor.Yd2ToMm2, Area.Yd2ToMm2(value));

    #endregion

    #region Convert dispatch matches the equivalent explicit method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Mm2ToCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToCm2(value), Area.Convert(value, Area.Unit.Mm2, Area.Unit.Cm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Mm2ToM2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToM2(value), Area.Convert(value, Area.Unit.Mm2, Area.Unit.M2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Mm2ToIn2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToIn2(value), Area.Convert(value, Area.Unit.Mm2, Area.Unit.In2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Mm2ToFt2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToFt2(value), Area.Convert(value, Area.Unit.Mm2, Area.Unit.Ft2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Mm2ToYd2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToYd2(value), Area.Convert(value, Area.Unit.Mm2, Area.Unit.Yd2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm2ToMm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToMm2(value), Area.Convert(value, Area.Unit.Cm2, Area.Unit.Mm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm2ToM2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToM2(value), Area.Convert(value, Area.Unit.Cm2, Area.Unit.M2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm2ToIn2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToIn2(value), Area.Convert(value, Area.Unit.Cm2, Area.Unit.In2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm2ToFt2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToFt2(value), Area.Convert(value, Area.Unit.Cm2, Area.Unit.Ft2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm2ToYd2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToYd2(value), Area.Convert(value, Area.Unit.Cm2, Area.Unit.Yd2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M2ToMm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToMm2(value), Area.Convert(value, Area.Unit.M2, Area.Unit.Mm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M2ToCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToCm2(value), Area.Convert(value, Area.Unit.M2, Area.Unit.Cm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M2ToIn2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToIn2(value), Area.Convert(value, Area.Unit.M2, Area.Unit.In2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M2ToFt2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToFt2(value), Area.Convert(value, Area.Unit.M2, Area.Unit.Ft2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M2ToYd2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToYd2(value), Area.Convert(value, Area.Unit.M2, Area.Unit.Yd2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In2ToMm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToMm2(value), Area.Convert(value, Area.Unit.In2, Area.Unit.Mm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In2ToCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToCm2(value), Area.Convert(value, Area.Unit.In2, Area.Unit.Cm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In2ToM2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToM2(value), Area.Convert(value, Area.Unit.In2, Area.Unit.M2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In2ToFt2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToFt2(value), Area.Convert(value, Area.Unit.In2, Area.Unit.Ft2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In2ToYd2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToYd2(value), Area.Convert(value, Area.Unit.In2, Area.Unit.Yd2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft2ToMm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToMm2(value), Area.Convert(value, Area.Unit.Ft2, Area.Unit.Mm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft2ToCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToCm2(value), Area.Convert(value, Area.Unit.Ft2, Area.Unit.Cm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft2ToM2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToM2(value), Area.Convert(value, Area.Unit.Ft2, Area.Unit.M2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft2ToIn2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToIn2(value), Area.Convert(value, Area.Unit.Ft2, Area.Unit.In2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft2ToYd2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToYd2(value), Area.Convert(value, Area.Unit.Ft2, Area.Unit.Yd2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Yd2ToMm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToMm2(value), Area.Convert(value, Area.Unit.Yd2, Area.Unit.Mm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Yd2ToCm2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToCm2(value), Area.Convert(value, Area.Unit.Yd2, Area.Unit.Cm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Yd2ToM2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToM2(value), Area.Convert(value, Area.Unit.Yd2, Area.Unit.M2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Yd2ToIn2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToIn2(value), Area.Convert(value, Area.Unit.Yd2, Area.Unit.In2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Yd2ToFt2_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToFt2(value), Area.Convert(value, Area.Unit.Yd2, Area.Unit.Ft2));

    #endregion

    #region Extension methods match their explicit class method

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm2ToFt2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToFt2(value), value.Cm2ToFt2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm2ToFt2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Cm2ToFt2(value), value.Cm2ToFt2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm2ToIn2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToIn2(value), value.Cm2ToIn2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm2ToIn2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Cm2ToIn2(value), value.Cm2ToIn2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm2ToM2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToM2(value), value.Cm2ToM2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm2ToM2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Cm2ToM2(value), value.Cm2ToM2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm2ToMm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToMm2(value), value.Cm2ToMm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm2ToMm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Cm2ToMm2(value), value.Cm2ToMm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Cm2ToYd2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Cm2ToYd2(value), value.Cm2ToYd2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Cm2ToYd2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Cm2ToYd2(value), value.Cm2ToYd2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToCm2(value), value.Ft2ToCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft2ToCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Ft2ToCm2(value), value.Ft2ToCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToIn2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToIn2(value), value.Ft2ToIn2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft2ToIn2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Ft2ToIn2(value), value.Ft2ToIn2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToM2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToM2(value), value.Ft2ToM2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft2ToM2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Ft2ToM2(value), value.Ft2ToM2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToMm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToMm2(value), value.Ft2ToMm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft2ToMm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Ft2ToMm2(value), value.Ft2ToMm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Ft2ToYd2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Ft2ToYd2(value), value.Ft2ToYd2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Ft2ToYd2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Ft2ToYd2(value), value.Ft2ToYd2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToCm2(value), value.In2ToCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In2ToCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.In2ToCm2(value), value.In2ToCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToFt2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToFt2(value), value.In2ToFt2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In2ToFt2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.In2ToFt2(value), value.In2ToFt2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToM2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToM2(value), value.In2ToM2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In2ToM2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.In2ToM2(value), value.In2ToM2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToMm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToMm2(value), value.In2ToMm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In2ToMm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.In2ToMm2(value), value.In2ToMm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void In2ToYd2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.In2ToYd2(value), value.In2ToYd2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void In2ToYd2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.In2ToYd2(value), value.In2ToYd2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToCm2(value), value.M2ToCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M2ToCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.M2ToCm2(value), value.M2ToCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToFt2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToFt2(value), value.M2ToFt2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M2ToFt2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.M2ToFt2(value), value.M2ToFt2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToIn2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToIn2(value), value.M2ToIn2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M2ToIn2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.M2ToIn2(value), value.M2ToIn2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToMm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToMm2(value), value.M2ToMm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M2ToMm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.M2ToMm2(value), value.M2ToMm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void M2ToYd2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.M2ToYd2(value), value.M2ToYd2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void M2ToYd2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.M2ToYd2(value), value.M2ToYd2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToCm2(value), value.Mm2ToCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Mm2ToCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Mm2ToCm2(value), value.Mm2ToCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToFt2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToFt2(value), value.Mm2ToFt2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Mm2ToFt2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Mm2ToFt2(value), value.Mm2ToFt2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToIn2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToIn2(value), value.Mm2ToIn2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Mm2ToIn2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Mm2ToIn2(value), value.Mm2ToIn2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToM2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToM2(value), value.Mm2ToM2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Mm2ToM2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Mm2ToM2(value), value.Mm2ToM2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Mm2ToYd2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Mm2ToYd2(value), value.Mm2ToYd2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Mm2ToYd2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Mm2ToYd2(value), value.Mm2ToYd2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToCm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToCm2(value), value.Yd2ToCm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Yd2ToCm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Yd2ToCm2(value), value.Yd2ToCm2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToFt2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToFt2(value), value.Yd2ToFt2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Yd2ToFt2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Yd2ToFt2(value), value.Yd2ToFt2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToIn2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToIn2(value), value.Yd2ToIn2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Yd2ToIn2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Yd2ToIn2(value), value.Yd2ToIn2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToM2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToM2(value), value.Yd2ToM2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Yd2ToM2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Yd2ToM2(value), value.Yd2ToM2());

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Yd2ToMm2_DoubleExtension_MatchesExplicitMethod(double value) =>
        Assert.Equal(Area.Yd2ToMm2(value), value.Yd2ToMm2());

    [Theory]
    [MemberData(nameof(SampleFloatValues))]
    public void Yd2ToMm2_FloatExtension_MatchesExplicitMethod(float value) =>
        Assert.Equal((float)Area.Yd2ToMm2(value), value.Yd2ToMm2());

    #endregion

    #region Same-unit conversion is a no-op

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Mm2ToMm2_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Area.Convert(value, Area.Unit.Mm2, Area.Unit.Mm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Cm2ToCm2_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Area.Convert(value, Area.Unit.Cm2, Area.Unit.Cm2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_M2ToM2_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Area.Convert(value, Area.Unit.M2, Area.Unit.M2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_In2ToIn2_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Area.Convert(value, Area.Unit.In2, Area.Unit.In2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Ft2ToFt2_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Area.Convert(value, Area.Unit.Ft2, Area.Unit.Ft2));

    [Theory]
    [MemberData(nameof(SampleValues))]
    public void Convert_Yd2ToYd2_ReturnsOriginalValue(double value) =>
        Assert.Equal(value, Area.Convert(value, Area.Unit.Yd2, Area.Unit.Yd2));

    #endregion
}
