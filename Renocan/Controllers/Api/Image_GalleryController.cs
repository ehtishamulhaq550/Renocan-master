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
    public class Image_GalleryController : ApiController
    {
        private Renocan_DbContext context;

        public Image_GalleryController()
        {
            context = new Renocan_DbContext();
        }

        public IEnumerable<Image_GalleryDto> Get()
        {
            return context.Image_Gallary.ToList().Select(Mapper.Map<Image_Gallary, Image_GalleryDto>);
        }

        public Image_GalleryDto GetImage_Gallery(int id)
        {
            var a = context.Image_Gallary.SingleOrDefault(c => c.Image_ID == id);
            if (a == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Image_Gallary, Image_GalleryDto>(a);

        }


        [HttpPost]
        public Image_GalleryDto CreateBookmark(Image_GalleryDto a)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var abc = Mapper.Map<Image_GalleryDto, Image_Gallary>(a);
            context.Image_Gallary.Add(abc);
            context.SaveChanges();
            return a;
        }

        [HttpPut]
        public void UpdateImage_Gallery(int id, Image_GalleryDto image_GalleryDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var admin = context.Image_Gallary.SingleOrDefault(c => c.Image_ID == id);
            if (admin == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(image_GalleryDto, admin);
            context.SaveChanges();

        }

    }
}

