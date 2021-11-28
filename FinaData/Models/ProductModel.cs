using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaData.Models;

public class ProductModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public int ProductionCode { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    [Required]
    public double Price { get; set; }
    [Required]
    public CountryModel Country { get; set; }
    [Required]
    public List<GroupModel> Groups { get; set; }
    public DateTime StarDate { get; set; }
    public DateTime EndDate { get; set; }
}

