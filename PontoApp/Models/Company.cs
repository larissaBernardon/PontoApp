using System.ComponentModel.DataAnnotations;


namespace PontoApp.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "CNPJ")]
        public ulong Cnpj { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Nome da empresa")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Data de fundação")]
        public DateTime creationDate { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Quantidade de funcionários")]
        public int numFuncionarios { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }
    }
}
