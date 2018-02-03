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
        }
    }
}