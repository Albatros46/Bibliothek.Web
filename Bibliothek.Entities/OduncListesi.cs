using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek.Entities
{
    public class OduncListesi
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public List<User> User { get; set; } = new List<User>();

        public int BookId { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public string? Status { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndetDate { get; set; }
    }
}
