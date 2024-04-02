using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Employee
    {
      
        public string Name;
        public string Surname;
        public byte Age;
        public int DepartmentNo;
        private double _salary;
        public int Id;
        public double Salary 
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
            
        }     

        public Employee()
        {
            Id++;

        }


        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}\n" + $"Surname:{Surname}" + $"Age:{Age}" + $"DepartmentNo:{DepartmentNo}" + $"Salary:{Salary}");
        }

        
        
       

    }
}
