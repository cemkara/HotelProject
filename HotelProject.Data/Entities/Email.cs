public class Email(){
    public int EmailId { get; set; }
    public string Mail { get; set; }
    public Status Status { get; set; }
    public DateTime RecordDate { get; set;} 

    public IList<UserEmail> UserEmails { get; set; }
    public IList<HotelEmail> HotelEmails { get; set; }
    public IList<RestaurantEmail> RestaurantEmails { get; set; }
}