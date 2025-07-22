using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class ContactInfoOutModel
    {
        public string EmailType { get; set; }
        public string Email { get; set; }
        public string PhoneType { get; set; }
        public string MainPhone { get; set; }
        public string PhoneExtension { get; set; }
    }
}
