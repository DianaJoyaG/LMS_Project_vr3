using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using LMS_project_3.Models;
using LMS_project_3.Interfaces;

public class IndexBookModel : PageModel
{
    private readonly IBookRepository _bookRepository;

    // This should match the type you're expecting to receive, in this case, an IEnumerable of Book
    public IEnumerable<Book> Books { get; private set; }

    public IndexBookModel(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public void OnGet()
    {
        Books = _bookRepository.GetAllBooks();
    }
}
