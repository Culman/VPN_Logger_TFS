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
using System.Collections;

namespace TFS_VPN_Logger
{
    public partial class FormMain : Form
    {
        

        ADFactory ADFactory = new ADFactory();
        private ArrayList targetArrayList = new ArrayList();

        public FormMain()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";


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

            /*listBox1.DataSource = ADFactory.FetchADUsers(ConfigurationManager.AppSettings["cis"]);*/

            listBox1.DataSource = ADFactory.Users(ConfigurationManager.AppSettings["cis"]);
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "SID";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button602_Click(object sender, EventArgs e)
        {       

            listBox1.DataSource = ADFactory.Users(ConfigurationManager.AppSettings["sw602"]);
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "SID";


        }

        private void buttonAmbica_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = ADFactory.Users(ConfigurationManager.AppSettings["ambica"]);
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "SID";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null) return;
            listBox2.DataSource = null;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "SID";
            var selectedObejct = listBox1.SelectedItem;
            if (!targetArrayList.Contains(selectedObejct))
            {
                targetArrayList.Add(selectedObejct);
              
            }
            listBox2.DataSource = targetArrayList;
         


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null) return;

            targetArrayList.Remove(listBox2.SelectedItem);
            listBox2.DataSource = null;


            listBox2.DataSource = targetArrayList;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "SID";

        }

        private void buttontest_Click(object sender, EventArgs e)
        {

            PrincipalContext principalCon = new PrincipalContext(ContextType.Domain, "CZ.Toyota-fs.com");
            UserPrincipal userPrinci = UserPrincipal.FindByIdentity(principalCon, IdentityType.SamAccountName, "CIS.PP.LB");
            userPrinci.Enabled = false;
            userPrinci.Description = "Láda Baran";
            userPrinci.Save();
        }
    }
}
