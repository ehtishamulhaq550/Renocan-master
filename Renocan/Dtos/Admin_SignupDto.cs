using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renocan.Dtos
{
    public class Admin_SignupDto
    {
        public int Admin_ID { get; set; }


        [Required]
        public string Admin_Name { get; set; }
       

        [Required]
         public string Admin_Designation { get; set; }


        [Required]
        public Nullable<int> Admin_Employee_ID { get; set; }


        [Required]
        public string Admin_Contact_Number { get; set; }


        [Required]
        public string Admin_Address { get; set; }


        [Required]
        public Nullable<int> User_CategoryId { get; set; }


        [Required]
        public string Admin_Password { get; set; }
    }
}