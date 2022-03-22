using BiblioNetAPP.Validation;
using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]
        public string Name_book { get; set; }
        public int Author { get; set; }
        public double Price { get; set; }

    }
}
