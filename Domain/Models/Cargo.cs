namespace Domain.Models
{
    public class Cargo : BaseModel
    {
        public Cargo(string descricao)
        {
            Descricao = descricao;
        }

        public Cargo()
        {

        }
        public string Descricao { get; private set; }

        public void Update(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            UpdateAt = DateTime.Now;
        }
    }
}