using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Fullname { get { return this.FirstName + " " + this.LastName; } }
        public string? About { get; set; }

        public int BookId { get; set; }
        public List<Book> Books { get; set; }= new List<Book>();//Bir yazar birden cok kitap yazabilir. Bu yüzden One To Many 
    }
}
