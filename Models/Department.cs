using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Department
    {
        public int No {  get; set; }

        public string Employees {  get; set; }

        public int EmployeesLimit { get; set; }

        Employee[] Employee = new Employee[] { };



        public Department()
        {
            No++;
        }
        public void AddEmployee(Employee employee)
        {
            Array.Resize( ref Employee, Employee.Length +1 );
            Employee[Employee.Length -1] = employee;

        }
        public Employee GetEmployee(int id)
        {
            Employee searchForId = null;
            for (int i = 0; i < Employee.Length; i++)
            {
                if (Employee[i].Id == id)
                {
                    searchForId = Employee[i];
                }
            }
            return searchForId;
        }
        public void GetEmployeeInfo(Employee employee)
        {
            Console.WriteLine($"{employee.Name}\n{employee.Surname}\n{employee.Age} \n{ employee.DepartmentNo}\n {employee.Salary}");
        }
        public string GetAllEmployees(Employee employee)
        {
            return $"{employee.Name}\n{employee.Surname}\n{employee.Age} \n{employee.DepartmentNo}\n {employee.Salary}";

        }
         public Employee[] GetAllEMployeesBySalary( int minSalary, int maxSalary)
         {
            Employee[] newEmployee = new Employee[] { };
            for(int i = 0; i < Employee.Length; i++)
            {
              if (Employee[i].Salary >= minSalary && Employee[i].Salary  <= maxSalary)
              {
                    Array.Resize(ref Employee, Employee.Length + 1);
                    Employee[Employee.Length-1] = Employee[i];
              }
            }
            return Employee;
         }


    }

}

   
      
   





