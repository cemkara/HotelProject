using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HotelViewModel : Hotel
{
    public int SelectedUserId { get; set; }
    public int SelectedDistrictId { get; set; }
    public int SelectedStatusId { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string AddressText { get; set; }
}

