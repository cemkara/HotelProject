public class PhoneNumber{
    public int PhoneNumberId { get; set; }
    public string Number { get; set; }
    public Status Status { get; set; }
    public DateTime RecordDate { get; set;} 

    public IList<UserPhoneNumber> UserPhoneNumbers { get; set; }
    public IList<HotelPhoneNumber> HotelPhoneNumbers { get; set; }
    public IList<RestaurantPhoneNumber> RestaurantPhoneNumbers { get; set; }
}