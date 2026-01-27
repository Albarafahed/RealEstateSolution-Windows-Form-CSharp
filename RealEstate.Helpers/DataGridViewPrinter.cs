using RealEstate.Helpers;
using System;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace RealEstate.Helpers
{
    public  class DataGridViewPrinter
    {
 
            private static int _currentRow = 0;

            public static void PrintDataGridView(
                PrintPageEventArgs e,
                DataGridView dgv,
                string title,
                Color? rowColor1 = null,
                Color? rowColor2 = null
            )
            {

            Color evenRowColor = rowColor1 ?? Color.FromArgb(240, 240, 240);
            Color oddRowColor = rowColor2 ?? Color.FromArgb(230, 240, 255);

            using Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            using Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            using Font rowFont = new Font("Arial", 10);
            using Pen gridPen = new Pen(Color.Black, 1);

            int margin = 40;
            int startY = (_currentRow == 0) ? 80 : e.MarginBounds.Top;
            int rowHeight = 30;

            int pageWidth = e.MarginBounds.Width;

            // الأعمدة الظاهرة فقط
            var visibleColumns = dgv.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .ToList();

            // الدالة لتحديد عرض كل عمود
            int GetColumnWidth(string colName)
            {
                return colName switch
                {
                    "FullName" => 70,   // اسم العميل
                    "Location" => 70,//موقع العقار
                    "PropertyType" => 40,
                    "ContractType" => 40,
                    "Status" => 40,

                    _ => (pageWidth - 60 * 5) / (visibleColumns.Count - 5)  // باقي الأعمدة موزعة
                };
            }

            // عرض العمود للترقيم #
            int numberColWidth = 20;

            // رسم عنوان التقرير مرة واحدة
            if (_currentRow == 0)
            {
                e.Graphics.DrawString(
                    title,
                    titleFont,
                    Brushes.Black,
                    e.PageBounds.Width / 2 - 150,
                    30
                );
            }

            int startX = e.MarginBounds.Right;

            // رسم رؤوس الأعمدة (ترقيم + باقي الأعمدة)
            startX -= numberColWidth;
            e.Graphics.DrawRectangle(gridPen, startX, startY, numberColWidth, rowHeight);
            e.Graphics.DrawString(
                "#",
                headerFont,
                Brushes.Black,
                new RectangleF(startX, startY, numberColWidth, rowHeight),
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
            );

            foreach (var col in visibleColumns)
            {
                int currentColWidth = GetColumnWidth(col.Name);
                startX -= currentColWidth;

                e.Graphics.DrawRectangle(gridPen, startX, startY, currentColWidth, rowHeight);
                e.Graphics.DrawString(
                    col.HeaderText,
                    headerFont,
                    Brushes.Black,
                    new RectangleF(startX, startY, currentColWidth, rowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                );
            }

            startY += rowHeight;

            // رسم الصفوف
            while (_currentRow < dgv.Rows.Count)
            {
                if (startY + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                var row = dgv.Rows[_currentRow];
                Brush rowBrush = (_currentRow % 2 == 0) ? new SolidBrush(evenRowColor) : new SolidBrush(oddRowColor);

                // حساب ارتفاع الصف حسب أطول نص
                int dynamicRowHeight = rowHeight;
                startX = e.MarginBounds.Right;

                foreach (var col in visibleColumns)
                {
                    int currentColWidth = GetColumnWidth(col.Name);
                    string txt = row.Cells[col.Name].Value?.ToString() ?? "";

                    // لو التاريخ، نأخذ التاريخ فقط
                    if (row.Cells[col.Name].Value is DateTime dt)
                        txt = dt.ToString("yyyy-MM-dd");

                    SizeF size = e.Graphics.MeasureString(txt, rowFont, currentColWidth);
                    int neededHeight = (int)Math.Ceiling(size.Height) + 14;
                    if (neededHeight > dynamicRowHeight) dynamicRowHeight = neededHeight;
                }

                // خلفية الصف
                e.Graphics.FillRectangle(rowBrush, e.MarginBounds.Left, startY, pageWidth, dynamicRowHeight);

                // عمود الترقيم #
                startX -= numberColWidth;
                e.Graphics.DrawRectangle(gridPen, startX, startY, numberColWidth, dynamicRowHeight);
                e.Graphics.DrawString(
                    (_currentRow + 1).ToString(),
                    rowFont,
                    Brushes.Black,
                    new RectangleF(startX, startY, numberColWidth, dynamicRowHeight),
                    new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                );

                // باقي الأعمدة
                foreach (var col in visibleColumns)
                {
                    int currentColWidth = GetColumnWidth(col.Name);
                    startX -= currentColWidth;

                    string value = row.Cells[col.Name].Value?.ToString() ?? "";
                    if (row.Cells[col.Name].Value is DateTime dt)
                        value = dt.ToString("yyyy-MM-dd");

                    e.Graphics.DrawRectangle(gridPen, startX, startY, currentColWidth, dynamicRowHeight);

                    e.Graphics.DrawString(
                        value,
                        rowFont,
                        Brushes.Black,
                        new RectangleF(startX + 2, startY + 2, currentColWidth - 4, dynamicRowHeight - 4),
                        new StringFormat
                        {
                            Alignment = StringAlignment.Near,
                            LineAlignment = StringAlignment.Near,
                            FormatFlags = StringFormatFlags.LineLimit
                        }
                    );
                }

                startY += dynamicRowHeight;
                _currentRow++;
            }

            _currentRow = 0;
            e.HasMorePages = false;


        }



    }
    

}

