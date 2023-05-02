using FinalProj_SftApps.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProj_SftApps
{
    public partial class Home : Form
    {
        Train tobj = new Train("1148", "Diesel", 500000);
        
        string message = "RailCar Added!";
        string title = "Successful";


        public Home()
        {
            InitializeComponent();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Trains' table. You can move, or remove it, as needed.
            this.trainsTableAdapter.Fill(this.dataSet2.Trains);
            
        }
        
        private void Load_ListView()
        {
            
                int count = tobj.cars.Count();
                for(int i = 0; i < count; i++)
                {
                    string[] raw = { tobj.cars[i].SN, tobj.cars[i].MaxWeight, tobj.cars[i].MaxPass };
                     var listeviewitem = new ListViewItem(raw);
                    listView1.Items.Add(listeviewitem);
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(message, title);
            tobj.cars.Add(new RailCar(Notext.Text,MaxwText.Text,MaxpassText.Text));
            Load_ListView();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginfrm = new Login();
            loginfrm.Show();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }
    }
}
