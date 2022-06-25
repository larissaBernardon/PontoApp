using System;
namespace PontoApp.Models
{
	public class Announcements
	{
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Subtitle { get; set; }

        public DateTime? createdAt { get; set; }
    }
}

