
using System.Globalization;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
namespace SoldierFinanceSample;


public static class ExcelExporter
{
    // Receive the entire soldier list and the destination file path.
    public static void Save(List<Soldier> soldiers, string path)
    {
        // These headings form row 1. Each data row must follow this exact order.
        string[] headers = {
            "SSN", "First Name", "Middle", "Last Name", "Rank", "Dependents", "Unit", "Years of Service", "Duty Station",
            "Base Salary", "Basic Allowance for Housing (BAH)", "Basic Allowance for Subsistence (BAS)",
            "Overseas Housing Allowance (OHA)", "Clothing Allowance", "Family Separation Allowance (FSA)", "Special Pay",
            "Federal Income Tax Withheld", "State Income Tax Withheld", "FICA/Medicare Taxes",
            "Servicemembers' Group Life Insurance", "Allotments/Debt Collections",
            "Total Entitlements", "Total Deductions", "Monthly Salary (estimated)", "Mid Month Deposit", "End of Month Deposit"
        };

        // SheetData holds all rows that will appear in the worksheet.
        SheetData data = new SheetData();
        // Write the headings first; string[] can also be used as an object[] here.
        AddRow(data, headers);
        // Loop through every soldier, not just the soldier currently selected.
        foreach (Soldier s in soldiers)
        {
            // object[] holds both text and decimal numbers in one row.
            // Use amounts directly: decimal zero will be written as numeric 0 in Excel.
            
            string dependents;

            if (s.WithDependents)
                {
                    dependents = "Yes";
                }
            else
                {
                    dependents = "No";
                }
            object[] values = new object[]
                {
                    s.Id,
                    s.FirstName,
                    s.MiddleName,
                    s.LastName,
                    s.Rank,
                    dependents,
                    s.Unit,
                    s.YearsOfService,
                    s.DutyStation,
                    s.BasicPay,
                    s.BAH,
                    s.BAS,
                    s.OHA,
                    s.Clothing,
                    s.FSA,
                    s.SpecialPay,
                    s.FederalTax,
                    s.StateTax,
                    s.FicaMedicare,
                    s.Insurance,
                    s.AllotmentsDebt,
                    s.TotalEntitlements,
                    s.TotalDeductions,
                    s.NetPay,
                    s.MidMonthPay,
                    s.EndMonthPay
                };
        AddRow(data, values);
        }
        // Create a unique temporary filename. Guid.NewGuid avoids filename collisions.
        // Build the new workbook before replacing an existing export.
        string temporary = path + "." + Guid.NewGuid() + ".tmp";
        // try runs the save operation; finally below runs even if saving fails.
        try
        {
            // using closes the workbook and releases its file handle when the block ends.
            using (SpreadsheetDocument file = SpreadsheetDocument.Create(
                temporary, SpreadsheetDocumentType.Workbook))
            {
                // Create the workbook container, then create its one worksheet.
                WorkbookPart book = file.AddWorkbookPart();
                book.Workbook = new Workbook();
                WorksheetPart sheet = book.AddNewPart<WorksheetPart>();
                // Give columns A through Z a width of 22 and attach the prepared rows.
                sheet.Worksheet = new Worksheet(new Columns(new Column {
                    Min = 1, Max = 26, Width = 22, CustomWidth = true }), data);
                // Register the worksheet with its name, ID and relationship to the workbook.
                book.Workbook.Append(new Sheets(new Sheet {
                    Id = book.GetIdOfPart(sheet), SheetId = 1, Name = "Soldier Finance" }));
                // Save both parts before the using block closes the Excel file.
                sheet.Worksheet.Save();
                book.Workbook.Save();
            }
            // Replace the destination with the completed workbook; true allows overwriting.
            File.Move(temporary, path, true);
        }
        // Remove a leftover temporary file if something went wrong during saving.
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
    // Private helper: turn an array of values into one Excel row.
    static void AddRow(SheetData data, object[] values)
    {
        // Start an empty row; the foreach below adds one cell for each value.
        Row row = new Row();
        foreach (object value in values)
        {
            Cell cell = new Cell();
            // Check the value type. If it is decimal, name that numeric value number.
            if (value is decimal number)
            {
                // Store amounts as real numbers, including 0, so Excel can calculate with them.
                cell.DataType = CellValues.Number;
                // InvariantCulture uses a decimal point regardless of Windows region settings.
                cell.CellValue = new CellValue(number.ToString(CultureInfo.InvariantCulture));
            }
            // Other values are text. InlineString stores text directly in the cell.
            // This preserves demo SSN leading zeros and prevents text becoming a formula.
            else
            {
                cell.DataType = CellValues.InlineString;
                // ToString converts the value to text; ! tells C# that this result is not null.
                // Preserve keeps leading/trailing spaces when a text value has them.
                cell.InlineString = new InlineString(new Text(value.ToString()!) {
                    Space = SpaceProcessingModeValues.Preserve });
            }
            row.Append(cell); // Add the cell in the same order as its column heading.
        }
        // Attach the completed row to the worksheet data.
        data.Append(row);
    }
}
