using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDConexion
    {
        string stringConexion = "Server=localhost;User=root;Password=;Port=3306;database=obrasocial;convert zero datetime=True";

        public void Create(Afiliado paramAfiliado)
        {
            MySqlConnection conn = new MySqlConnection(stringConexion);
            string query = @"INSERT INTO afiliados (nombre,apellido,idplan,fechaalta,observaciones) VALUES (@nombre,@apellido,@idplan,@fechaalta,@observaciones)";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@nombre", paramAfiliado.Nombre);
            command.Parameters.AddWithValue("@apellido", paramAfiliado.Apellido);
            command.Parameters.AddWithValue("@idplan", paramAfiliado.IDPlan);
            command.Parameters.AddWithValue("@fechaalta", paramAfiliado.FechaAlta);
            command.Parameters.AddWithValue("@observaciones", paramAfiliado.Observaciones);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public DataSet Read()
        {
            DataSet ds = new DataSet();
            MySqlConnection conn = new MySqlConnection(stringConexion);
            string query = "SELECT * FROM afiliados";
            conn.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

            adapter.Fill(ds,"tabla");

            conn.Close();
            return ds;
        }

        public DataTable TraerPlanes()
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(stringConexion) ;
            string query = "SELECT * FROM planes";
            conn.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

            adapter.Fill(dt);

            conn.Close();
            return dt;
        }

        public DataSet TraerAfiliadoPlanesAdicionales()
        {
            DataSet ds = new DataSet();
            MySqlConnection conn = new MySqlConnection(stringConexion);
            string query = "SELECT * FROM afiliadoplanesadicionales";
            conn.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

            adapter.Fill(ds,"tabla");

            conn.Close();
            return ds;
        }
    }
}
