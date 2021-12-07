using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinaData.Models;

public class ProductModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public int Code { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    [Required]
    public decimal Price { get; set; }
    public CountryModel? Country { get; set; }
    public GroupModel? Group { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}