using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;
namespace ShoesEntidades
{
   public class SearchID
    {
        public static List<LFGC1_SearchProductID_Result> Get(int id)
        {
            DataProductsEntities db = new DataProductsEntities();
            var datos =  db.LFGC1_SearchProductID(id).ToList();
            return datos;
        }
        public static int SearchIDSize(string idSize)
        {
            var context = new DataProductsEntities();
            //Query para encontrar el id de la talla  seleccionada
            var QueryTallaId =
                from c in context.CatSizes
                where c.Code.Contains(idSize)
                select c.IdSize;
            var result = QueryTallaId.FirstOrDefault();
            //retorna el id encontrado
            return result;

        }
    }
}
