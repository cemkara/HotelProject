public class OrderStatusHistory
{
    public int OrderStatusHistoryId { get; set; }
    public Order Order { get; set; }   
    public OrderStatus OrderStatus { get; set; }
    public DateTime StatusDate { get; set; }
}