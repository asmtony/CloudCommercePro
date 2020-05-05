using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace CloudCommercePro.Data.JSONData
{
    public class CsvConvert
    {     
        public void CreateCSVFromDataTable(DataTable dataTable, string filePath, string delimiter = ",")
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            DataColumn[] columns = dataTable.Columns.Cast<DataColumn>().ToArray();
            List<string> lines = new List<string>();
            lines.Add(string.Join(delimiter, columns.Select(c => c.ColumnName)));
            lines.AddRange(dataTable.Rows.Cast<DataRow>().Select(row => string.Join(delimiter, columns.Select(c => row[c]))));
            File.WriteAllLines(filePath, lines);
        }
        
    }
}
