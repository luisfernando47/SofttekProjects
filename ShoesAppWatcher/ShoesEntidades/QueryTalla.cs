using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
    public class QueryTalla
    {
        public static IQueryable listaTallas()
        {
            var context = new DataProductsEntities();
            //Query para traer las tallas de la tabla CatSizes
            var QuerySizes =
                from c in context.CatSizes
                select c.Code;
            return QuerySizes;
        }
    }
}
