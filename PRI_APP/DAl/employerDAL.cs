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
    class employerDAL
    {


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region selectioner matricule

        public DataTable ChercheMatricuel(string Cfi)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT Matricule FROM employer where Cfi like '%" + Cfi + "%'  ";
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
        #region selectioner employer
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM employer";
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
        public bool Insert(employerBLL u)
        {

            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO EMPLOYER (Nom,Prenom,Matricule,Cfi,Fonction,Batiment) VALUES (@Nom,@Prenom,@Matricule,@Cfi,@Fonction,@Batiment) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@Nom", u.Nom);
                cmd.Parameters.AddWithValue("@Prenom", u.Prenom);
                cmd.Parameters.AddWithValue("@Matricule", u.Matricule);
                cmd.Parameters.AddWithValue("@Cfi", u.Cfi);
                cmd.Parameters.AddWithValue("@Fonction", u.Fonction);
                cmd.Parameters.AddWithValue("@Batiment", u.Batiment);
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
        public bool Modifier(employerBLL u)
        {
           bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Employer set Nom=@Nom,Prenom=@Prenom,Cfi=@Cfi,Fonction=@Fonction,Batiment=@Batiment where Matricule=@Matricule";
                SqlCommand cmd = new SqlCommand(sql,conn);
               
                cmd.Parameters.AddWithValue("@Nom", u.Nom);
                cmd.Parameters.AddWithValue("@Prenom", u.Prenom);
                cmd.Parameters.AddWithValue("@Matricule", u.Matricule);
                cmd.Parameters.AddWithValue("@Cfi", u.Cfi);
                cmd.Parameters.AddWithValue("@Fonction", u.Fonction);
                cmd.Parameters.AddWithValue("@Batiment", u.Batiment);
                
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
        public bool Delete(employerBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "delete FROM Employer where Matricule=@Matricule";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Matricule", u.Matricule);

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
                string sql = "SELECT * FROM employer where Matricule like '%"+sherche+ "%' or  Matricule like '%" + sherche + "%' or  Nom like '%" + sherche + "%' or  Prenom like '%" + sherche + "%' or  Cfi like '%" + sherche + "%' or  Fonction like '%" + sherche + "%' ";
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

