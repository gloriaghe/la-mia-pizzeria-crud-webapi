using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo mail è obbligatorio")]
        [EmailAddress(ErrorMessage = "La mail deve avere un formato corretto")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Il campo nome è obbligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo titolo è obbligatorio")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Il campo testo è obbligatorio")]
        public string Text { get; set; }
    }

}
