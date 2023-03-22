namespace Domain.Models
{
    public class Funcionario : BaseModel
    {
        public string Nome { get; private set; }
        public long Matricula { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int CargoId { get; private set; }
        public Cargo Cargo { get; private set; } = new Cargo();

        public Funcionario() { }

        public Funcionario(string nome, long matricula, DateTime dataNascimento, int cargoId)
        {
            Nome = nome;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            CargoId = cargoId;
        }

        public void Update(string nome, long matricula, DateTime dataNascimento, int cargoId)
        {
            Nome = nome;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            CargoId = cargoId;
        }
    }
}