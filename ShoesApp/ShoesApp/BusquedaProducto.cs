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
            //load dgv
            var context = new DataProductsEntities();
            dataGridView1.DataSource = context.LFGC1_AllProducts();   
        }

        private void btnBuscaID_Click(object sender, EventArgs e) //boton buscar por id
        {
            panel1.Visible = true;
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
            panel1.Visible = true;
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
            Form formularioInsertar = new AgregarRegistro();
            formularioInsertar.Show();
        }

        private void btnEditProd_Click(object sender, EventArgs e) //btn editar producto
        {
            Form formularioEditar = new EditarProducto();
            formularioEditar.Show();
        }

        private void btnEliminaProd_Click(object sender, EventArgs e) //btn Eliminar producto
        {
            Form formularioDelete = new EliminarRegistro();
            formularioDelete.Show();
        }

        private void btnreset_Click(object sender, EventArgs e) //btn reset a valor inicial del data grid
        {
            var context = new DataProductsEntities();
            dataGridView1.DataSource = context.LFGC1_AllProducts();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) //textbox
        {
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                   // txtNombre.Text.Remove(txtNombre.Text.Length - 1);
                }

            }
        }
    }
}
