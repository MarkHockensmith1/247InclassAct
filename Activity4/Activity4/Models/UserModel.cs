using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity4.Models
{
    public class UserModel
    {
        public UserModel(string Name, string Email, string Phone) { }
  
        public String Name { get; set; }
        public String EmailAdress { get; set; }
        public String PhoneNumber { get; set; }
    }
}