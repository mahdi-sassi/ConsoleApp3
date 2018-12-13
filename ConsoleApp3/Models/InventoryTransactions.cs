using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using ConsoleApp3;

namespace ConsoleApp3
{
    public class InventoryTransactions : Table
    {
        public string Referance { get; set; }
        [InverseProperty("InventoryTransactions")]
        public List<InventoryTransactionsDetails> InventoryTransactionsDetailsList { get; set; }
        public Guid? ProductStoresID { get; set; }
        public ProductStores ProductStores { get; set; }
    }
}
