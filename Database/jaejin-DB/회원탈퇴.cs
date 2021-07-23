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
    public partial class 회원탈퇴 : Form
    {
        public Move_Data_Zero Move_State_Logout;
        OleDbConnection connector;
        string connString;
        string User_Identity;
        string User_Name;
        public 회원탈퇴()
        {
            InitializeComponent();
            DB_Link();
        }
        public void Get_IdName(string Identity, string Name)
        {
            User_Identity = Identity;
            User_Name = Name;
        }

        private void Widthdraw_Button_Click(object sender, EventArgs e)
        {
        
               if (Confirm_Check.Checked)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select identity,name from member where identity = '" + User_Identity + "'and password='" + Pw.Text + "'"; 
                cmd.CommandType = CommandType.Text; 
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    read.Close();
                    cmd.CommandText = "DELETE from member where identity = '" + User_Identity + "'and password='" + Pw.Text + "'";
                    cmd.CommandType = CommandType.Text; 
                    cmd.Connection = connector;
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    Move_State_Logout();
                    MessageBox.Show("회원탈퇴가 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("비밀번호가 일치 하지 않습니다.");
                }
            }
            else MessageBox.Show("탈퇴안내를 확인해주시고 체크버튼을 눌러주세요.");
            
        }
        private void DB_Link()
        {
            connString = "Provider=OraOLEDB.Oracle;Password=sbvmfhs5;User ID=jaejin";
            connector = new OleDbConnection(connString);
            connector.Open();
        }

        private void Pw_MouseClick(object sender, MouseEventArgs e)
        {
            Pw.Text = null;
        }
    }
}
