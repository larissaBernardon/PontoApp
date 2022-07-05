using System.ComponentModel.DataAnnotations;


namespace PontoApp.Models
{
    public class PunchTheClock
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Nome do funcionário")]
        public string? username { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Hora de entrada")]
        public DateTime? startedIn { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Hora de saída")]
        public DateTime? finishedIn { get; set; }
    }
}