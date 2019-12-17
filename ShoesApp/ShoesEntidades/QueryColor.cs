using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
    public class QueryColor
    {
        public static IQueryable listaColores()
        {
            var context = new DataProductsEntities();
            //Query para traer los ids de la tablacatTypeProduct
            var QueryColores =
                from c in context.CatColors
                select c.Name;

            return QueryColores;
            
        }
        public static int EncuentraIdColor(string str)
        {
            var context = new DataProductsEntities();
            //Query para encontrar el id del color seleccionado
            var QueryColorId =
                from c in context.CatColors
                where c.Name.Contains(str)
                select c.IdColor;
            var result = QueryColorId.FirstOrDefault();
            //retorna el id encontrado
            return result;
        }
        public static string EncuentraNombreColor(int idcolor)
        {
            var context = new DataProductsEntities();
            //Query para encontrar el id del color seleccionado
            var QueryColorname =
                from c in context.CatColors
                where  c.IdColor.Equals(idcolor)    //    Contains(idcolor)
                select c.Name;
            var result = QueryColorname.FirstOrDefault();
            //retorna el id encontrado
            return result;
        }
    }
}
