using CSVReader;

namespace CSVReader
{
    partial class frmCSVReader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCSVReader));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.grdMain = new CSVReader.grid.GridControlOverride();
            this.gridView2 = new CSVReader.grid.GridViewOverride();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnOpen = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnFolderCreate = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveData = new DevExpress.XtraBars.BarButtonItem();
            this.ribFile = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navTree = new DevExpress.XtraTreeList.TreeList();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMain
            // 
            this.grdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMain.Location = new System.Drawing.Point(281, 144);
            this.grdMain.MainView = this.gridView2;
            this.grdMain.Name = "grdMain";
            this.grdMain.Size = new System.Drawing.Size(618, 344);
            this.grdMain.TabIndex = 0;
            this.grdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdMain;
            this.gridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView2_RowStyle);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdMain;
            this.gridView1.Name = "gridView1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.btnOpen,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnSaveQuery,
            this.btnFolderCreate,
            this.btnSaveData});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribFile});
            this.ribbonControl1.Size = new System.Drawing.Size(899, 144);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnOpen
            // 
            this.btnOpen.Caption = "Open";
            this.btnOpen.Id = 2;
            this.btnOpen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.ImageOptions.Image")));
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpen_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnSaveQuery
            // 
            this.btnSaveQuery.Caption = "Save Query";
            this.btnSaveQuery.Id = 6;
            this.btnSaveQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveQuery.ImageOptions.Image")));
            this.btnSaveQuery.Name = "btnSaveQuery";
            this.btnSaveQuery.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSaveQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveQuery_ItemClick);
            // 
            // btnFolderCreate
            // 
            this.btnFolderCreate.Caption = "Add Root Folder";
            this.btnFolderCreate.Id = 7;
            this.btnFolderCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFolderCreate.ImageOptions.Image")));
            this.btnFolderCreate.Name = "btnFolderCreate";
            this.btnFolderCreate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnFolderCreate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFolderCreate_ItemClick);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Caption = "Save Data";
            this.btnSaveData.Id = 8;
            this.btnSaveData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveData.ImageOptions.Image")));
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem1.Text = "Save current selected data to file";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnSaveData.SuperTip = superToolTip1;
            this.btnSaveData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveData_ItemClick);
            // 
            // ribFile
            // 
            this.ribFile.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribFile.Name = "ribFile";
            this.ribFile.Text = "General";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOpen);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "File";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnFolderCreate);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSaveQuery);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Folder & Query";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSaveData);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Export";
            // 
            // navTree
            // 
            this.navTree.Cursor = System.Windows.Forms.Cursors.Default;
            this.navTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.navTree.Location = new System.Drawing.Point(0, 144);
            this.navTree.Name = "navTree";
            this.navTree.Size = new System.Drawing.Size(281, 344);
            this.navTree.TabIndex = 2;
            this.navTree.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.navTree_FocusedNodeChanged);
            this.navTree.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.navTree_ShowingEditor);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV  files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(281, 144);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 344);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CSV  files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 488);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.navTree);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "CSV Reader";
            this.Load += new System.EventHandler(this.CSVReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSVReader.grid.GridControlOverride grdMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraTreeList.TreeList navTree;
        private DevExpress.XtraBars.BarButtonItem btnOpen;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribFile;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraBars.BarButtonItem btnSaveQuery;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private CSVReader.grid.GridViewOverride gridView2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarButtonItem btnFolderCreate;
        private DevExpress.XtraBars.BarButtonItem btnSaveData;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
