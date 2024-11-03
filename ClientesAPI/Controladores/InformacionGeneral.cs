using Microsoft.AspNetCore.Mvc;
using ClientesAPI.Models;

[ApiController]
[Route("api/[controller]")]
public class InformacionGeneral : ControllerBase
{
    private readonly ClientesDbContext _context;

    public InformacionGeneral(ClientesDbContext context)
    {
        _context = context;
    }

    // POST: api/InformacionGeneral
    [HttpPost]
    public async Task<IActionResult> CreateInformacionGeneral([FromBody] InformacionGeneral info)
    {
        _context.InformacionGenerals.Add(info);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetInformacionGeneralById), new { id = info.Id }, info);
    }

    // GET: api/InformacionGeneral/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetInformacionGeneralById(int id)
    {
        var info = await _context.InformacionGenerals.FindAsync(id);
        if (info == null)
        {
            return NotFound();
        }
        return Ok(info);
    }
}
