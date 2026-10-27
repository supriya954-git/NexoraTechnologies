using System.ComponentModel.DataAnnotations;

namespace NexoraTechnologies.Models
{
    public class Registration
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string Gender { get; set; }

        public string Organization { get; set; }

        [Required]
        public string Address { get; set; }
    }
}