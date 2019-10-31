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
    public partial class EmployeeFunctionalities : Form
    {
        Controller controllerObj;
        DataTable dt;
        public EmployeeFunctionalities(int a)
        {
            InitializeComponent();
            controllerObj = new Controller();
            if (a == 0) checkBox4.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dt = null;
            dt = controllerObj.EmployeeFunc(1);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else MessageBox.Show("No available data");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dt = null;
            dt = controllerObj.EmployeeFunc(2);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else MessageBox.Show("No available data");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(textBox1.Text, out parsedValue) || !int.TryParse(textBox2.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            int SSN = int.Parse(textBox1.Text);
            int Salary = int.Parse(textBox2.Text);
            int valid = controllerObj.UpdateEmployeeSalary(SSN, Salary);
            if (valid != 0) MessageBox.Show("Data updated successfully");
            else MessageBox.Show("No available data");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            dt = null;
            dt = controllerObj.EmployeeFunc(4);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else MessageBox.Show("No available data");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            dt = null;
            dt = controllerObj.EmployeeFunc(5);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else MessageBox.Show("No available data");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            dt = null;
            dt = controllerObj.EmployeeFunc(6);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else MessageBox.Show("No available data");
        }
    }
}
