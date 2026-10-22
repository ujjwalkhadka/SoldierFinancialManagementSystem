/* Monthly locality rates, effective January 1, 2026; checked October 11, 2026. One pair per grade E-2, E-3, E-4, E-5, E-6, E-7, E-8: with / without dependents. 
 * Dictionary maps a station name to its two-dimensional decimal rate table.
 * Rows are grades; column 0 is with dependents and column 1 is without.*/



namespace SoldierFinanceSample;
public static class BahRates2026
{
   
 static Dictionary<string, decimal[,]> rates = new Dictionary<string, decimal[,]>
 {
    {
        "Fort Hood, TX (TX286)", new decimal[,]
        {
            { 1662, 1374 }, { 1662, 1374 }, { 1662, 1374 },
            { 1695, 1530 }, { 1920, 1626 }, { 2070, 1668 },
            { 2238, 1746 }
        }
    },
    {
        "Fort Bliss, TX (TX279)", new decimal[,]
        {
            { 1665, 1302 }, { 1665, 1302 }, { 1665, 1302 },
            { 1809, 1437 }, { 2148, 1611 }, { 2172, 1668 },
            { 2187, 1881 }
        }
    },
    {
        "Fort Sam Houston, TX (TX285)", new decimal[,]
        {
            { 1728, 1359 }, { 1728, 1359 }, { 1728, 1359 },
            { 1869, 1500 }, { 2094, 1596 }, { 2112, 1731 },
            { 2121, 1920 }
        }
    },
    {
        "Fort Riley, KS (KS100)", new decimal[,]
        {
            { 1272, 1050 }, { 1272, 1050 }, { 1272, 1050 },
            { 1314, 1158 }, { 1782, 1338 }, { 1845, 1383 },
            { 1911, 1434 }
        }
    },
    {
        "Fort Carson, CO (CO046)", new decimal[,]
        {
            { 2160, 1689 }, { 2160, 1689 }, { 2160, 1689 },
            { 2358, 1860 }, { 2433, 1980 }, { 2487, 2166 },
            { 2553, 2379 }
        }
    },
    {
        "Fort Campbell, KY (KY106)", new decimal[,]
        {
            { 1743, 1470 }, { 1743, 1470 }, { 1743, 1470 },
            { 1815, 1593 }, { 2100, 1671 }, { 2244, 1743 },
            { 2400, 1878 }
        }
    },
    {
        "Fort Jackson, SC (SC260)", new decimal[,]
        {
            { 1812, 1479 }, { 1812, 1479 }, { 1812, 1479 },
            { 1878, 1647 }, { 2121, 1746 }, { 2160, 1812 },
            { 2202, 1932 }
        }
    },
    {
        "Schofield Barracks, HI (HI408)", new decimal[,]
        {
            { 3333, 2598 }, { 3333, 2598 }, { 3333, 2598 },
            { 3663, 2856 }, { 3912, 3036 }, { 4098, 3348 },
            { 4302, 3720 }
        }
    }
 };
    // Return true when the station/grade are found, and return the amount through out.
    public static bool TryGetRate(
    string station,
    string grade,
    bool dependents,
    out decimal amount)
    {
        amount = 0;

        string[] grades =  { "E-2", "E-3", "E-4", "E-5", "E-6", "E-7", "E-8" };

        int index = -1;

        // Find the row for the selected grade.
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] == grade)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            return false;
        }

        // Check that the station exists before accessing its table.
        if (rates.ContainsKey(station) == false)
        {
            return false;
        }

        decimal[,] table = rates[station];

        if (dependents)
        {
            amount = table[index, 0]; // With dependents.
        }
        else
        {
            amount = table[index, 1]; // Without dependents.
        }

        return true;
    }
}
