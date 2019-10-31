using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class DepartmentFunctionalities : Form
    {
        Controller controllerObj;
        DataTable dt;

        public DepartmentFunctionalities(int a)
        {
            InitializeComponent();
            controllerObj = new Controller();
            if (a == 0) checkBox3.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dt = null;
            dt = controllerObj.DeptFunc(1);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else MessageBox.Show("No available data");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dt = null;
            dt = controllerObj.DeptFunc(2);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else MessageBox.Show("No available data");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(textBox1.Text, out parsedValue) || !int.TryParse(textBox3.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            int Dnumber = int.Parse(textBox1.Text);
            int Mgr_SSN = int.Parse(textBox3.Text);
            string Mgr_Start_Date = textBox4.Text.ToString();
            string Dlocation = textBox2.Text.ToString();
            string Dname = textBox5.Text.ToString();

            int valid = controllerObj.InsertDepartment(Dnumber, Mgr_SSN, Mgr_Start_Date, Dlocation, Dname);
            if(valid != 0) MessageBox.Show("New Department inserted Successfully");
            else MessageBox.Show("Something is wrong , try again");
        }
    }
}
