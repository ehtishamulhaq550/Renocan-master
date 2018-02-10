using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renocan.Dtos
{
    public class Image_GalleryDto
    {
        public int Image_ID { get; set; }

        [Required]
        public string Image_Name { get; set; }

        [Required]

        public string Image_Path { get; set; }

        [Required]

        public Nullable<int> User_ID { get; set; }

        [Required]

        public Nullable<int> Image_Type_ID { get; set; }

        [Required]

        public Nullable<int> User_Typeid { get; set; }
        
    }
}