using HospitalManagementSystem.Data;
using HospitalManagementSystem.Entities;
using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.ConsoleUi
{
    public class ConsoleUiController
    {
        //Appointment appt = new();
        public CrudOperations operations = new();
        public void userInterface(DataContext context)
        {
            do
            {
                Console.WriteLine("\t\t\tHOSPITAL MANAGEMENT SYSTEM");
                Console.WriteLine("\t\t\t_____________________________");
                Console.WriteLine("Select a service based on the number");
                Console.WriteLine("\t\t 1. Book an Appointment");
                Console.WriteLine("\t\t 2. Find A Patient By Name");
                Console.WriteLine("\t\t 3. Find A Patient By Id");
                Console.WriteLine("\t\t 4. See Available Rooms/Wards");
                string? userChoice = Console.ReadLine();
                var validOptions = new List<string>() { "1", "2", "3", "4", };

                try
                {
                    isValidOption(userChoice, validOptions);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }
                
                int.TryParse(userChoice, out int choice);
                redirectUser(choice, context);
            }while(true);
            

        }

        //This is a method that is used to check if the users input is one of the available options
        public  void isValidOption(string option, List<string>? validOptions)
        {
            if (validOptions != null && validOptions.Contains(option))
            {
                   
                    Console.WriteLine("\t---------Fetching your data-----------");
                    
            }
            else
            {
                    throw new Exception("\t-----------INVALID OPTION---------------");
                
            }

        }


        //After we have checked that indeed the users input is one of the available choices
        //we should redirect them according to their choice input number 
        //Thats what this function is intended to accomplish

        public void redirectUser(int choice, DataContext context)
        {
            switch (choice)
            {
                case 1:
                    NewAppointment(context);
                    break;
                default:
                    break;
            }
        }

        public void NewAppointment(DataContext context)
        {
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("\t++++++++++++++++++++++++++++ ");
                Console.WriteLine("\t+ CREATE NEW APPOINTMENT   +");
                Console.WriteLine("\t++++++++++++++++++++++++++++ ");

                Console.WriteLine("Whats your Patient ID");
                string? ptId = Console.ReadLine();
                Console.WriteLine("Enter suitable Date and time for the Appointment");
                Console.WriteLine("Format ----- DD/MM/YYYY HH:MM AM/PM -----");
                string? apptDate = Console.ReadLine();

                //DateTime apptDate = DateTime.Now;

                var inputs = new List<string>() { ptId, apptDate };
                //we might need to try catch later for defense cases
                int.TryParse(ptId, out int id);

                DateTime.TryParse(apptDate, out DateTime date);
                Console.WriteLine(date);


                var appt = new Appointment() { PatientId = id, AppointmentDate = date };
                bool isSuccessful = operations.CreateAppointment(appt, context);
                Console.WriteLine(isSuccessful ? "---- Appointment created successfully ---- \n" : "----- something went wrong ----- \n");
                break;
            } while (true);
        }


    }

       
       


}

