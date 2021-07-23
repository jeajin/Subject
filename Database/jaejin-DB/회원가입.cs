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
    public partial class 회원가입 : Form
    {
        public Move_Data_Two Move_Data_IdName;
        OleDbConnection connector;
        string connString;
        string Duplicate_Identity;
        bool Duplicate_Bool;
        public 회원가입()
        {
            InitializeComponent();
            Duplicate_Bool = false;
            DB_Link();
        }
        private void DB_Link()
        {
            connString = "Provider=OraOLEDB.Oracle;Password=sbvmfhs5;User ID=jaejin";
            connector = new OleDbConnection(connString);
            connector.Open();
        }
        private void Duplicate_Button_Click(object sender, EventArgs e)
        {
            if (!Join_Identity.Text.Equals(""))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select identity from member where identity = '" + Join_Identity.Text + "'"; //member 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = connector;
                OleDbDataReader read = cmd.ExecuteReader();
                if (!read.Read())
                {
                    MessageBox.Show(Join_Identity.Text + "는 사용 가능한 아이디 입니다.");
                    Duplicate_Identity = Join_Identity.Text;
                    Duplicate_Bool = true;
                }
                else
                {
                    MessageBox.Show("아이디가 중복되었습니다.");
                    Duplicate_Bool = false;
                }
            }
            else
            {
                MessageBox.Show("사용할 아이디를 입력해주세요.");
            }
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Join_Button_Click(object sender, EventArgs e)
        {
            if (Join_Pw.Text == Join_Pw2.Text && !Join_Pw.Text.Equals("") && 이용약관_Check.Checked && 개인정보_Check.Checked)
            {
                if (!Duplicate_Bool)
                {
                    MessageBox.Show("아이디 중복검사를 수행해주세요.");
                }
                else if (Join_Identity.Text != Duplicate_Identity)
                {
                    MessageBox.Show("중복검사 당시 아이디와 다릅니다.");
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT INTO member VALUES('" + Join_Identity.Text + "','" + Join_Pw.Text + "','" + Join_Name.Text + "','" + Join_Email.Text + "','" + Join_Question.Text + "','" + Join_Answer.Text + "','" + Join_PhoneNumber.Text + "')"; //member 테이블
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = connector;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("회원가입을 환영합니다.");
                    Move_Data_IdName(Join_Identity.Text, Join_Name.Text);
                    this.Hide();
                }
            }
            else
            {
                if (Join_Pw.Text.Equals("")) { MessageBox.Show("비밀번호를 입력해주세요."); }
                if (Join_Pw.Text != Join_Pw2.Text){ MessageBox.Show("비밀번호가 일치 하지 않습니다.");  }
                if (!이용약관_Check.Checked) { MessageBox.Show("이용약관을 체크해주세요."); }
                if (!개인정보_Check.Checked) { MessageBox.Show("개인정보 수집 동의에 체크해주세요."); }
            }
        }
    }
}
