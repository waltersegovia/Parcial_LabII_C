using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ConexionDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand com;

        static ConexionDAO()
        {
            ConexionDAO.conexion = new SqlConnection(@"Data Source = .\SQLEXPRESS; initial catalog = JardinUtn; integrated security = true");
            ConexionDAO.com = new SqlCommand();
            ConexionDAO.com.CommandType = System.Data.CommandType.Text;
            ConexionDAO.com.Connection = ConexionDAO.conexion;
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static void InsertarDocente(Docente d)
        {
            try
            {
                conexion.Open();
                com.CommandText = "INSERT INTO Docentes (Nombre,Apellido,Edad,Sexo,Dni,Direccion,Email)" + "VALUES('" + d.Nombre + "','" + d.Apellido + "'," + d.Edad + ",'" + d.Sexo + "'," + d.Dni + ",'" + d.Direccion + "','" + d.Email + "')";
                com.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

        }

        /// <summary>
        /// Carga la Tabla de Alumnos
        /// </summary>
        /// <param name="alumnos"></param>
        /// <returns></returns>
        public static List<Alumno> Leer(List<Alumno> alumnos)
        {
            try
            {

                conexion.Open();
                com.Connection = conexion;
                com.CommandText = "select * from Alumnos";

                SqlDataReader dr = com.ExecuteReader();

                //Lee la base de datos y carga la lista de alumnos
                while (dr.Read())
                {
                    alumnos.Add(new Alumno((int)dr[0], dr[1].ToString(), dr[2].ToString(), (int)dr[3], (int)dr[4], dr[5].ToString()));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return alumnos;
        }

        public static void InsertarEvaluado(Evaluaciones ev)
        {
            try
            {
                conexion.Open();
                com.CommandText = "INSERT INTO Evaluaciones (idAlumno,idDocente,idAula,Nota_1,Nota_2,NotaFinal,Observaciones)" + "VALUES(" + ev.IdAlumno + "," + ev.IdDocente + "," + ev.IdAula + "," + ev.Nota_1 + "," + ev.Nota_2 + "," + ev.NotaFinal + ",'" + ev.Observaciones + "')";
                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

        }

        public static List<Aulas> Leer(List<Aulas> aulas)
        {
            try
            {

                conexion.Open();
                com.Connection = conexion;
                com.CommandText = "select * from Aulas";

                SqlDataReader dr = com.ExecuteReader();

                //Lee la base de datos y carga la lista de aulas
                while (dr.Read())
                {
                    aulas.Add(new Aulas((int)dr[0], dr[1].ToString()));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return aulas;
        }
    }
}
