using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Nurse
    {
        public bool setAppointment(String DoctorID, String AppointmentTime, IPatient patient)
        {
            Appointment app = new Appointment(DoctorID, AppointmentTime, patient);
            //Console.WriteLine(app.ToString());
            AppointmentModel model = AppointmentModel.Instance;
            model.addAppointment(app);
            return true;
        }
        public List<Appointment> getAllAppointments()
        {
            AppointmentModel model = AppointmentModel.Instance;
            return model.Appointments;
        }
    }
}
