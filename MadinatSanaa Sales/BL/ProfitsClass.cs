using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MadinatSanaa_Sales.BL
{
    class ProfitsClass
    {
        public DataTable GetLastProfitsId()
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();


            dt = Dal.ExecutQuery("GetLastProfitsId", null);

            return dt;

        }

        public void AddProfit(int id, DateTime date,double price,
    int cust_id, int order_id, string note)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@date", SqlDbType.DateTime);
            param[1].Value = date;

            param[2] = new SqlParameter("@price", SqlDbType.Float);
            param[2].Value = price;

            param[3] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[3].Value = cust_id;

            param[4] = new SqlParameter("@order_id", SqlDbType.Int);
            param[4].Value = order_id;

            param[5] = new SqlParameter("@note", SqlDbType.VarChar, 150);
            param[5].Value = note;

            Dal.ExecuteUpdate("AddProfit", param);


        }


        public void UpdateProfit(DateTime date, double price, int order_id, string note)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;
            param[1] = new SqlParameter("@price", SqlDbType.Float);
            param[1].Value = price;
           

            param[2] = new SqlParameter("@order_id", SqlDbType.Int);
            param[2].Value = order_id;

            param[3] = new SqlParameter("@note", SqlDbType.VarChar, 150);
            param[3].Value = note;


            Dal.ExecuteUpdate("UpdateProfit", param);


        }
        
            public DataTable GetProfitPeforeUpdating( int order_id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = order_id;


            dt = Dal.ExecutQuery("GetProfitPeforeUpdating", param);

            return dt;



        }


        //////////////////////////////////////////////////////////////////////
        // سندات القبض

        public DataTable GetMoneyLastId()
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();


            dt = Dal.ExecutQuery("GetMoneyLastId", null);

            return dt;

        }

        public void AddMoney(int id, DateTime date, int cust_id, double price,
    int order_id, string note)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[2].Value = cust_id;

            param[3] = new SqlParameter("@price", SqlDbType.Float);
            param[3].Value = price;

            param[4] = new SqlParameter("@order_id", SqlDbType.Int);
            param[4].Value = order_id;



            param[5] = new SqlParameter("@note", SqlDbType.VarChar, 150);
            param[5].Value = note;

            Dal.ExecuteUpdate("AddMoney", param);


        }
        public void AddMoneyWithoutorder(int id, DateTime date, int cust_id, double price, string note)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[2].Value = cust_id;

            param[3] = new SqlParameter("@price", SqlDbType.Float);
            param[3].Value = price;

            



            param[4] = new SqlParameter("@note", SqlDbType.VarChar, 150);
            param[4].Value = note;

            Dal.ExecuteUpdate("AddMoneyWithoutorder", param);


        }


        public void UpdateMoney(int id, DateTime date, double price, string note,double prevPrice, int cust_id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@date", SqlDbType.DateTime);
            param[1].Value = date;
         

            param[2] = new SqlParameter("@price", SqlDbType.Float);
            param[2].Value = price;





            param[3] = new SqlParameter("@note", SqlDbType.VarChar, 150);
            param[3].Value = note;
            param[4] = new SqlParameter("@prevPrice", SqlDbType.Float);
            param[4].Value = prevPrice;
            param[5] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[5].Value = cust_id;

            Dal.ExecuteUpdate("UpdateMoney", param);


        }

        public void DeleteMoney(int id,  int cust_id, double price)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[1].Value = cust_id;
            param[2] = new SqlParameter("@price", SqlDbType.Float);
            param[2].Value = price;

          

            Dal.ExecuteUpdate("DeleteMoney", param);


        }
        public DataTable ShowAllGetMoney()
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();


            dt = Dal.ExecutQuery("ShowAllGetMoney", null);

            return dt;

        }


    }
}
