using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Order_Details
{
    public int Id { get; set; }
    [Required]
    public int Order_Id { get; set; }
    [Required]
    public int Product_Id { get; set; }
    public String? Product_Name { get; set; }
    [Required]
    public int Qty { get; set; }
    [Required]
    public Decimal Price { get; set; }
    public Decimal? Discount { get; set; }
    
    [ForeignKey("Order_Id")]
    public Order Order { get; set; }
    
}