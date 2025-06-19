using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages.Book;

public class Delete(IBookService bkServ) : PageModel
{
    [BindProperty] public int Id { get; set; }
    public async Task<IActionResult> OnGetAsync(int id)
    {
        var book = await bkServ.GetBookAsync(id);
        if (!book.IsSuccess)
        {
            return NotFound();
        }
        Id = book.Data!.Id;
        return Page();

    }

    public async Task<IActionResult> OnPostAsync()
    {
        var book = await bkServ.DeleteBookAsync(Id);
        if (!book.IsSuccess)
        {
            return Page();
        }
        return RedirectToPage("Index");
    }
}
