using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class LoadXML
    {
        public static void cargaXML()
        {
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
    }
}
