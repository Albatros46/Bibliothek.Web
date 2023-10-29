using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek.Entities
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? WebSite { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public string? Adress { get; set; }
        public bool IsActive { get; set; }

        public int BookId { get; set; }
        public List<Book> Books { get; set; }//Bir yayin evi birden fazla kitap basabilir. One To Many
    }
}
