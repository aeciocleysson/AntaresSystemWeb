namespace Domain.Models
{
    public class Funcionario : BaseModel
    {
        public string Nome { get; private set; }
        public long Matricula { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int CargoId { get; private set; }
        public Cargo Funcao { get; set; }
    }
}