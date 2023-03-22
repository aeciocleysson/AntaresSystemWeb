namespace Domain.Models
{
    public class Ponto : BaseModel
    {
        public int FuncionarioId { get; private set; }
        public long Matricula { get; private set; }
        public TimeSpan Entrada { get; private set; }
        public TimeSpan SaidaIntervalo { get; private set; }
        public TimeSpan RetornoIntervalo { get; private set; }
        public TimeSpan TotalIntervalo { get; private set; }
        public TimeSpan Saida { get; private set; }
        public TimeSpan TotalTrabalhado { get; private set; }
        public double Minutos { get; private set; }
        public int LogPontoId { get; private set; }
        public LogPonto LogPonto { get; set; } = new LogPonto();
        public virtual Funcionario Funcionario { get; private set; } = new Funcionario();
    }
}
