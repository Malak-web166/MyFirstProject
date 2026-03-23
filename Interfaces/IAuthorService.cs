using MyAssignmentProject.Models;

namespace MyAssignmentProject.Interfaces;

public interface IAuthorService
{
    IEnumerable<Author> GetAll();      // Endpoint 1: List all books
    Author GetById(int id);            // Endpoint 2: Get one book by ID
    void Add(Author author);             // Endpoint 3: Create a new book
}