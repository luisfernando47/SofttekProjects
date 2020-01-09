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
        public ActionResult Index()
        {
            try
            {
                var context = new DataProductsEntities();
                var productos=context.LFGC1_MuestraProductos();
                return View(productos);
            }
            catch (Exception e)
            {
               
                throw;
            }
            
            return View();
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

                throw;
            }
        }
    }
}