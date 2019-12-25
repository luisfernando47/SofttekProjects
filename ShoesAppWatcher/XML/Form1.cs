using ShoesData;
using ShoesEntidades;
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
using System.Xml.Serialization;

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddXML_Click(object sender, EventArgs e) //btn crear xml
        {
            //Traer ultimo registro insertado
           
            var dp = new ProductClean(); //se creo ProductClean debido a que products traer errores
            var RegistroQuery = TraerUltimoRegistro.LastReg();  //objeto de tipo Products con errores (se corrige con ProductClean)
            //pasar elemento a elemento de Products a ProductsClean para no pasar error
            dp.Id = RegistroQuery.Id;    
            dp.IdType = RegistroQuery.IdType;
            dp.IdColor = RegistroQuery.IdColor;
            dp.IdBrand = RegistroQuery.IdBrand;
            dp.IdProvider = RegistroQuery.IdProvider;
            dp.IdCatalog = RegistroQuery.IdCatalog;
            dp.Title = RegistroQuery.Title;
            dp.Nombre = RegistroQuery.Nombre;
            dp.Description = RegistroQuery.Description;
            dp.Observations = RegistroQuery.Observations;
            dp.PriceDistributor = RegistroQuery.PriceDistributor;
            dp.PriceClient = RegistroQuery.PriceClient;
            dp.PriceMember = RegistroQuery.PriceMember;
            dp.IsEnabled = RegistroQuery.IsEnabled;
            dp.Keywords = RegistroQuery.Keywords;
            dp.DateUpdate = RegistroQuery.DateUpdate;
            try
            {
                // guardar la lista a un XML
                List<ProductClean> ListaProducts = new List<ProductClean>();
                ListaProducts.Add(dp);
                SerializeToXml<List<ProductClean>>(ListaProducts, @"C:\Users\Curso\source\repos\ShoesAppWatcher\ShoesAppFileWatcher\ArchivosXML\RegistroXMLProducts.xml");
                MessageBox.Show("Registro Guardado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: Tabla vacia " + error.Message);
            }
        }

        private void btnUpdateXML_Click(object sender, EventArgs e) //btn Actualiza xml
        {
            Form formularioUpdateXML = new UpdateXML();
            formularioUpdateXML.Show();
        }

        private void btnDeleteXML_Click(object sender, EventArgs e) //Eliminar xml
        {
            if (File.Exists(@"C:\Users\Curso\source\repos\ShoesAppWatcher\ShoesAppFileWatcher\ArchivosXML\RegistroXMLProducts.xml"))
            {
                File.Delete(@"C:\Users\Curso\source\repos\ShoesAppWatcher\ShoesAppFileWatcher\ArchivosXML\RegistroXMLProducts.xml");
                MessageBox.Show("Documento Eliminado");
            }
            else
            {
                MessageBox.Show("El documento no existe");
            }
        }
    }
}
