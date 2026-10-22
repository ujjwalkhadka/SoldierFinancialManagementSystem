namespace SoldierFinanceSample;
// Monthly 2026 rates. Sources and supported limits are documented in README.md.
public static class PayRates2026
{
    // m marks decimal constants; rates are cached and not downloaded at runtime.
    public static decimal EnlistedBas = 476.95m;
    public static decimal DailyMeals = 13.65m;
    // Round money to two places; midpoint halves round away from zero.
    public static decimal Round(decimal value) => decimal.Round(value, 2, MidpointRounding.AwayFromZero);

    // Choose the appropriate row (grade) and column (service threshold).
    public static decimal BasicPay(string grade, decimal years)
    {
        // Reject service values outside the supported sample range.
        if (years < 0 || years > 18) throw new ArgumentException("This sample supports 0–18 years of service only.");
        // Columns: <=2, >2, >3, >4, >6, >8, >10, >12, >14, >16, >18.
        // The switch selects a rate array; each array has the same threshold columns.
        decimal[] rates = grade switch
        {
            "E-2" => new decimal[] { 2697.90m, 2697.90m, 2697.90m, 2697.90m, 2697.90m, 2697.90m, 2697.90m, 2697.90m, 2697.90m, 2697.90m, 2697.90m },
            "E-3" => new decimal[] { 2836.80m, 3015.00m, 3198.00m, 3198.00m, 3198.00m, 3198.00m, 3198.00m, 3198.00m, 3198.00m, 3198.00m, 3198.00m },
            "E-4" => new decimal[] { 3142.20m, 3303.00m, 3482.40m, 3658.50m, 3815.40m, 3815.40m, 3815.40m, 3815.40m, 3815.40m, 3815.40m, 3815.40m },
            "E-5" => new decimal[] { 3342.90m, 3598.20m, 3775.80m, 3946.80m, 4110.00m, 4299.90m, 4395.30m, 4421.70m, 4421.70m, 4421.70m, 4421.70m },
            "E-6" => new decimal[] { 3401.10m, 3743.10m, 3908.10m, 4068.90m, 4235.70m, 4612.80m, 4759.50m, 5043.30m, 5130.30m, 5193.60m, 5267.70m },
            "E-7" => new decimal[] { 3932.10m, 4291.50m, 4456.20m, 4673.10m, 4843.80m, 5135.70m, 5300.40m, 5591.70m, 5835.00m, 6000.90m, 6177.30m },
            "E-8" when years > 8 => new decimal[] { 0, 0, 0, 0, 0, 5656.50m, 5907.00m, 6061.80m, 6247.20m, 6448.20m, 6811.20m },
            _ => throw new ArgumentException("Choose E-2 through E-8. E-8 requires over 8 years. Officer/E-1/E-9 tables are outside this sample.")
        };
        // Strictly over thresholds: 5 years uses over-4; exactly 6 still uses over-4.
        decimal[] thresholds = { 2, 3, 4, 6, 8, 10, 12, 14, 16, 18 };
        int column = 0;
        // Count how many thresholds the soldier has passed to find the array index.
        foreach (decimal threshold in thresholds) if (years > threshold) column++;
        // Return the monthly basic pay at that zero-based index.
        return rates[column];
    }
}
