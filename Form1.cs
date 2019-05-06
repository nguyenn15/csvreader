using System;
using System.Windows.Forms;
using System.Data;
using CSVReader.grid;

namespace MultiSelectColumnCustomization
{
    public partial class Form1 : Form
    {
        private GridControlOverride gridControl1;
        private GridViewOverride gridView1;

        public Form1()
        {
            InitializeComponent();
        }

  

        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Vendor", typeof(string));
            tbl.Columns.Add("Model", typeof(string));
            tbl.Columns.Add("ProductNumber", typeof(int));


            for (int i = 0; i < RowCount; i++)
            {
                int rnd = new Random(i).Next(1, 4);
                tbl.Rows.Add(new object[] { i, String.Format("Vendor {0}", rnd), String.Format("Model {0}", i), i * new Random().Next(1, 10000) });
            }

            return tbl;
        }

        private void InitializeComponent()
        {
            this.gridControl1 = new CSVReader.grid.GridControlOverride();
            this.gridView1 = new GridViewOverride();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(481, 363);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(481, 363);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            gridControl1.DataSource = CreateTable(30);
        }
    }
}