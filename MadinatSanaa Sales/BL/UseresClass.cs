using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MadinatSanaa_Sales.BL
{
    class UseresClass
    {
        public void Add_user(string id, String pwd,
        String type, string name)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 20);
            param[0].Value = id;

            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 20);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 20);
            param[2].Value = type;

            param[3] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[3].Value = name;



            Dal.ExecuteUpdate("InsertUser", param);


        }

        public DataTable Searchusers(string id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cretiria", SqlDbType.VarChar, 50);
            param[0].Value = id;


            dt = Dal.ExecutQuery("SearchUsers", param);

            return dt;

        }
        public void Deleteuser(string id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar,20);
            param[0].Value = id;



            Dal.ExecuteUpdate("deleteUser", param);

            
        }
        }
    }
