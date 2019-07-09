﻿using System;
using System.Collections.Generic;

namespace Safe2Pay
{
    public class InvoiceResponse
    {
        public int Id { get; set; }
        public Merchant Merchant { get; set; }
        public Customer Customer { get; set; }
        public int IdTransaction { get; set; }
        public int Status { get; set; }
        public string SingleSaleHash { get; set; }
        public string Reference { get; set; }
        public string CallbackUrl { get; set; }
        public string SingleSaleUrl { get; set; }
        public string BankSplipUrl { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PenaltyAmount { get; set; }
        public decimal InterestAmount { get; set; }
        public List<string> Emails { get; set; }
        public List<string> Messages { get; set; }
        public string Instruction { get; set; }
        public bool IsExcluded { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public List<SingleSaleProduct> Products { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; }
        public int ApiVersion { get; set; }
        public int IdSubscription { get; set; }
    }
}