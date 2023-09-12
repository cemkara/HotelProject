using System.ComponentModel.DataAnnotations;


public class UserLoginViewModel
{
    [Required(ErrorMessage = "Please enter username")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Please enter password")]
    public string Password { get; set; }
}
