using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static bool CreateAppointment( string DateTime, string date, string appoinmentPlace, string ide)
        {
            
            string message = "";

            if (string.IsNullOrEmpty(DateTime))
            {
                message +=("Unable to schedule appointment, 'date time' is required\n");
                return  false;
            }
            
            if (string.IsNullOrEmpty(date))
            {
                message += ("Unable to schedule appointment, 'date' is required\n");
                return false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                message +=("Unable to schedule appointment, 'appoinment place' is required\n");
                return false;
            }

            if (string.IsNullOrEmpty(ide))
            {
                message +=("Unable to schedule appointment, 'ide' is required\n");
                return false;
            }

            message = "Appoinment scheduled";
            return true;
        }

    }
}
