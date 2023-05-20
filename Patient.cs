using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Patient:IPatient
    {


        

        public string patientName { get; set; }
        public string patientId { get; set; }
        public string disease { get; set; }
        public string prescription { get; set; }
        
        public string password { get; set; }
        public Patient() { }

        public Patient(string name, string ID, string disease)
        {
            this.patientName = name;
            this.patientId = ID;
            this.disease = disease;
        }

        public override string ToString()
        {
           return "Patient name: " + this.patientName + ", Patient ID: " + this.patientId + ", Disease: " + disease + ", Prescription: " + prescription;
        }

    }
}
