using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace App_Inventario
{
    internal class funciones
    {
        //static string cadena_conexion = "Server = localhost; User = root; Password = ; Database = cooler";
        //MySqlConnection conexion = new MySqlConnection(cadena_conexion);

        public static void login(string usuario, string contr)
        {
            string cadenaConexion = "Server = localhost; User = root; Password = ; Database = cooler";
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                string consulta = "SELECT Usuario, Password FROM usuarios WHERE Usuario = @usuario AND Password = @contr";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contr", contr);

                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    string username = reader["Usuario"].ToString();
                    MessageBox.Show("Bienvenido " + username);
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe en la base de datos");
                }
                reader.Close();
                conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
