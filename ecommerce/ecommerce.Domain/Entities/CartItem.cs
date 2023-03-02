﻿namespace ecommerce.Domain.Entities
{
    public class CartItem
    {
        public Guid CartItemId { get; set; }
        public int Quantity { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}