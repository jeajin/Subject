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
    public partial class 비밀번호변경 : Form
    {
        OleDbConnection connector;
        string connString;
        string User_Identity;
        string User_Name;
        public 비밀번호변경()
        {
            InitializeComponent();
            DB_Link();
        }
        public void Get_IdName(string Identity, string Name)
        {
            User_Identity = Identity;
            User_Name = Name;
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (NewPw.Text.Equals(NewPw2.Text))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select identity,name from member where identity = '" + User_Identity + "'and password='" + OldPw.Text + "'"; //member 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    read.Close();
                    cmd.CommandText = "UPDATE member set password = '" + NewPw.Text + "' where Identity= '" + User_Identity + "',";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = connector;
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    MessageBox.Show("비밀번호가 변경되었습니다.");
                }
                else
                {
                    MessageBox.Show("기존 비밀번호가 일치 하지 않습니다.");
                }
            }
            else MessageBox.Show("새로운 비밀번호가 일치 하지 않습니다.");
        }
        private void DB_Link()
        {
            connString = "Provider=OraOLEDB.Oracle;Password=sbvmfhs5;User ID=jaejin";
            connector = new OleDbConnection(connString);
            connector.Open();
        }
    }
}
