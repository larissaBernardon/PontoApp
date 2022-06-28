using System;
using System.ComponentModel.DataAnnotations;

namespace PontoApp.Models
{
	public class Announcements
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Título")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Comunicado")]
        public string? Subtitle { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Hora e data de criação")]
        public DateTime? createdAt { get; set; }
    }
}

