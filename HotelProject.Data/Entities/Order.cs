public class Order
{
    public int OrderId { get; set; }
    public HotelRoom HotelRoom { get; set; }
    public Hotel Hotel { get; set; }
    public decimal OrderTotalPrice { get; set; }
    public OrderStatus OrderStatus {get; set;}
    public PaymentMethod PaymentMethod {get; set;}
    public Payment Payment {get; set;}
    public DiscountCoupon? Coupon { get; set; }
    public DateTime OrderDate { get; set; }

    public IList<OrderDetail> OrderDetails { get; set; }
    public IList<AdminCommissionEarning> AdminCommissionEarnings{get; set;}
    public IList<HotelCommissionEarning> HotelCommissionEarnings{get; set;}
    public IList<Review> Reviews { get; set; }
    public IList<OrderStatusHistory> OrderStatusHistories { get; set; }
}