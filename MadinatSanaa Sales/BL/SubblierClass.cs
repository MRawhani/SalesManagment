using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MadinatSanaa_Sales.BL
{
    class SubblierClass
    {
        public void Add_Subblier(String first_name, String last_name,
            string phone, String address, double credit)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar, 25);
            param[0].Value = first_name;
            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;

            param[2] = new SqlParameter("@phone", SqlDbType.NChar, 15);
            param[2].Value = phone;
            param[3] = new SqlParameter("@address", SqlDbType.VarChar, 25);
            param[3].Value = address;
            param[4] = new SqlParameter("@credit", SqlDbType.Float);
            param[4].Value = credit;


            Dal.ExecuteUpdate("Add_Sub", param);


        }
        /// <summary>
        /// /////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public void updateSubblier(String first_name, String last_name,
          string phone, String address, double credit, int id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar, 25);
            param[0].Value = first_name;
            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;

            param[2] = new SqlParameter("@phone", SqlDbType.NChar, 15);
            param[2].Value = phone;
            param[3] = new SqlParameter("@address", SqlDbType.VarChar, 25);
            param[3].Value = address;
            param[4] = new SqlParameter("@credit", SqlDbType.Float);
            param[4].Value = credit;
            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Value = id;




            Dal.ExecuteUpdate("updateSubb", param);


        }
        /////////////////////////////////
        public DataTable getAllSubb()
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();


            dt = Dal.ExecutQuery("getAllSubb", null);

            return dt;

        }

        /// <summary>
        /// /////////////////////////////////////
        /// </summary>
        /// <param name="id"></param>
        /// 

        public DataTable SearchSubb(String id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dt = Dal.ExecutQuery("SearchSubb", param);
           
            return dt;

        }

        ///////////////////////////////////////
        public void DeleteSubblier(int id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            Dal.ExecuteUpdate("DeleteSubb", param);


        }
    }
}
