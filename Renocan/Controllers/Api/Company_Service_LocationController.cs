using AutoMapper;
using Renocan.Dtos;
using Renocan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Renocan.Controllers.Api
{
    public class Company_Service_LocationController : ApiController
    {


        private Renocan_DbContext context;

        public Company_Service_LocationController()
        {
            context = new Renocan_DbContext();
        }

        public IEnumerable<Company_Service_LocationDto> Get()
        {
            return context.Company_Service_Location.ToList().Select(Mapper.Map<Company_Service_Location, Company_Service_LocationDto>);
        }

        public BookmarkDto GetCompany_Service_Location(int id)
        {
            var a = context.Company_Service_Location.SingleOrDefault(c => c.Company_Service_Location_Id == id);
            if (a == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Company_Service_Location,Company_Service_LocationDto>(a);


        }


        [HttpPost]
        public Company_Service_LocationDto CreateCompany_Service_Location(Company_Service_LocationDto a)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var abc = Mapper.Map<Company_Service_LocationDto, Company_Service_Location>(a);
            context.Company_Service_Location.Add(abc);
            context.SaveChanges();
            return a;
        }

        [HttpPut]
        public void UpdateCompany_Service_Location(int id, Company_Service_LocationDto company_Service_LocationDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var admin = context.Company_Service_Location.SingleOrDefault(c => c.Company_Service_Location_Id == id);
            if (admin == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(Company_Service_LocationDto, admin);
            context.SaveChanges();

        }

    }
}
