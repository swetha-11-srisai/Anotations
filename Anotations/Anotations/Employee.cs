using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Anotations
{
    class Employee
    {
         
        [Required(ErrorMessage = "employee {0} is present")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should be minimum 3 characters and maximum 100 character")]
        public string Name { get; set; }
        [Range(18, 99, ErrorMessage = "Age should br above 18")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}

