using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Fullname { get { return this.FirstName + " " + this.LastName; } }
        public string? Email { get; set; } = string.Empty;
        public string? Telefon { get; set; }
        public string? Adress { get; set; }
    }
}
