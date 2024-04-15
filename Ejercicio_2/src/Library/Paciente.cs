using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public static string CreatePaciente(string name, string id, string edad, string phoneNumber)
        {
            StringBuilder stringBuilder = new StringBuilder($"paciente: {name}, {id}, { edad}, {phoneNumber} \n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(edad))
            {
                stringBuilder.Append("Unable to schedule appointment, 'edad' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
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
