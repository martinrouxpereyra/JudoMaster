namespace JudoMaster.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }
        public string Category { get; set; }
        public string Nationality { get; set; }
    }
}