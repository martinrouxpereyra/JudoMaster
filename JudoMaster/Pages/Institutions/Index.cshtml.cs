using JudoMaster.Models;
using JudoMaster.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JudoMaster.Pages.Institutions
{
    public class IndexModel : PageModel
    {
        private readonly InstitutionService _institutionService;

        public IndexModel(InstitutionService institutionService)
        {
            _institutionService = institutionService;
        }

        public List<Institution> Institutions { get; set; }

        public void OnGet()
        {
            Institutions = _institutionService.GetAll();
        }
    }
}