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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)//Coleccion de objeto ventanas en memoria que esten abiertos en ese momento
            {
                //si el tipo de objeto que estoy evaluando es igual al tipo del objeto de Form1 entonces
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Esta ventana se encuentra abierta");
                    return;//return en un metodo finaliza el metodo como es void no devuelve nada, termina la ejecucion y no permita que se siga ejecutando el siguiente codigo para reabrir una ventana existente
                }
                    
                    
                
            }
            Form1 ventana = new Form1();
            //ventana.ShowDialog();//Abre una sola ventana emergente
            ventana.MdiParent = this; //Indica que la ventana form1 tiene un parent que es this=esta osea la venta frmPrincipal
            ventana.Show();
        }
    }
}
