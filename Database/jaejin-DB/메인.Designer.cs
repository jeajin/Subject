namespace jaejin_DB
{
    partial class 메인
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(메인));
            this.Pw_Box = new System.Windows.Forms.TextBox();
            this.Id_Box = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.MemberInfo_Botton = new System.Windows.Forms.Button();
            this.PurchaseList_Button = new System.Windows.Forms.Button();
            this.Basket_Button = new System.Windows.Forms.Button();
            this.Join_Button = new System.Windows.Forms.Button();
            this.BookList = new System.Windows.Forms.DataGridView();
            this.Search_Combo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ComeBack = new System.Windows.Forms.PictureBox();
            this.BookSearch = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PutBasket_Button = new System.Windows.Forms.Button();
            this.Purchase_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Wellcome_Label = new System.Windows.Forms.Label();
            this.AdminButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComeBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Button)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pw_Box
            // 
            this.Pw_Box.Location = new System.Drawing.Point(833, 83);
            this.Pw_Box.Name = "Pw_Box";
            this.Pw_Box.Size = new System.Drawing.Size(146, 21);
            this.Pw_Box.TabIndex = 10;
            this.Pw_Box.Text = "비밀번호";
            this.Pw_Box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pw_Box_MouseClick);
            // 
            // Id_Box
            // 
            this.Id_Box.Location = new System.Drawing.Point(833, 56);
            this.Id_Box.Name = "Id_Box";
            this.Id_Box.Size = new System.Drawing.Size(146, 21);
            this.Id_Box.TabIndex = 9;
            this.Id_Box.Text = "아이디";
            this.Id_Box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Id_Box_MouseClick);
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.Tan;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.Location = new System.Drawing.Point(985, 57);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(92, 48);
            this.Login_Button.TabIndex = 8;
            this.Login_Button.Text = "로그인";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.Color.Tan;
            this.Logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Logout_Button.ForeColor = System.Drawing.Color.White;
            this.Logout_Button.Location = new System.Drawing.Point(985, 56);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(92, 49);
            this.Logout_Button.TabIndex = 8;
            this.Logout_Button.Text = "로그아웃";
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // MemberInfo_Botton
            // 
            this.MemberInfo_Botton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MemberInfo_Botton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberInfo_Botton.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemberInfo_Botton.ForeColor = System.Drawing.Color.White;
            this.MemberInfo_Botton.Location = new System.Drawing.Point(832, 8);
            this.MemberInfo_Botton.Name = "MemberInfo_Botton";
            this.MemberInfo_Botton.Size = new System.Drawing.Size(83, 23);
            this.MemberInfo_Botton.TabIndex = 18;
            this.MemberInfo_Botton.Text = "회원정보";
            this.MemberInfo_Botton.UseVisualStyleBackColor = false;
            this.MemberInfo_Botton.Click += new System.EventHandler(this.MemberInfo_Botton_Click);
            // 
            // PurchaseList_Button
            // 
            this.PurchaseList_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PurchaseList_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseList_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PurchaseList_Button.ForeColor = System.Drawing.Color.White;
            this.PurchaseList_Button.Location = new System.Drawing.Point(913, 8);
            this.PurchaseList_Button.Name = "PurchaseList_Button";
            this.PurchaseList_Button.Size = new System.Drawing.Size(83, 23);
            this.PurchaseList_Button.TabIndex = 17;
            this.PurchaseList_Button.Text = "주문정보";
            this.PurchaseList_Button.UseVisualStyleBackColor = false;
            this.PurchaseList_Button.Click += new System.EventHandler(this.PurchaseList_Button_Click);
            // 
            // Basket_Button
            // 
            this.Basket_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Basket_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Basket_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Basket_Button.ForeColor = System.Drawing.Color.White;
            this.Basket_Button.Location = new System.Drawing.Point(996, 8);
            this.Basket_Button.Name = "Basket_Button";
            this.Basket_Button.Size = new System.Drawing.Size(83, 23);
            this.Basket_Button.TabIndex = 16;
            this.Basket_Button.Text = "장바구니";
            this.Basket_Button.UseVisualStyleBackColor = false;
            this.Basket_Button.Click += new System.EventHandler(this.Basket_Button_Click);
            // 
            // Join_Button
            // 
            this.Join_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Join_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Join_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join_Button.ForeColor = System.Drawing.Color.White;
            this.Join_Button.Location = new System.Drawing.Point(994, 8);
            this.Join_Button.Name = "Join_Button";
            this.Join_Button.Size = new System.Drawing.Size(82, 23);
            this.Join_Button.TabIndex = 15;
            this.Join_Button.Text = "회원가입";
            this.Join_Button.UseVisualStyleBackColor = false;
            this.Join_Button.Click += new System.EventHandler(this.Join_Button_Click);
            // 
            // BookList
            // 
            this.BookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BookList.BackgroundColor = System.Drawing.Color.Moccasin;
            this.BookList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookList.Location = new System.Drawing.Point(15, 28);
            this.BookList.Name = "BookList";
            this.BookList.RowTemplate.Height = 23;
            this.BookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookList.Size = new System.Drawing.Size(773, 602);
            this.BookList.TabIndex = 19;
            // 
            // Search_Combo
            // 
            this.Search_Combo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Search_Combo.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Search_Combo.FormattingEnabled = true;
            this.Search_Combo.Items.AddRange(new object[] {
            "도서명",
            "도서번호"});
            this.Search_Combo.Location = new System.Drawing.Point(136, 61);
            this.Search_Combo.Name = "Search_Combo";
            this.Search_Combo.Size = new System.Drawing.Size(121, 38);
            this.Search_Combo.TabIndex = 20;
            this.Search_Combo.Text = "도서명";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(130, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(684, 50);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ComeBack
            // 
            this.ComeBack.Image = ((System.Drawing.Image)(resources.GetObject("ComeBack.Image")));
            this.ComeBack.Location = new System.Drawing.Point(-6, 39);
            this.ComeBack.Name = "ComeBack";
            this.ComeBack.Size = new System.Drawing.Size(144, 87);
            this.ComeBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComeBack.TabIndex = 22;
            this.ComeBack.TabStop = false;
            this.ComeBack.Click += new System.EventHandler(this.ComeBack_Click);
            // 
            // BookSearch
            // 
            this.BookSearch.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BookSearch.Location = new System.Drawing.Point(264, 61);
            this.BookSearch.Multiline = true;
            this.BookSearch.Name = "BookSearch";
            this.BookSearch.Size = new System.Drawing.Size(493, 38);
            this.BookSearch.TabIndex = 23;
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.Color.Tan;
            this.Search_Button.Image = ((System.Drawing.Image)(resources.GetObject("Search_Button.Image")));
            this.Search_Button.Location = new System.Drawing.Point(758, 63);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(54, 34);
            this.Search_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Search_Button.TabIndex = 25;
            this.Search_Button.TabStop = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BookList);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 643);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서목록";
            // 
            // PutBasket_Button
            // 
            this.PutBasket_Button.BackColor = System.Drawing.Color.BurlyWood;
            this.PutBasket_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PutBasket_Button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PutBasket_Button.ForeColor = System.Drawing.Color.White;
            this.PutBasket_Button.Location = new System.Drawing.Point(868, 205);
            this.PutBasket_Button.Name = "PutBasket_Button";
            this.PutBasket_Button.Size = new System.Drawing.Size(173, 54);
            this.PutBasket_Button.TabIndex = 27;
            this.PutBasket_Button.Text = "장바구니에 담기";
            this.PutBasket_Button.UseVisualStyleBackColor = false;
            this.PutBasket_Button.Click += new System.EventHandler(this.PutBasket_Button_Click);
            // 
            // Purchase_Button
            // 
            this.Purchase_Button.BackColor = System.Drawing.Color.BurlyWood;
            this.Purchase_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purchase_Button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Purchase_Button.ForeColor = System.Drawing.Color.White;
            this.Purchase_Button.Location = new System.Drawing.Point(868, 136);
            this.Purchase_Button.Name = "Purchase_Button";
            this.Purchase_Button.Size = new System.Drawing.Size(173, 54);
            this.Purchase_Button.TabIndex = 28;
            this.Purchase_Button.Text = "바로주문";
            this.Purchase_Button.UseVisualStyleBackColor = false;
            this.Purchase_Button.Click += new System.EventHandler(this.Purchase_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(835, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 491);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "이 달의 도서";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(17, 335);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(203, 143);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "엄마 복희는 딸 슬아의 인생에 그 어떤 간섭도, 거짓말도, 잔소리도, 허황된 희망도 말하지 않는다. 그저 삶을 씩씩하게 견디고 살아내는 딸에게 \'" +
    "나는 그저 영원한 짝사랑을 하고 있어\'라고 애틋한 말을 속삭여줄 뿐인데...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 50);
            this.label1.TabIndex = 30;
            this.label1.Text = "\"나는 울 때마다\r\n     엄마 얼굴이 된다.\"";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 212);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(205, 235);
            this.dataGridView2.TabIndex = 19;
            // 
            // Wellcome_Label
            // 
            this.Wellcome_Label.AutoSize = true;
            this.Wellcome_Label.Location = new System.Drawing.Point(833, 72);
            this.Wellcome_Label.Name = "Wellcome_Label";
            this.Wellcome_Label.Size = new System.Drawing.Size(97, 12);
            this.Wellcome_Label.TabIndex = 29;
            this.Wellcome_Label.Text = "Wellcome_Label";
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AdminButton.ForeColor = System.Drawing.Color.White;
            this.AdminButton.Location = new System.Drawing.Point(746, 8);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(83, 23);
            this.AdminButton.TabIndex = 30;
            this.AdminButton.Text = "관리자 창";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // 메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 781);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.Wellcome_Label);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PutBasket_Button);
            this.Controls.Add(this.Purchase_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.BookSearch);
            this.Controls.Add(this.Search_Combo);
            this.Controls.Add(this.MemberInfo_Botton);
            this.Controls.Add(this.PurchaseList_Button);
            this.Controls.Add(this.Basket_Button);
            this.Controls.Add(this.Join_Button);
            this.Controls.Add(this.Pw_Box);
            this.Controls.Add(this.Id_Box);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComeBack);
            this.Name = "메인";
            this.Text = "메인";
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComeBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Button)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Pw_Box;
        private System.Windows.Forms.TextBox Id_Box;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button MemberInfo_Botton;
        private System.Windows.Forms.Button PurchaseList_Button;
        private System.Windows.Forms.Button Basket_Button;
        private System.Windows.Forms.Button Join_Button;
        private System.Windows.Forms.DataGridView BookList;
        private System.Windows.Forms.ComboBox Search_Combo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox ComeBack;
        private System.Windows.Forms.TextBox BookSearch;
        private System.Windows.Forms.PictureBox Search_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PutBasket_Button;
        private System.Windows.Forms.Button Purchase_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Wellcome_Label;
        private System.Windows.Forms.Button AdminButton;
    }
}