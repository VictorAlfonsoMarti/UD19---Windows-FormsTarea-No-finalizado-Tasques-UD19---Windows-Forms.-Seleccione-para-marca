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
    public partial class Encuesta : Form
    {
        public Encuesta()
        {
            InitializeComponent();
        }

        public static string sistema = "";
        public static string especialidad = "";
        public static string horas = "";


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sistema = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                sistema = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                sistema = radioButton3.Text;
            }

            if (checkBox1.Checked)
            {
                especialidad = especialidad + " " + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                especialidad = especialidad + " " + checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                especialidad = especialidad + " " + checkBox3.Text;
            }

            Respuesta ventana = new Respuesta();
            ventana.Show();
            this.Hide();
        }

        private void Encuesta_Load(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(trackBar1.Value);
            horas = label4.Text;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(trackBar1.Value);
            horas = label4.Text;
        }
    }
}
