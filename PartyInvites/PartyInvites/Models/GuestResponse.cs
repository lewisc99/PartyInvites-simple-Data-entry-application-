
using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    //This class represent the Model that the user have to fill, and we see that there are expressions where the user has to follow to the form be submited.
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="please enter your email adress")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage ="please enter a valid email addres")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }

    }
}
