using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.DataGrid.Helpers;
using System.Reflection;
using System.Windows.Forms.VisualStyles;

namespace SfDataGrid_Demo_4_8
{
    public partial class Form1 : Form
    {
        public OrderInfoCollection collections;
        public Form1()
        {
            InitializeComponent();
            collections = new OrderInfoCollection();  
            sfDataGrid.DataSource = collections.Orders;
            sfDataGrid.QueryRowStyle += OnQueryRowStyle;
            sfDataGrid.DrawCell += OnDrawCell;       
        }

        private void OnDrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (e.DataRow == null || e.DataRow.RowData == null || sfDataGrid.SelectedItems == null || sfDataGrid.SelectedItems.Count < 0 || sfDataGrid.CurrentCell == null)
                return;
            if ((e.DataRow.RowData as OrderInfo).CustomerID == "ALFKI" && sfDataGrid.SelectedItems.OfType<OrderInfo>().Select(item => item.CustomerID).Contains("ALFKI"))
            {           
                var paddedBounds = new Rectangle( e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 2, e.Bounds.Height - 2);
                e.Style.TextColor = Color.Red;
                StringFormat format = new StringFormat();
                DrawingHelper drawingHelper = new DrawingHelper();
                if (e.Column.CellType == "Numeric")
                    e.Style.HorizontalAlignment = HorizontalAlignment.Right;
                var horizontalAlignment = drawingHelper.GetType().GetMethod("ConvertToStringAlignment", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static, Type.DefaultBinder, new Type[] { typeof(HorizontalAlignment) }, new ParameterModifier[] { }).Invoke(drawingHelper, new object[] { e.Style.HorizontalAlignment });
                var verticalAlignment = drawingHelper.GetType().GetMethod("ConvertToStringAlignment", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static, Type.DefaultBinder, new Type[] { typeof(VerticalAlignment) }, new ParameterModifier[] { }).Invoke(drawingHelper, new object[] { e.Style.VerticalAlignment });
                format.Alignment = (StringAlignment)horizontalAlignment;
                format.LineAlignment = (StringAlignment)verticalAlignment;
                if(e.ColumnIndex != sfDataGrid.CurrentCell.ColumnIndex)
                     e.Graphics.FillRectangle(new SolidBrush(sfDataGrid.Style.SelectionStyle.BackColor), e.Bounds);
                e.Graphics.DrawString(e.DisplayText, e.Style.GetFont(), new SolidBrush(e.Style.TextColor), paddedBounds, format);
                e.Graphics.DrawLine(new Pen(e.Style.Borders.Right.Color), e.Bounds.Right - 1, e.Bounds.Top, e.Bounds.Right - 1, e.Bounds.Bottom);
                e.Graphics.DrawLine(new Pen(e.Style.Borders.Bottom.Color), e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
                // For drawn the current cell
                if (e.ColumnIndex == sfDataGrid.CurrentCell.ColumnIndex)
                    e.Column.Renderer.OnDrawCurrentCell(e.Graphics, sfDataGrid, new RowColumnIndex(sfDataGrid.CurrentCell.RowIndex, sfDataGrid.CurrentCell.ColumnIndex));
                // For handling the event
                e.Handled = true;
            }
        }
        private void OnQueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if ((e.RowData as OrderInfo).CustomerID == "ALFKI")
                    e.Style.TextColor = Color.Red;
            }
        }
    }

}
