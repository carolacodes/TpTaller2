using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string resultConcatenado = apellido + " " + nombre;

            textBox3.Text = resultConcatenado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = " ";
            txtNombre.Text = " ";
            textBox3.Text = " ";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if (keyData == (Keys.Control | Keys.S))
            {
                
                btnSalir_Click(this, new EventArgs());
                return true;
            }

            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
