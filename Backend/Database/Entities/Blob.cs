using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Database.Entities;

[Table("blobs")]
public partial class Blob
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("filename")]
    public string Filename { get; set; } = null!;

    [Column("created")]
    public DateTime Created { get; set; }

    [Column("modified")]
    public DateTime Modified { get; set; }

    [InverseProperty("Blob")]
    public virtual ICollection<User> Users { get; } = new List<User>();
}
