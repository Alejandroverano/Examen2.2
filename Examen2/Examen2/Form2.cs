using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examen2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre,  cedula, sexo, cargo,aoi;
            int cod_empleado;


            if (textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||comboBox1.Text == ""||textBox4.Text == "")
            {
                MessageBox.Show("INGRESE LOS ELEMENTOS QUE PIDE NO DEJE NI UN ESPACIO VACIO");
            }
            else
            {
                nombre = textBox1.Text;
                cod_empleado = int.Parse(textBox2.Text);
                cedula = textBox3.Text;
                sexo = comboBox1.Text;
                cargo = textBox4.Text;
                aoi = comboBox2.Text;
              
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                textBox4.Text = "";

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);
                fila.Cells[0].Value = nombre;
                fila.Cells[1].Value = cod_empleado;
                fila.Cells[2].Value = cedula;
                fila.Cells[3].Value = sexo;
                fila.Cells[4].Value = cargo;
                fila.Cells[5].Value = aoi;

                dataGridView1.Rows.Add(fila);



                
                




            }
            






        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int buscar;/*, cod_empleado;
            cod_empleado = int.Parse(textBox2.Text);*/

            DataGridViewRow fila = new DataGridViewRow();

            
            buscar = int.Parse(textBox5.Text);
            //fila.Cells[1].Value = buscar;
            //  dataGridView1.Rows[buscar].Cells[5].Value = buscar;

            //  dataGridView1.Rows[buscar].Cells[5].Value = buscar;

            /* string nombre, cod_empleado, cedula, sexo, cargo, aoi;

             nombre = textBox1.Text;
             cod_empleado = textBox2.Text;
             cedula = textBox3.Text;
             sexo = comboBox1.Text;
             cargo = textBox4.Text;
             aoi = comboBox2.Text;*/


           MessageBox.Show(dataGridView1.Rows[0].Cells[5].Value.ToString());
           


            dataGridView1.Rows.Add(fila);


        }
    }
}
