namespace SfDataGrid_Demo_4_8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.Location = new System.Drawing.Point(63, 48);
            this.sfDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sfDataGrid.Name = "sfDataGrid1";
            this.sfDataGrid.PreviewRowHeight = 35;
            this.sfDataGrid.Size = new System.Drawing.Size(911, 441);
            this.sfDataGrid.TabIndex = 0;
            this.sfDataGrid.Text = "sfDataGrid1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 596);
            this.Controls.Add(this.sfDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "SelectionDemo";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid;
    }
}

