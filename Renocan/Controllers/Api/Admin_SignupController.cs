﻿using Renocan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Renocan.Models;

namespace Renocan.Controllers.Api
{
    public class Admin_SignupController : ApiController
    {


        private Renocan_DbContext context;

        public Admin_SignupController()
        {
            context = new Renocan_DbContext();
        }

        public IEnumerable<Admin_SignupDto> Get()
        {
            return context.Admin_Signup.ToList().Select(Mapper.Map<Admin_Signup, Admin_SignupDto>);
        }

        public Admin_SignupDto GetAdmin_Signup(int id)
        {
            var admin = context.Admin_Signup.SingleOrDefault(c => c.Admin_ID == id);
            if (admin == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Admin_Signup,Admin_SignupDto>(admin);

        }


        [HttpPost]
        public Admin_SignupDto CreateAdmin_Signup(Admin_SignupDto adminDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var admin = Mapper.Map<Admin_SignupDto, Admin_Signup>(adminDto);
            context.Admin_Signup.Add(admin);
            context.SaveChanges();
            return adminDto;
        }

        [HttpPut]
        public void UpdateAdmin_Signup(int id, Admin_SignupDto admin_SignupDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var admin = context.Admin_Signup.SingleOrDefault(c => c.Admin_ID == id);
            if (admin == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map<Admin_SignupDto, Admin_Signup>(admin_SignupDto,admin);
            admin.Admin_Name = admin_SignupDto.Admin_Name;
            admin.Admin_Contact_Number = admin_SignupDto.Admin_Contact_Number;
            admin.Admin_Address = admin_SignupDto.Admin_Address;
            admin.Admin_Designation = admin_SignupDto.Admin_Designation;
            admin.Admin_Employee_ID = admin_SignupDto.Admin_Employee_ID;
            admin.Admin_Password = admin_SignupDto.Admin_Password;
            context.SaveChanges();
   
        }


    }
}