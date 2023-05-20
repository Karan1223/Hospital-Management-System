using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal interface IPatient
    {
        string patientName { get; set; }
        string patientId { get; set; }
        string disease { get; set; }
        string prescription { get; set; }
       
        string password { get; set; }
    }
}
