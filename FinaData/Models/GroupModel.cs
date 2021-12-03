﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaData.Models;

public class GroupModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required] 
    [StringLength(50)]
    public string Name { get; set; }
    public GroupModel? ParentGroup { get; set; }
    public List<ProductModel>? Production { get; set; } = new List<ProductModel>();
}