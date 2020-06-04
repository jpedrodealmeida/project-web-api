using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWebApi.Models
{
    public class Client
    {
        public String Name { get; set; }

        public Client(String name)
        {
            this.Name = name;
        }
    }
}