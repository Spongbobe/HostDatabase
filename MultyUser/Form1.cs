using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultyUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            if(fd.FileName.Length > 0)
            {
                pictureBox1.Image =Image.FromFile(fd.FileName);
            }
        }

        private void LoadDataUser()
        {
            DataAccess.AccountAccess userAccess = new DataAccess.AccountAccess();
            var ouptput = userAccess.GetAllUserAccount();

            foreach (var item in ouptput)
            {
                comboBox1.Items.Add(item.acount);
            }

        }
        private void UserData(ListBox lb,string accountName)
        {
            DataAccess.AccountAccess userAccess = new DataAccess.AccountAccess();
            var output = userAccess.GetAccountData(accountName);

            /*lb.DataSource = output;
            lb.DisplayMember = "ImagePath";*/

            foreach (var item in output)
            {
                comboBox1.Items.Add(item.ImagePath);
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess.AccountAccess userAccess = new DataAccess.AccountAccess();

            if (comboBox1.Text.ToString().Length >0)
            {
                Console.WriteLine(listBox1.Text);

                listBox1.Items.Clear();
                foreach (var item in userAccess.GetAccountData(comboBox1.SelectedItem.ToString()))
                {
                    listBox1.Items.Add(item.ImagePath);
                }
                /* var crrItem = comboBox1.SelectedItem as Models.Account;
                 accountUser.Text = string.Format("Account : {0}", crrItem.acount);
                 UserData(listBox1, crrItem.acount);*/

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var crrItem = listBox1.SelectedItem as Models.Account;
            var crrItem = listBox1.SelectedItem.ToString();
            try
            {
                pictureBox1.ImageLocation = crrItem;

            }
            catch (Exception)
            {
                pictureBox1.Image = Image.FromFile(crrItem);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }
    }
}
