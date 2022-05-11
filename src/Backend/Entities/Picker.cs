﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Backend.Entities
{
    internal partial class Picker
    {
        [Key]
        [Column("PickerID")]
        public int PickerId { get; set; }
        [Required]
        [StringLength(35)]
        public string LastName { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        public bool Active { get; set; }
        [Column("StoreID")]
        public int StoreId { get; set; }

        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Pickers")]
        public virtual Store Store { get; set; }
    }
}