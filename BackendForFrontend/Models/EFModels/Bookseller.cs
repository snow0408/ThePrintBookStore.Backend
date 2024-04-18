﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BackendForFrontend.Models.EFModels;

public partial class Bookseller
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(50)]
    public string ContactPerson { get; set; }

    [Required]
    [StringLength(50)]
    public string Phone { get; set; }

    [Required]
    [StringLength(300)]
    public string Address { get; set; }

    public int? Compiled { get; set; }

    [StringLength(100)]
    public string BankAccount { get; set; }

    [InverseProperty("Publisher")]
    public virtual ICollection<BookProduct> BookProducts { get; set; } = new List<BookProduct>();

    [InverseProperty("Supplier")]
    public virtual ICollection<PdInStock> PdInStocks { get; set; } = new List<PdInStock>();
}