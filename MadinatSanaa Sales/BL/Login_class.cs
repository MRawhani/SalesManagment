using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MadinatSanaa_Sales.BL
{
    class Login_class
    {
        // these parameter willbe snet to te stored proc in the databse

        public DataTable Login(String id, String pass)
        {
            // this method is for calling the stored procedure 
            // ths equals the callable ststment java Video 89
            // every data base has its own language to store stored procedure
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 20);
            param[0].Value = id;

            param[1] = new SqlParameter("@pasword", SqlDbType.VarChar, 20);
            param[1].Value = pass;

            Dal.Open();
            DataTable dt = new DataTable();
            // this will pass the name of the procedure 
            // and the method will deal with the prcedure 
            // the load of the sql statment will be dine in the server
             dt= Dal.ExecutQuery("logIn", param);
            Dal.Close();
            return dt;

        }
    }
}
