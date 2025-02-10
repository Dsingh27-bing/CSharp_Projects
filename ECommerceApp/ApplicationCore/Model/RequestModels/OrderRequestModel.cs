namespace ApplicationCore.Model.RequestModels;

public class OrderRequestModel
{
        
        public int Id { get; set; }
        public DateTime? Order_Date { get; set; }
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? PaymentName { get; set; }
        public string? ShippingAddress { get; set; }
        public decimal? BillAmount { get; set; }
        public string? Order_Status { get; set; }
    
    
}