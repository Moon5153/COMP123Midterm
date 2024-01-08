using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Midterm
{
    public class Prescription
    {
        private static int CURRENT_NUMBER=100;
        public readonly string ID;
        
        public string Doctor { get; private set; }
        public bool ForRepeat { get; private set; }
        public int Length { get; private set; }
        public string Name { get; private set; }

        public Prescription(string doctor,string name,int length,bool forRepeat=false)
        {
            Doctor = doctor;
            Name = name;
            Length = length;
            ForRepeat = forRepeat;

            ID = Convert.ToString(CURRENT_NUMBER);
            CURRENT_NUMBER++;

        }
        public override string ToString()
        {
            string result = "";
            if(ForRepeat)
            {
                result += "(Repeat)";
            }
            else
            {
                result += "(No repeat)";
            }
            return $"#{ID} {Name} prescribed by {Doctor} for {Length}days {result}";
            
        }
    }
}

