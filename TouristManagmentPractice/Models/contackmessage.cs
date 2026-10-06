using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouristManagmentPractice.Models
{
    public class contackmessage
    {
        public int Id { get; set; }
         public string fullname { get; set; }

        public string emailaddress { get; set; }

        public string mobilenumber { get; set; }

        public string subject { get; set; }

        public string yourmessage { get; set; }

    }

}