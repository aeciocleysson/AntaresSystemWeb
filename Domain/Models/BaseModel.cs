using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime Inserted { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsAtivo { get; set; }
        public bool IsDeleted { get; set; }
        public string UserInserted { get; set; }
        public string UserAlteration { get; set; }
        public DateTime Deleted { get; set; }

        public BaseModel()
        {
            Inserted = DateTime.UtcNow;
            IsAtivo = true;
            IsDeleted = false;
        }

        public void Delete()
        {
            Deleted = DateTime.Now;
            IsDeleted = true;
            IsAtivo = false;
        }
    }
}