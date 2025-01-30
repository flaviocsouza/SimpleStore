﻿namespace SimpleStore.Domain.Models;

public class Product : BaseEntity 
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

    public List<Supplier> Suppliers { get; set; }
    public List<ProductSupplier> ProductsSuppliers { get; set; }

}
