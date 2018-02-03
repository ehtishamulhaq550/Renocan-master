using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renocan.Dtos
{
    public class Company_Service_LocationDto
    {

        public int Company_Service_Location_Id { get; set; }

        [Required]
        public Nullable<int> Company_ID { get; set; }

        [Required]
        public Nullable<int> Location_ID { get; set; }
    }
}