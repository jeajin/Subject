namespace jaejin_DB
{
    partial class 배송지정보
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
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Insert_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Company = new System.Windows.Forms.RadioButton();
            this.Home = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Detail_Addr = new System.Windows.Forms.TextBox();
            this.Basic_Addr = new System.Windows.Forms.TextBox();
            this.Postal_Code = new System.Windows.Forms.TextBox();
            this.AddressList = new System.Windows.Forms.DataGridView();
            this.InfoName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.AddressList);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 412);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "배송지 정보";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete_Button);
            this.groupBox2.Controls.Add(this.Insert_Button);
            this.groupBox2.Controls.Add(this.Update_Button);
            this.groupBox2.Controls.Add(this.Company);
            this.groupBox2.Controls.Add(this.Home);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Detail_Addr);
            this.groupBox2.Controls.Add(this.Basic_Addr);
            this.groupBox2.Controls.Add(this.Postal_Code);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(613, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 371);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "배송지 정보";
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Tan;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(185, 328);
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
            this.Insert_Button.Location = new System.Drawing.Point(96, 328);
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
            this.Update_Button.Location = new System.Drawing.Point(6, 328);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(81, 29);
            this.Update_Button.TabIndex = 32;
            this.Update_Button.Text = "수정";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company.Location = new System.Drawing.Point(51, 36);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(52, 21);
            this.Company.TabIndex = 18;
            this.Company.TabStop = true;
            this.Company.Text = "회사";
            this.Company.UseVisualStyleBackColor = true;
            this.Company.CheckedChanged += new System.EventHandler(this.Company_CheckedChanged);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(6, 36);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(39, 21);
            this.Home.TabIndex = 18;
            this.Home.TabStop = true;
            this.Home.Text = "집";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.CheckedChanged += new System.EventHandler(this.Home_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "상세주소";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "우편번호";
            // 
            // Detail_Addr
            // 
            this.Detail_Addr.BackColor = System.Drawing.Color.White;
            this.Detail_Addr.Location = new System.Drawing.Point(6, 253);
            this.Detail_Addr.Multiline = true;
            this.Detail_Addr.Name = "Detail_Addr";
            this.Detail_Addr.Size = new System.Drawing.Size(260, 56);
            this.Detail_Addr.TabIndex = 3;
            // 
            // Basic_Addr
            // 
            this.Basic_Addr.BackColor = System.Drawing.Color.White;
            this.Basic_Addr.Location = new System.Drawing.Point(6, 162);
            this.Basic_Addr.Multiline = true;
            this.Basic_Addr.Name = "Basic_Addr";
            this.Basic_Addr.Size = new System.Drawing.Size(260, 54);
            this.Basic_Addr.TabIndex = 3;
            // 
            // Postal_Code
            // 
            this.Postal_Code.BackColor = System.Drawing.Color.White;
            this.Postal_Code.Location = new System.Drawing.Point(6, 99);
            this.Postal_Code.Name = "Postal_Code";
            this.Postal_Code.Size = new System.Drawing.Size(260, 24);
            this.Postal_Code.TabIndex = 3;
            // 
            // AddressList
            // 
            this.AddressList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddressList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AddressList.BackgroundColor = System.Drawing.Color.Moccasin;
            this.AddressList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressList.Location = new System.Drawing.Point(15, 28);
            this.AddressList.Name = "AddressList";
            this.AddressList.RowTemplate.Height = 23;
            this.AddressList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddressList.Size = new System.Drawing.Size(580, 371);
            this.AddressList.TabIndex = 19;
            this.AddressList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressList_CellContentClick);
            // 
            // InfoName
            // 
            this.InfoName.AutoSize = true;
            this.InfoName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InfoName.Location = new System.Drawing.Point(843, 18);
            this.InfoName.Name = "InfoName";
            this.InfoName.Size = new System.Drawing.Size(66, 17);
            this.InfoName.TabIndex = 30;
            this.InfoName.Text = "         님";
            // 
            // 배송지정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoName);
            this.Name = "배송지정보";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView AddressList;
        private System.Windows.Forms.Label InfoName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Detail_Addr;
        private System.Windows.Forms.TextBox Basic_Addr;
        private System.Windows.Forms.TextBox Postal_Code;
        private System.Windows.Forms.RadioButton Company;
        private System.Windows.Forms.RadioButton Home;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Insert_Button;
        private System.Windows.Forms.Button Update_Button;
    }
}