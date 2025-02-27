using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_6
{
    internal class Company
    {
        public List<Employee> Employees { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
        }

        public string FindEmployeeBySalary(int salary)
        {
            foreach (var employee in Employees)
            {
                if (employee.Salary == salary)
                {
                    return employee.Name; 
                }
            }

            return "Не е намерен"; 
        }
    }
}
