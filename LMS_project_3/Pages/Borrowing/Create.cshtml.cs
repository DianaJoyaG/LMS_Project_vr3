using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LMS_project_3.Models;
using LMS_project_3.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CreateBorrowingModel : PageModel
{
    private readonly IBorrowingRepository _borrowingRepository;
    private readonly IBookRepository _bookRepository; 
    private readonly IReaderRepository _readerRepository; 

    [BindProperty]
    public Borrowing Borrowing { get; set; }
    public SelectList Books { get; set; }
    public SelectList Readers { get; set; }

    public CreateBorrowingModel(IBorrowingRepository borrowingRepository, IBookRepository bookRepository, IReaderRepository readerRepository)
    {
        _borrowingRepository = borrowingRepository;
        _bookRepository = bookRepository;
        _readerRepository = readerRepository;
    }

    public IActionResult OnGet()
    {
        Books = new SelectList(_bookRepository.GetAllBooks(), "IDBook", "Title");
        Readers = new SelectList(_readerRepository.GetAllReaders(), "IDReader", "NameReader");
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            Books = new SelectList(_bookRepository.GetAllBooks(), "IdBook", "Title", Borrowing.IDBook);
            Readers = new SelectList(_readerRepository.GetAllReaders(), "IdReader", "NameReader", Borrowing.IDReader);
            return Page();
        }

        var newBorrowing = _borrowingRepository.AddBorrowing(Borrowing);
        
        return RedirectToPage("./Index");
    }
}
