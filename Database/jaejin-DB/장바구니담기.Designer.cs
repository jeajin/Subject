namespace jaejin_DB
{
    partial class 장바구니담기
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
            this.Basket_Num_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Basket_Num = new System.Windows.Forms.ComboBox();
            this.BookCount_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BookCount = new System.Windows.Forms.ComboBox();
            this.BookList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Basket_Delete_Button = new System.Windows.Forms.Button();
            this.Basket_Insert_Button = new System.Windows.Forms.Button();
            this.Basket_LIst = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Basket_Select_LIst = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Basket_LIst)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Basket_Select_LIst)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Basket_Num_Button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Basket_Num);
            this.groupBox1.Controls.Add(this.BookCount_Button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BookCount);
            this.groupBox1.Controls.Add(this.BookList);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 337);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "선택 도서 리스트";
            // 
            // Basket_Num_Button
            // 
            this.Basket_Num_Button.BackColor = System.Drawing.Color.Tan;
            this.Basket_Num_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Basket_Num_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Basket_Num_Button.ForeColor = System.Drawing.Color.White;
            this.Basket_Num_Button.Location = new System.Drawing.Point(653, 294);
            this.Basket_Num_Button.Name = "Basket_Num_Button";
            this.Basket_Num_Button.Size = new System.Drawing.Size(81, 31);
            this.Basket_Num_Button.TabIndex = 39;
            this.Basket_Num_Button.Text = "적용";
            this.Basket_Num_Button.UseVisualStyleBackColor = false;
            this.Basket_Num_Button.Click += new System.EventHandler(this.Basket_Num_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "장바구니 선택";
            // 
            // Basket_Num
            // 
            this.Basket_Num.FormattingEnabled = true;
            this.Basket_Num.Location = new System.Drawing.Point(562, 295);
            this.Basket_Num.Name = "Basket_Num";
            this.Basket_Num.Size = new System.Drawing.Size(86, 29);
            this.Basket_Num.TabIndex = 37;
            // 
            // BookCount_Button
            // 
            this.BookCount_Button.BackColor = System.Drawing.Color.Tan;
            this.BookCount_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookCount_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BookCount_Button.ForeColor = System.Drawing.Color.White;
            this.BookCount_Button.Location = new System.Drawing.Point(652, 255);
            this.BookCount_Button.Name = "BookCount_Button";
            this.BookCount_Button.Size = new System.Drawing.Size(81, 31);
            this.BookCount_Button.TabIndex = 36;
            this.BookCount_Button.Text = "적용";
            this.BookCount_Button.UseVisualStyleBackColor = false;
            this.BookCount_Button.Click += new System.EventHandler(this.BookCount_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "도서 수량";
            // 
            // BookCount
            // 
            this.BookCount.FormattingEnabled = true;
            this.BookCount.Location = new System.Drawing.Point(561, 256);
            this.BookCount.Name = "BookCount";
            this.BookCount.Size = new System.Drawing.Size(86, 29);
            this.BookCount.TabIndex = 34;
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
            this.BookList.Size = new System.Drawing.Size(718, 221);
            this.BookList.TabIndex = 19;
            this.BookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookList_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Basket_Delete_Button);
            this.groupBox2.Controls.Add(this.Basket_Insert_Button);
            this.groupBox2.Controls.Add(this.Basket_LIst);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(12, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 317);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "장바구니 리스트";
            // 
            // Basket_Delete_Button
            // 
            this.Basket_Delete_Button.BackColor = System.Drawing.Color.Tan;
            this.Basket_Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Basket_Delete_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Basket_Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Basket_Delete_Button.Location = new System.Drawing.Point(149, 275);
            this.Basket_Delete_Button.Name = "Basket_Delete_Button";
            this.Basket_Delete_Button.Size = new System.Drawing.Size(125, 31);
            this.Basket_Delete_Button.TabIndex = 39;
            this.Basket_Delete_Button.Text = "장바구니 삭제";
            this.Basket_Delete_Button.UseVisualStyleBackColor = false;
            this.Basket_Delete_Button.Click += new System.EventHandler(this.Basket_Delete_Button_Click);
            // 
            // Basket_Insert_Button
            // 
            this.Basket_Insert_Button.BackColor = System.Drawing.Color.Tan;
            this.Basket_Insert_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Basket_Insert_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Basket_Insert_Button.ForeColor = System.Drawing.Color.White;
            this.Basket_Insert_Button.Location = new System.Drawing.Point(15, 275);
            this.Basket_Insert_Button.Name = "Basket_Insert_Button";
            this.Basket_Insert_Button.Size = new System.Drawing.Size(128, 31);
            this.Basket_Insert_Button.TabIndex = 36;
            this.Basket_Insert_Button.Text = "장바구니 생성";
            this.Basket_Insert_Button.UseVisualStyleBackColor = false;
            this.Basket_Insert_Button.Click += new System.EventHandler(this.Basket_Insert_Button_Click);
            // 
            // Basket_LIst
            // 
            this.Basket_LIst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Basket_LIst.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Basket_LIst.BackgroundColor = System.Drawing.Color.Moccasin;
            this.Basket_LIst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Basket_LIst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Basket_LIst.Location = new System.Drawing.Point(15, 28);
            this.Basket_LIst.Name = "Basket_LIst";
            this.Basket_LIst.RowTemplate.Height = 23;
            this.Basket_LIst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Basket_LIst.Size = new System.Drawing.Size(259, 241);
            this.Basket_LIst.TabIndex = 19;
            this.Basket_LIst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Basket_LIst_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Basket_Select_LIst);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox3.Location = new System.Drawing.Point(298, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 317);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "장바구니";
            // 
            // Basket_Select_LIst
            // 
            this.Basket_Select_LIst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Basket_Select_LIst.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Basket_Select_LIst.BackgroundColor = System.Drawing.Color.Moccasin;
            this.Basket_Select_LIst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Basket_Select_LIst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Basket_Select_LIst.Location = new System.Drawing.Point(20, 28);
            this.Basket_Select_LIst.Name = "Basket_Select_LIst";
            this.Basket_Select_LIst.RowTemplate.Height = 23;
            this.Basket_Select_LIst.Size = new System.Drawing.Size(428, 276);
            this.Basket_Select_LIst.TabIndex = 19;
            // 
            // 장바구니담기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 697);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "장바구니담기";
            this.Text = "장바구니담기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Basket_LIst)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Basket_Select_LIst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView BookList;
        private System.Windows.Forms.Button Basket_Num_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Basket_Num;
        private System.Windows.Forms.Button BookCount_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BookCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Basket_Delete_Button;
        private System.Windows.Forms.Button Basket_Insert_Button;
        private System.Windows.Forms.DataGridView Basket_LIst;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Basket_Select_LIst;
    }
}