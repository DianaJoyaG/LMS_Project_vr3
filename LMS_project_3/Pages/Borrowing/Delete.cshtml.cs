using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LMS_project_3.Models;
using LMS_project_3.Interfaces;
using System.Threading.Tasks;

public class DeleteBorrowingModel : PageModel
{
    private readonly IBorrowingRepository _borrowingRepository;

    [BindProperty]
    public Borrowing Borrowing { get; set; }

    public DeleteBorrowingModel(IBorrowingRepository borrowingRepository)
    {
        _borrowingRepository = borrowingRepository;
    }

    public async Task<IActionResult> OnGetA(int id)
    {
        Borrowing = _borrowingRepository.GetBorrowingById(id);

        if (Borrowing == null)
        {
            return NotFound();
        }

        return Page();
    }

    public IActionResult OnPost(int id)
    {
        var borrowingToDelete = _borrowingRepository.GetBorrowingById(id);

        if (borrowingToDelete != null)
        {
            _borrowingRepository.DeleteBorrowing(id);
        }

        return RedirectToPage("./Index");
    }
}
