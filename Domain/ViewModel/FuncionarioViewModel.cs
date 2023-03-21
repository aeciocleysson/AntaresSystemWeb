using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Domain.ViewModel
{
    public class FuncionarioViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "Nome deve ter no minimo 3 caracteres.")]
        [MaxLength(40, ErrorMessage = "Nome deve ter no maximo 40 caracteres.")]
        public string Nome { get; set; }
        public long Matricula { get; set; }
        public DateTime DataNascimento { get; set; } = DateTime.Now;
        public int CargoId { get; set; }
        public string Cargo { get; set; }
    }
}