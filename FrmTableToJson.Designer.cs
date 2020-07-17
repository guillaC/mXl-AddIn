namespace ExcelAddIn1
{
    partial class FrmTableToJson
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
            this.tvJson = new System.Windows.Forms.TreeView();
            this.tbJson = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tvJson
            // 
            this.tvJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvJson.FullRowSelect = true;
            this.tvJson.Location = new System.Drawing.Point(326, 12);
            this.tvJson.Name = "tvJson";
            this.tvJson.Size = new System.Drawing.Size(308, 430);
            this.tvJson.TabIndex = 0;
            // 
            // tbJson
            // 
            this.tbJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJson.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJson.Location = new System.Drawing.Point(12, 12);
            this.tbJson.Multiline = true;
            this.tbJson.Name = "tbJson";
            this.tbJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJson.Size = new System.Drawing.Size(308, 430);
            this.tbJson.TabIndex = 1;
            // 
            // frmTableToJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 454);
            this.Controls.Add(this.tbJson);
            this.Controls.Add(this.tvJson);
            this.Name = "frmTableToJson";
            this.Text = "Tables to JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvJson;
        private System.Windows.Forms.TextBox tbJson;
    }
}