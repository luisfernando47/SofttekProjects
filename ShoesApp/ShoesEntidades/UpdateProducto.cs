using ShoesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesEntidades
{
   public class UpdateProducto
    {
        public static void ActualizarProducto(int idUpdate,List<string> listadatosUpdate)
        {
            var logico = 0;
            if (listadatosUpdate.ElementAtOrDefault(12) == "YES")
            {
                logico = 1;
            }
            else
            {
                logico = 0;
            }

            var db = new DataProductsEntities();
            db.LFGC1_UpdateProduct(
                                     idUpdate,                                                //idProducto
                                     Convert.ToInt32(listadatosUpdate.ElementAtOrDefault(0)), //idtype
                                     Convert.ToInt32(listadatosUpdate.ElementAtOrDefault(1)), //idcolor
                                     Convert.ToInt32(listadatosUpdate.ElementAtOrDefault(2)), //idbrand 
                                     Convert.ToInt32(listadatosUpdate.ElementAtOrDefault(3)), //idprovider
                                     Convert.ToInt32(listadatosUpdate.ElementAtOrDefault(4)), //idcatalog
                                     listadatosUpdate.ElementAtOrDefault(5), //title
                                     listadatosUpdate.ElementAtOrDefault(6), //Nombre
                                     listadatosUpdate.ElementAtOrDefault(7), //Description
                                     listadatosUpdate.ElementAtOrDefault(8), //Observaciones
                                     Convert.ToDecimal(listadatosUpdate.ElementAtOrDefault(9)), // pricedistributor
                                     Convert.ToDecimal(listadatosUpdate.ElementAtOrDefault(10)), // priceclient
                                     Convert.ToDecimal(listadatosUpdate.ElementAtOrDefault(11)), // pricemember
                                     Convert.ToBoolean(logico),
                                     listadatosUpdate.ElementAtOrDefault(13), //Keywords
                                     Convert.ToDateTime(listadatosUpdate.ElementAtOrDefault(14)) //DateUpdate
                                  );

        }
    }
}
