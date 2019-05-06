using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader.Core
{
    class CVSAndDatable
    {
        public static char Delimiter = ','; // delimiter in csv file

        public static DataTable Convert(string filename)
        {
            DataTable dt = new DataTable();
            using (StreamReader text = new StreamReader(filename))
            {
                var headers = text.ReadLine().Split(CVSAndDatable.Delimiter).ToList();

                headers.ForEach(e =>
                {
                    dt.Columns.Add(e);
                });


                while (!text.EndOfStream)
                {
                    var rowtext = text.ReadLine().Split(CVSAndDatable.Delimiter);
                    DataRow row = dt.NewRow();
                    for (int i = 0; i < headers.Count; i++) row[i] = rowtext[i];

                    dt.Rows.Add(row);
                }

            }


            return dt;
        }

        public static void DataTable2CVS(string filename, DataTable dt)
        {
            var strDelimiter = Delimiter + "";


            var sb = new StringBuilder();
            var headers = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray();
            sb.AppendLine(string.Join(strDelimiter, headers));
            foreach (DataRow item in dt.Rows)
            {
                var values = item.ItemArray.Select(value => value.ToString()).ToArray();
                sb.AppendLine(string.Join(strDelimiter, values));
            }

            File.WriteAllText(filename, sb.ToString());
        }
    }
}
