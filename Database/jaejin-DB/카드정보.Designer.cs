namespace jaejin_DB
{
    partial class 카드정보
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valid_thru = new System.Windows.Forms.DateTimePicker();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Insert_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.CardList = new System.Windows.Forms.DataGridView();
            this.InfoName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CardList);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 320);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "카드정보";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.valid_thru);
            this.groupBox2.Controls.Add(this.Delete_Button);
            this.groupBox2.Controls.Add(this.Insert_Button);
            this.groupBox2.Controls.Add(this.Update_Button);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.type);
            this.groupBox2.Controls.Add(this.Code);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(613, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 280);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "카드 정보";
            // 
            // valid_thru
            // 
            this.valid_thru.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.valid_thru.Location = new System.Drawing.Point(6, 185);
            this.valid_thru.Name = "valid_thru";
            this.valid_thru.Size = new System.Drawing.Size(260, 24);
            this.valid_thru.TabIndex = 33;
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Tan;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(185, 233);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(81, 29);
            this.Delete_Button.TabIndex = 32;
            this.Delete_Button.Text = "삭제";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Insert_Button
            // 
            this.Insert_Button.BackColor = System.Drawing.Color.Tan;
            this.Insert_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Insert_Button.ForeColor = System.Drawing.Color.White;
            this.Insert_Button.Location = new System.Drawing.Point(96, 233);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(81, 29);
            this.Insert_Button.TabIndex = 32;
            this.Insert_Button.Text = "추가";
            this.Insert_Button.UseVisualStyleBackColor = false;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.Color.Tan;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Update_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Button.Location = new System.Drawing.Point(6, 233);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(81, 29);
            this.Update_Button.TabIndex = 32;
            this.Update_Button.Text = "수정";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "카드종류";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "카드기한";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "카드번호";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.White;
            this.type.Location = new System.Drawing.Point(6, 124);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(260, 24);
            this.type.TabIndex = 3;
            // 
            // Code
            // 
            this.Code.BackColor = System.Drawing.Color.White;
            this.Code.Location = new System.Drawing.Point(6, 65);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(260, 24);
            this.Code.TabIndex = 3;
            // 
            // CardList
            // 
            this.CardList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CardList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CardList.BackgroundColor = System.Drawing.Color.Moccasin;
            this.CardList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardList.Location = new System.Drawing.Point(15, 28);
            this.CardList.Name = "CardList";
            this.CardList.RowTemplate.Height = 23;
            this.CardList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CardList.Size = new System.Drawing.Size(580, 280);
            this.CardList.TabIndex = 19;
            this.CardList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardList_CellContentClick);
            // 
            // InfoName
            // 
            this.InfoName.AutoSize = true;
            this.InfoName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InfoName.Location = new System.Drawing.Point(841, 15);
            this.InfoName.Name = "InfoName";
            this.InfoName.Size = new System.Drawing.Size(66, 17);
            this.InfoName.TabIndex = 34;
            this.InfoName.Text = "         님";
            // 
            // 카드정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoName);
            this.Name = "카드정보";
            this.Text = "카드정보";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker valid_thru;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Insert_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.DataGridView CardList;
        private System.Windows.Forms.Label InfoName;
    }
}