using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Renocan.Models;
using Renocan.Dtos;

namespace Renocan.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Client_Signup, Client_SignupDto>();

            CreateMap<Client_SignupDto, Client_Signup>().ForMember(m => m.Client_ID, opt => opt.Ignore());

            CreateMap<Admin_Signup, Admin_SignupDto>();

            CreateMap<Admin_SignupDto, Admin_Signup>().ForMember(m => m.Admin_ID, opt => opt.Ignore());

            CreateMap<Bookmark, BookmarkDto>();

            CreateMap<BookmarkDto, Bookmark>().ForMember(m => m.Bookmark_ID, opt => opt.Ignore());




            CreateMap<Company_Service_Location, Company_Service_LocationDto>();

            CreateMap<Company_Service_LocationDto, Company_Service_Location>().ForMember(m => m.Company_Service_Location_Id, opt => opt.Ignore());

            CreateMap<Image_Gallary, Image_GalleryDto>();

            CreateMap<Image_GalleryDto, Image_Gallary>().ForMember(m => m.Image_ID, opt => opt.Ignore());

        }
    }
}