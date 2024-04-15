using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string paciente1 = Paciente.CreatePaciente("Juan","6666","34","444445553");
            Console.WriteLine(paciente1);
            string doc = Doctor.CreateDoctor("dr. Lopez", "neuro");
            Console.WriteLine(doc);

            bool appointmentCreated = AppointmentService.CreateAppointment("14:00", "12/10", "Wall Street", "1234");

            string notificationMessage = AppointmentNotificationBuilder.BuildMessage(appointmentCreated);
            Console.WriteLine(notificationMessage);
                   
        }
    }
}
