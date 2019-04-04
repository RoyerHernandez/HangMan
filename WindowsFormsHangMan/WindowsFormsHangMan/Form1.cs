using business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TabIndexChanged(object sender, EventArgs e)
        {
                  
           
        }
            
        public void mostrarLetras(string txt1, string txt2, string txt3, string txt4, string txt5, string txt6, string txt7, string txt8, string txt9, string txt10)
        {
            

            ObtenerDatos obtener = new ObtenerDatos();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato1;
            string dato2;
            string dato3;
            string dato4;
            string dato5;
            string dato6;
            string dato7;
            string dato8;
            string dato9;
            string dato10;

            dato1 = textBox1.Text;
            dato2 = textBox2.Text;
            dato3 = textBox3.Text;
            dato4 = textBox4.Text;
            dato5 = textBox5.Text;
            dato6 = textBox6.Text;
            dato7 = textBox7.Text;
            dato8 = textBox8.Text;
            dato9 = textBox9.Text;
            dato10 = textBox10.Text;

            ObtenerDatos obtener = new ObtenerDatos();
            obtener.obtenerInformación(dato1, dato2, dato3, dato4, dato5, dato6, dato7, dato8, dato9, dato10);
        }
    }
}
