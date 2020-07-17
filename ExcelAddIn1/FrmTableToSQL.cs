using System;
using System.Windows.Forms;

namespace ExcelAddIn1
{
    public partial class FrmTableToSQL : Form
    {
        public FrmTableToSQL(string sheetName, string sqlData)
        {
            InitializeComponent();
            this.Text = this.Text + " - " + sheetName;
            this.tbSQL.AppendText(sqlData);
        }

        private void btnToclipboard_Click(object sender, EventArgs e)
        {
            if (tbSQL.Text.Length > 0) Clipboard.SetText(this.tbSQL.Text);
        }
    }
}
