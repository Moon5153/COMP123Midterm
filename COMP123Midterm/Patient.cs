using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Midterm
{
    public class Patient
    {
        private List<Prescription> prescriptions = new List<Prescription>();

        public string Name { get; private set; }
        public int Yob { get; private set; }
        public Patient(string name,int yob)
        {
            Name = name;
            Yob = yob;
        }
        public void AddPrescription(Prescription prescription)
        {
            prescriptions.Add(prescription);
        }
        public void RemovePrescription(string id)
        {
            int flag = 0;
            int i;
            for(i=0;i<prescriptions.Count;i++)
            {

                if (prescriptions[i].ID.Equals(id))
                {
                    flag++;
                    break;
                }
            }
            if(flag==0)
            {
                throw new CustomException("Exception: Prescription "+id+" does not exist",this);
            }
            else
            {
                prescriptions.RemoveAt(i);
            }
        }
        private string GetPrescriptions()
        {
            string prescriptionList = "";

            for (int i = 0; i < prescriptions.Count; i++)
            {
                prescriptionList +=prescriptions[i].ToString() + "\n";
            }
            return prescriptionList;
        }

        public override string ToString()
        {
          
            return $"{Name} yob: {Yob}\nList of Prescription:\n{this.GetPrescriptions()}";
        }

        public void SaveAsText(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(this.ToString());
            }
           
        }
    }
}
