namespace jaejin_DB
{
    partial class 장바구니
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Basket_Select_LIst = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Basket_Delete_Button = new System.Windows.Forms.Button();
            this.Basket_Insert_Button = new System.Windows.Forms.Button();
            this.Basket_LIst = new System.Windows.Forms.DataGridView();
            this.Purchase_Button = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Basket_Select_LIst)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Basket_LIst)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Basket_Select_LIst);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox3.Location = new System.Drawing.Point(300, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 317);
            this.groupBox3.TabIndex = 42;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Purchase_Button);
            this.groupBox2.Controls.Add(this.Basket_Delete_Button);
            this.groupBox2.Controls.Add(this.Basket_Insert_Button);
            this.groupBox2.Controls.Add(this.Basket_LIst);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(18, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 317);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "장바구니 리스트";
            // 
            // Basket_Delete_Button
            // 
            this.Basket_Delete_Button.BackColor = System.Drawing.Color.Tan;
            this.Basket_Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Basket_Delete_Button.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Basket_Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Basket_Delete_Button.Location = new System.Drawing.Point(15, 287);
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
            this.Basket_Insert_Button.Location = new System.Drawing.Point(15, 250);
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
            this.Basket_LIst.Size = new System.Drawing.Size(259, 216);
            this.Basket_LIst.TabIndex = 19;
            this.Basket_LIst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Basket_LIst_CellContentClick);
            // 
            // Purchase_Button
            // 
            this.Purchase_Button.BackColor = System.Drawing.Color.BurlyWood;
            this.Purchase_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purchase_Button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Purchase_Button.ForeColor = System.Drawing.Color.White;
            this.Purchase_Button.Location = new System.Drawing.Point(146, 250);
            this.Purchase_Button.Name = "Purchase_Button";
            this.Purchase_Button.Size = new System.Drawing.Size(130, 67);
            this.Purchase_Button.TabIndex = 40;
            this.Purchase_Button.Text = "바로주문";
            this.Purchase_Button.UseVisualStyleBackColor = false;
            this.Purchase_Button.Click += new System.EventHandler(this.Purchase_Button_Click);
            // 
            // 장바구니
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 343);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "장바구니";
            this.Text = "장바구니";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Basket_Select_LIst)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Basket_LIst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Basket_Select_LIst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Basket_Delete_Button;
        private System.Windows.Forms.Button Basket_Insert_Button;
        private System.Windows.Forms.DataGridView Basket_LIst;
        private System.Windows.Forms.Button Purchase_Button;
    }
}