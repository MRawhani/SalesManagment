using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MadinatSanaa_Sales.BL
{using System.Drawing;
using System.Drawing.Imaging;
    class ClothAddClass
    {
       

        // we don't need parameters cuz we will fetch all the table
        public DataTable CategoriesFetch()
        {
            // this method is for calling the stored procedure 
            // ths equals the callable ststment java Video 89
            // every data base has its own language to store stored procedure
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();
         
          
            DataTable dt = new DataTable();
            // this will pass the name of the procedure 
            // and the method will deal with the prcedure 
            // the load of the sql statment will be dine in the server
            dt = Dal.ExecutQuery("CategoriesFetch", null);
            Dal.Close();
            return dt;

        }
        

   public DataTable SubbliersFetch()
        {
            // this method is for calling the stored procedure 
            // ths equals the callable ststment java Video 89
            // every data base has its own language to store stored procedure
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            // this will pass the name of the procedure 
            // and the method will deal with the prcedure 
            // the load of the sql statment will be dine in the server
            dt = Dal.ExecutQuery("SubbliersFetch", null);
            Dal.Close();
            return dt;

        }


        // this method is for adding 
        // the order of parameters should be the same as the stored proc inthe database

        public void Add_Cloth(int id_cat,String item_id, String item_label,
            int quanitity, String price,int sub_id, byte[] image)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();
            Dal.Open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@item_id", SqlDbType.VarChar, 30);
            param[1].Value = item_id;

            param[2] = new SqlParameter("@item_label", SqlDbType.VarChar, 50);
            param[2].Value = item_label;

            param[3] = new SqlParameter("@quantity", SqlDbType.Int);
            param[3].Value = quanitity;

            param[4] = new SqlParameter("@price", SqlDbType.VarChar, 20);
            param[4].Value = price;

            param[5] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[5].Value = sub_id;
            param[6] = new SqlParameter("@item_image", SqlDbType.Image);
            param[6].Value = image;

            Dal.ExecuteUpdate("ADD_Cloth", param);
            Dal.Close();

        }
        // thsi is for checing hte primary key 
        public DataTable VertifyCloth(String id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_item", SqlDbType.VarChar,30);
            param[0].Value = id;
           
            dt = Dal.ExecutQuery("VertifyItemId", param);
            Dal.Close();
            return dt;

        }
        //ادارة البضائع
        public DataTable ShowAll()
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            

            dt = Dal.ExecutQuery("ShowClothes", null);
            Dal.Close();
            return dt;

        }
        public DataTable SearchClothes(String id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dt = Dal.ExecutQuery("SearchClothes", param);
            Dal.Close();
            return dt;

        }
        public DataTable SearchClothesWithSubName(String id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dt = Dal.ExecutQuery("SearchClothesWithSubName", param);
            Dal.Close();
            return dt;

        }



        public void DeleteClothes(String id, int qty, string price,int sub_id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();
          
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 30);
            param[0].Value = id;
            param[1] = new SqlParameter("@qty", SqlDbType.Int);
            param[1].Value = qty;
            param[2] = new SqlParameter("@price", SqlDbType.VarChar, 20);
            param[2].Value = price;
            param[3] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[3].Value = sub_id;


            Dal.ExecuteUpdate("DeleteClothes", param);
            Dal.Close();

        }
        /// <summary>
        /// /////////////////////////////////////////////
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Get_image(string id)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();


            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dt = Dal.ExecutQuery("Get_image", param);
            Dal.Close();
            return dt;

        }
        public byte[] Get_images(string id)
        {
            
                DAL.DataAccesssLayer dal = new DAL.DataAccesssLayer();
                String qu = " select * from Items where Item_id="+id+";";
                dal.Open();
               
            SqlDataReader dr = dal.Execut(qu);
            // dal.Close();
            dr.Read();
            byte[] buteimg = null;
          
               buteimg = (byte[])dr["Item_image"];
         
            // MemoryStream ms = new MemoryStream(buteimg);
            return buteimg;
        }


        ///////
        public void UpdateClothes(int id_cat, String item_id, String item_label,
           int quanitity, String price,int sub_id, byte[] image)
        {
            DAL.DataAccesssLayer Dal = new DAL.DataAccesssLayer();
            Dal.Open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@item_id", SqlDbType.VarChar, 30);
            param[1].Value = item_id;

            param[2] = new SqlParameter("@item_label", SqlDbType.VarChar, 50);
            param[2].Value = item_label;

            param[3] = new SqlParameter("@quantity", SqlDbType.Int);
            param[3].Value = quanitity;

            param[4] = new SqlParameter("@price", SqlDbType.VarChar, 20);
            param[4].Value = price;

            param[5] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[5].Value = sub_id;
            param[6] = new SqlParameter("@item_image", SqlDbType.Image);
            param[6].Value = image;

            Dal.ExecuteUpdate("updateClothes", param);
            Dal.Close();

        }

    }
}
