using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Register
{
    public partial class LoginUserControl : UserControl
    {
        public event EventHandler LoginClicked;
        public string participation_number, password;


        public LoginUserControl()
        {
            InitializeComponent();
            this.ActiveControl = txt_participation_number;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            participation_number = txt_participation_number.Text;
            password = txt_password.Text;
            if(participation_number == "")
            {
                MessageBox.Show("የተሳትፎ ቁጥር ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password == "")
            {
                MessageBox.Show("የተሳትፎ ቁጥር ያስገቡ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //txt_participation_number.Text = "";
            txt_password.Text = "";
            OnClick(EventArgs.Empty);
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        protected virtual void LoginUserControl_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, e);
        }
    }
}
