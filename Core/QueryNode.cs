using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CSVReader.Core
{

    public class Query
    {
        public Guid id;
        public Dictionary<string, string> VisibleColumns { get; set; }
        public Dictionary<string, string> OrderingColumns { get; set; }
        public Dictionary<string, KeyValuePair<string, string> > FilteringColumns { get; set; }

        public Query()
        {
            this.id = new Guid();
            this.VisibleColumns = new Dictionary<string, string>();
            this.OrderingColumns = new Dictionary<string, string>();
            this.FilteringColumns = new Dictionary<string, KeyValuePair<string, string>>();
        }
        public override string ToString()
        {
            var countlist = new string[] {id.ToString(), VisibleColumns.Count.ToString(), OrderingColumns.Count.ToString(), FilteringColumns.Count.ToString() };
            return string.Join("-",countlist);
        }
    }
    public class QueryNode
    {
        public int ID { get; set; }
        public int ParentID { get; set; }

        public string Name { get; set; }
        public Query xQuery { get; set; }
        public QueryNode(int id, int parentid, string name=null, bool folder = false) 
        {
            this.xQuery = folder==false? new Query(): null;
            this.ID = id;
            this.ParentID = parentid;
            this.Name = name??"default";
        }


        public override string ToString()
        {
            return this.Name;
        }
        // test data
        public static List<QueryNode> LoadData(string filename= null)
        {
            var rs = new List<QueryNode>();
            var isloaded = false;
            // load from file
            try
            {
                using (StreamReader fs = new StreamReader(filename))
                {
                    var json = fs.ReadToEnd();

                    rs = JsonConvert.DeserializeObject<List<QueryNode>>(json);
                    isloaded = true;
                }
            }
            catch (Exception)
            {
             
            }
            // default if has error
            if(isloaded==false)
            {
                // this is
                var names = new string[] { "Root" };
                var id = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    var pid = id++;
                    var pnode = new QueryNode(pid, -1, names[i], true); // root means folders

                    rs.Add(pnode);
                }
            }

            return rs;
        }

        public static void SaveFile(string filename, List<QueryNode> ds) {
            if (ds != null)
            {
                try
                {
                    var json = JsonConvert.SerializeObject(ds);

                    using (StreamWriter fs = new StreamWriter(filename, false))
                    {
                        fs.WriteLine(json);
                    }
                }
                catch (Exception e)
                {

                    throw new Exception("Save file error! " + e.Message);
                }
            }
        }
       
    }
}
