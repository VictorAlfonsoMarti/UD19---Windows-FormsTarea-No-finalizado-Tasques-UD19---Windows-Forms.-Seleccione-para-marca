using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T19_Ex2
{
    public partial class Form1 : Form
    {
        // string para guardar el contenido de textbox
        public static string pelicula;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pelicula = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(pelicula);
            textBox1.Text = "";
        }
    }
}
