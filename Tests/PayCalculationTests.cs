namespace SoldierFinance.Tests;

// End-to-end tests for Soldier.Calculate() and the totals it feeds.
public class PayCalculationTests
{
    // Same values as the first seeded soldier in Program.cs.
    static Soldier CreateAlex() => new Soldier
    {
        Id = "000-00-0001",
        FirstName = "Alex",
        LastName = "Carter",
        PayGrade = "E-5",
        YearsOfService = 5,
        DutyStation = "Fort Hood, TX (TX286)",
        WithDependents = true,
        FederalTax = 300,
        AllotmentsDebt = 100
    };

    [Fact]
    public void Calculate_E5FortHoodWithDependents_ProducesExpectedPay()
    {
        Soldier alex = CreateAlex();

        alex.Calculate();

        Assert.Equal(3946.80m, alex.BasicPay);
        Assert.Equal(1695m, alex.BAH);
        Assert.Equal(476.95m, alex.BAS);
        Assert.Equal(244.70m, alex.SocialSecurity); // 6.2% of basic pay
        Assert.Equal(57.23m, alex.Medicare);        // 1.45% of basic pay
        Assert.Equal(100m, alex.Insurance);
        Assert.Equal(6118.75m, alex.TotalEntitlements);
        Assert.Equal(801.93m, alex.TotalDeductions);
        Assert.Equal(5316.82m, alex.NetPay);
    }

    [Fact]
    public void Calculate_SplitsNetPayIntoMidMonthAndEndOfMonth()
    {
        Soldier alex = CreateAlex();

        alex.Calculate();

        Assert.Equal(2658.41m, alex.MidMonthPay);
        Assert.Equal(2658.41m, alex.EndMonthPay);
        Assert.Equal(alex.NetPay, alex.MidMonthPay + alex.EndMonthPay);
    }

    [Fact]
    public void Calculate_OddCentNetPay_RoundsDepositsToWholeCents()
    {
        // Net pay 3412.95 cannot split evenly: mid-month 1706.48, end of month 1706.47.
        Soldier soldier = new Soldier
        {
            PayGrade = "E-4",
            YearsOfService = 3.5m,
            DutyStation = "Fort Bliss, TX (TX279)",
            WithDependents = false,
            GovernmentQuarters = true,
            FederalTax = 180
        };

        soldier.Calculate();

        Assert.Equal(3412.95m, soldier.NetPay);
        Assert.Equal(1706.48m, soldier.MidMonthPay);
        Assert.Equal(1706.47m, soldier.EndMonthPay);
        Assert.Equal(soldier.NetPay, soldier.MidMonthPay + soldier.EndMonthPay);
    }

    [Fact]
    public void Calculate_FicaMedicare_IsSocialSecurityPlusMedicare()
    {
        Soldier soldier = new Soldier { PayGrade = "E-2", YearsOfService = 1 };

        soldier.Calculate();

        Assert.Equal(167.27m, soldier.SocialSecurity); // 2697.90 x 6.2% = 167.2698
        Assert.Equal(39.12m, soldier.Medicare);        // 2697.90 x 1.45% = 39.11955
        Assert.Equal(206.39m, soldier.FicaMedicare);
    }

    [Fact]
    public void Calculate_GovernmentQuarters_SetsBahToZero()
    {
        Soldier soldier = new Soldier
        {
            PayGrade = "E-4",
            YearsOfService = 3.5m,
            DutyStation = "Fort Bliss, TX (TX279)",
            WithDependents = false,
            GovernmentQuarters = true,
            FederalTax = 180
        };

        soldier.Calculate();

        Assert.Equal(0m, soldier.BAH);
        Assert.Equal(3959.35m, soldier.TotalEntitlements);
        Assert.Equal(3412.95m, soldier.NetPay);
    }

    [Fact]
    public void Calculate_OverseasHousingAllowance_ReplacesBah()
    {
        Soldier soldier = new Soldier
        {
            PayGrade = "E-6",
            YearsOfService = 9,
            DutyStation = "Fort Hood, TX (TX286)",
            OHA = 1500,
            FederalTax = 420
        };

        soldier.Calculate();

        Assert.Equal(0m, soldier.BAH);
        Assert.Equal(4612.80m, soldier.BasicPay);
        Assert.Equal(6589.75m, soldier.TotalEntitlements); // includes OHA, not BAH
    }

    [Fact]
    public void Calculate_UnknownStation_UsesManualBahRate()
    {
        Soldier soldier = CreateAlex();
        soldier.DutyStation = "Other station (manual BAH)";
        soldier.BahRate = 1500;

        soldier.Calculate();

        Assert.Equal(1500m, soldier.BAH);
        Assert.Equal(5923.75m, soldier.TotalEntitlements);
    }

    [Theory]
    [InlineData("E-2", "", "PV2")]
    [InlineData("E-3", "", "PFC")]
    [InlineData("E-4", "", "SPC")]
    [InlineData("E-4", "CPL", "CPL")] // a corporal keeps CPL
    [InlineData("E-5", "", "SGT")]
    [InlineData("E-6", "", "SSG")]
    [InlineData("E-7", "", "SFC")]
    [InlineData("E-8", "", "MSG")]
    public void Calculate_SetsRankFromPayGrade(string grade, string startingRank, string expectedRank)
    {
        Soldier soldier = new Soldier
        {
            PayGrade = grade,
            YearsOfService = 10, // valid for every grade, including E-8
            Rank = startingRank
        };

        soldier.Calculate();

        Assert.Equal(expectedRank, soldier.Rank);
    }

    [Fact]
    public void Calculate_InvalidServiceForGrade_ThrowsArgumentException()
    {
        Soldier soldier = new Soldier { PayGrade = "E-8", YearsOfService = 8 };

        Assert.Throws<ArgumentException>(() => soldier.Calculate());
    }
}
