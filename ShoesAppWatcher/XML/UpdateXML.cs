using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ShoesEntidades;
using ShoesData;

namespace XML
{
    public partial class UpdateXML : Form
    {
        public UpdateXML()
        {
            InitializeComponent();
        }
        //metodo para serializar
        public void SerializeToXml<T>(T obj, string fileName)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fileStream, obj);
            fileStream.Close();

        }
        //metodo para DesSerializar
        public T DeserializeFromXml<T>(string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }
        private void UpdateXML_Load(object sender, EventArgs e)
        {  
            //load ids type
            var ids = QueryType.listaIdtypes();
            foreach (var dato in ids)
            {
                cmbTypeUpdate.Items.Add(dato);
            }
            //load colores
            var colores = QueryColor.listaColores();
            foreach (var dato in colores)
            {
                cmbColorUpdate.Items.Add(dato);
            }
            //load Brands
            var brand = QueryBrand.listaBrands();
            foreach (var dato in brand)
            {
                cmbMarcaUpdate.Items.Add(dato);
            }
            //load Provider
            var prov = QueryProvider.listaProvider();
            foreach (var dato in prov)
            {
                cmbProveeUpdate.Items.Add(dato);
            }
            //load catalog
            var cat = QueryCatalog.listaCatalog();
            foreach (var dato in cat)
            {
                cmbCatalogoUpdate.Items.Add(dato);
            }

            //Se creara la condicion para saber si existe el archivo y leerlo o mandar advertencia
            if (File.Exists(@"C:\Users\Curso\source\repos\ShoesAppWatcher\ShoesAppFileWatcher\ArchivosXML\RegistroXMLProducts.xml"))
            {
                //Traer xml de Producto
                List<ProductClean> prod = new List<ProductClean>();
                XmlDocument xmlprod = new XmlDocument();
                xmlprod.Load(@"C:\Users\Curso\source\repos\ShoesAppWatcher\ShoesAppFileWatcher\ArchivosXML\RegistroXMLProducts.xml");
                prod.AddRange(DeserializeFromXml<List<ProductClean>>(xmlprod.OuterXml));
                //cargar los campos del xml (clase prod) a los combo box
                var coleccion = prod.ElementAtOrDefault(0); //pasar el primer objeto de la lista  ProductClean a una nuevo objeto
                //obtener los datos para pasarlos a los text
                int idprod = coleccion.Id;
                cmbTypeUpdate.Text = coleccion.IdType.ToString();
                cmbColorUpdate.Text = QueryColor.EncuentraNombreColor(Convert.ToInt32((coleccion.IdColor)));
                cmbMarcaUpdate.Text = QueryBrand.EncuentraNombreBrand(Convert.ToInt32((coleccion.IdBrand)));
                cmbProveeUpdate.Text = QueryProvider.EncuentraNombreProvider((Convert.ToInt32(coleccion.IdProvider)));
                cmbCatalogoUpdate.Text = QueryCatalog.EncuentraNombreCatalog((Convert.ToInt32(coleccion.IdCatalog)));
                txtTitleUpdate.Text = coleccion.Title;
                txtNombreUpdate.Text = coleccion.Nombre;
                txtDescUpdate.Text = coleccion.Description;
                txtObsUpdate.Text = coleccion.Observations;
                txtPriceDisUpdate.Text = coleccion.PriceDistributor.ToString();
                txtPriceClientUpdate.Text = coleccion.PriceClient.ToString();
                txtPriceMemberUpdate.Text = coleccion.PriceMember.ToString();
                string valor;
                if (coleccion.IsEnabled == true) { valor = "YES"; } else { valor = "NO"; }
                cmbEnableUpdate.Text = valor;
                txtKeywordsUpdate.Text = coleccion.Keywords;
            }
            else { MessageBox.Show("No existe archivo"); }
        }
        // una vez actualizado los cambios se guardara el xml
        private void btnUpdateXML_Click(object sender, EventArgs e) //btn guardar
        {
            try
            {
                List<ProductClean> prodUpdate = new List<ProductClean>();  //instanciar la lista
                var datosProdUpdate = new ProductClean();  // instanciando la clase y creando obj
                datosProdUpdate.IdType = Convert.ToInt32(cmbTypeUpdate.Text);
                datosProdUpdate.IdColor = QueryColor.EncuentraIdColor(cmbColorUpdate.Text);
                datosProdUpdate.IdBrand = QueryBrand.EncuentraIdBrand(cmbMarcaUpdate.Text);
                datosProdUpdate.IdProvider = QueryProvider.EncuentraIdProvider(cmbProveeUpdate.Text);
                datosProdUpdate.IdCatalog = QueryCatalog.EncuentraIdCatalog(cmbCatalogoUpdate.Text);
                datosProdUpdate.Title = txtTitleUpdate.Text;
                datosProdUpdate.Nombre = txtNombreUpdate.Text;
                datosProdUpdate.Description = txtDescUpdate.Text;
                datosProdUpdate.Observations = txtObsUpdate.Text;
                datosProdUpdate.PriceDistributor = Convert.ToDecimal(txtPriceDisUpdate.Text);
                datosProdUpdate.PriceClient = Convert.ToDecimal(txtPriceClientUpdate.Text);
                datosProdUpdate.PriceMember = Convert.ToDecimal(txtPriceMemberUpdate.Text);
                bool dg;
                if (cmbEnableUpdate.Text == "YES") { dg = true; } else { dg = false; }
                datosProdUpdate.IsEnabled = dg;
                datosProdUpdate.Keywords = txtKeywordsUpdate.Text;
                var thisDay = DateTime.Today;
                datosProdUpdate.DateUpdate = thisDay;
                //creacion del archivo XML
                prodUpdate.Add(datosProdUpdate); // Almacena el datosProdUpdate en el objeto prodUpdate
                                                 //  SerializeToXml<List<Proveedores>>(new List<Proveedores>() { datosProveedor }, @"C:\Users\Curso\Documents\Proyectos\XMLBar\RegistroBarProveedores.xml");
                SerializeToXml<List<ProductClean>>(prodUpdate, @"C:\Users\Curso\source\repos\ShoesAppWatcher\ShoesAppFileWatcher\ArchivosXML\RegistroXMLProducts.xml");

                MessageBox.Show("XML Actualizado");
            }
            catch (Exception error)
            {

                MessageBox.Show("Verificar campos: "+error.Message);
            }
           
        }
    }
}

