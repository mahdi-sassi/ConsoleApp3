using System;

using System.Collections.Generic;

using System.Text;

using System.Configuration;

using System.Data.SqlClient;

using System.IO;


using System.Data.Entity;

namespace ConsoleApp3
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class App1Context : DbContext
    {
        //dynamic str = ConfigurationManager.AppSettings["DefaultConnection"];

        public App1Context()
            : base("name=DefaultConnection")
        {
        }






        /// <summary>
        /// DbSet Colors
        /// </summary>
        //public System.Data.Entity.DbSet<ConsoleApp3.Colors> Colors { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ValidationParentClass> ValidationParentClass { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductStoresJoinUser> ProductStoresJoinUser { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.Country> Country { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PaymentMethods> PaymentMethods { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.FieldValidationFactory> FieldValidationFactory { get; set; }


        //public DbSet<TransferRequests> TransferRequest { get; set; }
        //public DbSet<BLL.Models.Domains> Domains { get; set; }
        //public DbSet<TransferRequestDetails> TransferRequestDetails { get; set; }
        //public DbSet<ProductBatchDefinitionImageCategories> ProductBatchDefinitionImageCategories { get; set; }
        //public DbSet<TransferRequestBatchs> TransferRequestBatchs { get; set; }


        //public DbSet<ConsoleApp3.InvoiceDetails> InvoiceDetails { get; set; }
        //public DbSet<ConsoleApp3.InvoiceDetailsStatus> InvoiceDetailsStatus { get; set; }
        //public DbSet<ConsoleApp3.Invoices> Invoices { get; set; }
        //public DbSet<ConsoleApp3.InvoiceStatus> InvoiceStatus { get; set; }
        //public DbSet<ConsoleApp3.InvoiceSubTotals> InvoiceSubTotals { get; set; }
        //public DbSet<ConsoleApp3.InvoiceSubTotalTypes> InvoiceSubTotalTypes { get; set; }
        //public DbSet<ConsoleApp3.Payments> Payments { get; set; }
        //public DbSet<ConsoleApp3.ShippingAddresses> ShippingAddresses { get; set; }
        //public DbSet<ConsoleApp3.Customers> Customers { get; set; }


        //public System.Data.Entity.DbSet<ConsoleApp3.InventoryTransactions> InventoryTransactions { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.InventoryTransactionsDetails> InventoryTransactionsDetails { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.InventoryTransactionsTypes> InventoryTransactionsTypes { get; set; }

        //public System.Data.Entity.DbSet<ConsoleApp3.ShippmentUnitsImages> ShippmentUnitsImages { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.Currency> Currency { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ImageSizes> ImageSizes { get; set; }
        
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductCategoriesImages> ProductCategoriesImages { get; set; }

        //public System.Data.Entity.DbSet<ConsoleApp3.ProductCategories> ProductCategories { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.Vendors> Vendors { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.VendorsCategories> VendorsCategories { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.Sizes> Sizes { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.DimensionMeasurements> DimensionMeasurements { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.DimensionsDefinitions> DimensionsDefinitions { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.Units> Units { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.UnitTypes> UnitTypes { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.WeightMeasurements> WeightMeasurements { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductTypes> ProductTypes { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductTypesImages> ProductTypesImages { get; set; }

        //public System.Data.Entity.DbSet<ConsoleApp3.DesginPaddingImages> DesginPaddingImages { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.DesignedProductBatchDefinitionImages> DesignedProductBatchDefinitionImages { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.DesignedProductImages> DesignedProductImages { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.DesignedProducts> DesignedProducts { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.DiscountQualifications> DiscountQualifications { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.FreeGoods> FreeGoods { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PriceDiscounts> PriceDiscounts { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PriceDiscountTypes> PriceDiscountTypes { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PriceTypes> PriceTypes { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductBatchDefinitions> ProductBatchDefinitions { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductBatches> ProductBatches { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductBatchItems> ProductBatchItems { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductBatchItemShelves> ProductBatchItemShelves { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductBatchItemsImages> ProductBatchItemsImages { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductBatchItemsSmallImages> ProductBatchItemsSmallImages { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductCategoriesProductTypes> ProductCategoriesProductTypes { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductDetailsTypes> ProductDetailsTypes { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductDetailsTypesDetails> ProductDetailsTypesDetails { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductDetailsTypesDetailsProducts> ProductDetailsTypesDetailsProducts { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductImages> ProductImages { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductPrices> ProductPrices { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.Products> Products { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductSetLists> ProductSetLists { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductSmallImages> ProductSmallImages { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.SmallImageSettings> SmallImageSettings { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.BigImageSettings> BigImageSettings { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductStores> ProductStores { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductStoresRows> ProductStoresRows { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProductStoresShelves> ProductStoresShelves { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.TagModels> TagModels { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.TagProducts> TagProducts { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.TemperatureType> TemperatureType { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.VarianceTypes> VarianceTypes { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.VarianceTypesProducts> VarianceTypesProducts { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.VarianceTypesProductTypes> VarianceTypesProductTypes { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.VarianceValuesProductBatchDefinitions> VarianceValuesProductBatchDefinitions { get; set; }
        //public DbSet<EmailSenderConfigurations> EmailSenderConfigurations { get; set; }
        //public DbSet<EmailMessages> EmailMessages { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ProformaInvoiceDetails> ProformaInvoiceDetails { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PurchaseOrderDetails> PurchaseOrderDetails { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PurchaseOrderPayement> PurchaseOrderPayement { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PurchaseOrders> PurchaseOrders { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PurchaseOrderShippment> PurchaseOrderShippment { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PurchaseOrderShippmentDetails> PurchaseOrderShippmentDetails { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.PurchaseOrderShippmentItems> PurchaseOrderShippmentItems { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.ShippmentUnits> ShippmentUnits { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.VarianceValues> VarianceValues { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.VendorsContacts> VendorsContacts { get; set; }
        //public System.Data.Entity.DbSet<ConsoleApp3.Banks> Banks { get; set; }

        public DbSet<Products> Products { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductSmallImages>()
        //                .HasRequired(m => m.Products)
        //                .WithMany(t => t.ProductSmallImagesList)
        //                .HasForeignKey(m => m.ProductsID)
        //                .WillCascadeOnDelete(false);
        //}


    }
}