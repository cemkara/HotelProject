public class User{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Status Status {get; set;}
    public UserType UserType {get; set;}
    public DateTime LastLoginDate { get; set; }
    public DateTime RecordDate { get; set; }

    public IList<UserPhoneNumber> UserPhoneNumbers { get; set; }
    public IList<UserEmail> UserEmails { get; set; }
    public IList<Restaurant> Restaurants { get; set; }
    public IList<Hotel> Hotels { get; set; }
    public IList<DriverAssignment> DriverAssignments { get; set; }
}