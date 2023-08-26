public class HotelCommissionEarning
{
    public int HotelCommissionEarningId { get; set; }
    public decimal CommissionRate { get; set; }
    public decimal EarnedAmount { get; set; }
    public DateTime RecordDate { get; set; }
    public Hotel Hotel { get; set; }
    public Order Order { get; set; }
}