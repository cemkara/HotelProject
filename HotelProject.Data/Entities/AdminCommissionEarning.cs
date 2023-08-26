public class AdminCommissionEarning
{
    public int AdminCommissionEarningId { get; set; }
    public decimal CommissionRate { get; set; }
    public decimal EarnedAmount { get; set; }
    public DateTime RecordDate { get; set; }
    public Order Order { get; set; }
}