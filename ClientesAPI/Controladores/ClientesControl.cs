using Microsoft.AspNetCore.Mvc;
using ClientesAPI.Models;

[ApiController]
[Route("api/[controller]")]
public class ClientesControl : ControllerBase
{
    private readonly ClientesDbContext _context;

    public ClientesControl(ClientesDbContext context)
    {
        _context = context;
    }

    // POST: api/Clientes
    [HttpPost]
    public async Task<IActionResult> CreateCliente([FromBody] Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetClienteById), new { id = cliente.Id }, cliente);
    }

    // GET: api/Clientes/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetClienteById(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null)
        {
            return NotFound();
        }
        return Ok(cliente);
    }
}
