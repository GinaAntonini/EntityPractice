using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityPractice.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UpdatedAt { get; set; }
    }
}