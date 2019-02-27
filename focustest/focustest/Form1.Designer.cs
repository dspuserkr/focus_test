namespace focustest
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
            this.buttAddRegStock = new System.Windows.Forms.Button();
            this.DgvRegStock = new System.Windows.Forms.DataGridView();
            this.CBoxFocusList = new System.Windows.Forms.ComboBox();
            this.DgvFocusStock = new System.Windows.Forms.DataGridView();
            this.buttDelRegStock = new System.Windows.Forms.Button();
            this.listRegList = new System.Windows.Forms.ListView();
            this.TBoxFocusList = new System.Windows.Forms.TextBox();
            this.buttNewGroup = new System.Windows.Forms.Button();
            this.buttDelGroup = new System.Windows.Forms.Button();
            this.TBoxSelGroup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFocusStock)).BeginInit();
            this.SuspendLayout();
            // 
            // buttAddRegStock
            // 
            this.buttAddRegStock.Location = new System.Drawing.Point(482, 12);
            this.buttAddRegStock.Name = "buttAddRegStock";
            this.buttAddRegStock.Size = new System.Drawing.Size(75, 23);
            this.buttAddRegStock.TabIndex = 0;
            this.buttAddRegStock.Text = "RegAdd";
            this.buttAddRegStock.UseVisualStyleBackColor = true;
            // 
            // DgvRegStock
            // 
            this.DgvRegStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegStock.Location = new System.Drawing.Point(306, 52);
            this.DgvRegStock.Name = "DgvRegStock";
            this.DgvRegStock.RowTemplate.Height = 23;
            this.DgvRegStock.Size = new System.Drawing.Size(352, 150);
            this.DgvRegStock.TabIndex = 1;
            // 
            // CBoxFocusList
            // 
            this.CBoxFocusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxFocusList.FormattingEnabled = true;
            this.CBoxFocusList.Location = new System.Drawing.Point(32, 15);
            this.CBoxFocusList.Name = "CBoxFocusList";
            this.CBoxFocusList.Size = new System.Drawing.Size(121, 20);
            this.CBoxFocusList.TabIndex = 2;
            this.CBoxFocusList.SelectedIndexChanged += new System.EventHandler(this.ClickCBoxFocusList);
            // 
            // DgvFocusStock
            // 
            this.DgvFocusStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFocusStock.Location = new System.Drawing.Point(32, 52);
            this.DgvFocusStock.Name = "DgvFocusStock";
            this.DgvFocusStock.RowTemplate.Height = 23;
            this.DgvFocusStock.Size = new System.Drawing.Size(240, 150);
            this.DgvFocusStock.TabIndex = 3;
            // 
            // buttDelRegStock
            // 
            this.buttDelRegStock.Location = new System.Drawing.Point(583, 12);
            this.buttDelRegStock.Name = "buttDelRegStock";
            this.buttDelRegStock.Size = new System.Drawing.Size(75, 23);
            this.buttDelRegStock.TabIndex = 0;
            this.buttDelRegStock.Text = "RegDelete";
            this.buttDelRegStock.UseVisualStyleBackColor = true;
            // 
            // listRegList
            // 
            this.listRegList.AllowDrop = true;
            this.listRegList.Location = new System.Drawing.Point(32, 227);
            this.listRegList.Name = "listRegList";
            this.listRegList.Size = new System.Drawing.Size(224, 20);
            this.listRegList.TabIndex = 4;
            this.listRegList.UseCompatibleStateImageBehavior = false;
            // 
            // TBoxFocusList
            // 
            this.TBoxFocusList.AllowDrop = true;
            this.TBoxFocusList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBoxFocusList.Location = new System.Drawing.Point(345, 226);
            this.TBoxFocusList.Name = "TBoxFocusList";
            this.TBoxFocusList.Size = new System.Drawing.Size(100, 21);
            this.TBoxFocusList.TabIndex = 5;
            // 
            // buttNewGroup
            // 
            this.buttNewGroup.Location = new System.Drawing.Point(277, 11);
            this.buttNewGroup.Name = "buttNewGroup";
            this.buttNewGroup.Size = new System.Drawing.Size(75, 23);
            this.buttNewGroup.TabIndex = 6;
            this.buttNewGroup.Text = "새그룹";
            this.buttNewGroup.UseVisualStyleBackColor = true;
            this.buttNewGroup.Click += new System.EventHandler(this.ClickGroup);
            // 
            // buttDelGroup
            // 
            this.buttDelGroup.Location = new System.Drawing.Point(358, 11);
            this.buttDelGroup.Name = "buttDelGroup";
            this.buttDelGroup.Size = new System.Drawing.Size(75, 23);
            this.buttDelGroup.TabIndex = 7;
            this.buttDelGroup.Text = "그룹삭제";
            this.buttDelGroup.UseVisualStyleBackColor = true;
            this.buttDelGroup.Click += new System.EventHandler(this.ClickGroup);
            // 
            // TBoxSelGroup
            // 
            this.TBoxSelGroup.Location = new System.Drawing.Point(169, 13);
            this.TBoxSelGroup.Name = "TBoxSelGroup";
            this.TBoxSelGroup.Size = new System.Drawing.Size(100, 21);
            this.TBoxSelGroup.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.TBoxSelGroup);
            this.Controls.Add(this.buttDelGroup);
            this.Controls.Add(this.buttNewGroup);
            this.Controls.Add(this.TBoxFocusList);
            this.Controls.Add(this.listRegList);
            this.Controls.Add(this.DgvFocusStock);
            this.Controls.Add(this.CBoxFocusList);
            this.Controls.Add(this.DgvRegStock);
            this.Controls.Add(this.buttDelRegStock);
            this.Controls.Add(this.buttAddRegStock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFocusStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttAddRegStock;
        private System.Windows.Forms.DataGridView DgvRegStock;
        private System.Windows.Forms.ComboBox CBoxFocusList;
        private System.Windows.Forms.DataGridView DgvFocusStock;
        private System.Windows.Forms.Button buttDelRegStock;
        private System.Windows.Forms.ListView listRegList;
        private System.Windows.Forms.TextBox TBoxFocusList;
        private System.Windows.Forms.Button buttNewGroup;
        private System.Windows.Forms.Button buttDelGroup;
        private System.Windows.Forms.TextBox TBoxSelGroup;
    }
}

