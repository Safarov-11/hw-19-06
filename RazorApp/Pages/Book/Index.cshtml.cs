
using Domain.Entites;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages.Book;

public class Index(IBookService bkServ) : PageModel
{
    public List<Domain.Entites.Book> Books { get; set; } = [];
    public async Task<IActionResult> OnGetAsync()
    {
        var books = await bkServ.GetBooksAsync();
        if (books.Data == null)
        {
            return NotFound();
        }
        Books = books.Data!;
        return Page();

    }
}
