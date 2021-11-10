using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void orderTbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderTbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDbDataSet.StudentTb' table. You can move, or remove it, as needed.
            this.studentTbTableAdapter.Fill(this.studentDbDataSet.StudentTb);
            // TODO: This line of code loads data into the 'studentDbDataSet.OrderTb' table. You can move, or remove it, as needed.
            this.orderTbTableAdapter.Fill(this.studentDbDataSet.OrderTb);

        }
    }
}
