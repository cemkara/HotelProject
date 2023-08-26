public class Email{
    public int EmailId { get; set; }
    public string Mail { get; set; }
    public Status Status { get; set; }
    public DateTime RecordDate { get; set;} 

    public ICollection<UserEmail> UserEmails { get; set; }
    public ICollection<HotelEmail> HotelEmails { get; set; }
    public ICollection<RestaurantEmail> RestaurantEmails { get; set; }
}