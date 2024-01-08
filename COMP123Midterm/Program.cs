using System;

namespace COMP123Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //test the prescription class
            Console.WriteLine("\n*****Testing the Prescription Class");
            Console.WriteLine(new Prescription("Nika", "Aspirin", 21));
            Console.WriteLine(new Prescription("Khan", "Amoxicillin", 14, true));

            //test the patient class
            Console.WriteLine("\n*****Testing the Patient Class");
            Console.WriteLine(new Patient("Justin Trudeau", 1989));

            //testing AddPrescription method of the patient class
            Patient pat0 = new Patient("Stephen Harper", 1990);
            Console.WriteLine("\n*****Testing the AddPrescription() method");
            pat0.AddPrescription(new Prescription("Pershad", "Coumadin", 21));
            pat0.AddPrescription(new Prescription("Pershad", "Metformin", 7, true));
            pat0.AddPrescription(new Prescription("Tapia", "Ventolin", 28, true));
            pat0.AddPrescription(new Prescription("Nika", "Cipralex", 14, true));
            Console.WriteLine(pat0);

            Patient pat1 = new Patient("Paul Martin", 1993);
            Console.WriteLine("\n*****Testing the AddPrescription() method");
            pat1.AddPrescription(new Prescription("Khan", "Tylenol", 7, true));
            pat1.AddPrescription(new Prescription("Zouri", "Synthroid", 21));
            pat1.AddPrescription(new Prescription("Filotti", "Ramipril", 56, true));
            pat1.AddPrescription(new Prescription("Pershad", "Pravastatin", 42, true));
            pat1.AddPrescription(new Prescription("Filotti", "Metformin", 7, true));
            pat1.AddPrescription(new Prescription("Lac", "Metformin ", 190));
            pat1.AddPrescription(new Prescription("Li", "Fluvastatin", 21));
            pat1.AddPrescription(new Prescription("Nika", "Coumadin", 21));
            Console.WriteLine(pat1);

            Console.WriteLine("\n*****Saving to \"patient.txt\"");
            pat1.SaveAsText("c:\\drew2\\patient3.txt");

            //testing the RemovePrescription method of the patient class
            Console.WriteLine("\n*****Testing the RemovePrescription() method");
            pat1.RemovePrescription("107");
            pat1.RemovePrescription("109");
            try
            {
                pat1.RemovePrescription("107");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(pat1);

            Console.Write("... Press enter to exit");
            Console.ReadLine();

        }
    }
}
