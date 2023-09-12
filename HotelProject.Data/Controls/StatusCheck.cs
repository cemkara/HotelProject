using HotelProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StatusCheck
{
    private static Context context = new Context();

    public static bool IsUserActive(MyUser user)
    {
        var a = context.Users.Find(user.Id);
        if (user.Status == context.Statuses.Find(1))
        {
            return true;
        }
        return false;
    }
}

