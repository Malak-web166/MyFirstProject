using MyAssignmentProject.Models;

namespace MyAssignmentProject.Interfaces;

public interface IBookService {
    IEnumerable<Book> GetAll();      // Endpoint 1: List all
    Book GetById(int id);            // Endpoint 2: Get one
    void Create(Book book);          // Endpoint 3: Add new
}