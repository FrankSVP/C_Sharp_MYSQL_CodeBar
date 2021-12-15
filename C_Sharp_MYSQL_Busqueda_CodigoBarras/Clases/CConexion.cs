using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_MYSQL_Busqueda_CodigoBarras.Clases
{
    class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "barrasdb";
        static string usuario = "root";
        static string password = "root";
        static string puerto = "3307";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";


        public MySqlConnection establecerConexion() {

            try {
                conex.ConnectionString = cadenaConexion;
                //conex.Open();
               // MessageBox.Show("Se logró conectar a la Base de Datos");

            }
            
            catch (MySqlException e) {

                MessageBox.Show("No se logró conectar a la base de datos, error: "+ e.ToString());
            
            }

            return conex;
        
        }

    }
}
