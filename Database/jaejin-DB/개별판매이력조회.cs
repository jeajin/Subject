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
    public partial class 개별판매이력조회 : Form
    {
        public Move_Data_Zero Upt;
        OleDbConnection connector;
        string connString;
        string User_Identity;
        string User_Name;
        public 개별판매이력조회()
        {
            InitializeComponent();
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
            InfoName.Text = User_Name + "님";
            DB_Link();
            OrderListUpdate();
        }
        private void OrderListUpdate()
        {
            try
            {
                OrderList.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from purchase  where identity ='" + User_Identity + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                OrderList.ColumnCount = 6;

                OrderList.Columns[0].Name = "주문번호";
                OrderList.Columns[1].Name = "구매일";
                OrderList.Columns[2].Name = "총 금액";
                OrderList.Columns[3].Name = "주문 상태";
                OrderList.Columns[4].Name = "카드번호";
                OrderList.Columns[5].Name = "배송지";

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[6];

                    for (int i = 0; i < 6; i++)
                    {
                        obj[i] = new object();
                        if (i == 1) { obj[i] = read.GetValue(i).ToString().Substring(0, 10); }
                        else if (i == 5) { obj[i] = read.GetValue(7); }
                        else { obj[i] = read.GetValue(i); }
                    }
                    OrderList.Rows.Add(obj);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void OrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                try
                {
                    purchase_book_List.Rows.Clear();
                    OleDbCommand cmd = new OleDbCommand();
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd.CommandText = "select * from purchase_book  where code  ='" + Int32.Parse(OrderList.SelectedRows[0].Cells[0].Value.ToString()) + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connector;
                    OleDbDataReader read = cmd.ExecuteReader();
                    OleDbDataReader read2;
                    purchase_book_List.ColumnCount = 4;

                    purchase_book_List.Columns[0].Name = "도서 이름";
                    purchase_book_List.Columns[1].Name = "가격";
                    purchase_book_List.Columns[2].Name = "주문수량";
                    purchase_book_List.Columns[3].Name = "주문 번호";

                    //행 단위로 반복
                    while (read.Read())
                    {
                        //read.GetValue(1).ToString()
                        cmd2.CommandText = "select * from book where isbn   ='" + read.GetValue(1).ToString() + "'";
                        cmd2.CommandType = CommandType.Text;
                        cmd2.Connection = connector;
                        read2 = cmd2.ExecuteReader();

                        object[] obj = new object[4];
                        read2.Read();
                        obj[0] = new object();
                        obj[0] = read2.GetValue(0);
                        obj[1] = new object();
                        obj[1] = read2.GetValue(1);
                        obj[2] = new object();
                        obj[2] = read.GetValue(2);
                        obj[3] = new object();
                        obj[3] = read.GetValue(0);

                        purchase_book_List.Rows.Add(obj);
                        read2.Close();
                    }
                    read.Close();

                    cmd.CommandText = "select * from purchase  where code  =" + Int32.Parse(OrderList.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connector;
                    read = cmd.ExecuteReader();
                    code.Text = OrderList.SelectedRows[0].Cells[0].Value.ToString();
                    if (read.Read())
                    {
                        purchase_date.Text = read.GetValue(1).ToString();
                        Card.Text = read.GetValue(4).ToString() + " " + read.GetValue(5).ToString().Substring(0, 10) + " " + read.GetValue(6).ToString();
                        Addr.Text = read.GetValue(7).ToString() + " " + read.GetValue(8).ToString() + " " + read.GetValue(9).ToString();
                        Sum.Text = read.GetValue(2).ToString();
                        state.Text = read.GetValue(3).ToString();
                    }
                    read.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
