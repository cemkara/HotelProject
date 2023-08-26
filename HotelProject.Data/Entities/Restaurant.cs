public class Restaurant
{
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public Status Status { get; set; }
    public decimal MinAmount { get; set; }
    public int MaxDeliveryTime { get; set; }
    public RestaurantType RestaurantType { get; set; }
    public DateTime RecordDate { get; set; }

    public IList<RestaurantPhoneNumber> RestaurantPhoneNumbers { get; set; }
    public IList<RestaurantEmail> RestaurantEmails { get; set; }
    public IList<RestaurantProduct> RestaurantProducts { get; set; }
    public IList<HotelRestaurant> HotelRestaurants { get; set; }
    public IList<RestaurantCommission> RestaurantCommissions { get; set; }
    public IList<User> Users { get; set; }
}