namespace jaejin_DB
{
    partial class 바로주문
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
            this.label9 = new System.Windows.Forms.Label();
            this.BookCount_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BookCount = new System.Windows.Forms.ComboBox();
            this.BookList = new System.Windows.Forms.DataGridView();
            this.SumMoney = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CardList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.valid_thru = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddressList = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Company = new System.Windows.Forms.RadioButton();
            this.Home = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Detail_Addr = new System.Windows.Forms.TextBox();
            this.Basic_Addr = new System.Windows.Forms.TextBox();
            this.Postal_Code = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Purchase_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressList)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BookCount_Button);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BookCount);
            this.groupBox1.Controls.Add(this.BookList);
            this.groupBox1.Controls.Add(this.SumMoney);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 328);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서목록";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "원";
            // 
            // BookCount_Button
            // 
            this.BookCount_Button.BackColor = System.Drawing.Color.Tan;
            this.BookCount_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookCount_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BookCount_Button.ForeColor = System.Drawing.Color.White;
            this.BookCount_Button.Location = new System.Drawing.Point(731, 282);
            this.BookCount_Button.Name = "BookCount_Button";
            this.BookCount_Button.Size = new System.Drawing.Size(81, 31);
            this.BookCount_Button.TabIndex = 33;
            this.BookCount_Button.Text = "적용";
            this.BookCount_Button.UseVisualStyleBackColor = false;
            this.BookCount_Button.Click += new System.EventHandler(this.BookCount_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "합계";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "도서 수량";
            // 
            // BookCount
            // 
            this.BookCount.FormattingEnabled = true;
            this.BookCount.Location = new System.Drawing.Point(640, 283);
            this.BookCount.Name = "BookCount";
            this.BookCount.Size = new System.Drawing.Size(86, 29);
            this.BookCount.TabIndex = 20;
            // 
            // BookList
            // 
            this.BookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BookList.BackgroundColor = System.Drawing.Color.Moccasin;
            this.BookList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookList.Location = new System.Drawing.Point(15, 28);
            this.BookList.MultiSelect = false;
            this.BookList.Name = "BookList";
            this.BookList.RowTemplate.Height = 23;
            this.BookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookList.Size = new System.Drawing.Size(796, 241);
            this.BookList.TabIndex = 19;
            this.BookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookList_CellContentClick);
            // 
            // SumMoney
            // 
            this.SumMoney.BackColor = System.Drawing.Color.White;
            this.SumMoney.Location = new System.Drawing.Point(53, 283);
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.Size = new System.Drawing.Size(113, 29);
            this.SumMoney.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CardList);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(11, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 472);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "등록카드";
            // 
            // CardList
            // 
            this.CardList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CardList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CardList.BackgroundColor = System.Drawing.Color.Moccasin;
            this.CardList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardList.Location = new System.Drawing.Point(14, 27);
            this.CardList.MultiSelect = false;
            this.CardList.Name = "CardList";
            this.CardList.RowTemplate.Height = 23;
            this.CardList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CardList.Size = new System.Drawing.Size(351, 193);
            this.CardList.TabIndex = 34;
            this.CardList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardList_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.valid_thru);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.type);
            this.groupBox3.Controls.Add(this.Code);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(18, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 228);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "선택된 카드";
            // 
            // valid_thru
            // 
            this.valid_thru.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.valid_thru.Location = new System.Drawing.Point(6, 162);
            this.valid_thru.Name = "valid_thru";
            this.valid_thru.Size = new System.Drawing.Size(321, 24);
            this.valid_thru.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "유효기간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "카드번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "카드종류";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.White;
            this.type.Location = new System.Drawing.Point(6, 107);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(321, 24);
            this.type.TabIndex = 3;
            // 
            // Code
            // 
            this.Code.BackColor = System.Drawing.Color.White;
            this.Code.Location = new System.Drawing.Point(6, 47);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(321, 24);
            this.Code.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AddressList);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox4.Location = new System.Drawing.Point(391, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 471);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "배송지";
            // 
            // AddressList
            // 
            this.AddressList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddressList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AddressList.BackgroundColor = System.Drawing.Color.Moccasin;
            this.AddressList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressList.Location = new System.Drawing.Point(15, 26);
            this.AddressList.MultiSelect = false;
            this.AddressList.Name = "AddressList";
            this.AddressList.RowTemplate.Height = 23;
            this.AddressList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddressList.Size = new System.Drawing.Size(417, 175);
            this.AddressList.TabIndex = 34;
            this.AddressList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressList_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Company);
            this.groupBox5.Controls.Add(this.Home);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.Detail_Addr);
            this.groupBox5.Controls.Add(this.Basic_Addr);
            this.groupBox5.Controls.Add(this.Postal_Code);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(15, 207);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 251);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "선택된 배송지";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company.Location = new System.Drawing.Point(51, 23);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(52, 21);
            this.Company.TabIndex = 34;
            this.Company.TabStop = true;
            this.Company.Text = "회사";
            this.Company.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(6, 23);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(39, 21);
            this.Home.TabIndex = 35;
            this.Home.TabStop = true;
            this.Home.Text = "집";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(4, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "상세주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "우편번호";
            // 
            // Detail_Addr
            // 
            this.Detail_Addr.BackColor = System.Drawing.Color.White;
            this.Detail_Addr.Location = new System.Drawing.Point(7, 205);
            this.Detail_Addr.Name = "Detail_Addr";
            this.Detail_Addr.Size = new System.Drawing.Size(405, 24);
            this.Detail_Addr.TabIndex = 3;
            // 
            // Basic_Addr
            // 
            this.Basic_Addr.BackColor = System.Drawing.Color.White;
            this.Basic_Addr.Location = new System.Drawing.Point(6, 146);
            this.Basic_Addr.Name = "Basic_Addr";
            this.Basic_Addr.Size = new System.Drawing.Size(405, 24);
            this.Basic_Addr.TabIndex = 3;
            // 
            // Postal_Code
            // 
            this.Postal_Code.BackColor = System.Drawing.Color.White;
            this.Postal_Code.Location = new System.Drawing.Point(6, 84);
            this.Postal_Code.Name = "Postal_Code";
            this.Postal_Code.Size = new System.Drawing.Size(405, 24);
            this.Postal_Code.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Purchase_Button);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 876);
            this.panel1.TabIndex = 29;
            // 
            // Purchase_Button
            // 
            this.Purchase_Button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Purchase_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purchase_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Purchase_Button.ForeColor = System.Drawing.Color.White;
            this.Purchase_Button.Location = new System.Drawing.Point(723, 821);
            this.Purchase_Button.Name = "Purchase_Button";
            this.Purchase_Button.Size = new System.Drawing.Size(116, 45);
            this.Purchase_Button.TabIndex = 34;
            this.Purchase_Button.Text = "결제";
            this.Purchase_Button.UseVisualStyleBackColor = false;
            this.Purchase_Button.Click += new System.EventHandler(this.Purchase_Button_Click);
            // 
            // 바로주문
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 883);
            this.Controls.Add(this.panel1);
            this.Name = "바로주문";
            this.Text = "바로주문";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddressList)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView BookList;
        private System.Windows.Forms.ComboBox BookCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BookCount_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView CardList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker valid_thru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView AddressList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Basic_Addr;
        private System.Windows.Forms.TextBox Postal_Code;
        private System.Windows.Forms.RadioButton Company;
        private System.Windows.Forms.RadioButton Home;
        private System.Windows.Forms.TextBox Detail_Addr;
        private System.Windows.Forms.Button Purchase_Button;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SumMoney;
    }
}