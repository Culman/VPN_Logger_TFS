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
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;

namespace TFS_VPN_Logger
{
    public partial class FormMain : Form
    {
        

        ADFactory ADFactory = new ADFactory();
        private ArrayList targetArrayList = new ArrayList();
        bool isProd;
        string env;
        private int vendorid;

        public FormMain()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now;
            isProd = true;
            env = "PROD";
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
            vendorid = 1;
            if (isProd==true)
            {
                listBox1.DataSource = ADFactory.Users(ConfigurationManager.AppSettings["cisprod"]);
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "SID";
            }

            else
            {
                listBox1.DataSource = ADFactory.Users(ConfigurationManager.AppSettings["cis"]);
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "SID";

            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button602_Click(object sender, EventArgs e)
        {
            vendorid = 2;
            if (isProd==true)
            {
                listBox1.DataSource = ADFactory.Users(ConfigurationManager.AppSettings["sw602prod"]);
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "SID";

            }

            else
            {
                listBox1.DataSource = ADFactory.Users(ConfigurationManager.AppSettings["sw602"]);
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "SID";
            }



        }

        private void buttonAmbica_Click(object sender, EventArgs e)
        {
            vendorid = 3;
            if (isProd==true)
            {
                listBox1.DataSource = ADFactory.Users(ConfigurationManager.AppSettings["ambicaprod"]);
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "SID";
            }
            else
            {
                listBox1.DataSource = ADFactory.Users(ConfigurationManager.AppSettings["ambica"]);
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "SID";
            }



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
            UserPrincipal userPrinci = UserPrincipal.FindByIdentity(principalCon, IdentityType.Sid, "CIS.PP.LB");
            userPrinci.Enabled = false;
            userPrinci.Description = "Láda Baran";
            userPrinci.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO: zvalidovat vsechny vstupy pred vytvorenim xml atd...
            if (listBox2.Items == null || listBox2.Items.Count == 0) return;
            if (textBox1.Text=="" || textBox2.Text=="") 
            { MessageBox.Show("Description or Requestor Link must have a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                { MessageBox.Show("Time-frame is incorrect, value of 'To' needs to be in the future against value of 'From'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                return;
            }


            XElement users = new XElement("Users");
            foreach (ADUser user in listBox2.Items)
            {
                users.Add(new XElement("User", new XAttribute("Name", user.Name), new XAttribute("SID", user.SID), new XAttribute("Vendor", vendorid)
                    ));
            }
            XDocument xmldoc = new XDocument(
                new XElement("Input",
                users,
                new XElement("From", TimeConverter(dateTimePicker1.Value)),
                new XElement("To", TimeConverter(dateTimePicker2.Value)),
                new XElement("SubmitedBy", GetDisplayName()),
                new XElement("Environment", env),
                new XElement("RequestorID", textBox2.Text),
                new XElement("ReasonText",textBox1.Text)
                )
                );

            var SQL = new SQLFactory();


            SQL.WriteToDB(xmldoc.ToString());
            MessageBox.Show("The request has been successfully created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
            Environment.Exit(0);


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isProd = true;
             env = "PROD";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isProd = false;
            env = "TEST";
        }


        public DateTime TimeConverter (DateTime inputDatetime)
        {

            return DateTime.SpecifyKind(inputDatetime.AddMinutes(3), DateTimeKind.Local);
             
        }






    }
}
