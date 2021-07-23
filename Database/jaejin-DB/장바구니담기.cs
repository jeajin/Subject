using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace jaejin_DB
{
    public partial class 장바구니담기 : Form
    {
        OleDbConnection connector;
        string connString;
        string User_Identity;
        string User_Name;
        string BasketCode;
        public DataGridViewRow[] BookGrid;
        int BookNum;
        public 장바구니담기()
        {
            InitializeComponent();
            DB_Link();           
        }
        private void BookListUpdate()
        {
            BookList.ColumnCount = 5;
            BookList.Columns[0].Name = "도서명";
            BookList.Columns[1].Name = "재고량";
            BookList.Columns[2].Name = "가격";
            BookList.Columns[3].Name = "도서번호";
            BookList.Columns[4].Name = "구매량";

            for (int i = 0; i < BookNum; i++)
            {
                object[] tmp = new object[BookList.ColumnCount];
                for (int j = 0; j < BookList.ColumnCount - 1; j++)
                {
                    tmp[j] = new object();
                    tmp[j] = BookGrid[i].Cells[j].Value.ToString();
                }
                tmp[BookList.ColumnCount - 1] = "미정";
                BookList.Rows.Add(tmp);
            }
        }
        public void BasketListUpdate()
        {
            Basket_LIst.Rows.Clear();
            Basket_Num.Items.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from basket where identity  ='" + User_Identity + "'"; 
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            OleDbDataReader read = cmd.ExecuteReader();
            Basket_LIst.ColumnCount = 2;
            int j = 0;
       
            Basket_LIst.Columns[0].Name = "장바구니";
            Basket_LIst.Columns[1].Name = "생성일자";
        
            while (read.Read())
            {   
                object[] obj = new object[2];     
                obj[0] = new object();
                obj[1] = new object();
                obj[0] = read.GetValue(0);
                obj[1] = read.GetValue(1).ToString().Substring(0,10);
                Basket_LIst.Rows.Add(obj); 
                Basket_Num.Items.Add(Basket_LIst.Rows[j++].Cells[0].Value.ToString());
                BasketCode = Basket_LIst.Rows[0].Cells[0].Value.ToString();
                Basket_Num.Text = BasketCode;
            }
            
            read.Close();

        }
        private void DB_Link()
        {
            connString = "Provider=OraOLEDB.Oracle;Password=sbvmfhs5;User ID=jaejin";
            connector = new OleDbConnection(connString);
            connector.Open();
        }
        public void Get_IdName(string Identity, string Name)
        {
            User_Identity = Identity;
            User_Name = Name;
        }
        public void Getbook(DataGridViewRow[] BookGrid, int BookNum)
        {
            this.BookGrid = BookGrid;
            this.BookNum = BookNum;
            BookListUpdate();
            BookCount.Text = "1";
            for (int i = 1; i <= Int32.Parse(BookList.Rows[0].Cells[2].Value.ToString()); i++)
            {
                BookCount.Items.Add(i.ToString());
            }
            BasketListUpdate();
        }

        private void BookCount_Button_Click(object sender, EventArgs e)
        {       
            BookList.SelectedRows[0].Cells[4].Value = BookCount.Text;         
        }

        private void BookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                BookCount.Items.Clear();          
                for (int i = 1; i <= Int32.Parse(BookList.Rows[e.RowIndex].Cells[2].Value.ToString()) ; i++)
                {
                   BookCount.Items.Add(i.ToString());
                }
                if (BookList.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("미정"))
                {
                    BookCount.Text = "1";
                }
                else
                {
                    BookCount.Text = BookList.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }

        private void Basket_Insert_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "insert into basket values(to_char(B_N.nextval,'FM000'),sysdate,'" + User_Identity + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            cmd.ExecuteNonQuery();
            BasketListUpdate();
        }

        private void Basket_Delete_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "DELETE FROM basket WHERE identity = '" + User_Identity + "' and code =" + Int32.Parse(BasketCode);
            cmd.CommandType = CommandType.Text; 
            cmd.Connection = connector;
            cmd.ExecuteNonQuery();
            MessageBox.Show("장바구니를 삭제 했습니다.");
            BasketListUpdate();
            Basket_Select_LIst_Update();
        }

        private void Basket_LIst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                BasketCode = Basket_LIst.Rows[e.RowIndex].Cells[0].Value.ToString();
                Basket_Num.Text = BasketCode;
            }
            Basket_Select_LIst_Update();
        }
        private void Basket_Num_Button_Click(object sender, EventArgs e)
        {
            bool All_seletion = true;
            for(int i = 0; i < BookNum; i++)
            {
                if (BookList.Rows[i].Cells[4].Value.ToString().Equals("미정"))
                {
                    All_seletion = false;
                    break;
                }
            }
            if (All_seletion)
            {
                BasketCode = Basket_Num.Text.ToString();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from basket_selection  where code  ='" + BasketCode + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.Read()) { MessageBox.Show("장바구니에 이미 도서가 추가되었습니다.\n새로운 장바구니를 생성해주세요"); }
                else
                {
                    read.Close();
                    for (int i = 0; i < BookNum; i++)
                    {
                        cmd.CommandText = "insert into basket_selection  values('" + Int32.Parse(BasketCode) + "','" + BookList.Rows[i].Cells[3].Value.ToString() + "'," + Int32.Parse(BookList.Rows[i].Cells[4].Value.ToString()) + ")";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connector;
                        cmd.ExecuteNonQuery();
                    }
                }
                Basket_Select_LIst_Update();
            }
            else  MessageBox.Show("모든 도서의 구매량을 선택해 주세요.");

        }
        public void Basket_Select_LIst_Update()
        {
            Basket_Select_LIst.Rows.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from basket_selection  where code  ='" + BasketCode + "'"; 
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            OleDbDataReader read = cmd.ExecuteReader();
            Basket_Select_LIst.ColumnCount = 3;
           
            Basket_Select_LIst.Columns[0].Name = "장바구니";
            Basket_Select_LIst.Columns[1].Name = read.GetName(1);
            Basket_Select_LIst.Columns[2].Name = "구매량";
            while (read.Read())
            {
                object[] obj = new object[3]; 
                for (int i = 0; i < 3; i++) 
                {
                    obj[i] = new object();
                    obj[i] = read.GetValue(i); 
                }
                Basket_Select_LIst.Rows.Add(obj); 
            }
            read.Close();
        }
    }
}
