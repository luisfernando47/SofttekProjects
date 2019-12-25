using ShoesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesEntidades
{
   public class TraerUltimoRegistro
    {
        public static Products LastReg()
        {
            var context = new DataProductsEntities();
            //Query para traer los ids de la tablacatTypeProduct
            var QueryLastReg =
                from c in context.Products
                orderby c.Id descending 
                select c;
            var result = QueryLastReg.FirstOrDefault();
            return result;

        }
    }
}
