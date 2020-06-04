using ProjectWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectWebApi.Controllers
{
    public class ClientsController : ApiController
    {
        private static List<Client> clients = new List<Client>();

        public List<Client> Get()
        {
            return clients;
        }

        public void Post(String name)
        {
            if(!string.IsNullOrEmpty(name))
                clients.Add(new Client(name));
        }

        public void Delete(String name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                clients.RemoveAt(clients.IndexOf(clients.First(x =>
                x.Name.Equals(name)
                )));
            }
        }
    }
}
