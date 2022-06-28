using System;
using System.ComponentModel.DataAnnotations;

namespace PontoApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "RG")]
        public string? Rg { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Empresa")]
        public string? Empresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }
    }
}

