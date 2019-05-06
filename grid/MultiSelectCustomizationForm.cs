using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.Customization;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Customization;

namespace CSVReader.grid
{
    public class MultiSelectCustomizationForm : CustomizationForm
    {

        public MultiSelectCustomizationForm(GridView view)
            : base(view)
        {
           
        }

        protected override CustomizationListBoxBase CreateCustomizationListBox()
        {
            return new MultiSelectColumnCustomizationListBox(this);
        }

        protected override void CreateListBox()
        {
            base.CreateListBox();

            Panel bottomPanel = new Panel();
            bottomPanel.Parent = this;
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Height = 30;
            bottomPanel.SendToBack();

            Button bAddCheckedCols = new Button();
            bAddCheckedCols.Parent = bottomPanel;
            bAddCheckedCols.Dock = DockStyle.Fill;
            bAddCheckedCols.Text = "Add checked columns to grid";

            bAddCheckedCols.Click += new EventHandler(OnButtonAddCheckedColumns_Click);
            // create list of items columns
            Panel topPanel = new Panel();
            topPanel.Parent = this;
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 30;
            topPanel.SendToBack();

            Button btnUnselect = new Button();
            btnUnselect.Parent = bottomPanel;
            btnUnselect.Dock = DockStyle.Left;
            btnUnselect.Text = "Unselect all";

            btnUnselect.Click += new EventHandler(OnButtonUnselectColumns_Click);

            
        }

     

        private void OnButtonAddCheckedColumns_Click(object sender, EventArgs e)
        {
            MultiSelectColumnCustomizationListBox listBox = (MultiSelectColumnCustomizationListBox)ActiveListBox;
          
            for (int i = 0; i < listBox.CheckedItems.Count; i++)
            {
                if (listBox.CheckedItems[i] != null)
                    ((GridColumn)listBox.CheckedItems[i]).Visible = true;

            }
            View.BestFitColumns(true);
      
        }
        private void OnButtonUnselectColumns_Click(object sender, EventArgs e)
        {
            MultiSelectColumnCustomizationListBox listBox = (MultiSelectColumnCustomizationListBox)ActiveListBox;
            
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                ((GridColumn)listBox.Items[i]).Visible = false;

            }
            listBox.UnSelect();
        }
    }
}
