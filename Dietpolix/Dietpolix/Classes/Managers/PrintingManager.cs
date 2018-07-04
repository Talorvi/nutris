using System.Collections.Generic;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System;
using System.Drawing;

namespace Dietpolix.Classes.Managers
{
    public class PrintingManager
    {
        public PrintingManager()
        {

        } 
        public void CreatePDF(List<Diet> diets, string datefrom, string dateto)
        {
            PdfDocument doc = new PdfDocument();

            PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
            PdfMargins margin = new PdfMargins();
            margin.Top = unitCvtr.ConvertUnits(2.54f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            margin.Bottom = margin.Top;
            margin.Left = unitCvtr.ConvertUnits(3.17f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            margin.Right = margin.Left;

            PdfPageBase page = doc.Pages.Add(PdfPageSize.A4, margin);
            float y = 10;

            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);
            page.Canvas.DrawString(String.Format("Diet from {0} to {1}", datefrom, dateto), font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);
            y = y + font1.MeasureString(String.Format("Diet from {0} to {1}", datefrom, dateto), format1).Height;
            y = y + 5;

            List<string> arrayofstrings = new List<string>();
            arrayofstrings.Add("Product Name;Quantity;Date");
            foreach(var diet in diets)
            {
                arrayofstrings.Add(String.Format("{0};{1};{2}", diet.product_name, diet.quantity, diet.date));
            }

            String[] data = arrayofstrings.ToArray();

            String[][] dataSource
                = new String[data.Length][];
            for (int i = 0; i < data.Length; i++)
            {
                dataSource[i] = data[i].Split(';');
            }

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.HeaderSource = PdfHeaderSource.Rows;
            table.Style.HeaderRowCount = 1;
            table.Style.ShowHeader = true;
            table.DataSource = dataSource;
            PdfLayoutResult result = table.Draw(page, new PointF(0, y));
            y = y + result.Bounds.Height + 5;
            PdfBrush brush2 = PdfBrushes.Gray;
            PdfTrueTypeFont font2 = new PdfTrueTypeFont(new Font("Arial", 9f));
            page.Canvas.DrawString(String.Format("* {0} countries in the list.", data.Length - 1), font2, brush2, 5, y);

            doc.SaveToFile(String.Format("Diet from {0} to {1}.pdf", datefrom, dateto));
            doc.Close();
            System.Diagnostics.Process.Start(String.Format("Diet from {0} to {1}.pdf", datefrom, dateto));
        }
    }
}
