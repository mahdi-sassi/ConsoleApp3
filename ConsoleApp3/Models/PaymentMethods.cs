using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ConsoleApp3
{
    public class PaymentMethods : TableInfoShort
    {
        public byte[] Logo { get; set; }
        public byte[] Picture { get; set; }
        public bool Active { get; set; }
        public string AdditionalValue { get; set; }
        [InverseProperty("PaymentMethods")]
        public List<Payments> PaymentsList { get; set; }
    }
}