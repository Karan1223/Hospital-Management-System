using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Admin HospitalAdmin = new Admin();
            int mainMenuChoice = 0;
            do
            {   
                //
                Console.WriteLine("Main Menu");
                Console.WriteLine("1.Admin Menu");
                Console.WriteLine("2.Front Desk");
                Console.WriteLine("3.Doctor Login");
                Console.WriteLine("4.Patient Login");
                Console.WriteLine("0.To Exit");

                mainMenuChoice = Int32.Parse(Console.ReadLine());

                if (mainMenuChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("ADMIN LOGIN");
                    int adminChoice = 0;
                    do 
                    {
                        //
                        Console.WriteLine("1.Add Doctor");
                        Console.WriteLine("2.Remove Doctor");
                        Console.WriteLine("3.Add Patient");
                        Console.WriteLine("4.Remove Patient");
                        Console.WriteLine("5.Go back to main menu");
                        adminChoice = Int32.Parse(Console.ReadLine());

                        if (adminChoice == 1)
                        {
                            Console.WriteLine("Enter Doctor ID");
                            string DoctorID = Console.ReadLine();
                            Console.WriteLine("Enter Doctor Name");
                            string DocName = Console.ReadLine();
                            Console.WriteLine("Enter Doctor Password");
                            string password = Console.ReadLine();

                            Doctor doc = new Doctor();
                            doc.ID = DoctorID;
                            doc.name = DocName;
                            doc.password = password;
                            if (HospitalAdmin.AddDoctor(doc)) Console.WriteLine("Doctor added successfully");
                            else Console.WriteLine("Some error occured");
                            
                        }
                        if (adminChoice == 2)
                        {
                            Console.WriteLine("Enter the Doctor ID");
                            string DocID = Console.ReadLine();

                            if(HospitalAdmin.RemoveDoctor(DocID))
                            {
                                Console.WriteLine("Doctor " + DocID + " has been removed succesfully");
                            }
                            else Console.WriteLine("No such doctor found");
                        
                        }
                        if (adminChoice == 3)
                        {
                            Console.WriteLine("Enter patient name");
                            string patientName = Console.ReadLine();
                            Console.WriteLine("Enter Patient ID");
                            string patientID = Console.ReadLine();
                            Console.WriteLine("Enter patient password");
                            string password = Console.ReadLine();

                            Patient patient = new Patient();
                            patient.patientId = patientID;
                            patient.patientName = patientName;
                            patient.password = password;
                            if (HospitalAdmin.AddPatient(patient)) Console.WriteLine("Patient registration complete");
                            else Console.WriteLine("Some Error occured");

                        }
                        if (adminChoice == 4)
                        {
                            Console.WriteLine("Enter patient ID");
                            string patientID = Console.ReadLine();
                            if (HospitalAdmin.RemovePatient(patientID)) Console.WriteLine("Patient Removed successfully");
                            else Console.WriteLine("No such patient found");
                        }
                        if (adminChoice == 5)
                        {
                            break;
                        }
                        
                    } while (adminChoice != 0);
                }
                if (mainMenuChoice == 2)
                {
                   // Console.Clear();
                    Console.WriteLine("Front Desk");
                    int nurseChoice = 0;
                    Nurse nurse = new Nurse();
                    do 
                    {
                       
                        Console.WriteLine("1.Add Appointments");
                        Console.WriteLine("2.View Appointments");
                        Console.WriteLine("4.Go back");

                        nurseChoice = Int32.Parse(Console.ReadLine());

                        if (nurseChoice == 1)
                        {
                            Console.WriteLine("Enter Doctor ID");
                            string DoctorID = Console.ReadLine();
                            Console.WriteLine("Enter Appointment Time");
                            string AppointmentTime = Console.ReadLine();

                            

                            Console.WriteLine("Enter patient ID");
                            string patientID = Console.ReadLine();

                            Console.WriteLine("Enter disease details");
                            string disease = Console.ReadLine();


                            //Patient newPatient = new Patient(patientName, patientID, disease);
                            IPatient newPatient = HospitalAdmin.ViewPatient(patientID);
                            newPatient.disease = disease;

                           if (nurse.setAppointment(DoctorID, AppointmentTime, newPatient))
                           {
                                Console.WriteLine("Appointment set successfully");
                           }
                            
                        }
                        if (nurseChoice == 2)
                        { 
                            foreach(Appointment app in nurse.getAllAppointments())
                            {
                               

                                Console.WriteLine(app.ToString());
                            }
                            
                        }


                        if (nurseChoice == 4)
                        {
                            break;
                        }
                    } while (nurseChoice != 0);
                }
                if (mainMenuChoice == 3)
                {
                   // Console.Clear();
                    Console.WriteLine("Doctor Login");
                    int doctorChoice = 0;
                    Console.WriteLine("Enter ID");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();
                    IDoctor doc = HospitalAdmin.DoctorLogin(email, password);
                    if (doc != null)
                    {
                        do
                        {
                            
                            Console.WriteLine("1.View appointments");
                            Console.WriteLine("2.Add prescription");
                            Console.WriteLine("3.Go Back");

                            doctorChoice = Int32.Parse(Console.ReadLine());

                            if (doctorChoice == 1)
                            {

                                foreach(Appointment app in doc.getDoctorAppointments())
                                {
                                    app.ToString();
                                }
                            }
                            if (doctorChoice == 2)

                            {
                                Console.WriteLine("Enter the patient id: ");
                                string patientName = Console.ReadLine();
                                IPatient patient = HospitalAdmin.ViewPatient(patientName);
                                if (patient != null)
                                {
                                    Console.WriteLine(patient.ToString());
                                    Console.WriteLine("Enter prescription");
                                    string prescription = Console.ReadLine();
                                    patient.prescription = prescription;
                                    Console.WriteLine("Prescription added for patient");
                                }
                                else
                                {
                                    Console.WriteLine("No such Patient found");
                                }

                            }

                            if (doctorChoice == 3)

                            {
                                break;
                            }
                        } while (doctorChoice != 0);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Username or Password");
                        
                    }


                    
                }
                if (mainMenuChoice == 4)
                { 
                    Console.WriteLine("Patient login");
                    int patientChoice = 0;
                    Console.WriteLine("Enter ID");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();

                    IPatient patient = HospitalAdmin.PatientLogin(email, password);
                    if (patient != null)
                    {
                        do
                        {
                           // Console.Clear();
                            Console.WriteLine("1.View prescription");
                            Console.WriteLine("2.Go back");

                            patientChoice = Int32.Parse(Console.ReadLine());

                            if (patientChoice == 1)
                            {
                                Console.WriteLine(patient.ToString());
                            }
                            if (patientChoice == 2)
                            {
                                break;
                            }
                        } while (patientChoice != 0);
                    }
                    else Console.WriteLine("Login info not found");
                    
                }

            } while (mainMenuChoice != 0);
            
        }
    }
}
