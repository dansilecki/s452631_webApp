using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace s452631_webApp.Models
{
    public class UserModel
    {
        public int id { get; set; }
        
        public string name { get; set; }

        public string surname { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime dateOfBirth { get; set; }

        public string login { get; set; }

        public bool isDeleted { get; set; }
    }
}