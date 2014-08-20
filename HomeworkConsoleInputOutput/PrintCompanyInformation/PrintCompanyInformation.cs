using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the company");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter the address of the company");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Enter the phone number of the company");
            string companyPhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the fax number of the company.Press enter if irrelevant");
            string companyFaxNumber = Console.ReadLine();
            Console.WriteLine("Enter the website of the company");
            string companyWebSite = Console.ReadLine();
            Console.WriteLine("Enter the first name of the company's manager");
            string companyManagerFirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of the company's manager");
            string companyManagerLastName = Console.ReadLine();
            Console.WriteLine("Enter the age of the company's manager");
            int companyManagerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the phone number of the company's manager");
            string companyManagerPhone = Console.ReadLine();
            if (companyFaxNumber==null)
            {
                companyFaxNumber = "(no fax)";
            }
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}",companyAddress);
            Console.WriteLine("Tel. {0}",companyPhoneNumber);
            Console.WriteLine("Fax: {0}",companyFaxNumber);
            Console.WriteLine("Web Site: {0}",companyWebSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3}",companyManagerFirstName,companyManagerLastName,companyManagerAge,companyManagerPhone);
        }
    }
}
