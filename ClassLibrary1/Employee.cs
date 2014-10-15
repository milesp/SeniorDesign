using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     class Employee
     {
          public string Name { get; set; }
          public string SSN { get; set; }
          public double Experience { get; set; }
          public double Wage { get; set; }
          public bool[,] DayAvailability { get; set; }
          public int MinimumShifts { get; set; }
          public int MaximumShifts { get; set; }
          public int AssignedShifts { get; set; }
          public Employee(string name, string ssn, double exp, double wage, bool[,] availability, int min, int max)
          {
               Name = name;
               SSN = ssn;
               Experience = exp;
               Wage = wage;
               DayAvailability = availability;
               MinimumShifts = min;
               MaximumShifts = max;
               AssignedShifts = 0;
          }
     }
}
