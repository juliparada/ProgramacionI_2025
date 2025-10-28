using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectofinal.Models;

namespace proyectofinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarioPacienteController : ControllerBase
    {
        private readonly MydbContext _context;

        public usuarioPacienteController(MydbContext context)
        {
            _context = context;
        }

        // GET: api/usuarioPaciente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<usuarioPaciente>>> GetusuarioPaciente()
        {
            return await _context.usuarioPaciente.ToListAsync();
        }

        // GET: api/usuarioPaciente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<usuarioPaciente>> GetusuarioPaciente(int id)
        {
            var usuarioPaciente = await _context.usuarioPaciente.FindAsync(id);

            if (usuarioPaciente == null)
            {
                return NotFound();
            }

            return usuarioPaciente;
        }

        // PUT: api/usuarioPaciente/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutusuarioPaciente(int id, usuarioPaciente usuarioPaciente)
        {
            if (id != usuarioPaciente.idPacienteUsuario)
            {
                return BadRequest();
            }

            _context.Entry(usuarioPaciente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!usuarioPacienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/usuarioPaciente
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<usuarioPaciente>> PostusuarioPaciente(usuarioPaciente usuarioPaciente)
        {
            _context.usuarioPaciente.Add(usuarioPaciente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetusuarioPaciente", new { id = usuarioPaciente.idPacienteUsuario }, usuarioPaciente);
        }

        // DELETE: api/usuarioPaciente/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteusuarioPaciente(int id)
        {
            var usuarioPaciente = await _context.usuarioPaciente.FindAsync(id);
            if (usuarioPaciente == null)
            {
                return NotFound();
            }

            _context.usuarioPaciente.Remove(usuarioPaciente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool usuarioPacienteExists(int id)
        {
            return _context.usuarioPaciente.Any(e => e.idPacienteUsuario == id);
        }
    }
}
