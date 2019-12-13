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
    public partial class AgregarRegistro : Form
    {
        public AgregarRegistro()
        {
            InitializeComponent();
        }

        private void AgregarRegistro_Load(object sender, EventArgs e)
        {
            //load ids type
            var ids = QueryType.listaIdtypes();
            foreach (var dato in ids)
            {
                cmbType.Items.Add(dato);
            }
            //load colores
            var colores = QueryColor.listaColores();
            foreach (var dato in colores)
            {
                cmbColor.Items.Add(dato);
            }
            //load Brands
            var brand = QueryBrand.listaBrands();
            foreach (var dato in brand)
            {
                cmbMarca.Items.Add(dato);
            }
            //load Provider
            var prov = QueryProvider.listaProvider();
            foreach (var dato in prov)
            {
                cmbProvee.Items.Add(dato);
            }
            //load catalog
            var cat = QueryCatalog.listaCatalog();
            foreach (var dato in cat)
            {
                cmbCatalogo.Items.Add(dato);
            }
        }

        private void button1_Click(object sender, EventArgs e) //btn guardar
        {

        }
    }
}
