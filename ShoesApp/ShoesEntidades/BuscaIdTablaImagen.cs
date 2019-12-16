using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
    public class BuscaIdTablaImagen
    {
        public static int search(int idprod)
        {
            var context = new DataProductsEntities();
            //Query para encontrar el id del color seleccionado
            var QueryId =
                from c in context.ImagesProduct
                where c.IdProduct.Equals(idprod)
                select c.IdImage;
            var result = QueryId.FirstOrDefault();
            //retorna el id encontrado
            return result;
           
        }
    }
}
