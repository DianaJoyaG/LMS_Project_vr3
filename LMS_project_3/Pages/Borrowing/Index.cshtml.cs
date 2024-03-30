using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using LMS_project_3.Models;
using LMS_project_3.Interfaces;

public class IndexBorrowingModel : PageModel
{
    private readonly IBorrowingRepository _borrowingRepository;

    public IEnumerable<Borrowing> Borrowings { get; private set; }

    public IndexBorrowingModel(IBorrowingRepository borrowingRepository)
    {
        _borrowingRepository = borrowingRepository;
    }

    public void OnGet()
    {
        Borrowings = _borrowingRepository.GetAllBorrowings();
    }
}
