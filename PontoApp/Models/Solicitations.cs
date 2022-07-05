using System;
using System.ComponentModel.DataAnnotations;

namespace PontoApp.Models
{
    public class Solicitations
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Título da solicitação")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Descrição da solicitação")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Hora e data de criação da solicitação")]
        public DateTime? createdAt { get; set; }
    }
}