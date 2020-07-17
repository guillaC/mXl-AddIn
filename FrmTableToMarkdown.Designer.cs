namespace ExcelAddIn1
{
    partial class FrmTableToMarkdown
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
            this.tbMarkdown = new System.Windows.Forms.TextBox();
            this.btnToclipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMarkdown
            // 
            this.tbMarkdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMarkdown.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarkdown.Location = new System.Drawing.Point(12, 12);
            this.tbMarkdown.Multiline = true;
            this.tbMarkdown.Name = "tbMarkdown";
            this.tbMarkdown.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMarkdown.Size = new System.Drawing.Size(476, 375);
            this.tbMarkdown.TabIndex = 2;
            // 
            // btnToclipboard
            // 
            this.btnToclipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToclipboard.Location = new System.Drawing.Point(377, 393);
            this.btnToclipboard.Name = "btnToclipboard";
            this.btnToclipboard.Size = new System.Drawing.Size(111, 23);
            this.btnToclipboard.TabIndex = 3;
            this.btnToclipboard.Text = "Copy to clipboard";
            this.btnToclipboard.UseVisualStyleBackColor = true;
            this.btnToclipboard.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTableToMarkdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 428);
            this.Controls.Add(this.btnToclipboard);
            this.Controls.Add(this.tbMarkdown);
            this.Name = "frmTableToMarkdown";
            this.Text = "Tables to Markdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarkdown;
        private System.Windows.Forms.Button btnToclipboard;
    }
}