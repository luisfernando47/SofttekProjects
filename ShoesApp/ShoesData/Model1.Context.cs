﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DataProductsEntities1 : DbContext
    {
        public DataProductsEntities1()
            : base("name=DataProductsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatBrand> CatBrands { get; set; }
        public virtual DbSet<CatCatalog> CatCatalogs { get; set; }
        public virtual DbSet<CatColor> CatColors { get; set; }
        public virtual DbSet<CatProvider> CatProviders { get; set; }
        public virtual DbSet<CatRating> CatRatings { get; set; }
        public virtual DbSet<CatSize> CatSizes { get; set; }
        public virtual DbSet<CatTypeDetail> CatTypeDetails { get; set; }
        public virtual DbSet<CatTypeProduct> CatTypeProducts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<DetailProduct> DetailProducts { get; set; }
        public virtual DbSet<ImagesProduct> ImagesProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<SimilarProduct> SimilarProducts { get; set; }
        public virtual DbSet<SizeForProduct> SizeForProducts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<database_firewall_rules1> database_firewall_rules1 { get; set; }
    
        public virtual ObjectResult<ACOB_SearchByIdOrName_Result> ACOB_SearchByIdOrName(Nullable<int> id, string nombre)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACOB_SearchByIdOrName_Result>("ACOB_SearchByIdOrName", idParameter, nombreParameter);
        }
    
        public virtual ObjectResult<CAOE_BUSCAR_Result> CAOE_BUSCAR(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CAOE_BUSCAR_Result>("CAOE_BUSCAR", iDParameter);
        }
    
        public virtual ObjectResult<DataGrid_FernandoSanchez_Result> DataGrid_FernandoSanchez()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DataGrid_FernandoSanchez_Result>("DataGrid_FernandoSanchez");
        }
    
        public virtual ObjectResult<dena_sp_BusquedaProdId_Result> dena_sp_BusquedaProdId(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dena_sp_BusquedaProdId_Result>("dena_sp_BusquedaProdId", idParameter);
        }
    
        public virtual ObjectResult<dena_sp_BusquedaProdNom_Result> dena_sp_BusquedaProdNom(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dena_sp_BusquedaProdNom_Result>("dena_sp_BusquedaProdNom", nombreParameter);
        }
    
        public virtual int JEVJ1_ActualizaProducto(Nullable<int> productId, Nullable<int> idType, Nullable<int> idColor, Nullable<int> idBrand, Nullable<int> idProvider, Nullable<int> idCatalog, string title, string nombre, string description, string observations, Nullable<decimal> priceDistributor, Nullable<decimal> priceClient, Nullable<decimal> priceMember, Nullable<bool> isEnabled, string keywords, Nullable<System.DateTime> dataUpdate)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("IdType", idType) :
                new ObjectParameter("IdType", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("IdColor", idColor) :
                new ObjectParameter("IdColor", typeof(int));
    
            var idBrandParameter = idBrand.HasValue ?
                new ObjectParameter("IdBrand", idBrand) :
                new ObjectParameter("IdBrand", typeof(int));
    
            var idProviderParameter = idProvider.HasValue ?
                new ObjectParameter("IdProvider", idProvider) :
                new ObjectParameter("IdProvider", typeof(int));
    
            var idCatalogParameter = idCatalog.HasValue ?
                new ObjectParameter("IdCatalog", idCatalog) :
                new ObjectParameter("IdCatalog", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var observationsParameter = observations != null ?
                new ObjectParameter("Observations", observations) :
                new ObjectParameter("Observations", typeof(string));
    
            var priceDistributorParameter = priceDistributor.HasValue ?
                new ObjectParameter("PriceDistributor", priceDistributor) :
                new ObjectParameter("PriceDistributor", typeof(decimal));
    
            var priceClientParameter = priceClient.HasValue ?
                new ObjectParameter("PriceClient", priceClient) :
                new ObjectParameter("PriceClient", typeof(decimal));
    
            var priceMemberParameter = priceMember.HasValue ?
                new ObjectParameter("PriceMember", priceMember) :
                new ObjectParameter("PriceMember", typeof(decimal));
    
            var isEnabledParameter = isEnabled.HasValue ?
                new ObjectParameter("IsEnabled", isEnabled) :
                new ObjectParameter("IsEnabled", typeof(bool));
    
            var keywordsParameter = keywords != null ?
                new ObjectParameter("Keywords", keywords) :
                new ObjectParameter("Keywords", typeof(string));
    
            var dataUpdateParameter = dataUpdate.HasValue ?
                new ObjectParameter("DataUpdate", dataUpdate) :
                new ObjectParameter("DataUpdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("JEVJ1_ActualizaProducto", productIdParameter, idTypeParameter, idColorParameter, idBrandParameter, idProviderParameter, idCatalogParameter, titleParameter, nombreParameter, descriptionParameter, observationsParameter, priceDistributorParameter, priceClientParameter, priceMemberParameter, isEnabledParameter, keywordsParameter, dataUpdateParameter);
        }
    
        public virtual ObjectResult<JEVJ1_BuscaProductoPorID_Result> JEVJ1_BuscaProductoPorID(Nullable<int> productId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JEVJ1_BuscaProductoPorID_Result>("JEVJ1_BuscaProductoPorID", productIdParameter);
        }
    
        public virtual ObjectResult<JEVJ1_BuscaProductoPorNombre_Result> JEVJ1_BuscaProductoPorNombre(string productName)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JEVJ1_BuscaProductoPorNombre_Result>("JEVJ1_BuscaProductoPorNombre", productNameParameter);
        }
    
        public virtual int JEVJ1_EliminaProductoPorID(Nullable<int> productId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("JEVJ1_EliminaProductoPorID", productIdParameter);
        }
    
        public virtual int JEVJ1_InsertaNuevoProducto(Nullable<int> idType, Nullable<int> idColor, Nullable<int> idBrand, Nullable<int> idProvider, Nullable<int> idCatalog, string title, string nombre, string description, string observations, Nullable<decimal> priceDistributor, Nullable<decimal> priceClient, Nullable<decimal> priceMember, Nullable<bool> isEnabled, string keywords, Nullable<System.DateTime> dataUpdate)
        {
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("IdType", idType) :
                new ObjectParameter("IdType", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("IdColor", idColor) :
                new ObjectParameter("IdColor", typeof(int));
    
            var idBrandParameter = idBrand.HasValue ?
                new ObjectParameter("IdBrand", idBrand) :
                new ObjectParameter("IdBrand", typeof(int));
    
            var idProviderParameter = idProvider.HasValue ?
                new ObjectParameter("IdProvider", idProvider) :
                new ObjectParameter("IdProvider", typeof(int));
    
            var idCatalogParameter = idCatalog.HasValue ?
                new ObjectParameter("IdCatalog", idCatalog) :
                new ObjectParameter("IdCatalog", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var observationsParameter = observations != null ?
                new ObjectParameter("Observations", observations) :
                new ObjectParameter("Observations", typeof(string));
    
            var priceDistributorParameter = priceDistributor.HasValue ?
                new ObjectParameter("PriceDistributor", priceDistributor) :
                new ObjectParameter("PriceDistributor", typeof(decimal));
    
            var priceClientParameter = priceClient.HasValue ?
                new ObjectParameter("PriceClient", priceClient) :
                new ObjectParameter("PriceClient", typeof(decimal));
    
            var priceMemberParameter = priceMember.HasValue ?
                new ObjectParameter("PriceMember", priceMember) :
                new ObjectParameter("PriceMember", typeof(decimal));
    
            var isEnabledParameter = isEnabled.HasValue ?
                new ObjectParameter("IsEnabled", isEnabled) :
                new ObjectParameter("IsEnabled", typeof(bool));
    
            var keywordsParameter = keywords != null ?
                new ObjectParameter("Keywords", keywords) :
                new ObjectParameter("Keywords", typeof(string));
    
            var dataUpdateParameter = dataUpdate.HasValue ?
                new ObjectParameter("DataUpdate", dataUpdate) :
                new ObjectParameter("DataUpdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("JEVJ1_InsertaNuevoProducto", idTypeParameter, idColorParameter, idBrandParameter, idProviderParameter, idCatalogParameter, titleParameter, nombreParameter, descriptionParameter, observationsParameter, priceDistributorParameter, priceClientParameter, priceMemberParameter, isEnabledParameter, keywordsParameter, dataUpdateParameter);
        }
    
        public virtual ObjectResult<JEVJ1_MuestraProductos_Result> JEVJ1_MuestraProductos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JEVJ1_MuestraProductos_Result>("JEVJ1_MuestraProductos");
        }
    
        public virtual ObjectResult<JRCV1_SearchShoesProduct_Result> JRCV1_SearchShoesProduct(Nullable<int> id, string nombre)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JRCV1_SearchShoesProduct_Result>("JRCV1_SearchShoesProduct", idParameter, nombreParameter);
        }
    
        public virtual ObjectResult<Show_Result> Show()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Show_Result>("Show");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
