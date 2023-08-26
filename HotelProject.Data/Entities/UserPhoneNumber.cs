public class UserPhoneNumber{
    public int UserPhoneNumberId { get; set; }
    public User User { get; set; }  
    public PhoneNumber PhoneNumber { get; set; }  
}