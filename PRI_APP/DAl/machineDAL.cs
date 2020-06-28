using PRI_APP.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRI_APP.DAl
{
    class machineDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region selectioner employer
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Machine";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        #endregion
        #region insert data in datatable 
        public bool Insert(machineBLL u)
        {

            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Machine (Ninv,Designation,Cfi,Id) VALUES (@Ninv,@Designation,@Cfi,@Id) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ninv", u.Ninv);
                cmd.Parameters.AddWithValue("@Designation", u.Designation);
                cmd.Parameters.AddWithValue("@Cfi", u.Cfi);
                cmd.Parameters.AddWithValue("@Id", u.Id);
    
       
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        #endregion
        #region modifier la datatable
        public bool Modifier(machineBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Machine set Ninv=@Ninv,Designation=@Designation,Cfi=@Cfi,Id=@Id where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Ninv", u.Ninv);
                cmd.Parameters.AddWithValue("@Designatoin", u.Designation);
                cmd.Parameters.AddWithValue("@Cfi", u.Cfi);
                cmd.Parameters.AddWithValue("@Id", u.Id);
                
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }

        #endregion
        #region delete datatable
        public bool Delete(machineBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "delete FROM Machine where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", u.Id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }


        #endregion
        #region chercher to database
        public DataTable Cherche(string sherche)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Machine where Ninv like '%" + sherche + "%' or  Designation like '%" + sherche + "%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        #endregion
    }
}
