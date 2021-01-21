using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T19_Ex1
{
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // iniciamos ventana Saludador
            Saludador saludar = new Saludador();
            saludar.Show(); // mostramos ventana
            this.Hide(); // oculamos esta ventana
        }

        private void Message_Load(object sender, EventArgs e)
        {
            // recogemos la variable global nombre y la asignamos al cuadro de texto
            label1.Text = "¡Hola " + Saludador.nombre + "!";
        }
    }
}
