﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BackendForFrontend.Models.EFModels;

[Table("MyCache")]
[Index("ExpiresAtTime", Name = "Index_ExpiresAtTime")]
public partial class MyCache
{
    [Key]
    [StringLength(449)]
    public string Id { get; set; }

    [Required]
    public byte[] Value { get; set; }

    public DateTimeOffset ExpiresAtTime { get; set; }

    public long? SlidingExpirationInSeconds { get; set; }

    public DateTimeOffset? AbsoluteExpiration { get; set; }
}