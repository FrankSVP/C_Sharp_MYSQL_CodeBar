using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_MYSQL_Busqueda_CodigoBarras.Clases
{
    class CBusqueda
    {
        public void buscarCodigo(TextBox txtCodigo, TextBox txtNombre, TextBox txtapellidos) {
            CConexion objeto = new CConexion();

            MySqlConnection conn = objeto.establecerConexion();

            try{

                conn.Open();

                string sql = "select alumno.nombres, alumno.apellidos from alumno where alumno.id='"+ txtCodigo.Text+"'";

                MySqlCommand cmd = new MySqlCommand(sql,conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {

                    txtNombre.Text = rdr[0].ToString();
                    txtapellidos.Text = rdr[1].ToString();

                }

            }
            catch (Exception ex) {

                MessageBox.Show("No se logró realizar la búsqueda, error: " + ex.ToString());
            
            }


        }
    }
}
