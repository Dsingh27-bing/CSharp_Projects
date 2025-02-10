using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Order
{
    public int Id { get; set; }
    [Required]
    public DateTime Order_Date { get; set; }
    [Required]
    public int CustomerId { get; set; }
    public int? PaymentMethodId { get; set; }
    public String? PaymentName { get; set; }
    public String? ShippingAddress { get; set; }
    public String? ShippingMethod { get; set; }
    [Required]
    public Decimal BillAmount { get; set; }
    public String? Order_Status { get; set; }

    public IEnumerable<Order_Details> Order_Details { get; set; } = new List<Order_Details>();
}