using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //cancela la entrada de datos
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //cancela la entrada de datos
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            else
            {
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?",  // Mensaje de consulta
                                                    "Confirmar Inserción",                         // Título del mensaje
                                                    MessageBoxButtons.YesNo,                       // Botones 'Sí' y 'No'
                                                    MessageBoxIcon.Question,                       // Icono de pregunta
                                                    MessageBoxDefaultButton.Button1                // Enfocar el botón 'Sí'
                                                   );
                if (ask == DialogResult.Yes)
                {


                    MessageBox.Show("El cliente: "+ txtNombre.Text + " " + txtApellido.Text + " se inserto correctamente",  // Mensaje de consulta
                                                    "Guardar",                         // Título del mensaje
                                                    MessageBoxButtons.OK,                       
                                                    MessageBoxIcon.Information                    
                                                   );
                    lblModificar.Text = txtNombre.Text + " " + txtApellido.Text;
                }
                else
                {
                    MessageBox.Show("Inserción cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("“Está apunto de eliminar el Cliente: " + txtNombre.Text + " " + txtApellido.Text,
                                            "Confirmar Elinacion",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning,
                                            MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El cliente: " + txtNombre.Text + " " + txtApellido.Text + " se elimino correctamente",  // Mensaje de consulta
                                                    "Eliminar",                         // Título del mensaje
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information
                                                   );
                txtDni.Text = " ";
                txtNombre.Text = " ";
                txtApellido.Text = " ";
                txtTelefono.Text = " ";
                cbxMastercard.Checked = false;
                cbxNaranja.Checked = false;
                cbxVisa.Checked = false;
                lblModificar.Text = "Modificar";
            }
        }

        private void rbMujer_CheckedChanged(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources._190664;
            pbUser.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void rbVaron_CheckedChanged(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources.man;
            pbUser.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
