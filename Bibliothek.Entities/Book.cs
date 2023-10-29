using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Der Buchtitel darf kein leeres Feld sein!")]
        public string? Title { get; set; }
        public string? Status { get; set; }
        public int PageCount { get; set; }
        public string? ImgUrl { get; set; }
        public string? About { get; set; }
        public bool IsActived { get; set; }

        public DateTime PublishedDate { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
    //enum Status{
    //    Yeni, Kullanilmis
    //}
}
