public class Order
{
    public int OrderId { get; set; }
    public HotelRoom HotelRoom { get; set; }
    public Hotel Hotel { get; set; }
    public decimal OrderTotalPrice { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public int PaymentId { get; set; }
    public Payment Payment { get; set; }
    public DiscountCoupon? Coupon { get; set; }
    public DateTime OrderDate { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }
    public ICollection<AdminCommissionEarning> AdminCommissionEarnings { get; set; }
    public ICollection<HotelCommissionEarning> HotelCommissionEarnings { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<OrderStatusHistory> OrderStatusHistories { get; set; }
}