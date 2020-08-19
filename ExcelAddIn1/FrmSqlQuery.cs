using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ExcelAddIn1
{
    public partial class FrmSqlQuery : Form
    {
        private SQLiteConnection connection;
        public FrmSqlQuery(string sheetName, SQLiteConnection pCon)
        {
            InitializeComponent();

            this.Text = this.Text + " - " + sheetName;
            this.connection = pCon;
            updateTablesLb();
        }

        private void updateTablesLb()
        {
            var cmd = new SQLiteCommand("SELECT name FROM sqlite_master;", connection);
            SQLiteDataReader tables = cmd.ExecuteReader();
            if (tables.HasRows)
            {
                while (tables.Read())
                {
                    lbTables.Items.Add(tables.GetString(0));
                }
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var cmd = new SQLiteCommand(tbQuery.Text, connection);
            try
            {
                SQLiteDataReader result = cmd.ExecuteReader();
                lvResult.Clear();

                for (int i = 0; i < result.FieldCount; i++) //add columns
                {
                    lvResult.Columns.Add(result.GetName(i));
                }

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        List<String> entry = new List<string>();
                        for (int i = 0; i < result.FieldCount; i++) //add columns
                        {
                            entry.Add(result.GetString(i));
                        }
                        ListViewItem lvi = new ListViewItem(entry.ToArray());
                        lvResult.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("error in sql query");
                return;
            }
        }

        private void lbTables_DoubleClick(object sender, EventArgs e)
        {
            if (lbTables.SelectedItems.Count == 1)
            {
                    tbQuery.Text = "SELECT * FROM " + lbTables.Items[lbTables.SelectedIndex].ToString() + ";";
                    btnExecute.PerformClick();
            }
        }
    }
}
