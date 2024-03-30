using System.Collections.Generic;
using LMS_project_3.Models;

namespace LMS_project_3.Interfaces
{
    public interface IReaderRepository
    {
        // Get a single reader by their ID
        Reader GetReaderById(int readerId);

        // Get all readers
        IEnumerable<Reader> GetAllReaders();

        // Add a new reader
        Reader AddReader(Reader reader);

        // Update an existing reader
        Reader UpdateReader(Reader reader);

        // Delete a reader
        void DeleteReader(int readerId);
    }
}
