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
    public delegate void Move_Data_Zero();
    public delegate void Move_Data_One(string data);
    public delegate void Move_Data_Two(string data1, string date2);
    public delegate void Move_Book(DataGridViewRow[] dr, int dr_num);
    public delegate void Move_object(object[] ob, int num);
    public partial class 메인 : Form
    {
        public Move_Data_Two Move_Data_IdName;
        public Move_Book Move_Book_Data;
        public DataGridViewRow[] BookGrid;
        OleDbConnection connector;
        string connString;
        string User_Identity="";
        string User_Name;
        int BookNum;
        bool Zerobook;
        public 메인()
        {
            InitializeComponent();
            DB_Link();
            BookListUpdate();
            SetLogout();
            AdminButton.Hide();
        }
        private void BookListUpdate()
        {
            try
            {
                BookList.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from book"; 
                cmd.CommandType = CommandType.Text; 
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader(); 
                BookList.ColumnCount = 4;

                BookList.Columns[0].Name = "책 제목";
                BookList.Columns[1].Name = "가격";
                BookList.Columns[2].Name = "재고량";
                BookList.Columns[3].Name = "ISBN";
        
                while (read.Read())
                {
                    object[] obj = new object[4]; 

                    for (int i = 0; i < 4; i++) 
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i);
                    }
                    BookList.Rows.Add(obj);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DB_Link()
        {
            connString = "Provider=OraOLEDB.Oracle;Password=sbvmfhs5;User ID=jaejin";
            connector = new OleDbConnection(connString);
            connector.Open();
        }
        private void SetLogin()
        {
            Id_Box.Hide();
            Pw_Box.Hide();
            Login_Button.Hide();
            Join_Button.Hide();
            Logout_Button.Show();
            Basket_Button.Show();
            PurchaseList_Button.Show();
            MemberInfo_Botton.Show();
            Wellcome_Label.Text = User_Name + "님 환영합니다~!!!";
            Wellcome_Label.Show();
            Zerobook = true;
        }
        private void SetLogout()
        {
            Id_Box.Text = "아이디";
            Pw_Box.Text = "비밀번호";
            Id_Box.Show();
            Pw_Box.Show();
            Login_Button.Show();
            Join_Button.Show();
            Logout_Button.Hide();
            Basket_Button.Hide();
            PurchaseList_Button.Hide();
            MemberInfo_Botton.Hide();
            Wellcome_Label.Text = null;
            Wellcome_Label.Hide();
            User_Identity = "";
            User_Name = "";
            AdminButton.Hide();
        }
        private void Logout_Button_Click(object sender, EventArgs e)
        {
            SetLogout();
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select identity,name from member where identity = '" + Id_Box.Text + "'and password='" + Pw_Box.Text + "'"; 
            cmd.CommandType = CommandType.Text; 
            cmd.Connection = connector;
            OleDbDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                User_Identity = read.GetString(0);
                User_Name = read.GetString(1);
                SetLogin();
            }
            else
            {
                MessageBox.Show("회원정보를 다시 확인해주세요");
            }
            if (User_Identity.Equals("admin"))
            {
                관리자 Admin = new 관리자();
                Admin.Logout += new Move_Data_Zero(this.SetLogout);
                Admin.Show();
                AdminButton.Show();
            }
        }
        private void Join_Button_Click(object sender, EventArgs e)
        {
            회원가입 Join = new 회원가입();
            Join.Move_Data_IdName += new Move_Data_Two(this.Get_IdName);
            Join.Show();
        }
        private void MemberInfo_Botton_Click(object sender, EventArgs e)
        {
            회원정보 Info = new 회원정보();
            this.Move_Data_IdName += new Move_Data_Two(Info.Get_IdName);
            Info.Move_State_Logout = new Move_Data_Zero(this.SetLogout);
            Move_Data_IdName(User_Identity, User_Name);
            Info.Show();
        }
        private void Id_Box_MouseClick(object sender, MouseEventArgs e)
        {
            if (Id_Box.Text=="아이디") 
            {
                Id_Box.Text = null;
            }
        }
        private void Pw_Box_MouseClick(object sender, MouseEventArgs e)
        {
            if (Pw_Box.Text == "비밀번호")
            {
                Pw_Box.Text = null;
            }      
        }
        public void Get_IdName(string Identity, string Name)
        {
            User_Identity = Identity;
            User_Name = Name;
            SetLogin();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                BookList.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                if (Search_Combo.Text.Equals("도서명"))
                {
                    cmd.CommandText = "select * from book where lower(name) like '%" + BookSearch.Text.ToString().ToLower() + "%'"; 
                }
                else if (Search_Combo.Text.Equals("도서번호"))
                {
                    cmd.CommandText = "select * from book where lower(isbn) like '%" + BookSearch.Text.ToString().ToLower() + "%'"; 
                }
                cmd.CommandType = CommandType.Text; 
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader(); 
                BookList.ColumnCount = 4;

                while (read.Read())
                {
                    object[] obj = new object[4];

                    for (int i = 0; i < 4; i++) 
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); 
                    }
                    BookList.Rows.Add(obj); 
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
        }
        private void ComeBack_Click(object sender, EventArgs e)
        {
            BookListUpdate();
        }



        private void PutBasket_Button_Click(object sender, EventArgs e)
        {
            if (!User_Identity.Equals(""))
            {
                BookList.ColumnCount = 5;
                BookNum = BookList.SelectedRows.Count;
                BookGrid = new DataGridViewRow[BookNum];
                for (int i = 0; i < BookNum; i++)
                {
                    if (Int32.Parse(BookList.SelectedRows[i].Cells[2].Value.ToString()) == 0)
                    {
                        MessageBox.Show("재고가 없으면 장바구니에 담을 수 없습니다.\n뒤로 돌아갑니다!", "현재 재고가 없습니다.");
                        Zerobook = false;
                        BookListUpdate();
                        break;
                    }
                    BookGrid[i] = BookList.SelectedRows[i];
                }
                if (Zerobook)
                {
                    장바구니담기 Basket = new 장바구니담기();
                    this.Move_Book_Data = new Move_Book(Basket.Getbook);
                    this.Move_Data_IdName = new Move_Data_Two(Basket.Get_IdName);
                    Move_Data_IdName(User_Identity, User_Name);
                    Move_Book_Data(BookGrid, BookNum);
                    BookList.ColumnCount = 4;
                    Basket.Show();
                }
                else Zerobook = true;
            }
            else MessageBox.Show("장바구니 담기는 로그인 이후 가능 합니다.");
        }
        private void Purchase_Button_Click(object sender, EventArgs e)
        {
            if (!User_Identity.Equals(""))
            {
                BookList.ColumnCount = 5;
                BookNum = BookList.SelectedRows.Count;
                BookGrid = new DataGridViewRow[BookNum];
                for (int i = 0; i < BookNum; i++)
                {
                    if (Int32.Parse(BookList.SelectedRows[i].Cells[2].Value.ToString()) == 0)
                    {
                        MessageBox.Show("재고가 없으면 바로 주문하기를 할 수 없습니다.\n뒤로 돌아갑니다!", "현재 재고가 없습니다.");
                        Zerobook = false;
                        BookListUpdate();
                        break;
                    }
                    BookGrid[i] = BookList.SelectedRows[i];
                }
                if (Zerobook)
                {
                    바로주문 Order = new 바로주문();
                    this.Move_Book_Data = new Move_Book(Order.Getbook);
                    this.Move_Data_IdName = new Move_Data_Two(Order.Get_IdName);
                    Order.BookUpdateMain = new Move_Data_Zero(this.BookListUpdate);
                    Move_Data_IdName(User_Identity, User_Name);
                    Move_Book_Data(BookGrid, BookNum);
                    BookList.ColumnCount = 4;
                    Order.Show();
                }
                else Zerobook = true;
            }
            else MessageBox.Show("바로주문은 로그인 이후 가능 합니다.");
        }

        private void Basket_Button_Click(object sender, EventArgs e)
        {
            장바구니 Basket = new 장바구니();
            this.Move_Data_IdName = new Move_Data_Two(Basket.Get_IdName);
            Move_Data_IdName(User_Identity, User_Name);
            Basket.Show();
        }

        private void PurchaseList_Button_Click(object sender, EventArgs e)
        {
            주문정보 OrderList = new 주문정보();
            this.Move_Data_IdName += new Move_Data_Two(OrderList.Get_IdName);
            OrderList.Upt += new Move_Data_Zero(this.BookListUpdate);
            Move_Data_IdName(User_Identity, User_Name);
            OrderList.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            관리자 Admin = new 관리자();
            Admin.Logout += new Move_Data_Zero(this.SetLogout);
            Admin.Show();
        }
    }
}













