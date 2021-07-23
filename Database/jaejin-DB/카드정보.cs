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

    public partial class 카드정보 : Form
    {
        OleDbConnection connector;
        string connString;
        string User_Identity;
        string User_Name;
        public 카드정보()
        {
            InitializeComponent();
        }
        public void Get_IdName(string Identity, string Name)
        {
            User_Identity = Identity;
            User_Name = Name;
            InfoName.Text = User_Name + "님";
            DB_Link();
            UpdateCard();
        }
        private void DB_Link()
        {
            connString = "Provider=OraOLEDB.Oracle;Password=sbvmfhs5;User ID=jaejin";
            connector = new OleDbConnection(connString);
            connector.Open();
        }
        private void UpdateCard()
        {
            try
            {
                CardList.Rows.Clear();
                //conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from card where identity ='" + User_Identity + "'"; //member 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader(); //select * from emp 결과
                CardList.ColumnCount = 3;

                CardList.Columns[0].Name = "카드번호";
                CardList.Columns[1].Name = "유효기간";
                CardList.Columns[2].Name = "종류";
     
                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[3]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 3; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        if (i == 1){ obj[i] = read.GetValue(i).ToString().Substring(0,10); }
                        else { obj[i] = read.GetValue(i); }
                         // 오브젝트배열에 데이터 저장
                    }
                    CardList.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
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
            if (!Code.Text.Equals("") && !type.Text.Equals(""))
            {
                
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from card where identity ='" + User_Identity + "'and code ='" + Code.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.Read()) 
                {
                    read.Close();
                    cmd.CommandText = "UPDATE card set valid_thru  ='" + valid_thru.Text + "',type  ='" + type.Text + "' where identity  = '" + User_Identity + "'and code ='" + Code.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connector;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("카드정보가 수정되었습니다.");
                    UpdateCard();
                }
                else
                {
                    read.Close();
                    MessageBox.Show("해당 카드번호로 등록된 카드가 없습니다.");
                    UpdateCard();
                }
            }
            else { MessageBox.Show("입력하지 않은 정보가 있습니다."); UpdateCard(); }
        }
        private void Insert_Button_Click(object sender, EventArgs e)
        {
            if (!Code.Text.Equals("") && !type.Text.Equals(""))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from card where identity ='" + User_Identity + "'and code ='" + Code.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    MessageBox.Show("카드번호가 중복됩니다.");
                    UpdateCard();
                    read.Close();
                }
                else
                {
                    read.Close();
                    cmd.CommandText = "INSERT INTO card VALUES('" + Code.Text + "','" + valid_thru.Text.Substring(0, 10) + "','" + type.Text + "','" + User_Identity + "')";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connector;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("새로운 카드가 등록되었습니다.");
                    UpdateCard();
                }             
            }
            else { MessageBox.Show("입력하지 않은 정보가 있습니다."); UpdateCard(); }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "DELETE FROM card WHERE identity = '" + User_Identity + "' and code ='" + Code.Text + "'";
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = connector;
            cmd.ExecuteNonQuery();
            MessageBox.Show("카드정보가 삭제 되습니다.");
            Code.Text = "";
            valid_thru.Text = "";
            type.Text = "";
            UpdateCard();
        }

        private void CardList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Code.Text = CardList.Rows[e.RowIndex].Cells[0].Value.ToString();
                valid_thru.Text = CardList.Rows[e.RowIndex].Cells[1].Value.ToString();
                type.Text = CardList.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
