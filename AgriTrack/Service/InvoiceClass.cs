using System;
using System.IO;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

public static class SettlementPDFGenerator
{
    public static void GenerateGridReport(string filename, string targetMonth, DataGridView uiGrid)
    {
        
        if (PdfSharp.Fonts.GlobalFontSettings.FontResolver == null)
        {
            PdfSharp.Fonts.GlobalFontSettings.FontResolver = new WindowsFontResolver();
        }

       
        Document document = new Document();
        document.Info.Title = $"AgriTrack Ledger Summary - {targetMonth.Replace("/", "-")}";

       
        MigraDoc.DocumentObjectModel.Color agritrackGreen = MigraDoc.DocumentObjectModel.Color.FromRgb(30, 112, 67);
        MigraDoc.DocumentObjectModel.Color darkGray = MigraDoc.DocumentObjectModel.Color.FromRgb(51, 51, 51);

        
        Style style = document.Styles["Normal"];
        style.Font.Name = "Segoe UI";
        style.Font.Size = 10.5;
        style.Font.Color = darkGray;

        Section section = document.AddSection();
        section.PageSetup.PageFormat = PageFormat.A4;
        section.PageSetup.LeftMargin = "1.5cm";
        section.PageSetup.RightMargin = "1.5cm";

        
        Paragraph brand = section.AddParagraph();
        brand.AddText("AGRITRACK");
        brand.Format.Font.Size = 22;
        brand.Format.Font.Bold = true;
        brand.Format.Font.Color = agritrackGreen;

        Paragraph docTitle = section.AddParagraph();
        docTitle.AddText($"SETTLEMENT SUMMARY REPORT — PERIOD: {targetMonth}");
        docTitle.Format.Font.Size = 11;
        docTitle.Format.Font.Bold = true;
        docTitle.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.Gray;
        docTitle.Format.SpaceAfter = 20;

        
        Table pdfTable = section.AddTable();
        pdfTable.Borders.Width = 0.5;
        pdfTable.Borders.Color = MigraDoc.DocumentObjectModel.Colors.LightGray;

        
        pdfTable.AddColumn("3.0cm");  
        pdfTable.AddColumn("3.5cm");  
        pdfTable.AddColumn("3.5cm");   
        pdfTable.AddColumn("4.0cm");  
        pdfTable.AddColumn("4.0cm");  

        
        Row headerRow = pdfTable.AddRow();
        headerRow.Shading.Color = agritrackGreen;
        headerRow.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.White;
        headerRow.Format.Font.Bold = true;
        headerRow.Height = "0.8cm";
        headerRow.VerticalAlignment = VerticalAlignment.Center; 

        headerRow.Cells[0].AddParagraph(" Worker ID");
        headerRow.Cells[1].AddParagraph(" Total KG").Format.Alignment = ParagraphAlignment.Right;
        headerRow.Cells[2].AddParagraph(" Advance Amount").Format.Alignment = ParagraphAlignment.Right;
        headerRow.Cells[3].AddParagraph(" Net Salary").Format.Alignment = ParagraphAlignment.Right;
        headerRow.Cells[4].AddParagraph(" Status").Format.Alignment = ParagraphAlignment.Center;

        headerRow.Cells[1].Format.RightIndent = "0.2cm";
        headerRow.Cells[2].Format.RightIndent = "0.2cm";
        headerRow.Cells[3].Format.RightIndent = "0.2cm";

        
        int addedRowsCount = 0;
        foreach (DataGridViewRow uiRow in uiGrid.Rows)
        {
            if (uiRow.IsNewRow) continue;

            string cellWorkerId = uiRow.Cells[0].Value?.ToString() ?? "—";
            string cellTotalKg = uiRow.Cells[1].Value?.ToString() ?? "0.00";
            string cellAdvance = uiRow.Cells[2].Value?.ToString() ?? "0.00";
            string cellNetSalary = uiRow.Cells[3].Value?.ToString() ?? "0.00";
            string cellStatus = uiRow.Cells[4].Value?.ToString() ?? "Unknown";

            Row pdfDataRow = pdfTable.AddRow();
            pdfDataRow.Height = "0.75cm";
            pdfDataRow.VerticalAlignment = VerticalAlignment.Center;

            
            if (addedRowsCount % 2 == 1)
            {
                pdfDataRow.Shading.Color = MigraDoc.DocumentObjectModel.Color.FromRgb(248, 249, 250);
            }

            pdfDataRow.Cells[0].AddParagraph(" " + cellWorkerId);

            var pKg = pdfDataRow.Cells[1].AddParagraph(cellTotalKg);
            pKg.Format.Alignment = ParagraphAlignment.Right;
            pKg.Format.RightIndent = "0.2cm";

            var pAdv = pdfDataRow.Cells[2].AddParagraph(cellAdvance);
            pAdv.Format.Alignment = ParagraphAlignment.Right;
            pAdv.Format.RightIndent = "0.2cm";

            var pNet = pdfDataRow.Cells[3].AddParagraph(cellNetSalary);
            pNet.Format.Alignment = ParagraphAlignment.Right;
            pNet.Format.RightIndent = "0.2cm";

            if (cellNetSalary.Contains("-"))
            {
                pNet.Format.Font.Color = MigraDoc.DocumentObjectModel.Color.FromRgb(198, 40, 40);
            }

            var pStat = pdfDataRow.Cells[4].AddParagraph(cellStatus);
            pStat.Format.Alignment = ParagraphAlignment.Center;
            pStat.Format.Font.Bold = true;

            if (cellStatus.ToLower().Trim() == "paid")
                pStat.Format.Font.Color = agritrackGreen;
            else
                pStat.Format.Font.Color = MigraDoc.DocumentObjectModel.Color.FromRgb(198, 40, 40);

            addedRowsCount++;
        }

        
        section.AddParagraph().Format.SpaceAfter = 25;
        Paragraph totalsLine = section.AddParagraph();
        totalsLine.Format.Borders.Top.Width = 1;
        totalsLine.Format.Borders.Top.Color = agritrackGreen;
        totalsLine.Format.SpaceBefore = 10;

        totalsLine.AddText($"Total Processed Ledger Entries: {addedRowsCount} records.");
        totalsLine.Format.Font.Size = 9.5;
        totalsLine.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.SlateGray;

        
        PdfDocumentRenderer renderer = new PdfDocumentRenderer(true) { Document = document };
        renderer.RenderDocument();
        renderer.PdfDocument.Save(filename);
    }
}


public class WindowsFontResolver : PdfSharp.Fonts.IFontResolver
{
    public byte[] GetFont(string faceName)
    {
        string fontFolder = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
        string mainPath = Path.Combine(fontFolder, faceName);

        if (File.Exists(mainPath))
            return File.ReadAllBytes(mainPath);

        
        if (faceName.Contains("cour"))
            return File.ReadAllBytes(Path.Combine(fontFolder, "cour.ttf"));

        return File.ReadAllBytes(Path.Combine(fontFolder, "arial.ttf"));
    }

    public PdfSharp.Fonts.FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
        if (familyName.Equals("Segoe UI", StringComparison.OrdinalIgnoreCase))
        {
            if (isBold) return new PdfSharp.Fonts.FontResolverInfo("segoeuib.ttf");
            return new PdfSharp.Fonts.FontResolverInfo("segoeui.ttf");
        }

        
        return new PdfSharp.Fonts.FontResolverInfo("cour.ttf");
    }
}