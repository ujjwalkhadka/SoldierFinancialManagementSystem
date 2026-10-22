namespace SoldierFinance.Tests;

// Tests for PayRates2026.BasicPay: picking the right row (grade) and column (years of service).
public class BasicPayTests
{
    // grade, years of service, expected monthly basic pay
    public static TheoryData<string, decimal, decimal> ValidCases => new()
    {
        { "E-2", 1m, 2697.90m },
        { "E-3", 2m, 2836.80m },    // exactly 2 years is NOT "over 2"
        { "E-3", 2.5m, 3015.00m },  // over 2
        { "E-4", 3.5m, 3482.40m },  // over 3
        { "E-5", 5m, 3946.80m },    // over 4
        { "E-6", 6m, 4068.90m },    // exactly 6 still uses the over-4 column
        { "E-7", 0m, 3932.10m },    // first column
        { "E-8", 9m, 5656.50m },    // E-8 starts at over 8
        { "E-6", 18m, 5193.60m },   // exactly 18 uses the over-16 column
    };

    [Theory]
    [MemberData(nameof(ValidCases))]
    public void BasicPay_ReturnsRateForGradeAndYears(string grade, decimal years, decimal expected)
    {
        decimal actual = PayRates2026.BasicPay(grade, years);

        Assert.Equal(expected, actual);
    }

    public static TheoryData<string, decimal> InvalidCases => new()
    {
        { "E-5", -1m },  // negative service
        { "E-5", 19m },  // above the supported 0-18 range
        { "E-8", 8m },   // E-8 requires over 8 years
        { "E-1", 2m },   // grade not in this sample
        { "E-9", 10m },  // grade not in this sample
        { "", 5m },      // blank grade
    };

    [Theory]
    [MemberData(nameof(InvalidCases))]
    public void BasicPay_InvalidGradeOrYears_ThrowsArgumentException(string grade, decimal years)
    {
        Assert.Throws<ArgumentException>(() => PayRates2026.BasicPay(grade, years));
    }

    [Theory]
    [InlineData(0.125, 0.13)]    // midpoint rounds up
    [InlineData(-0.125, -0.13)]  // midpoint rounds away from zero
    [InlineData(244.7016, 244.70)]
    [InlineData(57.2286, 57.23)]
    public void Round_UsesTwoDecimalsAwayFromZero(double value, double expected)
    {
        Assert.Equal((decimal)expected, PayRates2026.Round((decimal)value));
    }
}
