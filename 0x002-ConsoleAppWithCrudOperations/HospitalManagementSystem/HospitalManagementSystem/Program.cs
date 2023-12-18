using HospitalManagementSystem.ConsoleUi;
using HospitalManagementSystem.Data;
Console.WriteLine(DateTime.Now);
ConsoleUiController ui=new ();
DataContext context = new();

ui.userInterface(context);
