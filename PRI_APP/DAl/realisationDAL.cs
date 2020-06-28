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
    class realisationDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region selectioner employer
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Realisation";
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
        public bool Insert(realisationBLL u)
        {

            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO Realisation (Matricule,NinvMachine,ReferancePieces,QuantitéRealiser,Rebut,TempsOpration,DateRealisation,Cfi,Noperation,TempsRealisation,Id) VALUES (@Matricule,@NinvMachine,@ReferancePieces,@QuantitéRealiser,@Rebut,@TempsOpration,@DateRealisation,@Cfi,@Noperation,@TempsRealisation,@Id) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Matricule", u.Matricule);
                cmd.Parameters.AddWithValue("@NinvMachine", u.NinvMachine);
                cmd.Parameters.AddWithValue("@ReferancePieces", u.ReferancePieces);
                cmd.Parameters.AddWithValue("@QuantitéRealiser", u.QuantitéRéaliser);
                cmd.Parameters.AddWithValue("@Rebut", u.Rebut);
                cmd.Parameters.AddWithValue("@TempsOpration", u.TempsOpration);
                cmd.Parameters.AddWithValue("@DateRealisation", u.DateRealisation);
                cmd.Parameters.AddWithValue("@Cfi", u.Cfi);
                cmd.Parameters.AddWithValue("@Noperation", u.Noperation);
                cmd.Parameters.AddWithValue("@TempsRealisation", u.TempsOpration);
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
        public bool Modifier(realisationBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Realisation set Matricule=@Matricule,NinvMachine=@NinvMachine,ReferancePieces=@ReferancePieces,QuantitéRealiser=@QuantitéRealiser,Rebut=@Rebut,TempsOpration=@TempsOpration,DateRealisation=@DateRealisation,Cfi=@Cfi,Noperaion=@Noperation,TempsRealisation=@TempsRealisation,Id=@Id where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Matricule", u.Matricule);
                cmd.Parameters.AddWithValue("@NinvMachine", u.NinvMachine);
                cmd.Parameters.AddWithValue("@ReferancePieces", u.ReferancePieces);
                cmd.Parameters.AddWithValue("@QuantitéRealiser", u.QuantitéRéaliser);
                cmd.Parameters.AddWithValue("@Rebut", u.Rebut);
                cmd.Parameters.AddWithValue("@TempsOpration", u.TempsOpration);
                cmd.Parameters.AddWithValue("@DateRealisation", u.DateRealisation);
                cmd.Parameters.AddWithValue("@Cfi", u.Cfi);
                cmd.Parameters.AddWithValue("@Noperation", u.Noperation);
                cmd.Parameters.AddWithValue("@TempsRealisation", u.TempsOpration);
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
        public bool Delete(realisationBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "delete FROM Realisation where Id=@Id";
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
                string sql = "SELECT * FROM Realisation where Matricule like '%" + sherche + "%' or  Cfi like '%" + sherche + "%' or  DateRealisation like '%" + sherche + "%'  ";
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
