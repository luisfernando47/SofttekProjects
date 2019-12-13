using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
    public class DeleteReg
    {
        public static void Delete(int id)
        {
            DataProductsEntities delete = new DataProductsEntities();
            var datos = delete.LFGC1_DeleteProductID(id); 
        }
    }
}
