using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace Watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source=microservicessttk.database.windows.net;Initial Catalog=DataProducts;User ID=adminSttk;Password=@Softtek01";
            using (var tableDependency = new SqlTableDependency<WProducts>(connectionString, "Products"))
            {
                tableDependency.OnChanged += TableDependency_Changed;
                tableDependency.OnError += TableDependency_OnError;

                tableDependency.Start();
                Console.WriteLine("Esperando notificacion...");
                Console.WriteLine("Tecle una tecla para detener");
                Console.ReadKey();
                tableDependency.Stop();
            }
        }
        static void TableDependency_Changed(object sender, RecordChangedEventArgs<WProducts> e)
        {
            Console.WriteLine(Environment.NewLine);
            if (e.ChangeType != ChangeType.None)
            {
                var changedEntity = e.Entity;
                Console.WriteLine("DML Operacion"+ e.ChangeType);
                Console.WriteLine("ID:"+ changedEntity.Id );
                Console.WriteLine("IdType:"+changedEntity.IdType);
                Console.WriteLine("IdColor:" + changedEntity.IdColor);
                Console.WriteLine("IdBrand:" + changedEntity.IdBrand);
                Console.WriteLine("IdProvider:" + changedEntity.IdProvider);
                Console.WriteLine("IdCatalog:" + changedEntity.IdCatalog);
                Console.WriteLine("Title:" + changedEntity.Title);
                Console.WriteLine("Nombre:" + changedEntity.Nombre);
                Console.WriteLine("Description:" + changedEntity.Description);
                Console.WriteLine("Observations:" + changedEntity.Observations);
                Console.WriteLine("PriceDistributor:" + changedEntity.PriceDistributor);
                Console.WriteLine("PriceClient:" + changedEntity.PriceClient);
                Console.WriteLine("PriceMember:" + changedEntity.PriceMember);
                Console.WriteLine("IsEnabled:" + changedEntity.IsEnabled); 
                Console.WriteLine("Keywords:" + changedEntity.Keywords);
                Console.WriteLine("DateUpdate:" + changedEntity.DateUpdate); 
                Console.WriteLine(Environment.NewLine);
            }
        }
        static void TableDependency_OnError(object sender, ErrorEventArgs e)
        {
            Exception ex = e.Error;
            throw ex;
        }
    }
}
