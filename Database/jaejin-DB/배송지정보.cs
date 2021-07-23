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
    public partial class 배송지정보 : Form
    {
        OleDbConnection connector;
        string connString;
        string User_Identity;
        string User_Name;
        string Loc,LocT;
        public 배송지정보()
        {
            InitializeComponent();
        }
        public void Get_IdName(string Identity, string Name)
        {
            User_Identity = Identity;
            User_Name = Name;
            InfoName.Text = User_Name + "님";
            DB_Link();
            UpdateAddr();
        }
        private void DB_Link()
        {
            connString = "Provider=OraOLEDB.Oracle;Password=sbvmfhs5;User ID=jaejin";
            connector = new OleDbConnection(connString);
            connector.Open();
        }
        private void UpdateAddr()
        {
            try
            {
                AddressList.Rows.Clear();
                //conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from address where identity ='" + User_Identity + "'"; //member 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader(); //select * from emp 결과
                AddressList.ColumnCount = 4;

                AddressList.Columns[0].Name = "배송지";
                AddressList.Columns[1].Name = "우편번호";
                AddressList.Columns[2].Name = "주소";
                AddressList.Columns[3].Name = "상세주소";
                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[4]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 4; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                    }
                    AddressList.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (Loc.Equals(LocT))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE address set postal_code ='" + Postal_Code.Text + "',basic_addr ='" + Basic_Addr.Text + "',detail_addr ='" + Detail_Addr.Text + "'where identity  = '" + User_Identity + "'and location ='" + Loc + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = connector;
                cmd.ExecuteNonQuery();
                MessageBox.Show("배송주소지가 수정되었습니다.");
                Home.Checked = false;
                Company.Checked = false;
                UpdateAddr();
            }
            else
            {
                MessageBox.Show("배송지 항목은 수정할 수 없습니다..");
                Home.Checked = false;
                Company.Checked = false;
            }
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            //conn.Open(); //데이터베이스 연결
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from address where identity ='" + User_Identity + "'and location ='"+Loc+"'"; //member 테이블
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = connector;
            OleDbDataReader read = cmd.ExecuteReader(); //select * from emp 결과

            //행 단위로 반복
            if (read.Read())
            {
                MessageBox.Show("배송지가 중복됩니다.");
                UpdateAddr();
                read.Close();
            }
            else 
            {
                if (!Loc.Equals("") && !Postal_Code.Text.Equals("") && !Basic_Addr.Text.Equals("") && !Detail_Addr.Text.Equals("") && !User_Identity.Equals(""))
                {
                    read.Close();
                    // OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT INTO address VALUES('" + Loc + "','" + Postal_Code.Text + "','" + Basic_Addr.Text + "','" + Detail_Addr.Text + "','" + User_Identity + "')";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = connector;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("배송주소지가 등록되었습니다.");
                    Home.Checked = false;
                    Company.Checked = false;
                    UpdateAddr();
                }
                else { MessageBox.Show("입력하지 않은 정보가 있습니다."); UpdateAddr(); }
                }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "DELETE FROM address WHERE identity = '" + User_Identity + "' and location ='" + Loc + "'";
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = connector;
            cmd.ExecuteNonQuery();
            MessageBox.Show("배송주소지가 삭제 되습니다.");
            Home.Checked = false;
            Company.Checked = false;
            Postal_Code.Text = "";
            Basic_Addr.Text = "";
            Detail_Addr.Text = "";
            UpdateAddr();
        }

        private void Home_CheckedChanged(object sender, EventArgs e)
        {
            if (Home.Checked)
            {
                Company.Checked = false;
                Loc = "home";
            }
        }

        private void Company_CheckedChanged(object sender, EventArgs e)
        {
            if (Company.Checked)
            {
                Home.Checked = false;
                Loc = "company";
            }
        }

        private void AddressList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (AddressList.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("home"))
                {
                    Home.Checked = true;
                    LocT = Loc = "home";
                }
                else
                {
                    Company.Checked = true;
                    LocT = Loc = "company";
                }
                Postal_Code.Text = AddressList.Rows[e.RowIndex].Cells[1].Value.ToString();
                Basic_Addr.Text = AddressList.Rows[e.RowIndex].Cells[2].Value.ToString();
                Detail_Addr.Text = AddressList.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
