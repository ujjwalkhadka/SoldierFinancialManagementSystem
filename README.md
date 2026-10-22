# Soldier Financial Management System

A Windows desktop application that calculates and manages U.S. Army enlisted soldiers' monthly pay: entitlements, deductions, net pay, and mid-month / end-of-month deposits. It is built with C#, .NET 8 and Windows Forms.

I built it as part of the Microsoft Software & Systems Academy (MSSA) Cloud Application Development program. It draws on my four years as an Army Financial Management Technician processing soldier payroll.

## Features

- **Login and logout:** a login screen opens the application. Logging out returns to the login screen and keeps any changes made during the session.
- **Soldier records:** add, update and delete soldiers through a separate management form.
  - Required fields and a unique SSN are validated before a record is saved.
  - Changes are applied only after validation and pay calculation succeed, so Cancel always leaves the original record untouched.
  - Deleting a soldier asks for confirmation.
- **Pay calculation**, based on pay grade, years of service, duty station and dependent status:
  - Basic pay from the 2026 DFAS enlisted pay table (E-2 to E-8, 0–18 years of service).
  - Basic Allowance for Housing (BAH) from cached 2026 rates for 8 duty stations, with a manual rate for other stations.
  - Basic Allowance for Subsistence (BAS), Overseas Housing Allowance (OHA), clothing allowance, Family Separation Allowance (FSA) and special pay.
  - Deductions: federal and state tax, Social Security (6.2%), Medicare (1.45%), life insurance (SGLI) and allotments/debt.
  - Total entitlements, total deductions, net monthly pay, and the mid-month / end-of-month deposit split.
- **Search:** a case-insensitive partial match on name, SSN or rank, with **Show all** to reset.
- **Excel export:** writes every record to a 26-column `.xlsx` workbook using the Open XML SDK, so Excel doesn't need to be installed.
  - Amounts are stored as real numbers, and SSNs as text so leading zeros are kept.
  - The file is written to a temporary location first, so a failed save never corrupts an existing export.
- **Sample data:** 50 fictional soldiers (SSNs 000-00-0001 to 000-00-0050) are loaded at startup.

## Tech stack

| Area | Technology |
|---|---|
| Language | C# |
| Framework | .NET 8 (`net8.0-windows`), Windows Forms |
| Excel export | DocumentFormat.OpenXml 3.5.1 (NuGet) |
| IDE | Visual Studio |

## Project structure

| File | Purpose |
|---|---|
| `Program.cs` | Entry point: seeds the 50 sample soldiers and opens the login form |
| `LoginForm.cs` | Login and logout flow |
| `MainForm.cs` | Read-only viewer with four tabs (Personal Details, Entitlements, Deductions, Pay Summary), search and Excel export |
| `SoldierManagementForm.cs` | Add / update / delete form with validation |
| `Soldier.cs` | Soldier model and pay calculation |
| `PayRates2026.cs` | 2026 basic pay table and BAS rate |
| `BahRates2026.cs` | 2026 BAH rates by duty station, grade and dependent status |
| `ExcelExporter.cs` | Open XML export to `.xlsx` |

## How to run

1. Install Visual Studio 2022 or later with the **.NET desktop development** workload (which includes the .NET 8 SDK).
2. Clone the repository and open `SoldierFinancialManagementSystem.slnx`.
3. Build and run with **F5**. NuGet restores the Open XML package on the first build.
4. Log in with the demo account: username `Soldier`, password `Password`.

**Save Excel** writes the file to `C:\Files\SoldierFinance.xlsx` and creates the folder if it doesn't exist. Close the workbook in Excel before saving again.

## Limitations

This is a learning project, not an official pay tool, and its results are estimates rather than real Leave and Earnings Statement (LES) amounts.

- Rates are cached 2026 tables and are not updated automatically.
- Records live in memory. They reset when the app restarts, and the exported Excel file is not read back in.
- The login uses one hard-coded demo account.
- It doesn't handle officer or E-1/E-9 pay, FICA wage caps, combat-zone exclusions, proration or BAH protection.

## Rate sources

- DFAS basic pay: https://www.dfas.mil/MilitaryMembers/payentitlements/Pay-Tables/Basic-Pay/EM/
- DFAS BAS: https://www.dfas.mil/MilitaryMembers/payentitlements/Pay-Tables/bas/
- DTMO BAH: https://www.travel.dod.mil/Allowances/Basic-Allowance-for-Housing/
