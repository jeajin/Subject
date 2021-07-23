namespace jaejin_DB
{
    partial class 회원가입
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
            System.Windows.Forms.Panel panel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(회원가입));
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Join_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.개인정보_Check = new System.Windows.Forms.CheckBox();
            this.이용약관_Check = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Duplicate_Button = new System.Windows.Forms.Button();
            this.Join_Question = new System.Windows.Forms.ComboBox();
            this.Join_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Join_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Join_Answer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Join_Pw2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Join_Pw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Join_Identity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Join_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(this.Cancel_Button);
            panel2.Controls.Add(this.Join_Button);
            panel2.Controls.Add(this.groupBox1);
            panel2.Location = new System.Drawing.Point(-3, 64);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(417, 1064);
            panel2.TabIndex = 8;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.Tan;
            this.Cancel_Button.FlatAppearance.BorderSize = 0;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.Location = new System.Drawing.Point(216, 1012);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(189, 40);
            this.Cancel_Button.TabIndex = 24;
            this.Cancel_Button.Text = "취소";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Join_Button
            // 
            this.Join_Button.BackColor = System.Drawing.Color.Tan;
            this.Join_Button.FlatAppearance.BorderSize = 0;
            this.Join_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Join_Button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join_Button.ForeColor = System.Drawing.Color.White;
            this.Join_Button.Location = new System.Drawing.Point(15, 1012);
            this.Join_Button.Name = "Join_Button";
            this.Join_Button.Size = new System.Drawing.Size(192, 40);
            this.Join_Button.TabIndex = 24;
            this.Join_Button.Text = "회원가입";
            this.Join_Button.UseVisualStyleBackColor = false;
            this.Join_Button.Click += new System.EventHandler(this.Join_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.개인정보_Check);
            this.groupBox1.Controls.Add(this.이용약관_Check);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(15, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "약관 동의";
            // 
            // 개인정보_Check
            // 
            this.개인정보_Check.AutoSize = true;
            this.개인정보_Check.Location = new System.Drawing.Point(9, 171);
            this.개인정보_Check.Name = "개인정보_Check";
            this.개인정보_Check.Size = new System.Drawing.Size(413, 25);
            this.개인정보_Check.TabIndex = 4;
            this.개인정보_Check.Text = "개인정보 \"필수\" 항목에 대한 수집과 이용 동의(필수)";
            this.개인정보_Check.UseVisualStyleBackColor = true;
            // 
            // 이용약관_Check
            // 
            this.이용약관_Check.AutoSize = true;
            this.이용약관_Check.Location = new System.Drawing.Point(9, 32);
            this.이용약관_Check.Name = "이용약관_Check";
            this.이용약관_Check.Size = new System.Drawing.Size(213, 25);
            this.이용약관_Check.TabIndex = 3;
            this.이용약관_Check.Text = "\"이용 약관\"에 동의(필수)";
            this.이용약관_Check.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(9, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(373, 96);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(9, 202);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(373, 101);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Duplicate_Button);
            this.groupBox2.Controls.Add(this.Join_Question);
            this.groupBox2.Controls.Add(this.Join_PhoneNumber);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Join_Email);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Join_Answer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Join_Pw2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Join_Pw);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Join_Identity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Join_Name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 657);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "정보 입력";
            // 
            // Duplicate_Button
            // 
            this.Duplicate_Button.BackColor = System.Drawing.Color.Tan;
            this.Duplicate_Button.FlatAppearance.BorderSize = 0;
            this.Duplicate_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Duplicate_Button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Duplicate_Button.ForeColor = System.Drawing.Color.White;
            this.Duplicate_Button.Location = new System.Drawing.Point(260, 143);
            this.Duplicate_Button.Name = "Duplicate_Button";
            this.Duplicate_Button.Size = new System.Drawing.Size(122, 27);
            this.Duplicate_Button.TabIndex = 24;
            this.Duplicate_Button.Text = "중복확인";
            this.Duplicate_Button.UseVisualStyleBackColor = false;
            this.Duplicate_Button.Click += new System.EventHandler(this.Duplicate_Button_Click);
            // 
            // Join_Question
            // 
            this.Join_Question.FormattingEnabled = true;
            this.Join_Question.Items.AddRange(new object[] {
            "오늘 아침에 먹은 음식은?"});
            this.Join_Question.Location = new System.Drawing.Point(19, 374);
            this.Join_Question.Name = "Join_Question";
            this.Join_Question.Size = new System.Drawing.Size(363, 29);
            this.Join_Question.TabIndex = 7;
            // 
            // Join_PhoneNumber
            // 
            this.Join_PhoneNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Join_PhoneNumber.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join_PhoneNumber.Location = new System.Drawing.Point(19, 605);
            this.Join_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Join_PhoneNumber.Name = "Join_PhoneNumber";
            this.Join_PhoneNumber.Size = new System.Drawing.Size(363, 27);
            this.Join_PhoneNumber.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(8, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "전화번호";
            // 
            // Join_Email
            // 
            this.Join_Email.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Join_Email.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join_Email.Location = new System.Drawing.Point(19, 528);
            this.Join_Email.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Join_Email.Name = "Join_Email";
            this.Join_Email.Size = new System.Drawing.Size(363, 27);
            this.Join_Email.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(12, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "이메일";
            // 
            // Join_Answer
            // 
            this.Join_Answer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Join_Answer.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join_Answer.Location = new System.Drawing.Point(19, 451);
            this.Join_Answer.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Join_Answer.Name = "Join_Answer";
            this.Join_Answer.Size = new System.Drawing.Size(363, 27);
            this.Join_Answer.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "아이디 찾기 질문 정답";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "아이디 찾기 때 사용할 질문 선택";
            // 
            // Join_Pw2
            // 
            this.Join_Pw2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Join_Pw2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join_Pw2.Location = new System.Drawing.Point(19, 297);
            this.Join_Pw2.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Join_Pw2.Name = "Join_Pw2";
            this.Join_Pw2.Size = new System.Drawing.Size(363, 27);
            this.Join_Pw2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "비밀번호 확인";
            // 
            // Join_Pw
            // 
            this.Join_Pw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Join_Pw.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join_Pw.Location = new System.Drawing.Point(19, 220);
            this.Join_Pw.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Join_Pw.Name = "Join_Pw";
            this.Join_Pw.Size = new System.Drawing.Size(363, 27);
            this.Join_Pw.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "비밀번호";
            // 
            // Join_Identity
            // 
            this.Join_Identity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Join_Identity.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join_Identity.Location = new System.Drawing.Point(19, 143);
            this.Join_Identity.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Join_Identity.Name = "Join_Identity";
            this.Join_Identity.Size = new System.Drawing.Size(234, 27);
            this.Join_Identity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "아이디";
            // 
            // Join_Name
            // 
            this.Join_Name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Join_Name.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join_Name.Location = new System.Drawing.Point(19, 66);
            this.Join_Name.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Join_Name.Name = "Join_Name";
            this.Join_Name.Size = new System.Drawing.Size(363, 27);
            this.Join_Name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // 회원가입
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(430, 872);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(panel2);
            this.Name = "회원가입";
            this.Text = "회원가입";
            panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Join_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Join_Pw2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Join_Pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Join_Identity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Join_Question;
        private System.Windows.Forms.TextBox Join_Answer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Join_PhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Join_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Join_Button;
        private System.Windows.Forms.Button Duplicate_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.CheckBox 개인정보_Check;
        private System.Windows.Forms.CheckBox 이용약관_Check;
    }
}

