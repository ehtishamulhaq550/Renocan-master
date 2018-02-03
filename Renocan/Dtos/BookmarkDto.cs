using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renocan.Dtos
{
    public class BookmarkDto
    {
        public int Bookmark_ID { get; set; }
        [Required]
        public Nullable<int> User_ID { get; set; }
        [Required]
        public Nullable<int> User_TypeId { get; set; }
        [Required]
        public Nullable<int> Company_ID { get; set; }

    }
}