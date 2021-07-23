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
    public partial class 관리자 : Form
    {
        public Move_Data_Two Move_Data_IdName;
        public Move_Book Move_Book_Data;
        public Move_Data_Zero Logout;
        OleDbConnection connector;
        string connString;
        bool totaldate;
        public 관리자()
        {
            
            InitializeComponent();
            DB_Link();
            totaldate = true;
            OrderListUpdate();
            OrderListSUpdate();
            BookListUpdate();
            MemberUpdate();
            PBookListUpdate();
            PMemberUpdate();
        }
        private void DB_Link()
        {
            connString = "Provider=OraOLEDB.Oracle;Password=sbvmfhs5;User ID=jaejin";
            connector = new OleDbConnection(connString);
            connector.Open();
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

        private void BookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                name.Text = BookList.Rows[e.RowIndex].Cells[0].Value.ToString();
                price.Text = BookList.Rows[e.RowIndex].Cells[1].Value.ToString();
                stock.Text = BookList.Rows[e.RowIndex].Cells[2].Value.ToString();
                isbn.Text = BookList.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
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

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Logout();
            this.Hide();
        }

        private void ChangeStock_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from book  where isbn  ='" + isbn.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            OleDbDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                read.Close();
                cmd.CommandText = "UPDATE book set stock  ='" + Int32.Parse(stock.Text) + "' where isbn  ='" + isbn.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                cmd.ExecuteNonQuery();
                MessageBox.Show("도서정보가 수정되었습니다.");
                BookListUpdate();
                read.Close();
            }
            else
            {
                MessageBox.Show("등록되지 않은 도서입니다."); BookListUpdate();
            }
        }

        private void InsertBook_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from book  where isbn  ='" + isbn.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            OleDbDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                MessageBox.Show("isbn번호가 중복됩니다.");
                BookListUpdate();
                read.Close();
            }
            else
            {
                if (!price.Equals("") && !name.Text.Equals("") && !stock.Text.Equals("") && !isbn.Text.Equals(""))
                {
                    read.Close();
                    cmd.CommandText = "INSERT INTO book  VALUES('" + name.Text + "'," + Int32.Parse(price.Text) + "," + Int32.Parse(stock.Text) + ",'" + isbn.Text + "')";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connector;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("도서가 등록되었습니다.");
                    BookListUpdate();
                }
                else { MessageBox.Show("입력하지 않은 정보가 있습니다."); BookListUpdate(); }
            }
        }

        private void UpdateBook_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from book  where isbn  ='" + isbn.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            OleDbDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                read.Close();
                cmd.CommandText = "UPDATE book set name  ='" + name.Text + "',price  ='" + Int32.Parse(price.Text) + "',stock  ='" + Int32.Parse(stock.Text) + "'where isbn   = '" + isbn.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                cmd.ExecuteNonQuery();
                MessageBox.Show("도서정보가 수정되었습니다.");
                BookListUpdate();
                BookListUpdate();
                read.Close();
            }
            else
            {
                MessageBox.Show("등록되지 않은 도서입니다."); BookListUpdate();
            }


        }

        private void DeleteBook_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "DELETE FROM book  WHERE isbn  = '" + isbn.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            cmd.ExecuteNonQuery();
            MessageBox.Show("도서가 삭제 되었습니다.");
            isbn.Text = "";
            stock.Text = "";
            name.Text = "";
            price.Text = "";
            BookListUpdate();
        }
        private void OrderListSUpdate()
        {
            try
            {
                OrderListS.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                if (totaldate) 
                { 
                    cmd.CommandText = "select * from purchase";
                }                
                else
                {
                    if (monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") == monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd"))
                    {
                        cmd.CommandText = "select * from purchase where purchase_date between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar1.SelectionRange.End.AddDays(1).ToString("yyyy-MM-dd") + "'";
                    }
                    else
                    {
                        cmd.CommandText = "select * from purchase where purchase_date between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd") + "'";

                    }
                }
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                OrderListS.ColumnCount = 6;

                OrderListS.Columns[0].Name = "주문번호";
                OrderListS.Columns[1].Name = "구매일";
                OrderListS.Columns[2].Name = "총 금액";
                OrderListS.Columns[3].Name = "주문 상태";
                OrderListS.Columns[4].Name = "카드번호";
                OrderListS.Columns[5].Name = "배송지";

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
                    OrderListS.Rows.Add(obj);
                }
                read.Close();
                if (totaldate)
                {
                    cmd.CommandText = "select sum(total_price ) from purchase";
                }
                else
                {
                    if (monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") == monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd"))
                    {
                        cmd.CommandText = "select sum(total_price ) from purchase where purchase_date between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar1.SelectionRange.End.AddDays(1).ToString("yyyy-MM-dd") + "'";
                    }
                    else
                    {
                        cmd.CommandText = "select sum (total_price ) from purchase where purchase_date between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd") + "'";

                    }
                }
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                read = cmd.ExecuteReader();
                if (read.Read())
                {
                    SumMoney.Text = read.GetValue(0).ToString();
                }
                read.Close();
                if (totaldate)
                {
                    cmd.CommandText = "select sum(count) from (select code from purchase)  sc,purchase_book pb where sc.code = pb.code";
                }
                else
                {
                    if (monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") == monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd"))
                    {
                        cmd.CommandText = "select sum(count) from (select code from purchase where purchase_date between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar1.SelectionRange.End.AddDays(1).ToString("yyyy-MM-dd") + "') sc, purchase_book pb where sc.code = pb.code";
                    }
                    else
                    {
                        cmd.CommandText = "select sum(count) from (select code from purchase where purchase_date between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd") + "') sc, purchase_book pb where sc.code = pb.code";

                    }
                }
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                read = cmd.ExecuteReader();
                if (read.Read())
                {
                    SumBook.Text = read.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void OrderListUpdate()
        {
            try
            {
                OrderList.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from purchase where state = '신청'";
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
            if (e.RowIndex != -1)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "select * from purchase  where code  ='" + int.Parse(OrderList.Rows[e.RowIndex].Cells[0].Value.ToString()) + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connector;
                    OleDbDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        identity.Text = read.GetValue(10).ToString();
                        code.Text = read.GetValue(0).ToString();
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

        private void 발송_Button_Click(object sender, EventArgs e)
        {
            if (state.Text.Equals("신청"))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE purchase set state ='발송'where code  = '" + code.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                cmd.ExecuteNonQuery();
                MessageBox.Show("발송상태로 변경되었습니다.");
                OrderListUpdate();
            }
            else
            {
                MessageBox.Show("신청상태만 승인을 할 수 있습니다.");
            }
        }

        private void DeletePurchase_Button_Click(object sender, EventArgs e)
        {        
            if (state.Text.Equals("신청"))
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbCommand cmd2 = new OleDbCommand();
                cmd.CommandText = "select pb.isbn, book.stock + pb.count from(select isbn, count  from purchase_book where code = '" + code.Text + "') pb, book where book.isbn = pb.isbn";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cmd2.CommandText = "update book set stock = " + Int32.Parse(read.GetValue(1).ToString()) + " where isbn = '" + read.GetValue(0).ToString() + "'";
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Connection = connector;
                    cmd2.ExecuteNonQuery();
                }
                read.Close();
                cmd.CommandText = "DELETE from purchase  where code   = '" + code.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                cmd.ExecuteNonQuery();


                MessageBox.Show("주문취소가 완료되었습니다.");
                purchase_date.Text = "";
                Card.Text = "";
                Addr.Text = "";
                Sum.Text = "";
                state.Text = "";
                
                OrderListUpdate();
            }

          }

        private void All발송_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE purchase set state ='발송'where state  = '신청'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connector;
            cmd.ExecuteNonQuery();
            MessageBox.Show("일괄 배송하였습니다.");
            OrderListUpdate();
        }

        private void memberInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "select * from member  where identity   ='" + memberInfo.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connector;
                    OleDbDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        MIdentity.Text = read.GetValue(0).ToString();
                        MPw.Text = read.GetValue(1).ToString();
                        MName.Text = read.GetValue(2).ToString();
                        ME.Text = read.GetValue(3).ToString();
                        MQ.Text = read.GetValue(4).ToString();
                        MA.Text = read.GetValue(5).ToString();
                        MP.Text = read.GetValue(6).ToString();
                    }
                    read.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void MemberUpdate()
        {
            try
            {
                memberInfo.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from member";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                memberInfo.ColumnCount = 7;

                memberInfo.Columns[0].Name = "회원번호";
                memberInfo.Columns[1].Name = "비밀번호";
                memberInfo.Columns[2].Name = "이름";
                memberInfo.Columns[3].Name = "메일";
                memberInfo.Columns[4].Name = "질문";
                memberInfo.Columns[5].Name = "답";
                memberInfo.Columns[6].Name = "핸드폰번호";


                while (read.Read())
                {
                    object[] obj = new object[7]; 

                    for (int i = 0; i < 7; i++)
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i);
                    }
                    memberInfo.Rows.Add(obj); 
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Member_Search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                memberInfo.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                if (Member_Search_Combo.Text.Equals("아이디"))
                {
                    cmd.CommandText = "select * from member where lower(identity ) like '%" + Member_Search.Text.ToString().ToLower() + "%'";
                }
                else if (Member_Search_Combo.Text.Equals("이름"))
                {
                    cmd.CommandText = "select * from member where lower(name ) like '%" + Member_Search.Text.ToString().ToLower() + "%'";
                }
                else if (Member_Search_Combo.Text.Equals("이메일"))
                {
                    cmd.CommandText = "select * from member where lower(email ) like '%" + Member_Search.Text.ToString().ToLower() + "%'";
                }
                else if (Member_Search_Combo.Text.Equals("전화번호"))
                {
                    cmd.CommandText = "select * from member where lower(phone ) like '%" + Member_Search.Text.ToString().ToLower() + "%'";
                }
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                BookList.ColumnCount = 7;

                while (read.Read())
                {
                    object[] obj = new object[7]; 

                    for (int i = 0; i < 7; i++) 
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); 
                    }
                    memberInfo.Rows.Add(obj); 
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);  
            }
        }

        private void MD_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select identity,name from member where identity = '" + MIdentity.Text + "'";
            cmd.CommandType = CommandType.Text; 
            cmd.Connection = connector;
            OleDbDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                read.Close();
                cmd.CommandText = "DELETE from member where identity  = '" + MIdentity.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("회원탈퇴가 완료되었습니다.");
                MIdentity.Text = "";
                MPw.Text = "";
                MName.Text = "";
                ME.Text = "";
                MQ.Text = "";
                MA.Text = "";
                MP.Text = "";

                MemberUpdate();
            }
            else MessageBox.Show("존재하지 않는 계정입니다.");
        }

        private void MI_Click(object sender, EventArgs e)
        {
            if (!MIdentity.Text.Equals(""))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select identity from member where identity = '" + MIdentity.Text + "'";
                cmd.CommandType = CommandType.Text; 
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                if (!read.Read())
                {
                    read.Close();
                    if (!MIdentity.Text.Equals("") && !MPw.Text.Equals("") && !MName.Text.Equals("") && !ME.Text.Equals("") && !MQ.Text.Equals("") && !MA.Text.Equals("") && !MP.Text.Equals(""))
                    {  
                        cmd.CommandText = "INSERT INTO member VALUES('" + MIdentity.Text + "','" + MPw.Text + "','" + MName.Text + "','" + ME.Text + "','" + MQ.Text + "','" + MA.Text + "','" + MP.Text + "')";
                        cmd.CommandType = CommandType.Text; 
                        cmd.Connection = connector;
                        cmd.ExecuteNonQuery();
                        MemberUpdate();
                    }
                    else
                    {
                        MessageBox.Show("입력하지 않은 정보가 있습니다.");                       
                    }
                }
                else
                {
                    MessageBox.Show("아이디가 중복되었습니다.");
                }
            }
            else
            {
                MessageBox.Show("생성할  아이디를 입력해주세요.");
            }
            
        }

        private void MU_Click(object sender, EventArgs e)
        {
            if (!MIdentity.Text.Equals(""))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select identity from member where identity = '" + MIdentity.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    read.Close();
                    if (!MIdentity.Text.Equals("") && !MPw.Text.Equals("") && !MName.Text.Equals("") && !ME.Text.Equals("") && !MQ.Text.Equals("") && !MA.Text.Equals("") && !MP.Text.Equals(""))
                    {
                        
                        cmd.CommandText = "UPDATE member set password='" + MPw.Text + "',name ='" + MName.Text + "',email ='" + ME.Text + "',question ='" + MQ.Text + "',answer ='" + MA.Text + "',phone ='" + MP.Text + "' where Identity= '" + MIdentity.Text + "'";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connector;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("회원정보가 수정되었습니다.");
                        MemberUpdate();

                    }
                    else
                    {
                        MessageBox.Show("입력하지 않은 정보가 있습니다.");
                    }
                }
                else MessageBox.Show("존재하지 않은 회원정보 입니다.");               
            }
            else MessageBox.Show("수정할 회원정보를 입력하세요.");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar1.SelectionRange.Start == monthCalendar1.SelectionRange.End)
                amongdate.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            else
                amongdate.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "~" + monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd");
        }

        private void SelectedDate_Click(object sender, EventArgs e)
        {
            totaldate = false;
            OrderListSUpdate();
        }

        private void TotalDate_Click(object sender, EventArgs e)
        {
            totaldate = true;
            amongdate.Text = "전체기간";
            OrderListSUpdate();
        }

   

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.Text == "회원")
            {
                PMemberUpdate();
            }
            else if (comboBox3.Text == "도서")
            {
               PBookListUpdate();

            }
        }
        private void PBookListUpdate()
        {
            try
            {
                List.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from book";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                List.ColumnCount = 4;

                List.Columns[0].Name = "책 제목";
                List.Columns[1].Name = "가격";
                List.Columns[2].Name = "재고량";
                List.Columns[3].Name = "ISBN";

                while (read.Read())
                {
                    object[] obj = new object[4];

                    for (int i = 0; i < 4; i++)
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i);
                    }
                    List.Rows.Add(obj);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void PMemberUpdate()
        {
            try
            {
                List.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from member";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                List.ColumnCount = 7;

                List.Columns[0].Name = "회원번호";
                List.Columns[1].Name = "비밀번호";
                List.Columns[2].Name = "이름";
                List.Columns[3].Name = "메일";
                List.Columns[4].Name = "질문";
                List.Columns[5].Name = "답";
                List.Columns[6].Name = "핸드폰번호";


                while (read.Read())
                {
                    object[] obj = new object[7];

                    for (int i = 0; i < 7; i++)
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i);
                    }
                    List.Rows.Add(obj);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            if (comboBox3.Text == "회원")
            {
                cmd.CommandText = "select sum(pc.total_price) , sum(pb.count) from(select code, total_price from purchase where identity = '"+List.Rows[e.RowIndex].Cells[0].Value.ToString()+"' ) pc,  purchase_book pb where pc.code = pb.code";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    if (!read.GetValue(1).ToString().Equals(""))
                    {
                        sellSum.Text = read.GetValue(1).ToString();
                        SellSumMoney.Text = read.GetValue(0).ToString() ;
                    }
                    else
                    {
                        sellSum.Text = "0";
                        SellSumMoney.Text = "0";
                    }

                }
                read.Close();
                개별판매이력조회 st = new 개별판매이력조회();
                this.Move_Data_IdName += new Move_Data_Two(st.Get_IdName);
                Move_Data_IdName(List.Rows[e.RowIndex].Cells[0].Value.ToString(), "admin");
                st.Show();
            }
            else if (comboBox3.Text == "도서")
            {
                cmd.CommandText = "select b.price,pb.s from (select price from book where isbn ='"+ List.Rows[e.RowIndex].Cells[3].Value.ToString()+ "') b, (select sum(count) s from purchase_book where isbn ='" + List.Rows[e.RowIndex].Cells[3].Value.ToString() + "') pb";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    if (!read.GetValue(1).ToString().Equals(""))
                    {
                        sellSum.Text = read.GetValue(1).ToString();
                        SellSumMoney.Text = (Int32.Parse(read.GetValue(1).ToString()) * Int32.Parse(read.GetValue(0).ToString())).ToString();
                    }
                    else
                    {
                        sellSum.Text = "0";
                        SellSumMoney.Text = "0";
                    }

                }
                read.Close();
            }
    
        }
    }
}
