using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ResumeTemplater.Pages
{
    public class IndexModel : PageModel
    {
        public string FullName { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Languages { get; set; }

        public void OnGet()
        {
            FullName = "Kaiser EkSha";
            LinkedInUsername = "vcuaya";
            YearsOfExperience = 4;
            Languages = new List<string> {
                "C",
                "C++",
                "Java",
                "C#"
            };
        }
    }
}
