﻿using PKShop.Domain.DomainClasses.Abstract;
using System;

namespace PKShop.Domain.DomainClasses.Purchases
{
    public class Purchase : BaseEntity
    {
        public Guid Id { get; protected set; }
        public Guid CustomerId { get; protected set; }
        public decimal TotalAmount { get; protected set; }
        public decimal TotalTax { get; protected set; }
        public PurchaseMethod PaymentMethod { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public DateTime CreateAt { get; protected set; }

        protected Purchase()
        {         
        }

        public Purchase(Guid id, Guid customerId, decimal totalAmount, decimal totalTax)
        {
            Id = id;
            CustomerId = customerId;
            TotalAmount = totalAmount;
            TotalTax = totalTax;
            CreateAt = DateTime.UtcNow;
        }

        public enum PurchaseMethod
        {
            CreditCard = 0,
            Cash = 1,
        }
    }
}
