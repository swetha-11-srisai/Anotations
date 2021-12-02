using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Anotations
{
    class AnotationTest
    {
        public void Display()
        {
            Console.WriteLine("employee validation");
            Console.WriteLine(".......................");
            Employee employeeobj = new Employee();
            employeeobj.Name = null;
            employeeobj.Age = 18;
            employeeobj.PhoneNumber = "7545698241";
            ValidationContext context = new ValidationContext(employeeobj, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employeeobj, context, results, true);
            if (valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Member Name:{0}", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Message:{0}{1}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name:" + employeeobj.Name + "\n" + "Age:" + employeeobj.Age + "\n" + "PhoneNumber:" + employeeobj.PhoneNumber);
            }
        }
    }
}
