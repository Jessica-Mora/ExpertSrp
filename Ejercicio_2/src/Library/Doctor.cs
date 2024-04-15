using System;
using System.Text;


namespace Library
{
    public class Doctor
    {
        public static string CreateDoctor(string doctorName, string especialidad)
        {
            StringBuilder stringBuilder = new StringBuilder($"Doctor: {doctorName}, {especialidad} \n");
            Boolean isValid = true;


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(especialidad))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("");
            }

            return stringBuilder.ToString();
        }

    }
}
