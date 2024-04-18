﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BackendForFrontend.Models.EFModels;

public partial class UsedBooksOrderDetail
{
    [Key]
    public int Id { get; set; }

    public int OrderID { get; set; }

    public int BookID { get; set; }

    public int UnitPrice { get; set; }

    [ForeignKey("BookID")]
    [InverseProperty("UsedBooksOrderDetails")]
    public virtual UsedBook Book { get; set; }

    [ForeignKey("OrderID")]
    [InverseProperty("UsedBooksOrderDetails")]
    public virtual UsedBooksOrder Order { get; set; }
}