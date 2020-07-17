namespace ExcelAddIn1
{
    partial class FrmFormulas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvFormulas = new System.Windows.Forms.ListView();
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFormulas
            // 
            this.lvFormulas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFormulas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.location,
            this.formula});
            this.lvFormulas.FullRowSelect = true;
            this.lvFormulas.GridLines = true;
            this.lvFormulas.HideSelection = false;
            this.lvFormulas.Location = new System.Drawing.Point(12, 12);
            this.lvFormulas.Name = "lvFormulas";
            this.lvFormulas.Size = new System.Drawing.Size(462, 365);
            this.lvFormulas.TabIndex = 0;
            this.lvFormulas.UseCompatibleStateImageBehavior = false;
            this.lvFormulas.View = System.Windows.Forms.View.Details;
            // 
            // location
            // 
            this.location.Text = "Location";
            this.location.Width = 128;
            // 
            // formula
            // 
            this.formula.Text = "Formula";
            this.formula.Width = 324;
            // 
            // FrmFormulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 389);
            this.Controls.Add(this.lvFormulas);
            this.Name = "FrmFormulas";
            this.Text = "Formulas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFormulas;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader formula;
    }
}