using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MadinatSanaa_Sales.BL
{
    class AddContract
    {
        public DataTable GetConId()
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();


            dt = Dal.ExecutQuery("GetLastItemId", null);
           
            return dt;

        }
        
             public DataTable GetLastorderIdForPrint()
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();


            dt = Dal.ExecutQuery("GetLastorderId", null);

            return dt;

        }
        public void Add_Order(int id, String note, DateTime date,
         String salesMan, int cust_id,double total,double debt)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@orders_id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@order_date", SqlDbType.DateTime);
            param[1].Value = date;

            param[2] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[2].Value = cust_id;

            param[3] = new SqlParameter("@notes", SqlDbType.VarChar, 250);
            param[3].Value = note;

            param[4] = new SqlParameter("@salesman", SqlDbType.VarChar, 75);
            param[4].Value = salesMan;
            param[5] = new SqlParameter("@total", SqlDbType.Float);
            param[5].Value = total;
            param[6] = new SqlParameter("@debt", SqlDbType.Float);
            param[6].Value = debt;


            Dal.ExecuteUpdate("Add_Oreder", param);


        }
        //////////////////////////////////////
        public void OrderDetails(string item_id,int Order_id,int qty,
            string price,
        double disCount, string PriceAfterQ,string total)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[7 ];

            param[0] = new SqlParameter("@item_id", SqlDbType.VarChar,30);
            param[0].Value = item_id;

            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = Order_id;

            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[2].Value = qty;

            param[3] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@DisCount", SqlDbType.Float);
            param[4].Value = disCount;
            param[5] = new SqlParameter("@Amount", SqlDbType.VarChar, 50);
            param[5].Value = PriceAfterQ;
            param[6] = new SqlParameter("@Total", SqlDbType.VarChar, 50);
            param[6].Value = total;


            Dal.ExecuteUpdate("OrderDetails", param);


        }
        /// <summary>
        /// /////اضافةكل ماتم تعديلة على الفواتير
        /// </summary>
        /// <param name="item_id"></param>
        /// <param name="Order_id"></param>
        /// <param name="qty"></param>
        /// <param name="price"></param>
        /// <param name="disCount"></param>
        /// <param name="PriceAfterQ"></param>
        /// <param name="total"></param>
        public void OrderDetailsLog(DateTime logDate, int Order_id, string item_id, int qty,
           string price, double disCount, string PriceAfterQ, string total , string notes)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@LogDate", SqlDbType.DateTime);
            param[0].Value = logDate;

            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = Order_id;

            param[2] = new SqlParameter("@item_id", SqlDbType.VarChar, 30);
            param[2].Value = item_id;

            param[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[3].Value = qty;

            param[4] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            param[4].Value = price;

            param[5] = new SqlParameter("@DisCount", SqlDbType.Float);
            param[5].Value = disCount;

            param[6] = new SqlParameter("@Amount", SqlDbType.VarChar, 50);
            param[6].Value = PriceAfterQ;

            param[7] = new SqlParameter("@Total", SqlDbType.VarChar, 50);
            param[7].Value = total;

            param[8] = new SqlParameter("@note", SqlDbType.VarChar, 50);
            param[8].Value = notes;



            Dal.ExecuteUpdate("SaveBaseLog", param);


        }
        //////////////////////
        /// <summary>
        /// هذه الدالة تتحقق من الكمية وان لاتتعدر الكمية
        /// </summary>
        /// <param name="id"></param>
        /// <param name="qty"></param>
        /// <returns></returns>
        public DataTable VerifyQty(String id, int qty)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@item_id", SqlDbType.VarChar, 30);
            param[0].Value = id;
            param[1] = new SqlParameter("@Qty_entered", SqlDbType.Int);
            param[1].Value = qty;

            dt = Dal.ExecutQuery("VerifyQty", param);

            return dt;

        }
        ////////////////
        public DataTable GetOrderDetails(int id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;


            dt = Dal.ExecutQuery("ReportOrder", param);

            return dt;

        }

        public DataTable SearchOrders(string id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cretiria", SqlDbType.VarChar, 50);
            param[0].Value = id;


            dt = Dal.ExecutQuery("SearchOrders", param);

            return dt;

        }
        public DataTable SearchLogs(string id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cretiria", SqlDbType.VarChar, 50);
            param[0].Value = id;


            dt = Dal.ExecutQuery("SearchLogs", param);

            return dt;

        }

        public DataTable SearchOrderDetails(string id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@critiria", SqlDbType.VarChar, 50);
            param[0].Value = id;


            dt = Dal.ExecutQuery("SearchOrderDetails", param);

            return dt;

        }
        /// <summary>
        /// //////////////// GEt Order Details for Update
        /// </summary>
        /// <param name="order_id"></param>
        /// <returns></returns>

        public DataTable GetDetailsByOrderID(int order_id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@order_Id", SqlDbType.Int);
            param[0].Value = order_id;


            dt = Dal.ExecutQuery("GetDetailsByOrderID", param);

            return dt;

        }


        ////////////////////////////////////////////////////
        // هذه الدوال ال3 لكي نحذف فاتورة واحدة
        ////////////////////////////
        public DataTable GetItemIDForUpdatingQty(int order_id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = order_id;


            dt = Dal.ExecutQuery("GetItemIDForUpdatingQty", param);

            return dt;

        }
        //
        public DataTable GetQtyBeforeDelete(string item_id,int order_id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@item_id", SqlDbType.VarChar,30);
            param[0].Value = item_id;
            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = order_id;


            dt = Dal.ExecutQuery("GetQtyBeforeDelete", param);

            return dt;

        }
        ////////////////////////
        public void updateQtyBeforeDelete(string item_id,int qtyToUpdate)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@item_id", SqlDbType.VarChar, 30);
            param[0].Value =item_id;
            param[1] = new SqlParameter("@qty", SqlDbType.Int);
            param[1].Value = qtyToUpdate;


            Dal.ExecuteUpdate("updateQtyBeforeDelete", param);
            

        }
        /////////////////////////////////////
        public void DeleteOrder(int order_id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = order_id;
            


             Dal.ExecuteUpdate("DeleteOrder", param);

           

        }

        // Update Order
        public void Update_Order(int id, DateTime date,
       String note, int cust_id, double total,double debt)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@order_date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@note", SqlDbType.VarChar, 250);
            param[2].Value = note;

            param[3] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[3].Value = cust_id;

            

            param[4] = new SqlParameter("@total", SqlDbType.Float);
            param[4].Value = total;
            param[5] = new SqlParameter("@debt", SqlDbType.Float);
            param[5].Value = debt;


            Dal.ExecuteUpdate("UpdateOrder", param);


        }
        //// Update order details
        public void UpdateOrderDetails(string item_id, int Order_id, int qty,
           string price,
       double disCount, string PriceAfterQ, string total, int qtyAfterUpdate)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@item_id", SqlDbType.VarChar, 30);
            param[0].Value = item_id;

            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = Order_id;

            param[2] = new SqlParameter("@qty", SqlDbType.Int);
            param[2].Value = qty;

            param[3] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@DisCount", SqlDbType.Float);
            param[4].Value = disCount;
            param[5] = new SqlParameter("@Amount", SqlDbType.VarChar, 50);
            param[5].Value = PriceAfterQ;
            param[6] = new SqlParameter("@Total", SqlDbType.VarChar, 50);
            param[6].Value = total;
            param[7] = new SqlParameter("@qtyAfterUpdate", SqlDbType.Int);
            param[7].Value = qtyAfterUpdate;


            Dal.ExecuteUpdate("UpdateOrderDetails", param);


        }

    }
}
