using System;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAddIn1
{
    public partial class Ribbon
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnConvertToJson_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet currentWorksheet = Globals.AddIn.GetActiveWorksheet();
            TreeNode jsonTree = Globals.AddIn.TablesToTree(Globals.AddIn.GetTables());
            String jsonData = Globals.AddIn.TablesToJson(Globals.AddIn.GetTables());
            FrmTableToJson frmTableToJson = new FrmTableToJson(currentWorksheet.Name, jsonData, jsonTree);
            frmTableToJson.Show();
        }

        private void btnConvertToMarkdown_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet currentWorksheet = Globals.AddIn.GetActiveWorksheet();
            String markdownData = Globals.AddIn.TablesToMarkdown(Globals.AddIn.GetTables());
            FrmTableToMarkdown frmTableToMarkdown = new FrmTableToMarkdown(currentWorksheet.Name, markdownData);
            frmTableToMarkdown.Show();
        }

        private void btnConvertToSQL_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet currentWorksheet = Globals.AddIn.GetActiveWorksheet();
            String sqlData = Globals.AddIn.TablesToSQL(Globals.AddIn.GetTables());
            FrmTableToSQL frmTableToSQL = new FrmTableToSQL(currentWorksheet.Name, sqlData);
            frmTableToSQL.Show();
        }

        private void btnExecuteSQL_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet currentWorksheet = Globals.AddIn.GetActiveWorksheet();
            FrmSqlQuery frmSqlQuery = new FrmSqlQuery(currentWorksheet.Name, Globals.AddIn.GenerateDatabase(Globals.AddIn.TablesToSQL(Globals.AddIn.GetTables())));
            frmSqlQuery.Show();
        }

        private void btnGetFormulas_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet currentWorksheet = Globals.AddIn.GetActiveWorksheet();
            FrmFormulas frmFormulas = new FrmFormulas(currentWorksheet.Name, Globals.AddIn.getFormulas());
            frmFormulas.Show();
        }
    }
}
