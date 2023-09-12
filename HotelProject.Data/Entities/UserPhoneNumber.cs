public class UserPhoneNumber{
    public int UserPhoneNumberId { get; set; }
    public MyUser User { get; set; }  
    public PhoneNumber PhoneNumber { get; set; }  
}