using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal interface IDoctor
    {
        string ID { get; set; }
        string name { get; set; }
       
        string password { get; set; }
       
        List<Appointment> getDoctorAppointments();
    }
}
