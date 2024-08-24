using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtcontra.Text = "";
            txtnombre.Text = "";
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //creamos una instancia del formulario de inicio
            inicio form = new inicio(); 
            //Lo mostramos con show
            form.Show();
            // ocultamos el login
            this.Hide();
            //a la isntancia del formulario de inicio le asignamos el evento closing o cerrrando
            form.FormClosing += frm_closing;
        }
        //declaramos un evento, enviamos dos parametros uno un objetos y el otro el evento de cerrado del formulario
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            //mostramos el login de nuevo al cerrar el formulario
            this.Show();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
