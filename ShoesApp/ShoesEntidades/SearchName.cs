using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;
namespace ShoesEntidades
{
    public class SearchName
    {
        public static List<LFGC1_SearchProductName_Result> Get(string name)
        {
            DataProductsEntities db = new DataProductsEntities();
            var datos = db.LFGC1_SearchProductName(name).ToList();       
            return datos;
        }
    }
}
