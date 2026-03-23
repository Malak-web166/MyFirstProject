using Microsoft.AspNetCore.Mvc;
using MyProject.Interfaces;
using MyProject.Models;

public class BooksController : Controller {
    private readonly IBookService _service;

    public BooksController(IBookService service) { _service = service; }

    // GET: /Books
    public IActionResult Index() => View(); 

    // GET: /Books/Details/5
    public IActionResult Details(int id) => View();

    // GET: /Books/Create
    public IActionResult Create() => View();
}