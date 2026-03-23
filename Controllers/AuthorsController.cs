using Microsoft.AspNetCore.Mvc;
using MyProject.Interfaces;
using MyProject.Models;

public class AuthorsController : Controller {
    private readonly IAuthorService _service;

    public AuthorsController(IAuthorService service) { _service = service; }

    // GET: /Books
    public IActionResult Index() => View(); 

    // GET: /Books/Details/5
    public IActionResult Details(int id) => View();

    // GET: /Books/Create
    public IActionResult Create() => View();
}