using System.ComponentModel.DataAnnotations;

namespace JudoMaster.Models
{
    public class Institution
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "La ubicación es obligatoria")]
        public string Country { get; set; }
        public string City { get; set; }
        public List<Athlete> Atletas { get; set; } = new List<Athlete>();
    }
}