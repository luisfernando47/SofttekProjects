using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
    public class QueryCatalog
    {
        public static IQueryable listaCatalog()
        {
            var context = new DataProductsEntities();
            //Query para traer los ids de la tablacatProviders
            var QueryCat =
                from c in context.CatCatalogs
                select c.Season;

            return QueryCat;
        }
        public static int EncuentraIdCatalog(string str)
        {
            var context = new DataProductsEntities();
            //Query para encontrar el id del provider seleccionado
            var QueryCatId =
                from c in context.CatCatalogs
                where c.Season.Contains(str)
                select c.IdCatalog;
            var result = QueryCatId.FirstOrDefault();
            //retorna el id encontrado
            return result;
        }
    }
}
