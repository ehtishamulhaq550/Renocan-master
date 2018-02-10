using AutoMapper;
using Renocan.Dtos;
using Renocan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Renocan.Controllers
{
    public class Client_SignupController : ApiController
    {
        private Renocan_DbContext context;

        public Client_SignupController()
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
        

        


        public void UpdateCustomer(int id,Client_SignupDto client_SignupDto)
        {
            if (ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = context.Client_Signup.SingleOrDefault(c => c.Client_ID == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(client_SignupDto, customerInDb);
            context.SaveChanges();


        }
    }
}
