using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MembershipRequest
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required, StringLength(50)]
        public string Forename { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAdress { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


    }
}
