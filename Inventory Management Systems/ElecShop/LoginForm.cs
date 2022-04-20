using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ElecShop.DataAccess;
using System.Security.Cryptography.X509Certificates;

namespace ElecShop
{
    public partial class LoginForm : Form
    {   
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            Userdataaccess ud = new Userdataaccess();
            string a= txtUserid.Text, b= txtpassword.Text;
            ul = ud.GetthatUser(a);
            try { 
            if (ul.Password == b)
            {
                MessageBox.Show(ul.Name+ " Sign in Successful!");
               
                OptionView PV = new OptionView();

                PV.Visible = true;
                this.Visible = false;
                
               
               
            }
            else
            { MessageBox.Show(" sign in error"); }

                //this.Close();
            }
            catch (Exception)
            { MessageBox.Show("Error"); }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration PV = new Registration();

            PV.Visible = true;
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
