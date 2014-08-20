using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName="Velizar";
            string lastName="Bishurov";
            byte age=20;
            char gender='m';
            long personalIdNumber = 8306112507;
            uint uniqueEmployeeNumber = 27569999;
            Console.WriteLine("The employee is {0} {1}.Their age, gender, personal id number and unique employee number are as follows:{2},{3},{4},{5}",firstName,lastName,age,gender,personalIdNumber,uniqueEmployeeNumber);
        }
    }
}
