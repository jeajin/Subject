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
    public partial class 장바구니 : Form
    {
        public Move_Data_One Or;
        public Move_Data_Two Move_Data_IdName;
        public Move_Book Move_Book_Data;
        public DataGridViewRow[] BookGrid;
        OleDbConnection connector;
        string connString;
        string User_Identity;
        string User_Name;
        int BookNum;
        string BasketCode;

        public 장바구니()
        {
            InitializeComponent();
            DB_Link();
        }
        public void BasketListUpdate()
        {
            Basket_LIst.Rows.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from basket where identity  ='" + User_Identity + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            OleDbDataReader read = cmd.ExecuteReader();
            Basket_LIst.ColumnCount = 2;

            Basket_LIst.Columns[0].Name = "장바구니";
            Basket_LIst.Columns[1].Name = "생성일자";

            while (read.Read())
            {
                object[] obj = new object[2];
                obj[0] = new object();
                obj[1] = new object();
                obj[0] = read.GetValue(0);
                obj[1] = read.GetValue(1).ToString().Substring(0, 10);
                Basket_LIst.Rows.Add(obj);
                BasketCode = Basket_LIst.Rows[0].Cells[0].Value.ToString();
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
            BasketListUpdate();
            Basket_Select_LIst_Update();
        }

        private void Basket_LIst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                BasketCode = Basket_LIst.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            Basket_Select_LIst_Update();
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

        private void Basket_Insert_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "insert into basket values(to_char(B_N.nextval,'FM000'),sysdate,'" + User_Identity + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            cmd.ExecuteNonQuery();
            BasketListUpdate();
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
            BookNum = 0;
            while (read.Read())
            {
                object[] obj = new object[3];
                for (int i = 0; i < 3; i++)
                {
                    obj[i] = new object();
                    obj[i] = read.GetValue(i);
                }
                Basket_Select_LIst.Rows.Add(obj);
                BookNum++;
            }
            read.Close();
        }

        private void Purchase_Button_Click(object sender, EventArgs e)
        {          
            BookGrid = new DataGridViewRow[BookNum];
            for (int i = 0; i < BookNum; i++)
            {               
                BookGrid[i] = Basket_Select_LIst.Rows[i];
            }
            바로주문 Order = new 바로주문();
            this.Or += new Move_Data_One(Order.Basket);
            this.Move_Book_Data = new Move_Book(Order.Getbook);
            this.Move_Data_IdName = new Move_Data_Two(Order.Get_IdName);
            Or(BasketCode);
            Move_Data_IdName(User_Identity, User_Name);
            Move_Book_Data(BookGrid, BookNum);
            Order.Show();
            this.Hide();
        }
    }
}
