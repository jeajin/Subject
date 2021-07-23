namespace jaejin_DB
{
    partial class 회원탈퇴
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(회원탈퇴));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Confirm_Check = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pw = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Widthdraw_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.Confirm_Check);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "탈퇴안내";
            // 
            // Confirm_Check
            // 
            this.Confirm_Check.AutoSize = true;
            this.Confirm_Check.ForeColor = System.Drawing.Color.Red;
            this.Confirm_Check.Location = new System.Drawing.Point(277, 128);
            this.Confirm_Check.Name = "Confirm_Check";
            this.Confirm_Check.Size = new System.Drawing.Size(108, 21);
            this.Confirm_Check.TabIndex = 4;
            this.Confirm_Check.Text = "확인했습니다.";
            this.Confirm_Check.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(373, 96);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(63, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 40);
            this.label2.TabIndex = 33;
            this.label2.Text = "본인 확인을 위해 비밀번호를 입력한 후,\r\n\"탈퇴확인\" 버튼을 눌러주세요.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pw
            // 
            this.Pw.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Pw.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Pw.Location = new System.Drawing.Point(12, 109);
            this.Pw.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Pw.Name = "Pw";
            this.Pw.Size = new System.Drawing.Size(245, 27);
            this.Pw.TabIndex = 32;
            this.Pw.Text = "비밀번호 입력";
            this.Pw.UseWaitCursor = true;
            this.Pw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pw_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox2.Controls.Add(this.Widthdraw_Button);
            this.groupBox2.Controls.Add(this.Pw);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(6, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 158);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "본인 확인";
            // 
            // Widthdraw_Button
            // 
            this.Widthdraw_Button.BackColor = System.Drawing.Color.Tan;
            this.Widthdraw_Button.FlatAppearance.BorderSize = 0;
            this.Widthdraw_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Widthdraw_Button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Widthdraw_Button.ForeColor = System.Drawing.Color.White;
            this.Widthdraw_Button.Location = new System.Drawing.Point(263, 109);
            this.Widthdraw_Button.Name = "Widthdraw_Button";
            this.Widthdraw_Button.Size = new System.Drawing.Size(122, 27);
            this.Widthdraw_Button.TabIndex = 34;
            this.Widthdraw_Button.Text = "탈퇴확인";
            this.Widthdraw_Button.UseVisualStyleBackColor = false;
            this.Widthdraw_Button.Click += new System.EventHandler(this.Widthdraw_Button_Click);
            // 
            // 회원탈퇴
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(404, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "회원탈퇴";
            this.Text = "회원탈퇴";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Confirm_Check;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Widthdraw_Button;
    }
}