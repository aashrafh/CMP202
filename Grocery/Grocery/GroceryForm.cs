using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery
{
    public partial class GroceryForm : Form
    {
        Controller controllerObj;

        public GroceryForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void productAddedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void GroceryForm_Load(object sender, EventArgs e)
        {
            //Fill the product ComboBox
            DataTable dt = controllerObj.FillComboBox("Product");
            productAddedComboBox.DataSource = dt;
            productAddedComboBox.DisplayMember = "name";
            productAddedComboBox.ValueMember = "id";
            productAddedComboBox.Update();

            //Fill the customer combobox
            dt = controllerObj.FillComboBox("Customer");
            customerComboBox.DataSource = dt;
            customerComboBox.DisplayMember = "name";
            customerComboBox.ValueMember = "id";
            customerComboBox.Update();

        }

        private void getPhoneButton_Click(object sender, EventArgs e)
        {
            String id = customerComboBox.SelectedValue.ToString();
            DataTable dt = controllerObj.FillComboBox("Customer");
            DataRow[] row = dt.Select("id = " + id);
            if(row.Length == 0) MessageBox.Show("Sorry no available data");
            else phoneDisplayTextBox.Text = row[0]["phone"].ToString();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int OrderID = int.Parse(orderIdTextBox.Text);
            int valid = controllerObj.DeleteOrder(OrderID);
            MessageBox.Show(valid.ToString());
            if (valid == 0) MessageBox.Show("Order not found, try again");
            else MessageBox.Show("Done");
        }

        private void showItemsButton_Click(object sender, EventArgs e)
        {
            int OrderID = int.Parse(orderIdTextBox.Text);
            DataTable dt = controllerObj.OrderData(OrderID);
            if(dt != null)
            {
                dt.Columns.Remove("order_id");
                orderDataGridView.DataSource = dt;
                orderDataGridView.Refresh();
            }
            else MessageBox.Show("Order not found, try again");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int OrderID = int.Parse(orderIdTextBox.Text);
            int OrderAmount = Decimal.ToInt32(amount.Value);
            String OrderProduct = productAddedComboBox.SelectedValue.ToString();
            DataTable dt = controllerObj.OrderData(OrderID);
            if (dt != null)
            {
                int valid = controllerObj.InsertItemToOrder(OrderID, OrderProduct, OrderAmount);
                if(valid == 0) MessageBox.Show("Failed, try again");
                else MessageBox.Show("Done");
            }
            else
            {
                int CustomerID = int.Parse(customerComboBox.SelectedValue.ToString());
                int valid = controllerObj.InsertNewOrder(OrderID, OrderProduct, OrderAmount, CustomerID);
                if (valid == 0) MessageBox.Show("Failed, try again");
                else MessageBox.Show("New order has been added successfully");
            }
        }

        private void customerInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
