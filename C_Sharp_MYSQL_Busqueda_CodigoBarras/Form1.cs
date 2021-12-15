using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_MYSQL_Busqueda_CodigoBarras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.CBusqueda objetoBusqueda = new Clases.CBusqueda();
            objetoBusqueda.buscarCodigo(txtcodigobarrasAlumno, txtnombres, txtapellidos);

        }

        private void txtcodigobarrasAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter) {
                Clases.CBusqueda objetoBusqueda = new Clases.CBusqueda();
                objetoBusqueda.buscarCodigo(txtcodigobarrasAlumno, txtnombres, txtapellidos);
                txtcodigobarrasAlumno.Text = "";

            }

         

        }
    }
}
