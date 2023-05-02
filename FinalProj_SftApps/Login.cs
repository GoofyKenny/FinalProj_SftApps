using FinalProj_SftApps.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProj_SftApps
{
    public partial class Login : Form
    {

        DataStore dt = new DataStore();
        int count;
        string message = "Your registration has been successfully completed";
        string title = "Successful";



        public Login()
        {
            InitializeComponent();
        }

        public void SignIn()
        {
            count = dt.users.Count();
            for(int i = 0; i < count; i++)
            {
                if (dt.users[i].userName == textBox1.Text && dt.users[i].password == textBox2.Text)
                {
                    this.Hide();
                    Home homefrm = new Home();
                    homefrm.Show();
                }
            }

        }

        public void SignUp()
        {
            
            if(checkBox1.Checked)
            {
                if(textBox2.Text == textBox3.Text)
                {
                    MessageBox.Show(message, title);
                    dt.users.Add(new User(textBox1.Text, textBox2.Text));
                }
            }
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            SignIn();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            label3.Visible = checkBox1.Checked;
            textBox3.Visible = checkBox1.Checked;
            panel9.Visible = checkBox1.Checked;
            button1.Visible = checkBox1.Checked;

        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            textBox3.UseSystemPasswordChar = false;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUp();
        }
    }

    
}
