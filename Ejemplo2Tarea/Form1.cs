using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            if (rbtMasculino.Checked == true)
                usuario.Sexo = rbtMasculino.Text.ToLower();
            else if (rbtFemenino.Checked == true)
                usuario.Sexo = rbtFemenino.Text.ToLower();
            else
                usuario.Sexo = rbtOtro.Text.ToLower();

            usuario.FechaDeNacimiendo = dtpFecha.Value;

            usuario.Monotributo = cbxMonotributo.Checked == true ? "Es monotributo" : "No es monotributo";

            lwDetalle.Items.Add(usuario.ToString());
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
