using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages.Book;

public class Edit(IBookService bkServ) : PageModel
{
    [BindProperty] public Domain.Entites.Book Book { get; set; }
    public async Task<IActionResult> OnGetAsync(int id)
    {
        var book = await bkServ.GetBookAsync(id);
        if (book == null)
        {
            return NotFound();
        }

        Book = book.Data!;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        Book.PublishedDate = DateTime.SpecifyKind(Book.PublishedDate, DateTimeKind.Utc);
        var response = await bkServ.UpdateBookAsync(Book);

        if (!response.IsSuccess)
        {
            return Page();
        }
        return RedirectToPage("Index");
    }
}
