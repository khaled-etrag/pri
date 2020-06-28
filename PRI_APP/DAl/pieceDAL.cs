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
    class pieceDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region selectioner employer
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Piece";
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
        public bool Insert(pieceBLL u)
        {

            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Piece (Referance,Designation,Operation,TempOp) VALUES (@Referance,@Designation,@Operation,@TempOp)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Referance", u.Referance);
                cmd.Parameters.AddWithValue("@Designation", u.Designation);
                cmd.Parameters.AddWithValue("@Operation", u.Operation);
                cmd.Parameters.AddWithValue("@TempOp", u.TempOp);
        
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
        public bool Modifier(pieceBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Piece set Referance=@Referance,Designation=@Designation,Operation=@Operation,TempOp=@TempOp where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Referance", u.Referance);
                cmd.Parameters.AddWithValue("@Designation", u.Designation);
                cmd.Parameters.AddWithValue("@Operation", u.Operation);
                cmd.Parameters.AddWithValue("@TempOp", u.TempOp);
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
        public bool Delete(pieceBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "delete FROM Piece where Id=@Id";
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
                string sql = "SELECT * FROM Piece where Referance like '%" + sherche + "%' or  Designation like '%" + sherche + "%'";
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
