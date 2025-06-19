using System.Net;
using AutoMapper;
using Domain.ApiResponse;
using Domain.Entites;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class BookService(DataContext context) : IBookService
{
    public async Task<Response<string>> AddBookAsync(Book book)
    {
        await context.Books.AddAsync(book);
        var result = await context.SaveChangesAsync();

        return result > 0
            ? new Response<string>(null, "Success")
            : new Response<string>("Something went wrong", HttpStatusCode.InternalServerError);
    }


    public async Task<Response<string>> DeleteBookAsync(int id)
    {
        var book = await context.Books.FindAsync(id);
        if (book == null)
        {
            return new Response<string>("Book not found", HttpStatusCode.NotFound);
        }

        context.Books.Remove(book);
        var res = await context.SaveChangesAsync();
        return res == 0
        ? new Response<string>("Someting went wrong", HttpStatusCode.InternalServerError)
        : new Response<string>(null, "Success");
    }

    public async Task<Response<string>> UpdateBookAsync(Book book)
    {
        var foundedBook = await context.Books.FindAsync(book.Id);
        if (foundedBook == null)
        {
            return new Response<string>("Book not found", HttpStatusCode.NotFound);
        }

        foundedBook.Title = book.Title;
        foundedBook.Author = book.Author;
        foundedBook.Genre = book.Genre;
        foundedBook.PublishedDate = book.PublishedDate;

        var res = await context.SaveChangesAsync();
        return res == 0
        ? new Response<string>("Someting went wrong", HttpStatusCode.InternalServerError)
        : new Response<string>(null, "Success");
    }

    public async Task<Response<Book?>> GetBookAsync(int id)
    {
        var book = await context.Books.FindAsync(id);
        if (book == null)
        {
            return new Response<Book?>("Book not found", HttpStatusCode.NotFound);
        }

        return new Response<Book?>(book, "Success");
    }


    public async Task<Response<List<Book>>> GetBooksAsync()
    {
        var books = await context.Books.ToListAsync();

        return new Response<List<Book>>(books);

    }


}
