public class RestaurantCommission
{
    public int RestaurantCommissionId { get; set; }
    public decimal CommissionRate { get; set; }
    public Restaurant Restaurant { get; set; }
}