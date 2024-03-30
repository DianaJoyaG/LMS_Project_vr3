using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LMS_project_3.Models;
using LMS_project_3.Interfaces;
using System.Threading.Tasks;

public class EditBorrowingModel : PageModel
{
    private readonly IBorrowingRepository _borrowingRepository;

    [BindProperty]
    public Borrowing Borrowing { get; set; }

    public EditBorrowingModel(IBorrowingRepository borrowingRepository)
    {
        _borrowingRepository = borrowingRepository;
    }

    public IActionResult OnGet(int id)
    {
        Borrowing = _borrowingRepository.GetBorrowingById(id);

        if (Borrowing == null)
        {
            return NotFound();
        }

        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _borrowingRepository.UpdateBorrowing(Borrowing);
        
        return RedirectToPage("./Index");
    }
}
