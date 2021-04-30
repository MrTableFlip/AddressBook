using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name="Category")]
        public int CatId { get; set; }

        public string Name { get; set; }
        public byte[] CatPic { get; set; }
        public string ContentType { get; set; }
        public ICollection<Contact> Contacts{ get; set; } = new HashSet<Contact>();
    }
}
