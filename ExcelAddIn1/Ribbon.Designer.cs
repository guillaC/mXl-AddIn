namespace ExcelAddIn1
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnConvertToJson = this.Factory.CreateRibbonButton();
            this.btnConvertToMarkdown = this.Factory.CreateRibbonButton();
            this.btnConvertToSQL = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnExecuteSQL = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.btnGetFormulas = this.Factory.CreateRibbonButton();
            this.tab.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Groups.Add(this.group1);
            this.tab.Groups.Add(this.group2);
            this.tab.Groups.Add(this.group3);
            this.tab.Label = "mxlAddIn";
            this.tab.Name = "tab";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnConvertToJson);
            this.group1.Items.Add(this.btnConvertToMarkdown);
            this.group1.Items.Add(this.btnConvertToSQL);
            this.group1.Label = "Converter";
            this.group1.Name = "group1";
            // 
            // btnConvertToJson
            // 
            this.btnConvertToJson.Label = "Export to JSON";
            this.btnConvertToJson.Name = "btnConvertToJson";
            this.btnConvertToJson.OfficeImageId = "CreateMacro";
            this.btnConvertToJson.ShowImage = true;
            this.btnConvertToJson.SuperTip = "convert excel table of current worksheet to JSON";
            this.btnConvertToJson.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnConvertToJson_Click);
            // 
            // btnConvertToMarkdown
            // 
            this.btnConvertToMarkdown.Label = "Export to Markdown";
            this.btnConvertToMarkdown.Name = "btnConvertToMarkdown";
            this.btnConvertToMarkdown.OfficeImageId = "TableInsertDialogWord";
            this.btnConvertToMarkdown.ShowImage = true;
            this.btnConvertToMarkdown.SuperTip = "convert excel table of current worksheet to Markdwon";
            this.btnConvertToMarkdown.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnConvertToMarkdown_Click);
            // 
            // btnConvertToSQL
            // 
            this.btnConvertToSQL.Label = "Export to SQL";
            this.btnConvertToSQL.Name = "btnConvertToSQL";
            this.btnConvertToSQL.OfficeImageId = "DatabaseDocumenter";
            this.btnConvertToSQL.ShowImage = true;
            this.btnConvertToSQL.SuperTip = "convert excel table of current worksheet to SQL";
            this.btnConvertToSQL.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnConvertToSQL_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnExecuteSQL);
            this.group2.Label = "SQL";
            this.group2.Name = "group2";
            // 
            // btnExecuteSQL
            // 
            this.btnExecuteSQL.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnExecuteSQL.Label = "Execute SQL queries";
            this.btnExecuteSQL.Name = "btnExecuteSQL";
            this.btnExecuteSQL.OfficeImageId = "EditQuery";
            this.btnExecuteSQL.ShowImage = true;
            this.btnExecuteSQL.SuperTip = "Execute SQL Query";
            this.btnExecuteSQL.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnExecuteSQL_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.btnGetFormulas);
            this.group3.Label = "Other";
            this.group3.Name = "group3";
            // 
            // btnGetFormulas
            // 
            this.btnGetFormulas.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnGetFormulas.Label = "Get Formulas";
            this.btnGetFormulas.Name = "btnGetFormulas";
            this.btnGetFormulas.OfficeImageId = "TableFormulaDialog";
            this.btnGetFormulas.ShowImage = true;
            this.btnGetFormulas.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnGetFormulas_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnConvertToJson;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnConvertToSQL;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnConvertToMarkdown;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnExecuteSQL;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnGetFormulas;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon1
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
