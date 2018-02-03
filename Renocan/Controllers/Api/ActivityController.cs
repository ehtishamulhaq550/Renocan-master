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
    public class ActivityController : ApiController
    {
        public class BookmarkController : ApiController
        {
            private Renocan_DbContext context;

            public BookmarkController()
            {
                context = new Renocan_DbContext();
            }

            public IEnumerable<ActivityDto> Get()
            {
                return context.Activities.ToList().Select(Mapper.Map<Activity, ActivityDto>);
            }

            public ActivityDto GetActivity(int id)
            {
                var a = context.Activities.SingleOrDefault(c => c.Activity_ID == id);
                if (a == null)
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                return Mapper.Map<Activity,ActivityDto>(a);

            }


            [HttpPost]
            public ActivityDto CreateActivity(ActivityDto a)
            {
                if (!ModelState.IsValid)
                    throw new HttpResponseException(HttpStatusCode.BadRequest);

                var abc = Mapper.Map<ActivityDto, Activity>(a);
                context.Activities.Add(abc);
                context.SaveChanges();
                return a;
            }

            [HttpPut]
            public void UpdateActivity(int id, ActivityDto activityDto)
            {
                if (!ModelState.IsValid)
                    throw new HttpResponseException(HttpStatusCode.BadRequest);

                var admin = context.Activities.SingleOrDefault(c => c.Activity_ID == id);
                if (admin == null)
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                Mapper.Map(activityDto, admin);
                context.SaveChanges();

            }

        }

    }
}
