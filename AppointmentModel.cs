using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class AppointmentModel
    {
        public List<Appointment> Appointments = new List< Appointment>();
        private static AppointmentModel _instance = new AppointmentModel();
        public static AppointmentModel Instance => _instance;

        //public Appointment getAppointment(string DoctorName)
        //{
        //    return Appointments[DoctorName];

        //}
        public bool addAppointment(Appointment appointment)
        { 
            Console.WriteLine(appointment.ToString());
            Appointments.Add(appointment);
            return true;
        }

        public List<Appointment> getAppointmentForDoctor(string DoctorName)
        { 
            List<Appointment> appointments = new List<Appointment>();
            
            foreach (Appointment app in Appointments)
            {

                if (DoctorName == app.DoctorID)
                {
                    appointments.Add(app);
                }
            }
            return appointments;
        }
    }
}
