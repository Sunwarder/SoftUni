using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Velizar";
            string middleName = "Petrov";
            string lastName = "Bishurov";
            object holderName = firstName + " " + middleName + " " + lastName;
            decimal balance=135.658m;
            string bankName = "Societe Generale Expressbank";
            string iban="BG80 BNBG 9661 1020 3456 78";
            long creditCardNumber1 = 5555555555554444;
            long creditCardNumber2 = 378282246310005;
            long creditCardNumber3=4222222222222;
            Console.WriteLine("The user is {0}.The bank they are using is {1} and they have a bank account with iban: {2}",holderName,bankName,iban);
            Console.WriteLine("in which they have {0} balance.The user has three credit card numbers" ,balance);
            Console.WriteLine("associated with their bank account and they are as follows:");
            Console.WriteLine(creditCardNumber1);
            Console.WriteLine(creditCardNumber2);
            Console.WriteLine(creditCardNumber3);
        }
    }
}
