using TXTextControl;
using System.Text.RegularExpressions;

public static class TableExtender
{
    public static void ConvertCellsToMergeFields(this Table table, TextControl textControl, int referenceColumn, int referenceRow, int fromRow, int toRow)
    {
        static string CleanString(string input)
        {
            // Directly remove unwanted characters and replace spaces
            return Regex.Replace(input.Replace(" ", "_"), "[^a-zA-Z0-9_]", "");
        }

        // Validate the input table and bounds
        if (table == null || fromRow > toRow || fromRow < 1 || toRow > table.Rows.Count)
            return;

        int colCount = table.Columns.Count;

        for (int row = fromRow; row <= toRow; row++)
        {
            for (int col = 1; col <= colCount; col++)
            {
                // Skip reference row/column
                if (col == referenceColumn || row == referenceRow)
                    continue;

                var cell = table.Cells[row, col];
                var referenceCellVertical = table.Cells[row, referenceColumn];
                var referenceCellHorizontal = table.Cells[referenceRow, col];

                // Combine and clean reference text
                string referenceCellText = CleanString(referenceCellVertical.Text + "_" + referenceCellHorizontal.Text);

                // Create and configure the merge field
                var mergeField = new TXTextControl.DocumentServer.Fields.MergeField
                {
                    Name = referenceCellText,
                    Text = cell.Text,
                };

                mergeField.ApplicationField.HighlightColor = System.Drawing.Color.FromArgb(0, 255, 255, 0);
                mergeField.ApplicationField.HighlightMode = HighlightMode.Always;

                // Clear cell text and insert the merge field
                cell.Text = string.Empty;
                textControl.InputPosition = new InputPosition(cell.Start - 1);
                textControl.ApplicationFields.Add(mergeField.ApplicationField);
            }
        }
    }

    public static void AdaptSize(this Table table, TextControl textControl, bool landscapeIfNecessary = true)
    {
        if (table == null)
            return;

        textControl.PageUnit = MeasuringUnit.Twips;
        Section section = textControl.Sections.GetItem();

        // Calculate margins and available page width
        int CalculateAvailablePageWidth(Section sec)
        {
            var margins = sec.Format.PageMargins.Left + sec.Format.PageMargins.Right;
            return (int)(sec.Format.PageSize.Width - margins);
        }

        var availablePageWidth = CalculateAvailablePageWidth(section);

        // Calculate maximum table width based on the last column
        var lastColumn = table.Columns[table.Columns.Count];
        var maxTableWidth = lastColumn.Position + lastColumn.Width;

        // Switch to landscape if necessary
        if (landscapeIfNecessary && maxTableWidth > availablePageWidth)
        {
            section.Format.Landscape = true;
            section = textControl.Sections.GetItem();
            availablePageWidth = CalculateAvailablePageWidth(section);
            maxTableWidth = lastColumn.Position + lastColumn.Width;
        }

        int rowCount = table.Rows.Count;
        int colCount = table.Columns.Count;

        // Adjust the width of each cell
        for (int row = 1; row <= rowCount; row++)
        {
            int totalRowWidth = 0;

            // Calculate the total width of the row
            for (int col = 1; col <= colCount; col++)
            {
                totalRowWidth += table.Cells[row, col].Width;
            }

            // Calculate the difference between row width and available page width
            int widthDifference = totalRowWidth - availablePageWidth;

            // Adjust cell widths proportionally to fit within the available page width
            for (int col = 1; col <= colCount; col++)
            {
                var cell = table.Cells[row, col];
                float ratio = (float)cell.Width / totalRowWidth;
                cell.Width -= (int)(widthDifference * ratio);
            }
        }
    }

}