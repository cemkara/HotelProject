public class Payment(){
    public int PaymentId { get; set;}
    public Order Order {get; set;}
    public decimal TotalPayment { get; set; }
    public PaymentMethod PaymentMethod {get; set;}
    public DateTime PaymentDate{get; set;}
}