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

    public ICollection<RestaurantPhoneNumber> RestaurantPhoneNumbers { get; set; }
    public ICollection<RestaurantEmail> RestaurantEmails { get; set; }
    public ICollection<RestaurantProduct> RestaurantProducts { get; set; }
    public ICollection<HotelRestaurant> HotelRestaurants { get; set; }
    public ICollection<RestaurantCommission> RestaurantCommissions { get; set; }
    public ICollection<User> Users { get; set; }
}