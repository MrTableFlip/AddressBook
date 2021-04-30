using AddressBook.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Display(Name ="Category")]
        public int CatId { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public States State { get; set; }

        [Display(Name ="Zip Code")]
        public string ZipCode { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Home Phone")]
        public string HomePhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Work Phone")]
        public string WorkPhone { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public byte[] ProfilePic { get; set; }
        public string ContentType { get; set; }

        public Category Category { get; set; }
    }
}
