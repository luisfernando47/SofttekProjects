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
using System.IO;

namespace ShoesApp
{
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            //load Productos en combobox
           var Productos = QueryProducts.listaProducts();       
            foreach (var dato in Productos)
            {
                cmbBuscarProd.Items.Add(dato);
            }
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
            //load Tallas
            var size = QueryTalla.listaTallas();
            foreach (var dato in size)
            {
                cmboSize.Items.Add(dato);
            }
        }

        private void btnSearchProd_Click(object sender, EventArgs e) //btn buscar producto
        {
            try
            {
                var Idproducto = QueryProducts.EncuentraIdProducts(cmbBuscarProd.Text.Trim());
                var a = QueryProducts.DP_SP(Idproducto); //traer el registro usando el SP
                bool logico = a.IsEnabled;
                cmbTypeUpdate.Text = Convert.ToString(a.IdType);
                cmbColorUpdate.Text = QueryColor.EncuentraNombreColor(Convert.ToInt32(a.IdColor));
                cmbMarcaUpdate.Text = QueryBrand.EncuentraNombreBrand(Convert.ToInt32(a.IdBrand));
                cmbProveeUpdate.Text = QueryProvider.EncuentraNombreProvider(Convert.ToInt32(a.IdProvider));
                cmbCatalogoUpdate.Text = QueryCatalog.EncuentraNombreCatalog(Convert.ToInt32(a.IdCatalog));
                txtTitleUpdate.Text = a.Title;
                txtNombreUpdate.Text = a.Nombre;
                txtDescUpdate.Text = a.Description;
                txtObsUpdate.Text = a.Observations;
                txtPriceDisUpdate.Text = Convert.ToString(a.PriceDistributor);
                txtPriceClientUpdate.Text = Convert.ToString(a.PriceClient);
                txtPriceMemberUpdate.Text = Convert.ToString(a.PriceMember);
                if (logico == true) { cmbEnableUpdate.Text = "YES"; } else { cmbEnableUpdate.Text = "NO"; };
                txtKeywordsUpdate.Text = a.Keywords;

                var idImage = BuscaIdTablaImagen.search(Idproducto);
                if (idImage == 0) { } //por si la imagen es nula
                else
                {
                    using (DataProductsEntities ld = new DataProductsEntities())
                    {
                        var oimg = ld.ImagesProduct.Find(idImage);
                        MemoryStream mstm = new MemoryStream(oimg.Image);
                        Bitmap bmp = new Bitmap(mstm);
                        pictureBox1.Image = bmp;
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: "+error.Message);
            }
        }

        private void btnUpdateReg_Click(object sender, EventArgs e) //btn guardar  registro Actualizado
        {
            //guardar una talla
            try
            { 
                if (string.IsNullOrWhiteSpace(cmboSize.Text.Trim())) { }
                else
                {
                    //buscar id de la talla seleccionada
                    int IdSizze = SearchID.SearchIDSize(cmboSize.Text);
                    //buscar id del producto
                    var Idproducto = QueryProducts.EncuentraIdProducts(cmbBuscarProd.Text.Trim());
                    //Insertar la talla y el id del producto en tabla SizeOfProduct
                    InsertaProducto.InsertarTalla(Idproducto, IdSizze);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: "+error.Message);
            }

            //guardar el registro actualizado

            DateTime thisDay = DateTime.Today;
            var fecha = thisDay.ToString();
            //buscar id del producto
            var Idproducto2 = QueryProducts.EncuentraIdProducts(cmbBuscarProd.Text.Trim());
            //lista de datos
            List<string> cadenaUpdate = new List<string>();
            cadenaUpdate.Add(cmbTypeUpdate.Text); //typyId
            cadenaUpdate.Add(Convert.ToString(QueryColor.EncuentraIdColor(cmbColorUpdate.Text))); //buscar el id del color y agregarlo a la lista
            cadenaUpdate.Add(Convert.ToString(QueryBrand.EncuentraIdBrand(cmbMarcaUpdate.Text))); //busca id y agregar a la lista
            cadenaUpdate.Add(Convert.ToString(QueryProvider.EncuentraIdProvider(cmbProveeUpdate.Text))); // busca id y agrega a la lista
            cadenaUpdate.Add(Convert.ToString(QueryCatalog.EncuentraIdCatalog(cmbCatalogoUpdate.Text))); // busca id y agrega a la lista
            cadenaUpdate.Add(txtTitleUpdate.Text); // Title
            cadenaUpdate.Add(txtNombreUpdate.Text); // Nombre
            cadenaUpdate.Add(txtDescUpdate.Text); // Descripcion
            cadenaUpdate.Add(txtObsUpdate.Text);  //observaciones
            cadenaUpdate.Add(txtPriceDisUpdate.Text); //price distributor
            cadenaUpdate.Add(txtPriceClientUpdate.Text); //price client
            cadenaUpdate.Add(txtPriceMemberUpdate.Text); //price Member
            cadenaUpdate.Add(cmbEnableUpdate.Text); //Enable    
            cadenaUpdate.Add(txtKeywordsUpdate.Text); //keywords
            cadenaUpdate.Add(fecha);  //fecha y hora
            try
            {
                UpdateProducto.ActualizarProducto(Idproducto2,cadenaUpdate);    //envio de la cadena a la funcion
                MessageBox.Show("Registro Guardado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            //guardar imagen
            var context = new DataProductsEntities();
            if (txtImgDesc.Text.Trim().Equals("")) { }  //si esta vacio no pasa nada, no es necesario guardar img, es opcional
            else
            {
                //crear memoria de bytes
                byte[] file = null;
                Stream myStream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file = ms.ToArray();
                }
                var logic = 0;
                if (cmbEnableUpdate.Text == "YES")
                {
                    logic = 1;
                }
                else
                {
                    logic = 0;
                }
                GuardarImagen.RegistraImagen(Idproducto2,txtImgDesc.Text.Trim(),file,fecha,logic);
                MessageBox.Show("Registro completado con exito");
            }
        }

        private void btnBuscarImg_Click(object sender, EventArgs e) //btn selecciona imagen en PC
        {
            openFileDialog1.InitialDirectory = @"C:\\Users\Curso\Pictures";
            openFileDialog1.FileName = "*.jpg;*.png;";                                                                                             
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { }
            if (openFileDialog1.FileName.Equals("") == false) { pictureBox1.Load(this.openFileDialog1.FileName); }
        }

        private void btnAddImg_Click(object sender, EventArgs e) 
        {
            
        }
    }
}
