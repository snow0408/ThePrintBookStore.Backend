﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BackendForFrontend.Models.EFModels;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [Required]
    [StringLength(50)]
    public string ProductStatus { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Category { get; set; }

    public int Stock { get; set; }

    public int? DetailsCategoryId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Offer { get; set; }

    public int? DiscountDegree { get; set; }

    [Column(TypeName = "decimal(34, 6)")]
    public decimal? RealPrice { get; set; }

    [InverseProperty("Book")]
    public virtual ICollection<AnalyzeOneBook> AnalyzeOneBooks { get; set; } = new List<AnalyzeOneBook>();

    [InverseProperty("Book")]
    public virtual ICollection<AnalyzeSale> AnalyzeSales { get; set; } = new List<AnalyzeSale>();

    [InverseProperty("Book")]
    public virtual ICollection<AnalyzeUserInteraction> AnalyzeUserInteractions { get; set; } = new List<AnalyzeUserInteraction>();

    [InverseProperty("Product")]
    public virtual ICollection<BookProduct> BookProducts { get; set; } = new List<BookProduct>();

    [InverseProperty("Product")]
    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    [ForeignKey("DetailsCategoryId")]
    [InverseProperty("Products")]
    public virtual ProductDetailsCategory DetailsCategory { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<EBook> EBooks { get; set; } = new List<EBook>();

    [InverseProperty("Product")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [InverseProperty("Product")]
    public virtual ICollection<PdInStock> PdInStocks { get; set; } = new List<PdInStock>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductKeyword> ProductKeywords { get; set; } = new List<ProductKeyword>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductPicture> ProductPictures { get; set; } = new List<ProductPicture>();

    [InverseProperty("Product")]
    public virtual ICollection<QtyBookInventory> QtyBookInventories { get; set; } = new List<QtyBookInventory>();

    [InverseProperty("Book")]
    public virtual ICollection<QtyflawBook> QtyflawBooks { get; set; } = new List<QtyflawBook>();

    [InverseProperty("Book")]
    public virtual ICollection<WriteBookReview> WriteBookReviews { get; set; } = new List<WriteBookReview>();
}