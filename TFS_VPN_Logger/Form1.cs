using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Configuration;


namespace TFS_VPN_Logger
{
    public partial class FormMain : Form
    {
        

        ADFactory ADFactory = new ADFactory();

        private List<string> targetlist = new List<string>();

        public FormMain()
        {
            InitializeComponent();
            

        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        public static String GetDisplayName()
        {
            
            String user = UserPrincipal.Current.DisplayName.ToString();
            return user;

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.labeluser.Text = "User: " + GetDisplayName();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCIS_Click(object sender, EventArgs e)
        {

            listBox1.DataSource = ADFactory.FetchADUsers(ConfigurationManager.AppSettings["cis"]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button602_Click(object sender, EventArgs e)
        {
            
            listBox1.DataSource = ADFactory.FetchADUsers(ConfigurationManager.AppSettings["sw602"]);

        }

        private void buttonAmbica_Click(object sender, EventArgs e)
        {
    
            listBox1.DataSource = ADFactory.FetchADUsers(ConfigurationManager.AppSettings["ambica"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return; 
            listBox2.DataSource = null;
            var selectedTtem = listBox1.SelectedItem.ToString();
            if (!targetlist.Contains(selectedTtem))
            {
                targetlist.Add(selectedTtem);
            }
           
            listBox2.DataSource = targetlist;

        }
    }
}
