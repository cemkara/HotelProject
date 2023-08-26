public class PhoneNumber{
    public int PhoneNumberId { get; set; }
    public string Number { get; set; }
    public Status Status { get; set; }
    public DateTime RecordDate { get; set;} 

    public ICollection<UserPhoneNumber> UserPhoneNumbers { get; set; }
    public ICollection<HotelPhoneNumber> HotelPhoneNumbers { get; set; }
    public ICollection<RestaurantPhoneNumber> RestaurantPhoneNumbers { get; set; }
}