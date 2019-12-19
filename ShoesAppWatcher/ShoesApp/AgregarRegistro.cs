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
using ShoesData;

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

            DateTime thisDay = DateTime.Today;
            var fecha = thisDay.ToString();
            List<string> cadena = new List<string>();
            cadena.Add(cmbType.Text); //typyId
            cadena.Add(Convert.ToString(QueryColor.EncuentraIdColor(cmbColor.Text))); //buscar el id del color y agregarlo a la lista
            cadena.Add(Convert.ToString(QueryBrand.EncuentraIdBrand(cmbMarca.Text))); //busca id y agregar a la lista
            cadena.Add(Convert.ToString(QueryProvider.EncuentraIdProvider(cmbProvee.Text))); // busca id y agrega a la lista
            cadena.Add(Convert.ToString(QueryCatalog.EncuentraIdCatalog(cmbCatalogo.Text))); // busca id y agrega a la lista
            cadena.Add(txtTitle.Text); // Title
            cadena.Add(txtNombre.Text); // Nombre
            cadena.Add(txtDesc.Text); // Descripcion
            cadena.Add(txtObs.Text);  //observaciones
            cadena.Add(txtPriceDis.Text); //price distributor
            cadena.Add(txtPriceClient.Text); //price client
            cadena.Add(txtPriceMember.Text); //price Member
            cadena.Add(cmbEnable.Text); //Enable    
            cadena.Add(txtKeywords.Text); //keywords
            cadena.Add(fecha);  //fecha y hora
            try
            {
                InsertaProducto.MInserta(cadena);    //envio de la cadena a la funcion
                MessageBox.Show("Registro Guardado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: "+error.Message);
            }
        }
    }
}
