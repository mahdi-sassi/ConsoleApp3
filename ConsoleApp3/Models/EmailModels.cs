using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
namespace ConsoleApp3
{
    public class EmailSenderConfigurations:Table
    {
        public string SmtpConfig { get; set; }
        public string SenderName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public int Port { get; set; }
        [Required]
        public string Host { get; set; }
        [Required]
        public bool EnableSSL { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool IsBodyHTML { get; set; }
        // public SmtpDeliveryFormat deliveryFormat { get; set; }
        //  public SmtpDeliveryMethod deliveryMethod { get; set; }
        public string TargetNmae { get; set; }
        public int TimeOut { get; set; }
        public bool Default { get; set; }
        public bool UsedefaultCredentials { get; set; }
    }
    public class SmsMessages :Table
    {
        public string Message { get; set; }
        public string To { get; set; }
        public string SentID { get; set; }
        public string messageid { get; set; }
        public string messageprice { get; set; }
        public string remainingbalance { get; set; }
        public bool Status { get; set; }
        //public SmsStatus SmsStatus { get; set; }
        public DateTime SentDateTime { get; set; }
    }
}