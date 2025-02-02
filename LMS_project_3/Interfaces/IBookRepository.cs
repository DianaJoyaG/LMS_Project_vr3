﻿using LMS_project_3.Models;

namespace LMS_project_3.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
        Book AddBook(Book book);
        Book UpdateBook(Book book);
        void DeleteBook(int bookId);
    }
}
