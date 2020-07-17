using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExcelAddIn1
{
    public partial class FrmFormulas : Form
    {
        public FrmFormulas(string sheetName, Dictionary<string,string> pFormulas)
        {
            InitializeComponent();

            this.Text = this.Text + " - " + sheetName;

            foreach (KeyValuePair<string, string> formula in pFormulas)
            {
                string[] row = { formula.Key, formula.Value };
                ListViewItem lvi = new ListViewItem(row);
                lvFormulas.Items.Add(lvi);
            }
        }
    }
}
