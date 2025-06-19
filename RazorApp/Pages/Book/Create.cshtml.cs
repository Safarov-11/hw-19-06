
using Domain.Entites;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages.Book;

public class Create(IBookService bkServ) : PageModel
{
    [BindProperty] public Domain.Entites.Book Book { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        Book.PublishedDate = DateTime.SpecifyKind(Book.PublishedDate, DateTimeKind.Utc);

        var response = await bkServ.AddBookAsync(Book);
        if (!response.IsSuccess)
        {
            return Page();
        }
        return RedirectToPage("index");
    }
}
