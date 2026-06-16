using System;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

public static class SettlementPDFGenerator
{
    public static void GenerateReceipt(string filename, string month, string workerId, string name, string kg, string advance, string gross, string net, string status)
    {
       
        Document document = new Document();
        document.Info.Title = $"AgriTrack Settlement - {workerId}";


       
        MigraDoc.DocumentObjectModel.Color agritrackGreen = MigraDoc.DocumentObjectModel.Color.FromRgb(30, 112, 67);
        MigraDoc.DocumentObjectModel.Color darkGray = MigraDoc.DocumentObjectModel.Color.FromRgb(51, 51, 51);

        
        Style style = document.Styles["Normal"];
        style.Font.Name = "Segoe UI";
        style.Font.Size = 11;
        style.Font.Color = darkGray;

       
        Section section = document.AddSection();
        section.PageSetup.PageFormat = PageFormat.A4;
        section.PageSetup.LeftMargin = "2cm";
        section.PageSetup.RightMargin = "2cm";

       
        Paragraph brand = section.AddParagraph();
        brand.AddText("AGRITRACK");
        brand.Format.Font.Size = 20;
        brand.Format.Font.Bold = true;
        brand.Format.Font.Color = agritrackGreen;
        brand.Format.SpaceAfter = 2;

        Paragraph title = section.AddParagraph();
        title.AddText("WORKER SETTLEMENT STATEMENT");
        title.Format.Font.Size = 13;
        title.Format.Font.Bold = true;
        title.Format.Font.Color = Colors.Gray;
        title.Format.SpaceAfter = 20;

        
        Table metaTable = section.AddTable();
        metaTable.AddColumn("9cm");
        metaTable.AddColumn("7cm");
        Row metaRow = metaTable.AddRow();

        Paragraph workerInfo = metaRow.Cells[0].AddParagraph();
        workerInfo.AddFormattedText("WORKER DETAILS:\n", TextFormat.Bold);
        workerInfo.AddText($"Worker ID: {workerId}\n");
        workerInfo.AddText($"Name: {name}");
        workerInfo.Format.LineSpacing = 1.3;

        Paragraph sheetInfo = metaRow.Cells[1].AddParagraph();
        sheetInfo.Format.Alignment = ParagraphAlignment.Right;
        sheetInfo.AddFormattedText("STATEMENT PERIOD:\n", TextFormat.Bold);
        sheetInfo.AddText($"Month: {month}\n");
        sheetInfo.AddText($"Issued Date: {DateTime.Now.ToString("yyyy-MM-dd")}");
        sheetInfo.Format.LineSpacing = 1.3;

        section.AddParagraph().Format.SpaceAfter = 30; 

        
        Table table = section.AddTable();
        table.Borders.Width = 0.5;
        table.Borders.Color = Colors.LightGray;
        table.AddColumn("11cm"); 
        table.AddColumn("5cm");  

       
        Row headerRow = table.AddRow();
        headerRow.Shading.Color = agritrackGreen;
        headerRow.Format.Font.Color = Colors.White;
        headerRow.Format.Font.Bold = true;
        headerRow.HeadingFormat = true;
        headerRow.Height = "0.7cm";
        headerRow.VerticalAlignment = VerticalAlignment.Center;

        headerRow.Cells[0].AddParagraph(" Description");
        var h2 = headerRow.Cells[1].AddParagraph("Amount / Metrics");
        h2.Format.Alignment = ParagraphAlignment.Right;
        h2.Format.RightIndent = "0.2cm";

        
        AddDataRow(table, "Total Harvest Weight", $"{kg} KG");
        AddDataRow(table, "Gross Salary Earnings", gross);
        AddDataRow(table, "Less: Cash Advance Issued", $"- {advance}");

        
        Row netRow = table.AddRow();
        netRow.Shading.Color = Colors.WhiteSmoke;
        netRow.Height = "0.8cm";
        netRow.VerticalAlignment = VerticalAlignment.Center;

        var n1 = netRow.Cells[0].AddParagraph(" Net Pay Amount");
        n1.Format.Font.Bold = true;
        var n2 = netRow.Cells[1].AddParagraph(net);
        n2.Format.Font.Bold = true;
        n2.Format.Alignment = ParagraphAlignment.Right;
        n2.Format.RightIndent = "0.2cm";

       
        Row statusRow = table.AddRow();
        statusRow.Height = "0.7cm";
        statusRow.VerticalAlignment = VerticalAlignment.Center;
        statusRow.Cells[0].AddParagraph(" Settlement Status");

        var statusCell = statusRow.Cells[1].AddParagraph(status.ToUpper());
        statusCell.Format.Alignment = ParagraphAlignment.Right;
        statusCell.Format.RightIndent = "0.2cm";
        statusCell.Format.Font.Bold = true;
       
        if (status.ToLower().Contains("paid")) statusCell.Format.Font.Color = agritrackGreen;

        
        section.AddParagraph().Format.SpaceAfter = 50;

        Table sigTable = section.AddTable();
        sigTable.AddColumn("6cm");
        sigTable.AddColumn("4cm"); 
        sigTable.AddColumn("6cm");
        Row sigRow = sigTable.AddRow();

        var sig1 = sigRow.Cells[0].AddParagraph("_____________________\nAuthorized Signature");
        sig1.Format.Alignment = ParagraphAlignment.Center;

        var sig2 = sigRow.Cells[2].AddParagraph("_____________________\nWorker Signature");
        sig2.Format.Alignment = ParagraphAlignment.Center;

        
        PdfDocumentRenderer renderer = new PdfDocumentRenderer(true) { Document = document };
        renderer.RenderDocument();
        renderer.PdfDocument.Save(filename);
    }

    private static void AddDataRow(Table table, string label, string value)
    {
        Row row = table.AddRow();
        row.Height = "0.7cm";
        row.VerticalAlignment = VerticalAlignment.Center;

        row.Cells[0].AddParagraph(" " + label);
        var c2 = row.Cells[1].AddParagraph(value);
        c2.Format.Alignment = ParagraphAlignment.Right;
        c2.Format.RightIndent = "0.2cm";
    }
}