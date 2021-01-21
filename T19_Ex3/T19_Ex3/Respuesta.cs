using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T19_Ex3
{
    public partial class Respuesta : Form
    {
        public Respuesta()
        {
            InitializeComponent();
        }

        private void Respuesta_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " " + Encuesta.sistema;
            label2.Text = label2.Text + " " + Encuesta.especialidad;
            label3.Text = label3.Text + " " + Encuesta.horas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encuesta nueva_encuesta = new Encuesta();
            nueva_encuesta.Show();
            this.Hide();

            Encuesta.sistema = "";
            Encuesta.especialidad = "";
            Encuesta.horas = Encuesta.horas = "";
        }
    }
}
