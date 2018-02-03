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
    public class BookmarkController : ApiController
    {
        private Renocan_DbContext context;

        public BookmarkController()
        {
            context = new Renocan_DbContext();
        }

        public IEnumerable<BookmarkDto> Get()
        {
            return context.Bookmarks.ToList().Select(Mapper.Map<Bookmark, BookmarkDto>);
        }

        public BookmarkDto GetBookmark(int id)
        {
            var a = context.Bookmarks.SingleOrDefault(c => c.Bookmark_ID == id);
            if (a == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Bookmark, BookmarkDto>(a);

        }


        [HttpPost]
        public BookmarkDto CreateBookmark(BookmarkDto a)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var abc = Mapper.Map<BookmarkDto, Bookmark>(a);
            context.Bookmarks.Add(abc);
            context.SaveChanges();
            return a;
        }

        [HttpPut]
        public void UpdateBookmark(int id, BookmarkDto bookmarkDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var admin = context.Bookmarks.SingleOrDefault(c => c.Bookmark_ID == id);
            if (admin == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(bookmarkDto,admin);
            context.SaveChanges();
        
            }

        }


}
   

