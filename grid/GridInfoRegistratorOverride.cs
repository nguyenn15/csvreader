using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
namespace CSVReader.grid
{
    public class GridInfoRegistratorOverride : GridInfoRegistrator
    {
        public override BaseView CreateView(GridControl grid)
        {
            return new GridViewOverride(grid as GridControl);
        }

        public override string ViewName
        {
            get
            {
                return "GridViewOverride";
            }
        }
    }
}
