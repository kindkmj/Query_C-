namespace MSSQL
{
    partial class EditText
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
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnValueOk = new System.Windows.Forms.Button();
            this.btnKeyOk = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbValue
            // 
            this.tbValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValue.Location = new System.Drawing.Point(7, 43);
            this.tbValue.Multiline = true;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(436, 302);
            this.tbValue.TabIndex = 0;
            // 
            // btnValueOk
            // 
            this.btnValueOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnValueOk.Location = new System.Drawing.Point(235, 352);
            this.btnValueOk.Name = "btnValueOk";
            this.btnValueOk.Size = new System.Drawing.Size(208, 23);
            this.btnValueOk.TabIndex = 1;
            this.btnValueOk.Text = "값 변경";
            this.btnValueOk.UseVisualStyleBackColor = true;
            this.btnValueOk.Click += new System.EventHandler(this.btnValueOk_Click);
            // 
            // btnKeyOk
            // 
            this.btnKeyOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKeyOk.Location = new System.Drawing.Point(7, 350);
            this.btnKeyOk.Name = "btnKeyOk";
            this.btnKeyOk.Size = new System.Drawing.Size(208, 23);
            this.btnKeyOk.TabIndex = 2;
            this.btnKeyOk.Text = "키 변경";
            this.btnKeyOk.UseVisualStyleBackColor = true;
            this.btnKeyOk.Click += new System.EventHandler(this.btnKeyOk_Click);
            // 
            // tbKey
            // 
            this.tbKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKey.Location = new System.Drawing.Point(7, 12);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(436, 25);
            this.tbKey.TabIndex = 3;
            // 
            // EditText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 386);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnKeyOk);
            this.Controls.Add(this.btnValueOk);
            this.Controls.Add(this.tbValue);
            this.MinimumSize = new System.Drawing.Size(468, 425);
            this.Name = "EditText";
            this.Text = "MjQuery";
            this.Load += new System.EventHandler(this.EditText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnValueOk;
        private System.Windows.Forms.Button btnKeyOk;
        private System.Windows.Forms.TextBox tbKey;
    }
}