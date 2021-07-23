namespace jaejin_DB
{
    partial class 주문정보
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
            this.InfoName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.수취완료 = new System.Windows.Forms.Button();
            this.purchase_book_List = new System.Windows.Forms.DataGridView();
            this.Addr = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.TextBox();
            this.Card = new System.Windows.Forms.TextBox();
            this.purchase_date = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.DataGridView();
            this.주문취소 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_book_List)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoName
            // 
            this.InfoName.AutoSize = true;
            this.InfoName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InfoName.Location = new System.Drawing.Point(725, 21);
            this.InfoName.Name = "InfoName";
            this.InfoName.Size = new System.Drawing.Size(66, 17);
            this.InfoName.TabIndex = 23;
            this.InfoName.Text = "         님";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.OrderList);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 616);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문정보";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.주문취소);
            this.panel4.Controls.Add(this.수취완료);
            this.panel4.Controls.Add(this.purchase_book_List);
            this.panel4.Controls.Add(this.Addr);
            this.panel4.Controls.Add(this.state);
            this.panel4.Controls.Add(this.Sum);
            this.panel4.Controls.Add(this.Card);
            this.panel4.Controls.Add(this.purchase_date);
            this.panel4.Controls.Add(this.code);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(15, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 299);
            this.panel4.TabIndex = 26;
            // 
            // 수취완료
            // 
            this.수취완료.BackColor = System.Drawing.Color.Tan;
            this.수취완료.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.수취완료.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.수취완료.ForeColor = System.Drawing.Color.White;
            this.수취완료.Location = new System.Drawing.Point(562, 269);
            this.수취완료.Name = "수취완료";
            this.수취완료.Size = new System.Drawing.Size(91, 28);
            this.수취완료.TabIndex = 33;
            this.수취완료.Text = "수취확인";
            this.수취완료.UseVisualStyleBackColor = false;
            this.수취완료.Click += new System.EventHandler(this.수취완료_Click);
            // 
            // purchase_book_List
            // 
            this.purchase_book_List.AllowUserToOrderColumns = true;
            this.purchase_book_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchase_book_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.purchase_book_List.BackgroundColor = System.Drawing.Color.Moccasin;
            this.purchase_book_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchase_book_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchase_book_List.Location = new System.Drawing.Point(102, 66);
            this.purchase_book_List.Name = "purchase_book_List";
            this.purchase_book_List.RowTemplate.Height = 23;
            this.purchase_book_List.Size = new System.Drawing.Size(648, 110);
            this.purchase_book_List.TabIndex = 22;
            // 
            // Addr
            // 
            this.Addr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Addr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Addr.Cursor = System.Windows.Forms.Cursors.Default;
            this.Addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Addr.HideSelection = false;
            this.Addr.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Addr.Location = new System.Drawing.Point(102, 211);
            this.Addr.Multiline = true;
            this.Addr.Name = "Addr";
            this.Addr.ReadOnly = true;
            this.Addr.Size = new System.Drawing.Size(648, 27);
            this.Addr.TabIndex = 21;
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.state.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.state.Cursor = System.Windows.Forms.Cursors.Default;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.state.HideSelection = false;
            this.state.ImeMode = System.Windows.Forms.ImeMode.On;
            this.state.Location = new System.Drawing.Point(102, 269);
            this.state.Multiline = true;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Size = new System.Drawing.Size(464, 27);
            this.state.TabIndex = 21;
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sum.Cursor = System.Windows.Forms.Cursors.Default;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sum.HideSelection = false;
            this.Sum.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Sum.Location = new System.Drawing.Point(102, 240);
            this.Sum.Multiline = true;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Size = new System.Drawing.Size(648, 27);
            this.Sum.TabIndex = 21;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Card.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Card.Cursor = System.Windows.Forms.Cursors.Default;
            this.Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Card.HideSelection = false;
            this.Card.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Card.Location = new System.Drawing.Point(102, 182);
            this.Card.Multiline = true;
            this.Card.Name = "Card";
            this.Card.ReadOnly = true;
            this.Card.Size = new System.Drawing.Size(648, 27);
            this.Card.TabIndex = 21;
            // 
            // purchase_date
            // 
            this.purchase_date.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.purchase_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchase_date.Cursor = System.Windows.Forms.Cursors.Default;
            this.purchase_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.purchase_date.HideSelection = false;
            this.purchase_date.ImeMode = System.Windows.Forms.ImeMode.On;
            this.purchase_date.Location = new System.Drawing.Point(101, 33);
            this.purchase_date.Multiline = true;
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.ReadOnly = true;
            this.purchase_date.Size = new System.Drawing.Size(648, 27);
            this.purchase_date.TabIndex = 21;
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Cursor = System.Windows.Forms.Cursors.Default;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.code.HideSelection = false;
            this.code.ImeMode = System.Windows.Forms.ImeMode.On;
            this.code.Location = new System.Drawing.Point(101, 4);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Size = new System.Drawing.Size(648, 27);
            this.code.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tan;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label25);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 296);
            this.panel5.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(6, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 2);
            this.label12.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(6, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 2);
            this.label10.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 2);
            this.label2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(6, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 2);
            this.label8.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 2);
            this.label4.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(6, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 2);
            this.label22.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(21, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "주문상태";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "결제 금액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(32, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "배송지";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(17, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "카드정보";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(17, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "주문상품";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(17, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "주문일자";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(17, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "주문번호";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(15, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(767, 2);
            this.label6.TabIndex = 25;
            // 
            // OrderList
            // 
            this.OrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.OrderList.BackgroundColor = System.Drawing.Color.Moccasin;
            this.OrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderList.Location = new System.Drawing.Point(15, 28);
            this.OrderList.Name = "OrderList";
            this.OrderList.RowTemplate.Height = 23;
            this.OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderList.Size = new System.Drawing.Size(764, 259);
            this.OrderList.TabIndex = 19;
            this.OrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderList_CellContentClick);
            // 
            // 주문취소
            // 
            this.주문취소.BackColor = System.Drawing.Color.Tan;
            this.주문취소.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.주문취소.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.주문취소.ForeColor = System.Drawing.Color.White;
            this.주문취소.Location = new System.Drawing.Point(658, 270);
            this.주문취소.Name = "주문취소";
            this.주문취소.Size = new System.Drawing.Size(91, 28);
            this.주문취소.TabIndex = 34;
            this.주문취소.Text = "주문취소";
            this.주문취소.UseVisualStyleBackColor = false;
            this.주문취소.Click += new System.EventHandler(this.주문취소_Click);
            // 
            // 주문정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 669);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoName);
            this.Name = "주문정보";
            this.Text = "주문정보";
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_book_List)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InfoName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView OrderList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView purchase_book_List;
        private System.Windows.Forms.TextBox Addr;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.TextBox Card;
        private System.Windows.Forms.TextBox purchase_date;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button 수취완료;
        private System.Windows.Forms.Button 주문취소;
    }
}