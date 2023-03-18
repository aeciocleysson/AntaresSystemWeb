using Domain.Models;

namespace Domain.ViewModel
{
    public class FuncionarioViewModel : BaseViewModel
    {
        public string Nome { get; set; }
        public long Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
    }
}