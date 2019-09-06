namespace MSSQL
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSqlValueList = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExpansion = new System.Windows.Forms.Button();
            this.lblSqlKeyList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSqlValueList
            // 
            this.lblSqlValueList.FormattingEnabled = true;
            this.lblSqlValueList.ItemHeight = 12;
            this.lblSqlValueList.Location = new System.Drawing.Point(200, 33);
            this.lblSqlValueList.Name = "lblSqlValueList";
            this.lblSqlValueList.Size = new System.Drawing.Size(401, 448);
            this.lblSqlValueList.TabIndex = 1;
            this.lblSqlValueList.SelectedIndexChanged += new System.EventHandler(this.lblSqlList_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(275, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(98, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "검색";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 21);
            this.textBox2.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(607, 62);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(141, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "추가하기";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(607, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "변경하기";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(607, 91);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefrush_Click);
            // 
            // btnExpansion
            // 
            this.btnExpansion.Location = new System.Drawing.Point(576, 10);
            this.btnExpansion.Name = "btnExpansion";
            this.btnExpansion.Size = new System.Drawing.Size(25, 23);
            this.btnExpansion.TabIndex = 7;
            this.btnExpansion.Text = ">";
            this.btnExpansion.UseVisualStyleBackColor = true;
            this.btnExpansion.Click += new System.EventHandler(this.btnExpansion_Click);
            // 
            // lblSqlKeyList
            // 
            this.lblSqlKeyList.FormattingEnabled = true;
            this.lblSqlKeyList.ItemHeight = 12;
            this.lblSqlKeyList.Location = new System.Drawing.Point(12, 33);
            this.lblSqlKeyList.Name = "lblSqlKeyList";
            this.lblSqlKeyList.Size = new System.Drawing.Size(182, 448);
            this.lblSqlKeyList.TabIndex = 8;
            this.lblSqlKeyList.SelectedIndexChanged += new System.EventHandler(this.lblSqlKeyList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 491);
            this.Controls.Add(this.lblSqlKeyList);
            this.Controls.Add(this.btnExpansion);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblSqlValueList);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(622, 530);
            this.Name = "Form1";
            this.Text = "MjQuery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblSqlValueList;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExpansion;
        private System.Windows.Forms.ListBox lblSqlKeyList;
    }
}

