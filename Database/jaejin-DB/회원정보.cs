using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jaejin_DB
{
    public partial class 회원정보 : Form
    {
        public Move_Data_Zero Move_State_Logout;
        public Move_Data_Two Move_Data_IdName;
        string User_Identity;
        string User_Name;
        public 회원정보()
        {
            InitializeComponent();
        }
        public void Get_IdName(string Identity, string Name)
        {
            User_Identity = Identity;
            User_Name = Name;
            InfoName.Text = User_Name + "님";
        }
        private void CP_Button_Click(object sender, EventArgs e)
        {
            개인정보수정 ChangePw = new 개인정보수정();
            this.Move_Data_IdName += new Move_Data_Two(ChangePw.Get_IdName);
            Move_Data_IdName(User_Identity, User_Name);
            ChangePw.Show();
        }
        private void Withdraw_Button_Click(object sender, EventArgs e)
        {
            회원탈퇴 Widthdraw = new 회원탈퇴();
            this.Move_Data_IdName += new Move_Data_Two(Widthdraw.Get_IdName);
            Widthdraw.Move_State_Logout += new Move_Data_Zero(this.PuchLogoutState);
            Move_Data_IdName(User_Identity, User_Name);
            Widthdraw.Show();
        }
        private void PurchaseList_Button_Click(object sender, EventArgs e)
        {
            주문정보 OrderList = new 주문정보();
            this.Move_Data_IdName = new Move_Data_Two(OrderList.Get_IdName);
            Move_Data_IdName(User_Identity, User_Name);
            OrderList.Show();
        }
        private void Address_Button_Click(object sender, EventArgs e)
        {
            배송지정보 Addr = new 배송지정보();
            this.Move_Data_IdName += new Move_Data_Two(Addr.Get_IdName);
            Move_Data_IdName(User_Identity, User_Name);
            Addr.Show();
        }
        private void Card_Button_Click(object sender, EventArgs e)
        {
            카드정보 Card = new 카드정보();
            this.Move_Data_IdName += new Move_Data_Two(Card.Get_IdName);
            Move_Data_IdName(User_Identity, User_Name);
            Card.Show();
        }
        public void PuchLogoutState()
        {
            Move_State_Logout();
            this.Hide();
        }

        private void InfoName_Click(object sender, EventArgs e)
        {

        }
    }
}

