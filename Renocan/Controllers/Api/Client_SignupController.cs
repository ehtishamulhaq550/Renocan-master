using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Renocan.Models;
using Renocan.Dtos;
using System.Web.Http;
using System.Net;
using AutoMapper;

namespace Renocan.Controllers.Api
{
    public class ClientSignupController : Controller
    {
        // GET: Client_Signup
        public ActionResult Index()
        {
            return View();
        }


        private Renocan_DbContext context;

        public ClientSignupController()
        {
            context = new Renocan_DbContext();
        }

        // [System.Web.Http.HttpPost]
        public Client_SignupDto POST(Client_SignupDto clientSignUpDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var clientSignUp = Mapper.Map<Client_SignupDto, Client_Signup>(clientSignUpDto);
            context.Client_Signup.Add(clientSignUp);
            context.SaveChanges();
            return clientSignUpDto;
        }

        public IEnumerable<Client_SignupDto> GET()
        {
            return context.Client_Signup.ToList().Select(Mapper.Map<Client_Signup, Client_SignupDto>);
        }

    }
}