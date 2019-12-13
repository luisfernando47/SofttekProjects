using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
    public class QueryBrand
    {
        public static IQueryable listaBrands()
        {
            var context = new DataProductsEntities();
            //Query para traer los ids de la tablacatTypeProduct
            var QueryBrands =
                from c in context.CatBrands
                select c.Name;
            return QueryBrands;
        }
        public static int EncuentraIdBrand(string str)
        {
            var context = new DataProductsEntities();
            //Query para encontrar el id del color seleccionado
            var QueryBrandId =
                from c in context.CatBrands
                where c.Name.Contains(str)
                select c.IdBrand;
            var result = QueryBrandId.FirstOrDefault();
            //retorna el id encontrado
            return result;
        }
    }
}
