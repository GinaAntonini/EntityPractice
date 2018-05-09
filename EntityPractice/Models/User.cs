using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityPractice.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime? Birthdate { get; set; }
    }
}