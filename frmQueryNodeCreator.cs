using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVReader.Core;

namespace CSVReader
{
    public partial class frmQueryNodeCreator : Form
    {
        public List<QueryNode> datasource { get; set;}
        public string QueryName { get; set; }
        public QueryNode SelectedNode { get; set; }

        public frmQueryNodeCreator()
        {
            InitializeComponent();

            datasource = datasource ?? new List<QueryNode>();
            QueryName = "";
        }

        private void frmNodeCreator_Load(object sender, EventArgs e)
        {
            // filter only folder node
            var folders = datasource.Where(k => k.xQuery == null).ToList();
            if (folders != null)
            {
                cmbFolder.Properties.Items.AddRange(folders);

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.QueryName = txtName.Text;
            this.SelectedNode = (QueryNode)cmbFolder.SelectedItem;
        }
    }
}
