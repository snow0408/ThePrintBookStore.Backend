﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BackendForFrontend.Models.EFModels;

public partial class Post
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Title { get; set; }

    [Required]
    public string Content { get; set; }

    public int AuthorId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PublishDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Required]
    [StringLength(255)]
    public string Slug { get; set; }

    public bool IsPublished { get; set; }

    [ForeignKey("AuthorId")]
    [InverseProperty("Posts")]
    public virtual Employee Author { get; set; }

    [InverseProperty("Post")]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    [ForeignKey("PostId")]
    [InverseProperty("Posts")]
    public virtual ICollection<Category1> Categories { get; set; } = new List<Category1>();

    [ForeignKey("PostId")]
    [InverseProperty("Posts")]
    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}