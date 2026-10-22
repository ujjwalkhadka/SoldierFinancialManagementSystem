namespace SoldierFinance.Tests;

// Tests for BahRates2026.TryGetRate: station + grade + dependents lookup.
public class BahRateTests
{
    [Theory]
    [InlineData("Fort Hood, TX (TX286)", "E-5", true, 1695)]
    [InlineData("Fort Hood, TX (TX286)", "E-5", false, 1530)]
    [InlineData("Fort Hood, TX (TX286)", "E-2", true, 1662)]
    [InlineData("Schofield Barracks, HI (HI408)", "E-8", false, 3720)]
    [InlineData("Fort Riley, KS (KS100)", "E-6", true, 1782)]
    public void TryGetRate_KnownStationAndGrade_ReturnsRate(
        string station, string grade, bool dependents, int expected)
    {
        bool found = BahRates2026.TryGetRate(station, grade, dependents, out decimal rate);

        Assert.True(found);
        Assert.Equal((decimal)expected, rate);
    }

    [Fact]
    public void TryGetRate_UnknownStation_ReturnsFalseAndZero()
    {
        bool found = BahRates2026.TryGetRate("Other station (manual BAH)", "E-5", true, out decimal rate);

        Assert.False(found);
        Assert.Equal(0m, rate);
    }

    [Fact]
    public void TryGetRate_UnsupportedGrade_ReturnsFalseAndZero()
    {
        bool found = BahRates2026.TryGetRate("Fort Hood, TX (TX286)", "E-9", true, out decimal rate);

        Assert.False(found);
        Assert.Equal(0m, rate);
    }
}
