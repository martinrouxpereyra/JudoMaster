using JudoMaster.Data;
using JudoMaster.Models;

namespace JudoMaster.Services
{
    public class InstitutionService
    {
        private readonly JudoContext _context;

        public InstitutionService(JudoContext context)
        {
            _context = context;
        }

        public void Create(Institution institution)
        {
            _context.Institutions.Add(institution);
            _context.SaveChanges();
        }

        public List<Institution> GetAll()
        {
            return _context.Institutions.ToList();
        }
    }
}