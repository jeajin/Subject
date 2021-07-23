namespace jaejin_DB
{
    partial class 회원정보
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
            this.CP_Button = new System.Windows.Forms.Button();
            this.InfoName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Withdraw_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Card_Button = new System.Windows.Forms.Button();
            this.Address_Button = new System.Windows.Forms.Button();
            this.PurchaseList_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CP_Button
            // 
            this.CP_Button.BackColor = System.Drawing.Color.Tan;
            this.CP_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CP_Button.ForeColor = System.Drawing.Color.White;
            this.CP_Button.Location = new System.Drawing.Point(63, 37);
            this.CP_Button.Name = "CP_Button";
            this.CP_Button.Size = new System.Drawing.Size(111, 29);
            this.CP_Button.TabIndex = 21;
            this.CP_Button.Text = "개인정보수정";
            this.CP_Button.UseVisualStyleBackColor = false;
            this.CP_Button.Click += new System.EventHandler(this.CP_Button_Click);
            // 
            // InfoName
            // 
            this.InfoName.AutoSize = true;
            this.InfoName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InfoName.Location = new System.Drawing.Point(193, 19);
            this.InfoName.Name = "InfoName";
            this.InfoName.Size = new System.Drawing.Size(66, 17);
            this.InfoName.TabIndex = 22;
            this.InfoName.Text = "         님";
            this.InfoName.Click += new System.EventHandler(this.InfoName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Withdraw_Button);
            this.groupBox1.Controls.Add(this.CP_Button);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(18, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 119);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원정보관리";
            // 
            // Withdraw_Button
            // 
            this.Withdraw_Button.BackColor = System.Drawing.Color.Tan;
            this.Withdraw_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Withdraw_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Withdraw_Button.ForeColor = System.Drawing.Color.White;
            this.Withdraw_Button.Location = new System.Drawing.Point(63, 72);
            this.Withdraw_Button.Name = "Withdraw_Button";
            this.Withdraw_Button.Size = new System.Drawing.Size(111, 29);
            this.Withdraw_Button.TabIndex = 21;
            this.Withdraw_Button.Text = "회원탈퇴";
            this.Withdraw_Button.UseVisualStyleBackColor = false;
            this.Withdraw_Button.Click += new System.EventHandler(this.Withdraw_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Card_Button);
            this.groupBox2.Controls.Add(this.Address_Button);
            this.groupBox2.Controls.Add(this.PurchaseList_Button);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(18, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 148);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주문 관리";
            // 
            // Card_Button
            // 
            this.Card_Button.BackColor = System.Drawing.Color.Tan;
            this.Card_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Card_Button.ForeColor = System.Drawing.Color.White;
            this.Card_Button.Location = new System.Drawing.Point(64, 104);
            this.Card_Button.Name = "Card_Button";
            this.Card_Button.Size = new System.Drawing.Size(111, 29);
            this.Card_Button.TabIndex = 21;
            this.Card_Button.Text = "카드 정보";
            this.Card_Button.UseVisualStyleBackColor = false;
            this.Card_Button.Click += new System.EventHandler(this.Card_Button_Click);
            // 
            // Address_Button
            // 
            this.Address_Button.BackColor = System.Drawing.Color.Tan;
            this.Address_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Address_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Address_Button.ForeColor = System.Drawing.Color.White;
            this.Address_Button.Location = new System.Drawing.Point(64, 69);
            this.Address_Button.Name = "Address_Button";
            this.Address_Button.Size = new System.Drawing.Size(111, 29);
            this.Address_Button.TabIndex = 21;
            this.Address_Button.Text = "배송지 정보";
            this.Address_Button.UseVisualStyleBackColor = false;
            this.Address_Button.Click += new System.EventHandler(this.Address_Button_Click);
            // 
            // PurchaseList_Button
            // 
            this.PurchaseList_Button.BackColor = System.Drawing.Color.Tan;
            this.PurchaseList_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseList_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PurchaseList_Button.ForeColor = System.Drawing.Color.White;
            this.PurchaseList_Button.Location = new System.Drawing.Point(64, 34);
            this.PurchaseList_Button.Name = "PurchaseList_Button";
            this.PurchaseList_Button.Size = new System.Drawing.Size(111, 29);
            this.PurchaseList_Button.TabIndex = 21;
            this.PurchaseList_Button.Text = "주문 정보";
            this.PurchaseList_Button.UseVisualStyleBackColor = false;
            this.PurchaseList_Button.Click += new System.EventHandler(this.PurchaseList_Button_Click);
            // 
            // 회원정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(279, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoName);
            this.Name = "회원정보";
            this.Text = "회원정보";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CP_Button;
        private System.Windows.Forms.Label InfoName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Address_Button;
        private System.Windows.Forms.Button PurchaseList_Button;
        private System.Windows.Forms.Button Withdraw_Button;
        private System.Windows.Forms.Button Card_Button;
    }
}