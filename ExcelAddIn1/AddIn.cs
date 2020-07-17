using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SQLite;

namespace ExcelAddIn1
{
    public partial class AddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }
        private bool IsNumeric(string s)
        {
            return int.TryParse(s, out int n);
        }

        public Excel.Worksheet GetActiveWorksheet()
        {
            return (Excel.Worksheet)Application.ActiveSheet;
        }

        public List<Excel.ListObject> GetTables() // get tables of current worksheet
        {
            List<Excel.ListObject> result = new List<Excel.ListObject>();
            Excel.Worksheet current = GetActiveWorksheet();
            foreach (Excel.ListObject tbl in current.ListObjects)
            {
                result.Add(tbl);
            }

            return result;
        }

        public TreeNode TablesToTree(List<Excel.ListObject> tables)
        {
            TreeNode parent = new TreeNode("JSON");
            TreeNode rowNode = new TreeNode();
            int tableCounter = 0;

            foreach (Excel.ListObject table in tables)
            {
                List<string> colNames = new List<string>();
                int dataCounter = 0;
                int rowCounter = 0;

                parent.Nodes.Add(table.Name, "[" + tableCounter.ToString() + "] - " + table.Name);
                foreach (Excel.Range cell in table.HeaderRowRange.Cells) colNames.Add(cell.Text);

                foreach (Excel.Range cell in table.DataBodyRange.Cells)
                {
                    if (dataCounter == colNames.Count)
                    {
                        dataCounter = 0;
                        rowCounter++;
                        parent.Nodes[table.Name].Nodes.Add(rowNode);
                    }

                    if (dataCounter == 0) rowNode = new TreeNode("[" + rowCounter.ToString() + "]");

                    string nodeCellData = IsNumeric(cell.Text) ? cell.Text : "\"" + cell.Text + "\"";
                    rowNode.Nodes.Add("\"" + colNames[dataCounter] + "\":" + nodeCellData);
                    dataCounter++;
                }

                parent.Nodes[table.Name].Nodes.Add(rowNode);
                tableCounter++;
            }

            return parent;
        }

        public string TablesToJson(List<Excel.ListObject> tables)
        {
            string jsonData = "";
            foreach (Excel.ListObject table in tables)
            {
                jsonData += "[" + Environment.NewLine + "  {";
                List<string> colNames = new List<string>();
                int dataCounter = 0;

                foreach (Excel.Range cell in table.HeaderRowRange.Cells) colNames.Add(cell.Text);

                foreach (Excel.Range cell in table.DataBodyRange.Cells)
                {
                    string nodeCellData = IsNumeric(cell.Text) ? cell.Text : "\"" + cell.Text + "\"";
                    string newEntry = "\"" + colNames[dataCounter] + "\"" + ":" + nodeCellData;
                    jsonData += Environment.NewLine + "    " + newEntry;
                    dataCounter++;
                    if (dataCounter == colNames.Count)
                    {
                        dataCounter = 0;
                        jsonData += Environment.NewLine + "  }," + Environment.NewLine + "  {";
                    }
                    else jsonData += ",";
                }

                jsonData = jsonData.Remove(jsonData.Length - 8) + "  }" + Environment.NewLine + "]";
            }

            if (tables.Count > 1)
            {
                string[] jsonLines = jsonData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                jsonData = "";

                foreach (string line in jsonLines) jsonData += "  " + line + Environment.NewLine;

                jsonData = "[" + Environment.NewLine + jsonData + "]";
                jsonData = jsonData.Replace("][", "]," + Environment.NewLine + "  [");
            }

            return jsonData;
        }


        public string TablesToMarkdown(List<Excel.ListObject> tables)
        {
            string markdownData = "";
            foreach (Excel.ListObject table in tables)
            {
                string cellData;
                int dataCounter = 0, headerCounter = 0;
                List<int> letterCounter = new List<int>();
                foreach (Excel.Range cell in table.HeaderRowRange.Cells)
                {
                    cellData = cell.Text;
                    letterCounter.Add(cellData.Length);
                    headerCounter++;
                }

                foreach (Excel.Range cell in table.DataBodyRange.Cells)
                {
                    cellData = cell.Text;
                    if (letterCounter.Count > dataCounter)
                    {
                        if (letterCounter[dataCounter] < cellData.Length) letterCounter[dataCounter] = cellData.Length;
                    }
                    else
                    {
                        letterCounter.Add(cellData.Length);
                    }

                    dataCounter++;
                    if (dataCounter == headerCounter)
                        dataCounter = 0;
                }

                markdownData += "# " + table.Name + Environment.NewLine + "|";
                foreach (Excel.Range cell in table.HeaderRowRange.Cells)
                {
                    string title = cell.Text;
                    markdownData += title;
                    int spaceNb = letterCounter[dataCounter] - title.Length;
                    for (int i = 0; i < spaceNb; i++) markdownData += " ";
                    markdownData += "|";
                    dataCounter++;
                }

                markdownData += Environment.NewLine + "|";
                foreach (int nbLettersInTitle in letterCounter)
                {
                    for (int i = 0; i < nbLettersInTitle; i++) { markdownData += "-"; }
                    markdownData += "|";
                }

                markdownData += Environment.NewLine;
                dataCounter = 0;
                foreach (Excel.Range cell in table.DataBodyRange.Cells)
                {
                    cellData = cell.Text;
                    markdownData += "|" + cellData;
                    int spaceNb = letterCounter[dataCounter] - cellData.Length;
                    for (int i = 0; i < spaceNb; i++) markdownData += " ";
                    dataCounter++;
                    if (dataCounter == headerCounter)
                    {
                        dataCounter = 0;
                        markdownData += "|" + Environment.NewLine;
                    }
                }

                markdownData += Environment.NewLine;
            }

            return markdownData;
        }

        public string TablesToSQL(List<Excel.ListObject> tables)
        {
            string CREATE = "";
            string INSERT = "";
            foreach (Excel.ListObject table in tables)
            {
                List<string> colNames = new List<string>();
                int dataCounter = 0;
                string tableName = table.Name.Replace(" ", "_");
                CREATE += "CREATE TABLE " + tableName + Environment.NewLine + "(";
                INSERT += "INSERT INTO " + tableName + " (";
                foreach (Excel.Range cell in table.HeaderRowRange.Cells)
                {
                    string columnName = cell.Text;
                    columnName = columnName.Replace(" ", "_");
                    colNames.Add(columnName);
                    CREATE += Environment.NewLine + columnName + " varchar(300),";
                    INSERT += columnName + ",";
                }

                CREATE = CREATE.Remove(CREATE.Length - 1); //remove last ","
                INSERT = INSERT.Remove(INSERT.Length - 1); //remove last ","
                CREATE += Environment.NewLine + ");" + Environment.NewLine;
                INSERT += ")" + Environment.NewLine + "VALUES" + Environment.NewLine;
                foreach (Excel.Range cell in table.DataBodyRange.Cells)
                {
                    if (dataCounter == 0) INSERT += "(";
                    INSERT += "'" + cell.Text + "'";
                    dataCounter++;

                    if (dataCounter == colNames.Count)
                    {
                        dataCounter = 0;
                        INSERT += ")," + Environment.NewLine;
                    }
                    else INSERT += ",";
                }
                INSERT = INSERT.Remove(INSERT.Length - 3);
                INSERT += ";" + Environment.NewLine + Environment.NewLine;
            }
            return CREATE + INSERT;
        }

        public SQLiteConnection GenerateDatabase(string pCreateInsert)
        {
            var con = new SQLiteConnection("Data Source=:memory:");
            con.Open();
            var cmd = new SQLiteCommand(pCreateInsert, con);
            cmd.ExecuteNonQuery();
            return con;
        }

        public Dictionary<string, string> getFormulas()
        {
            Dictionary<string, string> formulas = new Dictionary<string, string>();
            Excel.Worksheet current = GetActiveWorksheet();
            try
            {
                Excel.Range data = current.Cells.SpecialCells(Excel.XlCellType.xlCellTypeFormulas, Type.Missing);
                //Excel.Range cell;
                foreach (Excel.Range formula in data)
                {
                    formulas.Add(formula.Address, formula.Formula);
                }
            }
            catch { }

            return formulas;
        }

        #region Code généré par VSTO

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
