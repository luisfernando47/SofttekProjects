using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
   public class QueryType
    {
        public static IQueryable listaIdtypes()   //List<string>
        {
            var context = new DataProductsEntities();
            //Query para traer los ids de la tablacatTypeProduct
            var QueryIndexes =
                from c in context.CatTypeProduct
                select c.IdType;

            return QueryIndexes;
        }
    }
}
