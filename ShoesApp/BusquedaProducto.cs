using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesData;
using ShoesEntidades;

namespace ShoesApp
{
    public partial class BusquedaProducto : Form
    {
        public BusquedaProducto()
        {
            InitializeComponent();
        }

        private void BusquedaProducto_Load(object sender, EventArgs e)
        {
            var context = new DataProductsEntities();
            dataGridView1.DataSource = context.LFGC1_AllProducts();
        }

        private void btnBuscaID_Click(object sender, EventArgs e) //boton buscar por id
        {
            try
            {
                dataGridView1.DataSource = SearchID.Get(Convert.ToInt32(txtIDproduct.Text.Trim()));
            }
            catch (Exception fatallity)
            {
                MessageBox.Show("Error: "+fatallity.Message);
            }
        }

        private void btnBuscaNombre_Click(object sender, EventArgs e) //boton buscar por nombre
        {
            try
            {
                dataGridView1.DataSource = SearchName.Get(txtNombre.Text);
            }
            catch (Exception fatallity)
            {
                MessageBox.Show("Error: " + fatallity.Message);
            }
        }

        private void btnNvoReg_Click(object sender, EventArgs e) //btn nuevo registro
        {

        }

        private void btnEditProd_Click(object sender, EventArgs e) //btn editar producto
        {

        }

        private void btnEliminaProd_Click(object sender, EventArgs e) //btn Eliminar producto
        {

        }

        private void btnreset_Click(object sender, EventArgs e) //btn reset a valor inicial del data grid
        {
            var context = new DataProductsEntities();
            dataGridView1.DataSource = context.LFGC1_AllProducts();
        }
    }
}
