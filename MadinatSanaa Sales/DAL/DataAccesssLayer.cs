using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MadinatSanaa_Sales.DAL
{
    class DataAccesssLayer
    {
        // this class is the direct path to the database 
        SqlConnection sqlConnection; // the class that sets a connection path to db
        public DataAccesssLayer()
        {
            // first parameter is the server = jdbc url in java
            // the . means localhost and @ to allow "/"
            // if we open with windows authintecation we make intregrity as true 
            sqlConnection = new SqlConnection(@"server= .\SQLEXPRESS; Database= MadinatSales_d; Integrated Security=false; User ID=sa; Password=moh123456");

        }
        // open aconnection is it is not open
        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        // cloe aconnection is it is  open
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        // read from database
        // data table is like result set in java
        // we sat it as an array because we don't know how many parameters
        public DataTable ExecutQuery(String stored_procesure, SqlParameter[] param)
        {
            
            
                // sql command is the one excute the procedure
                // sqlcommand = statment
                SqlCommand sqlcmd = new SqlCommand();
                // its type is defined by the stored procedure; its type is stored procedur
                sqlcmd.CommandType = CommandType.StoredProcedure;
                // the text should be executed is the stored procedure
                sqlcmd.CommandText = stored_procesure;
            // we should give the cammand the connection or th road to move in
            sqlcmd.Connection = sqlConnection;
                // we add the param to the command 
                // first chech
                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        sqlcmd.Parameters.Add(param[i]);
                    }
                }
                // raad data that is a result of excuting the stored procedure
                // sqladapter = methodes of select statment 
                // this will open and close the connection automatically
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

                // store the read data into adata table
                DataTable dt = new DataTable();
                da.Fill(dt);
            this.Close();
                return dt;

            
        }

        // update in database
        public void ExecuteUpdate(String stored_procesure, SqlParameter[] param)
        {

            this.Open();
            // sql command is the one excute the procedure
            // sqlcommand = statment
            SqlCommand sqlcmd = new SqlCommand();
            // its type is defined by the stored procedure; its type is stored procedur
            sqlcmd.CommandType = CommandType.StoredProcedure;
            // the text should be executed is the stored procedure
            sqlcmd.CommandText = stored_procesure;
            sqlcmd.Connection = sqlConnection;
            // we add the param to the command 
            // first chech
            if (param != null)
            {
               
                
                    sqlcmd.Parameters.AddRange(param);
                
            }
           
            // perform upadtion
            sqlcmd.ExecuteNonQuery();
            this.Close();
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////
        /// this is just for trying to retrieve an image
        /// </summary>
        /// <param name="stored_procesure"></param>
        /// <returns></returns>

        public SqlDataReader Execut(String stored_procesure)
        {


           
            SqlCommand sqlcmd = new SqlCommand(stored_procesure,sqlConnection);
            // its type is defined by the stored procedure; its type is stored procedur
            //sqlcmd.Connection = sqlConnection;
            
            
            SqlDataReader da = sqlcmd.ExecuteReader();
            //da.Read();
           
            DataTable dt = new DataTable();
            //da.Fill(dt);
            
            return da;
           


        }

    }
}

