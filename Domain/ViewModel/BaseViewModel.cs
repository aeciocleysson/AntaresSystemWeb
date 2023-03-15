namespace Domain.ViewModel
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public DateTime Inserted { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsAtivo { get; set; }
        public bool IsDeleted { get; set; }
        public string UserInserted { get; set; }
        public string UserAlteration { get; set; }
        public DateTime Deleted { get; set; }
    }
}