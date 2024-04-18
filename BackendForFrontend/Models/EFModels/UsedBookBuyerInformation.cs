﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BackendForFrontend.Models.EFModels;

[Table("UsedBookBuyerInformation")]
public partial class UsedBookBuyerInformation
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string OrderId { get; set; }

    [Required]
    [StringLength(50)]
    public string RecipientName { get; set; }

    [Required]
    [StringLength(50)]
    public string RecipientPhone { get; set; }

    [Required]
    [StringLength(50)]
    public string RecipientAddress { get; set; }

    [StringLength(50)]
    public string RecipientEmail { get; set; }

    public string Remark { get; set; }
}