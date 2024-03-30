using Microsoft.AspNetCore.Mvc.RazorPages;
using LMS_project_3.Interfaces;
using LMS_project_3.Models;
using System.Collections.Generic;

public class IndexReaderModel : PageModel
{
    private readonly IReaderRepository _readerRepository; 

    public List<Reader> Readers { get; private set; }

    public IndexReaderModel(IReaderRepository readerRepository)
    {
        _readerRepository = readerRepository;
    }

    public void OnGet()
    {
        Readers = _readerRepository.GetAllReaders().ToList();
    }
}
