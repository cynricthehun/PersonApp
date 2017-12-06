using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PersonWeb.ViewModels
{
    public class Person
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Age")]
        public int Age { get; set; }
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [DisplayName("Birthday")]
        public string Birthday { get; set; }
    }
}