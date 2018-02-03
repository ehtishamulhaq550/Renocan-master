using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renocan.Dtos
{
    public class ActivityDto
    {
        public int Activity_ID { get; set; }

        [Required]
        public Nullable<System.DateTime> Activity_Date { get; set; }

        [Required]
        public string Reviews_Commented { get; set; }

        [Required]
        public Nullable<int> Ratings { get; set; }

        [Required]
        public Nullable<int> Company_ID { get; set; }

        [Required]
        public Nullable<int> Targeted_Company { get; set; }
    }
}