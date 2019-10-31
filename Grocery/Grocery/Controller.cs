using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Grocery
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public int DeleteOrder(int id)
        {
            /*
             * This function is used to delete a specific order 
             * Parameters:
                      id(int):the id of the order to be deleted
             */
            string OrderDetailsQuery = "DELETE FROM [Order_Details] WHERE order_id=" + id + ";";
            string OrderQuery = "DELETE FROM [Order] WHERE id=" + id + ";";
            dbMan.ExecuteNonQuery(OrderDetailsQuery);
            return dbMan.ExecuteNonQuery(OrderQuery);
        }
        public int InsertItemToOrder(int orderId,string productId,int amount)
        {
            /*
             * This function is used to add an item an order
             * Parameters:
                      orderId(int):the id of the order to which wew will add an item
                      productId(string):the id of the product added to the order
                      amount(int):the quantity of the product that is ordered
             */
            string query = "INSERT INTO Order_Details (order_id, product_id,amount) " +
                            "Values (" + orderId + ",'" + productId + "'," + amount + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertNewOrder(int orderId, string productId, int amount, int CustomerID)
        {
            /*
             * This function is used to add a new order
             * Parameters:
                      orderId(int):the id of the order to which wew will add an item
                      productId(string):the id of the product added to the order
                      amount(int):the quantity of the product that is ordered
             */
            string query = "insert into [Order](id, customer_id, order_date, Status)" +
                "Values(" + orderId + ", " + CustomerID + ", GETDATE(), 0);";
            dbMan.ExecuteNonQuery(query);

            query = "INSERT INTO Order_Details (order_id, product_id,amount) " +
                            "Values (" + orderId + ",'" + productId + "'," + amount + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable FillComboBox(String entity)
        {
            String query = "SELECT * FROM " + entity + ";";
            DataTable table = dbMan.ExecuteReader(query);
            return table;
        }
        public DataTable OrderData(int id)
        {
            String query = "SELECT * FROM [Order] INNER JOIN [Order_Details] ON [Order].id = " + id + "AND Order_Details.order_id = " + id + ";";
            DataTable table = dbMan.ExecuteReader(query);
            return table;
        }
    }
}
