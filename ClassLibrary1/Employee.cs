using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Models
{
     public class Employee
     {
          private string Name { get; set; }
          private string SSN { get; set; }
          private double Experience { get; set; }
          private double Wage { get; set; }
          private bool[,] DayAvailability { get; set; }
          private int MinimumShifts { get; set; }
          private int MaximumShifts { get; set; }
          private int AssignedShifts { get; set; }
         //name, ssn, exp, availability, wage, min, max
          public Employee(string name, string ssn, double exp, bool[,] availability, double wage, int min, int max)
          {//bool[,] availability
               Name = name;
               SSN = ssn;
               Experience = exp;
               Wage = wage;
               DayAvailability = availability;
               MinimumShifts = min;
               MaximumShifts = max;
               AssignedShifts = 0;
               //Employee y = new Employee("miles", "124432", 1.0, 20.0, 1, 1);
          }
          public Employee()
          {
              Name = "0";
              SSN = "0";
              Experience = 0;
              Wage = 0;
              //DayAvailability = availability;
              MinimumShifts = 0;
              MaximumShifts = 0;
              AssignedShifts = 0;
          }
     }
}
