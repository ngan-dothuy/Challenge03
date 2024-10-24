using Challenge03.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Category.Pages
{
    public class CategoryModel : PageModel
    {
        public required List<CategoryDto> Categories { get; set; }
        public void OnGet()
        {
            Categories = new List<CategoryDto> {
                new (1, "Kids and Family"),
                new (2, "Eco-Friendly Living"),
                new (3, "Smart Home Technology")
            };
            
            
        }
    }
}
