using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Customization;
using System.Drawing;

namespace CSVReader.grid
{
    public class GridViewOverride : GridView
    {
        public GridViewOverride(GridControl ownerGrid)
            : base(ownerGrid)
        {
        }
        public GridViewOverride()
        {
        }

        protected override CustomizationForm CreateCustomizationForm()
        {
            return new MultiSelectCustomizationForm(this);
        }

        protected override string ViewName
        {
            get
            {
                return "GridViewOverride";
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
