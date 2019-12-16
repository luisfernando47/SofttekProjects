using ShoesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesEntidades
{
   public class QueryProducts
    {
        
        public static IQueryable listaProducts()
        {
            var context = new DataProductsEntities();
            //Query para traer los nombres de la tablaProducts
            var QueryProducts =
                from c in context.Products
                select c.Nombre;
            return QueryProducts;
        }
        public static int EncuentraIdProducts(string str)
        {
            var context = new DataProductsEntities();
            //Query para encontrar el id del Producto seleccionado
            var QueryProductId =
                from c in context.Products
                where c.Nombre.Contains(str)
                select c.Id;
            var result = QueryProductId.FirstOrDefault();
            //retorna el id encontrado
            return result;
        }

        public static LFGC1_SearchProductID_Result DP_SP(int idprod)
        {

            using (var ctx = new DataProductsEntities())
                 {
                return ctx.Database.SqlQuery<LFGC1_SearchProductID_Result>("LFGC1_SearchProductID @p0",idprod) //LFGC1_SearchProductID nombre del sp en sql
                       .SingleOrDefault();
                    
                }
        }


    }
}
