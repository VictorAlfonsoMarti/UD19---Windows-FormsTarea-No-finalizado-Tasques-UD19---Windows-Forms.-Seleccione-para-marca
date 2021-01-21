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
    public partial class Saludador : Form
    {

        public static string nombre = "";

        public Saludador()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // asigniamos el contenido del texto a la variable global nombre
            nombre = textBox1.Text;

            // iniciamos ventana Message
            Message mensaje = new Message();
            mensaje.Show(); // mostramos ventana
            this.Hide(); // oculamos esta ventana
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
