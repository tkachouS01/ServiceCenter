using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using static System.Convert;
using System.Threading;

namespace Курсовая_АСОИР191_Ткачёв_С.А
{
    public partial class LoginForm : Form
    {

        public LoginForm ( )
        {
            InitializeComponent ();
        }

        private void Enter_button_Click ( object sender , EventArgs e )
        {
            if (LoginField_box.Text == "Приёмщик" && PassField_box.Text == "user1")
            {
                this.Hide ();
                ReceiverForm receiver_form = new ReceiverForm ();
                receiver_form.Show ();
            }
            
            else if (LoginField_box.Text == "Мастер" && PassField_box.Text == "user2")
            {
                this.Hide ();
                MasterForm master_form = new MasterForm ();
                master_form.Show ();
            }
            else
            {
                LoginField_box.BackColor = Color.Red;
                PassField_box.BackColor = Color.Red;
                LoginField_box.Text = "Неверно!!";
                PassField_box.Text = "";
            }
            

        }
        private void СloseButton_Click ( object sender , EventArgs e )
        {
            Application.Exit ();
        }
    }
}
