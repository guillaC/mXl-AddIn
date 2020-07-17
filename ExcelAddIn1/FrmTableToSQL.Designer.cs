namespace ExcelAddIn1
{
    partial class FrmTableToSQL
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
            this.btnToclipboard = new System.Windows.Forms.Button();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnToclipboard
            // 
            this.btnToclipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToclipboard.Location = new System.Drawing.Point(381, 390);
            this.btnToclipboard.Name = "btnToclipboard";
            this.btnToclipboard.Size = new System.Drawing.Size(111, 23);
            this.btnToclipboard.TabIndex = 5;
            this.btnToclipboard.Text = "Copy to clipboard";
            this.btnToclipboard.UseVisualStyleBackColor = true;
            this.btnToclipboard.Click += new System.EventHandler(this.btnToclipboard_Click);
            // 
            // tbSQL
            // 
            this.tbSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSQL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSQL.Location = new System.Drawing.Point(16, 9);
            this.tbSQL.Multiline = true;
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSQL.Size = new System.Drawing.Size(476, 375);
            this.tbSQL.TabIndex = 4;
            // 
            // FrmTableToSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 422);
            this.Controls.Add(this.btnToclipboard);
            this.Controls.Add(this.tbSQL);
            this.Name = "FrmTableToSQL";
            this.Text = "Tables to SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToclipboard;
        private System.Windows.Forms.TextBox tbSQL;
    }
}