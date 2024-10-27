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
    internal class Funciones
    {
        //rectificar cambios
        public static void Login(string usuario, string contr)
        {
            string cadenaConexion = "Server = localhost; User = root; Password = ; Database = cooler";
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contr))
            {
                MessageBox.Show("Completa los datos para continuar", "Error");
            }
            else
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT Usuario, Password, Cargo FROM usuarios WHERE Usuario = @usuario AND Password = @contr";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contr", contr);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string cargo = reader["Cargo"].ToString();
                        if (cargo == "Almacenista")
                        {
                            string username = reader["Usuario"].ToString();
                            MessageBox.Show("Bienvenido " + username);
                            Inicio inicio = new Inicio();
                            inicio.Show();
                        }else if (cargo == "Admin")
                        {
                            string username = reader["Usuario"].ToString();
                            MessageBox.Show("Bienvenido " + username);
                            Admin admin = new Admin();
                            admin.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe en la base de datos");
                    }
                    reader.Close();
                    conexion.Close();
                }
                catch (Exception ex)
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

        public static void cargarInventarioSeven(DataGridView dataGridView)
        {
            string cadena_conexion = "Server = localhost; User = root; Password = ; Database = cooler";
            MySqlConnection conexion = new MySqlConnection(cadena_conexion);

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                conexion.Open();
                string consulta = "SELECT idMaterial as Id, Material, Cantidad FROM inventarioseven";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dataGridView.DataSource = tabla;

                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al consultar el inventario de Seven " + ex.Message, "Error al consultar los datos.");
            }
        }

        public static void cargarInventarioOptima(DataGridView dataGridView)
        {
            string cadenaConexion = "Server = localhost; User = root; Password = ; Database = cooler";
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                conexion.Open();
                string consulta = "SELECT idMaterial AS Id, Material, Cantidad FROM inventariooptima";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dataGridView.DataSource = tabla;

                conexion.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al consultar el inventario de Optima " + ex.Message, "Error al consultar los datos.");
            }
        }

        public static void cargarInventarioFrunatural(DataGridView dataGridView)
        {
            string cadenaConexion = "Server = localhost; User = root; Password = ; Database = cooler";
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                conexion.Open();
                string consulta = "SELECT idMaterial AS Id, Material, Cantidad FROM inventariofrunatural";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dataGridView.DataSource = tabla;

                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al consultar el inventario de Frunatural " + ex.Message, "Error al consultar los datos.");
            }
        }
    }
}
