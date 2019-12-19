using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesEntidades
{
    public class InsertaProducto
    {
        public static void MInserta(List<string> listadatos)
        {
            var logico = 0;
            if (listadatos.ElementAtOrDefault(12) == "YES")
            {
                logico = 1;
            }
            else
            {
                logico = 0;
            }

            var db = new DataProductsEntities();
            db.LFGC1_InsertProduct(
                                     Convert.ToInt32(listadatos.ElementAtOrDefault(0)), //idtype
                                     Convert.ToInt32(listadatos.ElementAtOrDefault(1)), //idcolor
                                     Convert.ToInt32(listadatos.ElementAtOrDefault(2)), //idbrand 
                                     Convert.ToInt32(listadatos.ElementAtOrDefault(3)), //idprovider
                                     Convert.ToInt32(listadatos.ElementAtOrDefault(4)), //idcatalog
                                     listadatos.ElementAtOrDefault(5), //title
                                     listadatos.ElementAtOrDefault(6), //Nombre
                                     listadatos.ElementAtOrDefault(7), //Description
                                     listadatos.ElementAtOrDefault(8), //Observaciones
                                     Convert.ToDecimal(listadatos.ElementAtOrDefault(9)), // pricedistributor
                                     Convert.ToDecimal(listadatos.ElementAtOrDefault(10)), // priceclient
                                     Convert.ToDecimal(listadatos.ElementAtOrDefault(11)), // pricemember
                                     Convert.ToBoolean(logico),
                                     listadatos.ElementAtOrDefault(13), //Keywords
                                     Convert.ToDateTime(listadatos.ElementAtOrDefault(14)) //DateUpdate
                                  );

        }
        public static void InsertarTalla(int idprod, int idSize)
        {
            var context = new DataProductsEntities();
            var insert = new SizeForProduct()
            {
                IdProduct = idprod,
                IdSize = idSize
            };
            context.SizeForProduct.Add(insert);
            context.SaveChanges();
        }
}

   
}
