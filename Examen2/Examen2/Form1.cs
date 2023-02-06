using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            












        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string user = "FullAdmin", password = "*123";

            if(textBox1.Text==""||textBox2.Text == "")
            {

                MessageBox.Show("INGRESE LOS ELEMENTOS QUE PIDE NO DEJE NI UN ESPACIO VACIO");



            }
            else
            {

                if (textBox1.Text == user && textBox2.Text == password)
                {

                    MessageBox.Show("Entro al sistema");
                    Form2 entrar = new Form2();
                    entrar.ShowDialog();


                }
                else
                {
                    MessageBox.Show("ERROR INGRESE DE NUEVO");
                }



            }








        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
