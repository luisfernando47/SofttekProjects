using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesApp3.Models;

namespace ShoesApp3.Controllers
{
    public class ShoesController : Controller
    {
        // GET: Shoes
        DataProductsEntities context = new DataProductsEntities();
        public ActionResult Index(string searchingID,string searchingName)
        {
            try
            {
                
               // var productos=context.LFGC1_MuestraProductos();

               // var Busqueda = context.LFGC1_BuscaProductoNombre(searching);

               var QueryFiltro = from s in context.LFGC1_MuestraProductos()
                   select s;


                if (!String.IsNullOrEmpty(searchingID))
                {
                    QueryFiltro = QueryFiltro
                        .Where(s => s.Id == Convert.ToInt32(searchingID));
                }
                if (!String.IsNullOrEmpty(searchingName))
                {
                    QueryFiltro = QueryFiltro
                        .Where(s => s.Nombre.Contains(searchingName));
                }

                //ModelState.Remove("searchingID");
                //ModelState.Remove("searchingName");

                return View(QueryFiltro);



            }
            catch (Exception e)
            {
               
                throw e;
            }
            
            
        }
        //get, solo llama a la vista
        public ActionResult Create()
        {
            var CollectionModel= new LFGC1_MuestraProductos_Result();
            using (var db = new DataProductsEntities())
            {
                CollectionModel.ColorsCollection = db.CatColors.ToList<CatColors>();
                CollectionModel.TypeCollection = db.CatTypeProduct.ToList<CatTypeProduct>();
                CollectionModel.BrandsCollection = db.CatBrands.ToList<CatBrands>();
                CollectionModel.ProvidersCollection = db.CatProviders.ToList<CatProviders>();
                CollectionModel.CatalogsCollection = db.CatCatalogs.ToList<CatCatalogs>();
            }

            return View(CollectionModel);
        }

        [HttpPost] //envia datos
        [ValidateAntiForgeryToken]
        public ActionResult Create(LFGC1_MuestraProductos_Result lfgcmpr)
        {
            if (!ModelState.IsValid) return View();

            try
            {
                var db =new DataProductsEntities();
                db.LFGC1_InsertaNuevoProducto(
                                               lfgcmpr.IdType,
                                               lfgcmpr.IdColor,
                                               lfgcmpr.IdBrand,
                                               lfgcmpr.IdProvider,
                                               lfgcmpr.IdCatalog,
                                               lfgcmpr.Title,
                                               lfgcmpr.Nombre,
                                               lfgcmpr.Description,
                                               lfgcmpr.Observations,
                                               lfgcmpr.PriceDistributor,
                                               lfgcmpr.PriceClient,
                                               lfgcmpr.PriceMember,
                                               lfgcmpr.IsEnabled,
                                               lfgcmpr.Keywords,
                                               lfgcmpr.DateUpdate = DateTime.Now
                                             );
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public ActionResult Edit2(int id)
        {
            try
            {
                using (var db = new DataProductsEntities())
                {
                    var Buscar = db.LFGC1_MuestraProductos().Where(a => a.Id == id).FirstOrDefault();
                   //var Buscar2 = db.LFGC1_MuestraProductos().find(id);
                    return View();
                }
            }
            catch (Exception e)
            {
               
                throw e;
            }
            

           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit2(Products up)
        {
            try
            {
                using (var db = new DataProductsEntities())
                {
                    Products prod = db.Products.Find(up.Id); //trae el id oculto desde get
                    prod.Nombre = up.Nombre;
                    prod.IdColor = up.IdColor;
                    prod.Description = up.Description;
                    prod.PriceClient = up.PriceClient;
                    prod.IsEnabled = up.IsEnabled;
                    prod.DateUpdate = DateTime.Now;

                    db.SaveChanges();
                    return RedirectToAction("Index");

                }

            }
            catch (Exception e)
            {
                
                throw;
            }

            
        }

        public ActionResult Delete(int id)
        {
            using (var db = new DataProductsEntities())

            {

                LFGC1_MuestraProductos_Result Del = db.LFGC1_MuestraProductos().Where(a => a.Id == id).FirstOrDefault();
                db.LFGC1_EliminaProductoPorID(id);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
        }


    }
}