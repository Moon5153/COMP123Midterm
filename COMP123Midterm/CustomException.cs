using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Midterm
{
    public class CustomException:Exception
    {
        public Patient Patient { get; }
        public CustomException(string message,Patient patient):base(message)
        {
            Patient = patient;
        }
        public CustomException(string message,Exception innerException,Patient patient):base(message,innerException)
        {
            Patient = patient;
        }
    }
}
