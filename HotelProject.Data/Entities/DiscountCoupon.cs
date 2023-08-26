public class DiscountCoupon
{
    public int DiscountCouponId { get; set; }
    public string CouponCode { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal MinAmount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Status Status { get; set; }
}