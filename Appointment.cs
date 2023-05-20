using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Appointment
    {
        public string DoctorID { get; set; }
        public string appointmentTime { get; set; }

        IPatient patient;

        


        public Appointment(string DoctorID, string appointmentTime, IPatient patient)
        {
            this.DoctorID = DoctorID;
            this.appointmentTime = appointmentTime;
            this.patient = patient;
        }

        public override string ToString()
        {
            return "Doctor ID: " + DoctorID + ", Appointment Time: " + appointmentTime + " " + patient.ToString();
        }

    }
}
