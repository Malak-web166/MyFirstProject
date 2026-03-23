using MyAssignmentProject.Models;

namespace MyAssignmentProject.Interfaces;

public interface IBookService
{
    IEnumerable<Book> GetAll();      // Endpoint 1: List all books
    Book GetById(int id);            // Endpoint 2: Get one book by ID
    void Add(Book book);             // Endpoint 3: Create a new book
}