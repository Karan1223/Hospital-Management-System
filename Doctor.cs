using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Doctor:IDoctor
    {
        public string name { get; set; }
       
        
        public string password { get; set; }
        public string ID { get; set; }

        public List<Appointment> getDoctorAppointments()
        {
            AppointmentModel model = AppointmentModel.Instance;
            //Console.WriteLine(ID);
            return model.getAppointmentForDoctor(ID);
        }
    }
}
