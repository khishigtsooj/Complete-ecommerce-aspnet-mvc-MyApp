using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace MovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture Url")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name ="Full Name")]
        public string Fullname { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        //Relationships
        public List<Actor_Movie>Actors_Movies { get; set; }
    }
}
