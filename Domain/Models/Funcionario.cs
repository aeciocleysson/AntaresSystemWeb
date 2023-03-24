namespace Domain.Models
{
    public class Funcionario : BaseModel
    {
        public string Nome { get; private set; }
        public long Matricula { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int CargoId { get; private set; }
        public virtual Cargo Cargo { get; private set; } 

        public Funcionario() { }

        public Funcionario(string nome, long matricula, DateTime dataNascimento, int cargoId)
        {
            Nome = nome;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            CargoId = cargoId;
        }

        public void Update(int id,string nome, DateTime dataNascimento, int cargoId)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            CargoId = cargoId;
        }
    }
}