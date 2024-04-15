using System;
using System.Text;

namespace Library 
{
 public class AppointmentNotificationBuilder
{
  public static string BuildMessage(bool isSuccess)
  {
    if (isSuccess)
    {
      return "Appointment scheduled successfully";
    }
    else
    {
      return "Error scheduling appointment";
    }
  }
}




}