using System.Collections.Generic;

namespace SoldierFinanceSample;
internal static class Program
{
    
    // Windows Forms must start on an STA thread.
    [STAThread]
    static void Main()
    {
        
        ApplicationConfiguration.Initialize();
        

        List<Soldier> soldiers = new List<Soldier>
        {
            new Soldier { Id="000-00-0001", FirstName="Alex", LastName="Carter", Rank="SGT", PayGrade="E-5", YearsOfService=5, DutyStation="Fort Hood, TX (TX286)", FederalTax=300, AllotmentsDebt=100 },
            new Soldier { Id="000-00-0002", FirstName="Jordan", LastName="Lee", Rank="SPC", PayGrade="E-4", YearsOfService=3.5m, DutyStation="Fort Bliss, TX (TX279)", WithDependents=false, GovernmentQuarters=true, FederalTax=180 },
            new Soldier { Id="000-00-0003", FirstName="Morgan", LastName="Hayes", Rank="PV2", PayGrade="E-2", YearsOfService=1, DutyStation="Fort Sam Houston, TX (TX285)", WithDependents=false, GovernmentQuarters=true, FederalTax=120, AllotmentsDebt=100 },
            new Soldier { Id="000-00-0004", FirstName="Taylor", LastName="Brooks", Rank="PFC", PayGrade="E-3", YearsOfService=2.5m, DutyStation="Fort Riley, KS (KS100)", WithDependents=false, GovernmentQuarters=true, FederalTax=140 },
            new Soldier { Id="000-00-0005", FirstName="Casey", LastName="Rivera", Rank="SPC", PayGrade="E-4", YearsOfService=5, DutyStation="Fort Carson, CO (CO046)", FederalTax=220, StateTax=100, AllotmentsDebt=100 },
            new Soldier { Id="000-00-0006", FirstName="Riley", LastName="Bennett", Rank="SGT", PayGrade="E-5", YearsOfService=7, DutyStation="Fort Campbell, KY (KY106)", WithDependents=false, FederalTax=330 },
            new Soldier { Id="000-00-0007", FirstName="Jamie", LastName="Parker", Rank="SSG", PayGrade="E-6", YearsOfService=9, DutyStation="Fort Jackson, SC (SC260)", FederalTax=420, AllotmentsDebt=100 },
            new Soldier { Id="000-00-0008", FirstName="Drew", LastName="Collins", Rank="SSG", PayGrade="E-6", YearsOfService=11, DutyStation="Schofield Barracks, HI (HI408)", WithDependents=false, FederalTax=460 },
            new Soldier { Id="000-00-0009", FirstName="Avery", LastName="Mitchell", Rank="SFC", PayGrade="E-7", YearsOfService=13, DutyStation="Fort Hood, TX (TX286)", FederalTax=550, AllotmentsDebt=100 },
            new Soldier { Id="000-00-0010", FirstName="Sam", LastName="Foster", Rank="MSG", PayGrade="E-8", YearsOfService=17, DutyStation="Fort Bliss, TX (TX279)", FederalTax=700 },
            new Soldier { Id="000-00-0011", FirstName="Emma", LastName="Wilson", Rank="PV2", PayGrade="E-2", YearsOfService=1, DutyStation="Fort Hood, TX (TX286)", FederalTax=120 },
            new Soldier { Id="000-00-0012", FirstName="Noah", LastName="Thompson", Rank="PFC", PayGrade="E-3", YearsOfService=3, DutyStation="Fort Bliss, TX (TX279)", FederalTax=150 },
            new Soldier { Id="000-00-0013", FirstName="Liam", LastName="Anderson", Rank="SPC", PayGrade="E-4", YearsOfService=4, DutyStation="Fort Sam Houston, TX (TX285)", FederalTax=200, WithDependents=false },
            new Soldier { Id="000-00-0014", FirstName="Olivia", LastName="Thomas", Rank="SGT", PayGrade="E-5", YearsOfService=6, DutyStation="Fort Riley, KS (KS100)", FederalTax=280, AllotmentsDebt=100 },
            new Soldier { Id="000-00-0015", FirstName="Ethan", LastName="Martinez", Rank="SSG", PayGrade="E-6", YearsOfService=9, DutyStation="Fort Carson, CO (CO046)", FederalTax=400 },
            new Soldier { Id="000-00-0016", FirstName="Sophia", LastName="Robinson", Rank="SFC", PayGrade="E-7", YearsOfService=13, DutyStation="Fort Campbell, KY (KY106)", FederalTax=500, AllotmentsDebt=150 },
            new Soldier { Id="000-00-0017", FirstName="Mason", LastName="Clark", Rank="MSG", PayGrade="E-8", YearsOfService=17, DutyStation="Fort Jackson, SC (SC260)", FederalTax=650 },
            new Soldier { Id="000-00-0018", FirstName="Isabella", LastName="Lewis", Rank="SPC", PayGrade="E-4", YearsOfService=5, DutyStation="Schofield Barracks, HI (HI408)", FederalTax=230, WithDependents=false },
            new Soldier { Id="000-00-0019", FirstName="James", LastName="Walker", Rank="SGT", PayGrade="E-5", YearsOfService=7, DutyStation="Fort Hood, TX (TX286)", FederalTax=320 },
            new Soldier { Id="000-00-0020", FirstName="Charlotte", LastName="Hall", Rank="SSG", PayGrade="E-6", YearsOfService=11, DutyStation="Fort Bliss, TX (TX279)", FederalTax=450, AllotmentsDebt=200 },
            new Soldier { Id="000-00-0021", FirstName="Benjamin", LastName="Allen", Rank="PV2", PayGrade="E-2", YearsOfService=1.5m, DutyStation="Fort Sam Houston, TX (TX285)", FederalTax=110, WithDependents=false },
            new Soldier { Id="000-00-0022", FirstName="Amelia", LastName="Young", Rank="PFC", PayGrade="E-3", YearsOfService=2.5m, DutyStation="Fort Riley, KS (KS100)", FederalTax=140 },
            new Soldier { Id="000-00-0023", FirstName="Lucas", LastName="King", Rank="CPL", PayGrade="E-4", YearsOfService=5, DutyStation="Fort Carson, CO (CO046)", FederalTax=220, AllotmentsDebt=75 },
            new Soldier { Id="000-00-0024", FirstName="Harper", LastName="Wright", Rank="SGT", PayGrade="E-5", YearsOfService=8, DutyStation="Fort Campbell, KY (KY106)", FederalTax=340, WithDependents=false },
            new Soldier { Id="000-00-0025", FirstName="Henry", LastName="Scott", Rank="SSG", PayGrade="E-6", YearsOfService=10, DutyStation="Fort Jackson, SC (SC260)", FederalTax=420 },
            new Soldier { Id="000-00-0026", FirstName="Evelyn", LastName="Green", Rank="SFC", PayGrade="E-7", YearsOfService=15, DutyStation="Schofield Barracks, HI (HI408)", FederalTax=560, AllotmentsDebt=250 },
            new Soldier { Id="000-00-0027", FirstName="Alexander", LastName="Baker", Rank="MSG", PayGrade="E-8", YearsOfService=18, DutyStation="Fort Hood, TX (TX286)", FederalTax=700 },
            new Soldier { Id="000-00-0028", FirstName="Abigail", LastName="Adams", Rank="SPC", PayGrade="E-4", YearsOfService=3, DutyStation="Fort Bliss, TX (TX279)", FederalTax=180, WithDependents=false },
            new Soldier { Id="000-00-0029", FirstName="Daniel", LastName="Nelson", Rank="SGT", PayGrade="E-5", YearsOfService=5, DutyStation="Fort Sam Houston, TX (TX285)", FederalTax=300, AllotmentsDebt=100 },
            new Soldier { Id="000-00-0030", FirstName="Emily", LastName="Hill", Rank="SSG", PayGrade="E-6", YearsOfService=12, DutyStation="Fort Riley, KS (KS100)", FederalTax=460 },
            new Soldier { Id="000-00-0031", FirstName="Michael", LastName="Ramirez", Rank="PV2", PayGrade="E-2", YearsOfService=1, DutyStation="Fort Carson, CO (CO046)", FederalTax=100, WithDependents=false },
            new Soldier { Id="000-00-0032", FirstName="Elizabeth", LastName="Campbell", Rank="PFC", PayGrade="E-3", YearsOfService=4, DutyStation="Fort Campbell, KY (KY106)", FederalTax=170 },
            new Soldier { Id="000-00-0033", FirstName="Sebastian", LastName="Mitchell", Rank="SPC", PayGrade="E-4", YearsOfService=6, DutyStation="Fort Jackson, SC (SC260)", FederalTax=240, AllotmentsDebt=125 },
            new Soldier { Id="000-00-0034", FirstName="Sofia", LastName="Roberts", Rank="SGT", PayGrade="E-5", YearsOfService=9, DutyStation="Schofield Barracks, HI (HI408)", FederalTax=350, WithDependents=false },
            new Soldier { Id="000-00-0035", FirstName="Jack", LastName="Turner", Rank="SSG", PayGrade="E-6", YearsOfService=14, DutyStation="Fort Hood, TX (TX286)", FederalTax=480 },
            new Soldier { Id="000-00-0036", FirstName="Avery", LastName="Phillips", Rank="SFC", PayGrade="E-7", YearsOfService=16, DutyStation="Fort Bliss, TX (TX279)", FederalTax=580, AllotmentsDebt=300 },
            new Soldier { Id="000-00-0037", FirstName="Owen", LastName="Evans", Rank="MSG", PayGrade="E-8", YearsOfService=14, DutyStation="Fort Sam Houston, TX (TX285)", FederalTax=620 },
            new Soldier { Id="000-00-0038", FirstName="Ella", LastName="Edwards", Rank="CPL", PayGrade="E-4", YearsOfService=4, DutyStation="Fort Riley, KS (KS100)", FederalTax=210, WithDependents=false },
            new Soldier { Id="000-00-0039", FirstName="Samuel", LastName="Collins", Rank="SGT", PayGrade="E-5", YearsOfService=6.5m, DutyStation="Fort Carson, CO (CO046)", FederalTax=310, AllotmentsDebt=80 },
            new Soldier { Id="000-00-0040", FirstName="Grace", LastName="Stewart", Rank="SSG", PayGrade="E-6", YearsOfService=8, DutyStation="Fort Campbell, KY (KY106)", FederalTax=390 },
            new Soldier { Id="000-00-0041", FirstName="David", LastName="Sanchez", Rank="PV2", PayGrade="E-2", YearsOfService=2, DutyStation="Fort Jackson, SC (SC260)", FederalTax=115, WithDependents=false },
            new Soldier { Id="000-00-0042", FirstName="Chloe", LastName="Morris", Rank="PFC", PayGrade="E-3", YearsOfService=3.5m, DutyStation="Schofield Barracks, HI (HI408)", FederalTax=160, AllotmentsDebt=50 },
            new Soldier { Id="000-00-0043", FirstName="Joseph", LastName="Rogers", Rank="SPC", PayGrade="E-4", YearsOfService=7, DutyStation="Fort Hood, TX (TX286)", FederalTax=250 },
            new Soldier { Id="000-00-0044", FirstName="Victoria", LastName="Reed", Rank="SGT", PayGrade="E-5", YearsOfService=10, DutyStation="Fort Bliss, TX (TX279)", FederalTax=370, WithDependents=false },
            new Soldier { Id="000-00-0045", FirstName="John", LastName="Cook", Rank="SSG", PayGrade="E-6", YearsOfService=13, DutyStation="Fort Sam Houston, TX (TX285)", FederalTax=470, AllotmentsDebt=175 },
            new Soldier { Id="000-00-0046", FirstName="Lily", LastName="Morgan", Rank="SFC", PayGrade="E-7", YearsOfService=17, DutyStation="Fort Riley, KS (KS100)", FederalTax=600 },
            new Soldier { Id="000-00-0047", FirstName="Luke", LastName="Bell", Rank="MSG", PayGrade="E-8", YearsOfService=16, DutyStation="Fort Carson, CO (CO046)", FederalTax=680, AllotmentsDebt=200 },
            new Soldier { Id="000-00-0048", FirstName="Zoey", LastName="Murphy", Rank="SPC", PayGrade="E-4", YearsOfService=2.5m, DutyStation="Fort Campbell, KY (KY106)", FederalTax=170, WithDependents=false },
            new Soldier { Id="000-00-0049", FirstName="Gabriel", LastName="Bailey", Rank="SGT", PayGrade="E-5", YearsOfService=11, DutyStation="Fort Jackson, SC (SC260)", FederalTax=380, AllotmentsDebt=120 },
            new Soldier { Id="000-00-0050", FirstName="Hannah", LastName="Cooper", Rank="SSG", PayGrade="E-6", YearsOfService=15, DutyStation="Schofield Barracks, HI (HI408)", FederalTax=500 }

        };

        foreach (Soldier soldier in soldiers)
        {
            soldier.Unit = "125TH FMSU";
            soldier.Calculate();

        }

        // Create the list once; LoginForm passes this same list to every MainForm session.
        Application.Run(new LoginForm(soldiers));
    }
}
