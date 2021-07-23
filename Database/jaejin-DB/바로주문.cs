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
    public partial class 바로주문 : Form
    {
        OleDbConnection connector;
        public Move_Data_Zero BookUpdateMain;
        string connString;
        string User_Identity;
        string User_Name;
        bool S_C;
        bool S_A;
        bool ToBasket;
        int BasketNum;
        public DataGridViewRow[] BookGrid;
        int BookNum;
        public 바로주문()
        {
            InitializeComponent();
            S_C = false;
            S_A = false;
            ToBasket = false;
            DB_Link();
        }
        private void BookListUpdate()
        {
            BookList.ColumnCount = 5;
            BookList.Columns[0].Name = "도서명";
            BookList.Columns[1].Name = "가격";
            BookList.Columns[2].Name = "재고량";
            BookList.Columns[3].Name = "도서번호";
            BookList.Columns[4].Name = "구매량";
            if (ToBasket) 
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader read;
                
                for (int i = 0; i < BookNum; i++)
                {
                    cmd.CommandText = "select * from book where isbn  ='" + BookGrid[i].Cells[1].Value.ToString() + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connector;
                    read = cmd.ExecuteReader();
                    while (read.Read()) 
                    {
                        object[] tmp = new object[BookList.ColumnCount];
                        for (int j = 0; j < BookList.ColumnCount - 1; j++)
                        {
                            tmp[j] = new object();
                            tmp[j] = read.GetValue(j);
                        }
                        tmp[BookList.ColumnCount - 1] = BookGrid[i].Cells[2].Value.ToString();
                        BookList.Rows.Add(tmp); 
                    }
                    read.Close();
                }
                int Sum = 0;
                for (int i = 0; i < BookNum; i++)
                {
                    if (!BookList.Rows[i].Cells[4].Value.ToString().Equals("미정"))
                    {
                        Sum += (Int32.Parse(BookList.Rows[i].Cells[1].Value.ToString()) * Int32.Parse(BookList.Rows[i].Cells[4].Value.ToString()));
                    }
                }
                SumMoney.Text = Sum.ToString();
            }
            else
            {
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
        }
        public void Basket(string BasketNum)
        {
            this.BasketNum = Int32.Parse(BasketNum);
            ToBasket = true;
        }
        private void AddressList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                S_A = true;
                if (AddressList.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("home"))
                {
                    Home.Checked = true;
                    // LocT = Loc = "home";
                }
                else
                {
                    Company.Checked = true;
                    // LocT = Loc = "company";
                }
                Postal_Code.Text = AddressList.Rows[e.RowIndex].Cells[1].Value.ToString();
                Basic_Addr.Text = AddressList.Rows[e.RowIndex].Cells[2].Value.ToString();
                Detail_Addr.Text = AddressList.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void CardList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                S_C = true;
                Code.Text = CardList.Rows[e.RowIndex].Cells[0].Value.ToString();
                valid_thru.Text = CardList.Rows[e.RowIndex].Cells[1].Value.ToString();
                type.Text = CardList.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
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
            UpdateAddr();
            UpdateCard();
            BookListUpdate();
            BookCount.Text = "1";
            if (!ToBasket)
            {
                for (int i = 1; i <= Int64.Parse(BookList.Rows[0].Cells[2].Value.ToString()); i++)
                {
                    BookCount.Items.Add(i.ToString());
                }
            }
        }

        private void UpdateCard()
        {
            try
            {
                CardList.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from card where identity ='" + User_Identity + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                CardList.ColumnCount = 3;

                CardList.Columns[0].Name = "카드번호";
                CardList.Columns[1].Name = "유효기간";
                CardList.Columns[2].Name = "종류";

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[3];

                    for (int i = 0; i < 3; i++)
                    {
                        obj[i] = new object();
                        if (i == 1) { obj[i] = read.GetValue(i).ToString().Substring(0, 10); }
                        else { obj[i] = read.GetValue(i); }
                    }
                    CardList.Rows.Add(obj);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateAddr()
        {
            try
            {
                AddressList.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from address where identity ='" + User_Identity + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                AddressList.ColumnCount = 4;

                AddressList.Columns[0].Name = "배송지";
                AddressList.Columns[1].Name = "우편번호";
                AddressList.Columns[2].Name = "주소";
                AddressList.Columns[3].Name = "상세주소";
                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[4];

                    for (int i = 0; i < 4; i++)
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i);
                    }
                    AddressList.Rows.Add(obj);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BookCount_Button_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            if(Int64.Parse(BookCount.Text)<= Int64.Parse(BookList.SelectedRows[0].Cells[2].Value.ToString()))
            BookList.SelectedRows[0].Cells[4].Value = BookCount.Text;
            for (int i = 0; i < BookNum; i++)
            {
                if (!BookList.Rows[i].Cells[4].Value.ToString().Equals("미정"))
                {
                    Sum += (Int32.Parse(BookList.Rows[i].Cells[1].Value.ToString()) * Int32.Parse(BookList.Rows[i].Cells[4].Value.ToString()));
                }
            }
            SumMoney.Text = Sum.ToString();
        }

        private void BookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                BookCount.Items.Clear();
                for (int i = 1; i <= Int64.Parse(BookList.Rows[e.RowIndex].Cells[2].Value.ToString()); i++)
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

        private void BackHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Purchase_Button_Click(object sender, EventArgs e)
        {
            bool All_seletion = true;
            for (int i = 0; i < BookNum; i++)
            {
                if (BookList.Rows[i].Cells[4].Value.ToString().Equals("미정"))
                {
                    All_seletion = false;
                    break;
                }
            }
            if (All_seletion && S_A && S_C)
            {
                string P_Code;
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO purchase  VALUES(to_char(P_N.nextval,'FM000'),sysdate," + Int64.Parse(SumMoney.Text.ToString()) +",'신청','" + Code.Text + "','" + valid_thru.Text.Substring(0, 10) + "','" + type.Text + "','" + Postal_Code.Text + "','" + Basic_Addr.Text + "','" + Detail_Addr.Text + "','" + User_Identity+"')";
                cmd.CommandType = CommandType.Text; 
                cmd.Connection = connector;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(code) from purchase";
                cmd.CommandType = CommandType.Text; 
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                //행 단위로 반복
                if (read.Read())
                {
                    P_Code= read.GetValue(0).ToString();
                    read.Close();
                    for (int i = 0; i < BookNum; i++)
                    {
                        cmd.CommandText = "insert into purchase_book   values('" + Int64.Parse(P_Code) + "','" + BookList.Rows[i].Cells[3].Value.ToString() + "'," + Int64.Parse(BookList.Rows[i].Cells[4].Value.ToString()) + ")";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connector;
                        cmd.ExecuteNonQuery();
                    }
                    if (ToBasket)
                    {
                        cmd.CommandText = "DELETE FROM basket WHERE code  = "+BasketNum;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connector;
                        cmd.ExecuteNonQuery();
                    }
                }
                this.Hide();
                MessageBox.Show("결제가 완료 되었습니다.");
                if(!ToBasket) BookUpdateMain();
               
            }
            if(!All_seletion) MessageBox.Show("모든 도서의 구매량을 선택해 주세요.");
            if (!S_A) MessageBox.Show("배송지를 선택해 주세요.");
            if (!S_C) MessageBox.Show("결제 카드를 선택해 주세요.");
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
