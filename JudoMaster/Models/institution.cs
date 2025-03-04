namespace JudoMaster.Models
{
    public class Institution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public List<Athlete> Atletas { get; set; } = new List<Athlete>();
    }
}