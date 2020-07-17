using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAddIn1
{
    public partial class FrmTableToJson : Form
    {
        public FrmTableToJson(String sheetName, string jsonData, TreeNode jsonTree)
        {
            InitializeComponent();
            this.Text = this.Text + " - " +  sheetName;
            this.tbJson.Text = jsonData;
            this.tvJson.Nodes.Add(jsonTree);
        }
    }
}
