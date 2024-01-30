﻿using System.ComponentModel.DataAnnotations;

namespace aTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePicUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
