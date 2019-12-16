using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
   public class GuardarImagen
    {
        public static void RegistraImagen(int idP,string desc,byte[] img,string dateUp,int enable)
        {
            var context = new DataProductsEntities();
            var imgpro = new ImagesProduct
            {
                IdProduct=idP,
                Decription =desc,
                Image =img,
                DateUpdate =Convert.ToDateTime(dateUp),
                IsEnabled=Convert.ToBoolean(enable)
            };

            context.ImagesProduct.Add(imgpro);
            context.SaveChanges();
        }
    }
}
