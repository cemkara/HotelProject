using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RestaurantViewModel : Restaurant
{
    [Required(ErrorMessage = "This field cannot be left blank.")]
    public int SelectedUserId { get; set; }
    [Required(ErrorMessage = "This field cannot be left blank.")]
    public int SelectedDistrictId { get; set; }
    [Required(ErrorMessage = "This field cannot be left blank.")]
    public int SelectedStatusId { get; set; }

    [Required(ErrorMessage = "This field cannot be left blank.")]
    public int SelectedTypeId { get; set; }

    [Required(ErrorMessage = "This field cannot be left blank.")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }
    [Required(ErrorMessage = "This field cannot be left blank.")]
    public string Phone { get; set; }
    [Required(ErrorMessage = "This field cannot be left blank.")]
    public string AddressText { get; set; }
    public string UserName { get; set; }
    public string DistrictName { get; set; }
    public string StatusName { get; set; }
}

