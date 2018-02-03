//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Renocan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client_Signup
    {
        public int Client_ID { get; set; }

        [Required]
        public string Full_Name { get; set; }

        [Required]
        public string First_Name { get; set; }

        [Required]
        public string Last_Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string IsNewsletter { get; set; }

       
        public string Creation_By { get; set; }


        public Nullable<System.DateTime> Creation_Date { get; set; }

     
        public string Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_Date { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public byte[] Ip { get; set; }
    }
}
