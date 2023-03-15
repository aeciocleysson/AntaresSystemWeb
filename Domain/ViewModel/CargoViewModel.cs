using System.ComponentModel.DataAnnotations;

namespace Domain.ViewModel
{
    public class CargoViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Descrição é obrigatório")]
        [MinLength(4, ErrorMessage = "Descrição deve ter no minimo 4 caracteres.")]
        [MaxLength(30, ErrorMessage = "Descrição deve ter no maximo 30 caracteres.")]
        public string Descricao { get; set; }
    }
}