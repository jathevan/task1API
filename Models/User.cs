using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task1API.Models
{
    public class User
    {
     /*   public long Id { get; set; }*/
        public string name { get; set; }
        public string phone { get; set; }

        public User(string name, string phone)
        {
            this.name = name;
            this.phone = phone;

        }
    }
}
