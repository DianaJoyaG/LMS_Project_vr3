using System;
using System.ComponentModel.DataAnnotations;

namespace LMS_project_3.Models
{
    public class Borrowing
    {
        [Key] // Data annotation to denote that this is the primary key
        public int IDBorrowing { get; set; } // Unique identifier for each borrowing instance

        public int IDBook { get; set; } // Foreign key to the Book entity, assuming there's a BookId in your Book model

        [Required]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Author name cannot be longer than 100 characters.")]
        public string Author { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Description name cannot be longer than 100 characters.")]
        public string Description { get; set; }

        [Required]
        public int IDReader { get; set; } // Foreign key to the Reader entity, assuming there's a ReaderId in your Reader model

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string NameReader { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BorrowedDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReturnedDate { get; set; } // Nullable, assuming the book might not have been returned yet
    }
}
