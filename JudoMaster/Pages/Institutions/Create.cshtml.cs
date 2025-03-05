using JudoMaster.Models;
using JudoMaster.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JudoMaster.Pages.Institutions
{
    public class CreateModel : PageModel
    {
        private readonly InstitutionService _institucionService;

        public CreateModel(InstitutionService institucionService)
        {
            _institucionService = institucionService;
        }

        [BindProperty]
        public Institution Institution { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _institucionService.Create(Institution);
            return RedirectToPage("Index");
        }
    }
}