using System;
using System.Windows.Forms;

namespace ExcelAddIn1
{
    public partial class FrmTableToMarkdown : Form
    {
        public FrmTableToMarkdown(String sheetName, string markdownData)
        {
            InitializeComponent();
            this.Text = this.Text + " - " + sheetName;
             this.tbMarkdown.AppendText(markdownData);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbMarkdown.Text.Length>0) Clipboard.SetText(this.tbMarkdown.Text);
        }
    }
}
