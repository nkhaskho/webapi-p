using Microsoft.AspNetCore.Mvc;
using WebApiP.Data;
using WebApiP.Models;

namespace WebApiP.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class UsersController : ControllerBase
{

    private ApiDbContext _context { get; set; }

    public UsersController(ApiDbContext ctx)
    {
        _context = ctx;
    }


    [HttpGet]
    //[Route("search")] FromQuery] string? q, 
    public IActionResult Search(string? q)
    {
        if (q == null) return Ok(_context.Users.ToList());
        return Ok(_context.Users.Where(
            u => u.Username.Contains(q)).ToList()
        );
    }

    [HttpPost]
    public IActionResult Add(User user)
    {
        // logic; validation + save
        if (!ModelState.IsValid) return BadRequest(ModelState.AsEnumerable());
        Console.WriteLine(user.Role);
        //user.CreatedAt = DateTime.Now()
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok(user);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null) return NotFound();
        return Ok(user);
    }

    [HttpPut]
    public IActionResult Update(User user)
    {
        // if (ModelState.IsValid) { /* update */ }
        _context.Users.Update(user);
        _context.SaveChanges();
        return Ok(user);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null) return NotFound();
        _context.Users.Remove(user);
        _context.SaveChanges();
        return NoContent();
    }
    
}