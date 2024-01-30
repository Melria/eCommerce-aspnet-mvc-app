using System.ComponentModel.DataAnnotations;

namespace aTickets.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }

        public string ProfilePicUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
