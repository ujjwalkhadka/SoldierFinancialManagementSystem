# Soldier Finance - four tabs matching the reference pictures

Open SoldierFinanceSample.csproj in Visual Studio on Windows with the .NET desktop development workload/.NET 8 SDK. Extract this update into a new folder. Visual Studio restores DocumentFormat.OpenXml 3.5.1 on first build.

## Four read-only tabs
Both MainForm and the separate SoldierManagementForm have exactly four tabs: Personal Details, Entitlements, Deductions and Pay Summary. MainForm shows labels and read-only textboxes positioned to resemble your four uploaded pictures. The management form provides editable inputs for the same record.

Personal Details: SSN, First Name, Middle, Last Name, Rank, Dependents, Unit, Years of Service, Duty Station. Middle is optional. Dependents displays Yes/No. There is no pay period or separate pay settings tab on the viewer. First/middle/last names are separate model properties; Name combines them for the selector/search.

Entitlements: Base Salary, Basic Allowance for Housing (BAH), Basic Allowance for Subsistence (BAS), Overseas Housing Allowance (OHA), Clothing Allowance, Family Separation Allowance (FSA), Special Pay.

Deductions: Federal Income Tax Withheld, State Income Tax Withheld, FICA/Medicare Taxes, Servicemembers' Group Life Insurance, Allotments/Debt Collections. Social Security and Medicare are combined for display. Allotments/debt is entered as one combined amount and included once in Total Deductions.

Pay Summary: Total Entitlements, Total Deductions, Monthly Salary(estimated), Mid Month Deposit, End of Month Deposit. There is no separate allotment total or extra settings display.

TSP, meals, dental, COLA, separate savings/support inputs and the old pay period field were removed to match the pictured categories. Financial zero labels/textboxes are hidden at runtime, preserving your previous omit-zero requirement. Every control remains visible and editable in Design view. Excel stores numeric 0.

## Managing records and search
Add/Update/Delete buttons open SoldierManagementForm. All list mutations and validation are in that .cs file, not MainForm.cs. Typing does not change a record. Save validates and calculates a candidate, then commits. Cancel, Escape or X discards unsaved changes. Delete requires Yes confirmation; No/Cancel keeps the record. Deleting all records is handled safely.

The management Personal Details tab also holds pay grade and government-quarters inputs required for calculation, without adding those fields to the pictured main viewer. Its Entitlements tab has the BAH rate input for manual stations. Other computed fields are not editable.

Search matches part of a full name (including middle), demo SSN or rank, ignoring case. Click Search or press Enter. Show all restores the complete selector; no match clears the displays. A successful management change clears the current search. Excel exports all current soldiers even while searched.

## Pay assumptions and new demo totals
- Cached 2026 basic-pay and BAH tables are retained. E-2 through E-8, 0-18 service years; E-8 requires over 8 years. Strictly-over service thresholds apply.
- BAS is 476.95. SGLI + TSGLI assumes 26/month. Social Security is 6.2% and Medicare 1.45% of basic pay only, rounded separately. They appear together as FICA/Medicare Taxes.
- Federal/state withholding and allotments/debt are entered. The combined allotment/debt amount is already inside Total Deductions; do not subtract it again.
- OHA and FSA are entered authorized amounts, defaulting to zero. No overseas rent cap, currency conversion or eligibility calculation is provided. In this simplified demo, entering positive OHA sets BAH to zero to avoid adding two housing allowances. Government quarters also sets BAH to zero.
- Total Entitlements = Base Salary + BAH + BAS + OHA + Clothing + FSA + Special Pay.
- Total Deductions = Federal + State + Social Security + Medicare + Insurance + Allotments/Debt.
- Monthly Salary = Total Entitlements - Total Deductions. EOM = Monthly Salary - Mid Month Deposit already paid.
- FICA wage caps, special-pay tax treatment, proration, combat exclusions, withholding schedules, BAH protection and partial housing allowances are outside this sample.
- The screenshots remove earlier TSP and meal deductions, so demo net pay has changed. Default Alex: gross 6118.75; deductions 727.93; monthly net 5390.82; demo midmonth/EOM 2695.41. These remain fictional estimates, not actual LES amounts.

## Excel, startup and Designer
Save Excel creates C:\Files\SoldierFinance.xlsx with one real worksheet named Soldier Finance. There are 26 columns matching the four pictured tab fields, from A to Z. SSNs/names are text and financial amounts are numeric, including zero. No ClosedXML, JSON or installed Excel is required. Close the workbook before overwriting it.

Ten soldiers remain directly inside Main() in Program.cs. Restarting restores them; exported Excel is not read at startup. Runtime edits do not rewrite C# source.

Use Shift+F7 on either form's .cs file to open Design view. All layout is in its .Designer.cs file, with comments. The main viewer is 1400 x 900; the management form is 1100 x 720. Both tab containers allow scrolling. The updated PDF contains setup steps and complete source. The old video has not been regenerated and shows earlier fields/layouts.

## Windows checks
Source/event/property mappings and the 26-column export were inspected. This environment cannot compile or run WinForms, so Windows validation remains required. No executable is included.

1. Verify exactly four tabs on both forms; viewer textboxes are read-only.
2. Inspect all pictured fields in Design view; zero financial controls hide only at runtime.
3. Add with separate first/middle/last names, Save, then search by each name; Cancel/X adds nothing.
4. Update/cancel, duplicate ID and invalid grade/service preserve original records; save refreshes all fields.
5. Test Delete No/Yes and removing the last soldier; Show all and Add still work.
6. Add OHA/FSA and recalculate; check OHA replaces BAH and totals include both newly supported fields. Restore zero and check hidden controls.
7. Verify FICA combines both taxes and Allotments/Debt is counted once.
8. Export while searched: one worksheet, every current record, 26 aligned columns and zero cells.

## Rate sources (checked October 11, 2026)
DFAS basic pay: https://www.dfas.mil/MilitaryMembers/payentitlements/Pay-Tables/Basic-Pay/EM/
DFAS BAS: https://www.dfas.mil/MilitaryMembers/payentitlements/Pay-Tables/bas/
DFAS LES: https://www.dfas.mil/militarymembers/payentitlements/les/
VA SGLI: https://www.benefits.va.gov/INSURANCE/sgli.asp
IRS: https://www.irs.gov/publications/p15
DTMO meals: https://www.travel.dod.mil/Travel-Transportation-Rates/Meal-Rates/
DTMO housing policy: https://www.travel.dod.mil/Allowances/Basic-Allowance-for-Housing/
Fort Riley official check: https://installations.militaryonesource.mil/in-depth-overview/fort-riley

The official all-locality DTMO file could not be retrieved during earlier research. Station numeric rates were cross-checked in listings below, rather than claimed as a direct official import. Tables are cached, not automatically updated for later off-cycle changes.
Fort Hood: https://uniformedpay.com/bah/2026/fort-hood-tx/
Fort Bliss: https://uniformedpay.com/bah/2026/el-paso-tx/
Fort Sam Houston: https://militarypaydates.com/bah-rates/tx/san-antonio-tx/
Fort Riley: https://www.militarytoolkit.com/bah-rates/fort-riley
Fort Carson: https://www.militarytoolkit.com/bah-rates/fort-carson
Fort Campbell: https://www.militarytoolkit.com/bah-rates/fort-campbell
Fort Jackson: https://www.militarytoolkit.com/bah-rates/fort-jackson
Schofield: https://uniformedpay.com/bah/2026/honolulu-county-hi/



