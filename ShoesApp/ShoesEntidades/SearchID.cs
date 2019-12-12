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
    }
}
