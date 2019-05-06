using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using CSVReader.Core;
using DevExpress.XtraGrid.Views.Base;
namespace CSVReader
{
    public partial class frmCSVReader : RibbonForm
    {
        static string ERROR_MESSAGE = "ERROR with : ";
        static string CONFIG_FILE_PATH = "folderquery.json";


        string csvFileName = "";   // current cvs text file


        public frmCSVReader()
        {
            InitializeComponent();

        }

        private void CSVReader_Load(object sender, EventArgs e)
        {

            Init_QTree();
        }

        private void btnOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Do_LoadCSV();
        }


        private void Do_LoadCSV()
        {
            try
            {
                // browser file
                var status = openFileDialog1.ShowDialog(this);
                if (status.ToString() == "OK")
                {
                    var filename = openFileDialog1.FileName;
                    var data = CVSAndDatable.Convert(filename);
                    grdMain.DataSource = data;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ERROR_MESSAGE + ex);
            }
        }

        private void btnSaveQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Do_SaveQuery();
        }

        // save query from current grid state
        private void Do_SaveQuery()
        {
            Query objQuery = new Query();
            /// save visible column first
            var cols = gridView2.Columns.ToList();

            foreach (var item in cols)
            {
                // visible
                objQuery.VisibleColumns.Add(item.FieldName, item.Visible.ToString());
                //ordering
                objQuery.OrderingColumns.Add(item.FieldName, item.SortOrder.ToString());
            }

            var datasource = (List<QueryNode>)navTree.DataSource;
            var count = datasource.Count();
            var name = "";

            using (var frmNameCreator = new frmQueryNodeCreator())
            {
                frmNameCreator.datasource = datasource;
                if (frmNameCreator.ShowDialog() == DialogResult.OK)
                {

                    name = frmNameCreator.QueryName ?? $"Query {count}";
                    var folderNode = frmNameCreator.SelectedNode;

                    var qnode = new QueryNode(count, folderNode.ID, name);
                    qnode.xQuery = objQuery;

                    // add again to navtree
                    datasource.Add(qnode);
                    navTree.DataSource = datasource;
                    navTree.RefreshDataSource();
                    // apply save columns
                    Apply_XQuery(objQuery);

                    // save to file
                    QueryNode.SaveFile(CONFIG_FILE_PATH, datasource);
                }

            }




        }

        // applly select query to current grid
        private void Apply_XQuery(Query objQuery)
        {
            var cols = gridView2.Columns.ToList();
            try
            {

                VisibleAllCols(false);
                foreach (var item in cols)
                {
                    var col = gridView2.Columns[item.FieldName];
                    col.GroupIndex = -1;

                    // visible
                    if(objQuery.VisibleColumns.ContainsKey(item.FieldName))
                    {
                        try
                        {
                            var vCol = objQuery.VisibleColumns[item.FieldName];
                            if (vCol != null) col.Visible = Boolean.Parse(vCol);
                            //ordering
                            var oCol = objQuery.OrderingColumns[item.FieldName];
                            if (oCol != null)
                            {
                                col.SortOrder = (oCol.ToLower() == "descending") ? DevExpress.Data.ColumnSortOrder.Descending : DevExpress.Data.ColumnSortOrder.Ascending;
                            }
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(" Error " + e.Message);
                        }
                       

                    }
                   
                }

                gridView2.BestFitColumns();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error when apply Query to current data \n" + e.StackTrace);
            }

        }


        private void VisibleAllCols(bool v)
        {
            for (int i = 0; i < gridView2.Columns.Count(); i++)
            {
                gridView2.Columns[i].Visible = v;
            }
        }
        private void Init_QTree()
        {
            // navTree.OptionsBehavior.PopulateServiceColumns = true;
            navTree.KeyFieldName = "ID";
            navTree.ParentFieldName = "ParentID";
            navTree.DataSource = QueryNode.LoadData(CONFIG_FILE_PATH);
            navTree.Columns["xQuery"].Visible = false;
        }

        private void navTree_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }



        private void navTree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                var qnode = e.Node;
                if (qnode != null)
                {

                    var objQuery = (Query)qnode["xQuery"];
                    if (objQuery != null) this.Apply_XQuery(objQuery);
                    else
                    {
                        var QueryNode = (int)qnode["ID"];
                        if (QueryNode==0) VisibleAllCols(true); 
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not apply selected query ");

            }



        }

        private void btnFolderCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var datasource = (List<QueryNode>)navTree.DataSource;
            var count = datasource.Count();
            using (var frmRootFolder = new frmRootFolder())
            {

                if (frmRootFolder.ShowDialog() == DialogResult.OK)
                {

                    var name = frmRootFolder.FolderName ?? $"Folder {count}";

                    var qnode = new QueryNode(count, -1, name);
                    qnode.xQuery = null;

                    // add again to navtree
                    datasource.Add(qnode);
                    navTree.DataSource = datasource;
                    navTree.RefreshDataSource();
                }

            }
        }

        private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle % 2 == 1)
                e.Appearance.BackColor = Color.AliceBlue;
        }


        // save data to file
        private void btnSaveData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Do_LoadSaveCSV();
        }

        private void Do_LoadSaveCSV()
        {
            try
            {
                // browser file
                var status = saveFileDialog1.ShowDialog(this);
                if (status.ToString() == "OK")
                {
                    var filename = saveFileDialog1.FileName;
                    var dataview = GetFilteredData(gridView2);
                   
                    var dt = dataview.ToTable();
                    
                    

                    CVSAndDatable.DataTable2CVS(filename, dt); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ERROR_MESSAGE + ex);
            }
        }


        DataView GetFilteredData(ColumnView view)
        {
            if (view == null) return null;
          

            DataTable table = ((DataView)view.DataSource).ToTable();
            // only columns we want
            for (int i = 0; i < view.Columns.Count; i++)     
            {
                var vcol = view.Columns[i];
                var colname = vcol.FieldName;
                var col = table.Columns[colname];
                if (col == null) continue;
                if (vcol.Visible == false) table.Columns.Remove(col);
            }


            DataView filteredDataView = new DataView(table);
            filteredDataView.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(view.ActiveFilterCriteria);
            return filteredDataView;
        }
    }
}
