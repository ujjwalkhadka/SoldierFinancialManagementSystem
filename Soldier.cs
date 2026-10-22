namespace SoldierFinanceSample;


public class Soldier
{
    public string Id { get; set; } = ""; 
    public string FirstName { get; set; } = "";
    public string MiddleName { get; set; } = ""; // Optional.
    public string LastName { get; set; } = "";

    public string Name
    {
        get
        {
            string fullName = "";

            if (!string.IsNullOrWhiteSpace(FirstName))
            {
                fullName = FirstName;
            }

            if (!string.IsNullOrWhiteSpace(MiddleName))
            {
                if (fullName != "")
                {
                    fullName += " ";
                }

                fullName += MiddleName;
            }

            if (!string.IsNullOrWhiteSpace(LastName))
            {
                if (fullName != "")
                {
                    fullName += " ";
                }

                fullName += LastName;
            }

            return fullName;
        }
    }
    public string Rank { get; set; } = "";
    public bool WithDependents { get; set; } = true;
    public string Unit { get; set; } = "";
    public decimal YearsOfService { get; set; } = 5;
    public string DutyStation { get; set; } = "Fort Hood, TX (TX286)";

   
    public string PayGrade { get; set; } = "E-5";
    public bool GovernmentQuarters { get; set; }
    public decimal BahRate { get; set; } = 1695;

    
    public decimal BasicPay { get; set; }
    public decimal BAH { get; set; }
    public decimal BAS { get; set; }
    public decimal OHA { get; set; } 
    public decimal Clothing { get; set; }
    public decimal FSA { get; set; } 
    public decimal SpecialPay { get; set; }

    
    public decimal FederalTax { get; set; } = 300;
    public decimal StateTax { get; set; }
    public decimal SocialSecurity { get; set; }
    public decimal Medicare { get; set; }
    public decimal FicaMedicare
    {
        get
        {
            return SocialSecurity + Medicare;
        }
    }
    public decimal Insurance { get; set; }
    public decimal AllotmentsDebt { get; set; }
    public decimal MidMonthPay 
    { 
        get
        {
            // Round to the cent so deposits never contain half-cents;
            // EndMonthPay gets any remaining cent.
            return PayRates2026.Round(NetPay / 2);
        }
            
    }

    public decimal TotalEntitlements
    {
        get
        {
            return BasicPay + BAH + BAS + OHA + Clothing + FSA + SpecialPay;
        }
    }
    public decimal TotalDeductions
    {
        get
        {
            return FederalTax + StateTax + FicaMedicare + Insurance + AllotmentsDebt;
        }
    }
    
    public decimal NetPay
    {
        get
        {
            return TotalEntitlements - TotalDeductions;
        }
    }
    public decimal EndMonthPay
    {
        get
        {
            return NetPay - MidMonthPay;
        }
    }

    
    public void Calculate()
    {
        BasicPay = PayRates2026.BasicPay(PayGrade, YearsOfService);

        
        switch (PayGrade)
        {
            case "E-1":
                Rank = "PV1";
                break;

            case "E-2":
                Rank = "PV2";
                break;

            case "E-3":
                Rank = "PFC";
                break;

            case "E-4":
               
                if (Rank != "CPL")
                {
                    Rank = "SPC";
                }
                break;

            case "E-5":
                Rank = "SGT";
                break;

            case "E-6":
                Rank = "SSG";
                break;

            case "E-7":
                Rank = "SFC";
                break;

            case "E-8":
                Rank = "MSG";
                break;

            default:
                
                break;
        }

        decimal rate;

        if (BahRates2026.TryGetRate(
            DutyStation, PayGrade, WithDependents, out rate))
        {
            BahRate = rate;
        }

        
        if (GovernmentQuarters || OHA > 0)
        {
            BAH = 0;
        }
        else
        {
            BAH = BahRate;
        }

        BAS = PayRates2026.EnlistedBas;

        SocialSecurity = PayRates2026.Round(BasicPay * 0.062m);
        Medicare = PayRates2026.Round(BasicPay * 0.0145m);

        Insurance = 100; 
    }
    public override string ToString()
    {
        return Id + " - " + Rank + " " + Name;
    }
}
