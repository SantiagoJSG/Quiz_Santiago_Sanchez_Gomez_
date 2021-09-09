using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Santiago_Sanchez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtdocumento.Text.Length > 0) 
                {
                    Convert.ToInt64(txtdocumento.Text);
                }                    
            }
            catch (Exception)
            {
                MessageBox.Show("Solo números en el apartado de documento y edad");
                if (txtdocumento.Text.Length > 0)
                {
                    txtdocumento.Text = txtdocumento.Text.Remove(txtdocumento.Text.Length - 1, 1);
                }                
            }
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtedad.Text.Length > 0)
                {
                    Convert.ToInt64(txtedad.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Solo números en el apartado de documento y edad");
                if (txtedad.Text.Length > 0)
                {
                    txtedad.Text = txtedad.Text.Remove(txtedad.Text.Length - 1, 1);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text.Length == 0)
                {
                    return;
                }
                if (txtname.Text.Length > 1)
                {
                    Convert.ToInt64(txtname.Text.Remove(txtname.Text.Length));
                }
                if (txtname.Text.Length == 1) 
                {
                    Convert.ToInt64(txtname.Text);
                }
                MessageBox.Show("Solo letras en el apartado nombre");
                if (txtname.Text.Length > 0)
                {
                    txtname.Text = txtname.Text.Remove(txtname.Text.Length - 1, 1);
                }
            }
            catch (Exception)
            {
                return;
            }

            ///if (txtname.Text.Length == 1)
            /// {
            /// if (txtname.Text.Remove(txtname.Text.Length - 2));
            ///}
            /// if (txtname.Text.Remove(txtname.Text.Length - 2)) 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbdocumento.Text == "" || txtdocumento.Text == "" || txtname.Text == "" || txtedad.Text == "")
            {
                MessageBox.Show("Falta Información Por Rellenar");
                return;
            }
            String genero = "";
            if (radioButton1.Checked) 
            {
                genero = "Masculino";
            }
            if (radioButton2.Checked)
            {
                genero = "Femenino";
            }
            MessageBox.Show("Tipo de Documento: " + cmbdocumento.Text + "\nDocumento: " + txtdocumento.Text + "\nNombre: " + txtname.Text + "\nGenero: " + genero + "\nEdad: " + txtedad.Text + "\n");
        }
    }
}
