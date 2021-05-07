using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain.Entities
{
   public class ContactTable
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }

    }
}
