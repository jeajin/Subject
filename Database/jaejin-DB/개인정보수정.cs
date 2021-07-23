using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace jaejin_DB
{
    public partial class 개인정보수정 : Form
    {
        OleDbConnection connector;
        string connString;
        string User_Identity;
        string User_Name;
        public 개인정보수정()
        {
            InitializeComponent();
            DB_Link();
        }
        public void Get_IdName(string Identity, string Name)
        {
            User_Identity = Identity;
            User_Name = Name;
            InfoName.Text = User_Name;
        }       
        private void DB_Link()
        {
            connString = "Provider=OraOLEDB.Oracle;Password=sbvmfhs5;User ID=jaejin";
            connector = new OleDbConnection(connString);
            connector.Open();
        }
        private void MU_Click(object sender, EventArgs e)
        {           
            OleDbCommand cmd = new OleDbCommand();            
            if (!MPw.Text.Equals("") && !MName.Text.Equals("") && !ME.Text.Equals("") && !MQ.Text.Equals("") && !MA.Text.Equals("") && !MP.Text.Equals(""))
            {
                cmd.CommandText = "UPDATE member set password='" + MPw.Text + "',name ='" + MName.Text + "',email ='" + ME.Text + "',question ='" + MQ.Text + "',answer ='" + MA.Text + "',phone ='" + MP.Text + "' where Identity= '" + User_Identity + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connector;
                cmd.ExecuteNonQuery();
                MessageBox.Show("회원정보가 수정되었습니다.");
            }
            else
            {
                MessageBox.Show("입력하지 않은 정보가 있습니다.");
            }      
        }
    }
}
