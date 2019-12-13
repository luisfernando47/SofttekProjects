using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
    public class QueryProvider
    {
        public static IQueryable listaProvider()
        {
            var context = new DataProductsEntities();
            //Query para traer los ids de la tablacatProviders
            var QueryProv =
                from c in context.CatBrands
                select c.Name;

            return QueryProv;
        }
        public static int EncuentraIdProvider(string str)
        {
            var context = new DataProductsEntities();
            //Query para encontrar el id del provider seleccionado
            var QueryProvId =
                from c in context.CatProviders
                where c.Name.Contains(str)
                select c.IdProvider;
            var result = QueryProvId.FirstOrDefault();
            //retorna el id encontrado
            return result;
        }
    }
}
