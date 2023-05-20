using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Admin
    {
        List<IDoctor> users = new List<IDoctor>();
        List<IPatient> patients = new List<IPatient>();


        public bool AddDoctor(IDoctor user)
        {
            users.Add(user);
            return true;
        }
        public bool AddPatient(IPatient patient)
        {
            patients.Add(patient);
            return true;
        }
        public bool RemoveDoctor(String ID)
        {
            foreach (IDoctor user in users)
            {
                if (user.ID == ID)
                {
                    users.Remove(user);
                    return true;
                }
                    

            }
            return false;
        }
        public bool RemovePatient(string ID)
        { 
            foreach(IPatient user in patients)
            {
                if (user.patientId == ID)
                {
                    patients.Remove(user);
                    return true;
                }
            }
            return false;
        }

        public IDoctor ViewDoctor(String ID)
        {
            foreach (IDoctor user in users)
            {
                if (user.ID == ID)
                    return user;
            }
            return null;
        }
        public IPatient ViewPatient(string PatientID)
        {
            foreach(IPatient user in patients)
            {
                if(user.patientId == PatientID)
                {
                    return user;
                }
            }
            return null;
        }

        public IDoctor DoctorLogin(string ID, string password)
        {

            foreach(IDoctor doc in users)
            {
                    
                if (doc.ID == ID && doc.password == password)
                {
                    return doc;
                }

            }
            return null;
        }
        public IPatient PatientLogin(string patientID, string password)
        {
            foreach( IPatient user in patients)
            {
                if(user.patientId == patientID && user.password == password)
                {
                    return user;
                }
            }
            return null;
        }

    }
}
 