﻿namespace MishnatYosef.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int Sell { get; set; }
        public int Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderAmount { get; set; }
        public string Comments { get; set; }
        public int OrderedProduct { get; set; }

        public Order(int id, int sell, int customer, DateTime orderDate, double orderAmount, string comments, int orderedProduct)
        {
            Id = id;
            Sell = sell;
            Customer = customer;
            OrderDate = orderDate;
            OrderAmount = orderAmount;
            Comments = comments;
            OrderedProduct = orderedProduct;
        }
        public Order()
        {
            
        }
    }
}
