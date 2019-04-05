using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MadinatSanaa_Sales.BL
{
    class DebitsClass
    {
        public DataTable GetLastDebitId()
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();


            dt = Dal.ExecutQuery("GetLastDebitId", null);

            return dt;

        }

        public void AddDebit(int id, DateTime date,double price,
       int cust_id, int order_id,string note)
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



            param[5] = new SqlParameter("@note", SqlDbType.VarChar,150);
            param[5].Value = note;


            Dal.ExecuteUpdate("AddDebit", param);


        }
        public void UpdateDepit( DateTime date, double price,
       int cust_id, int order_id, string note,double PrevDebt)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[6];

          
            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;
            param[1] = new SqlParameter("@price", SqlDbType.Float);
            param[1].Value = price;
            param[2] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[2].Value = cust_id;

            param[3] = new SqlParameter("@order_id", SqlDbType.Int);
            param[3].Value = order_id;

            param[4] = new SqlParameter("@note", SqlDbType.VarChar, 150);
            param[4].Value = note;

            param[5] = new SqlParameter("@PrevDebt", SqlDbType.Float);
            param[5].Value = PrevDebt;

            Dal.ExecuteUpdate("UpdateDepit", param);


        }
    }
}
