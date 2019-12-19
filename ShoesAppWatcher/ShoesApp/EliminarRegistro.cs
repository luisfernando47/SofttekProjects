using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesEntidades;

namespace ShoesApp
{
    public partial class EliminarRegistro : Form
    {
        public EliminarRegistro()
        {
            InitializeComponent();
        }

        private void EliminarRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)  //btn eliminar registro
        {
            try
            {
                DeleteReg.Delete(Convert.ToInt32(txtEliminaID.Text.Trim()));
                MessageBox.Show("Registro Eliminado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: "+error.Message);
            }
        }
    }
}
