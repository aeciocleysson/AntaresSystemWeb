namespace Domain.Models
{
    public class Funcionario : BaseModel
    {
        public string Nome { get; private set; }
        public string Matricula { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int CargoId { get; private set; }
        public virtual Cargo Cargo { get; private set; }

        public Funcionario() { }

        public Funcionario(string nome, string matricula, DateTime dataNascimento, int cargoId, string userInserted)
        {
            Nome = nome;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            CargoId = cargoId;
            UserInserted = userInserted;
        }

        public void Update(int id, string nome, DateTime dataNascimento, int cargoId, string userAlteration)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            CargoId = cargoId;
            UserAlteration = userAlteration;
            UpdateAt = DateTime.Now;
        }
    }
}