using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppAcademica.Models;

namespace WebAppAcademica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculasController : ControllerBase
    {
        private readonly MyDbContext _context;

        public MatriculasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Matriculas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetMatriculas()
        {
            var q = _context.Matriculas
                .Include(m => m.Alumno)
                .Include(m => m.Periodo)
                .AsQueryable();

            var lista = await q
                .Select(m => new
                {
                    idMatricula = m.idMatricula,
                    fecha = m.fecha,
                    alumno = m.Alumno != null ? (m.Alumno.nombre ?? "").Trim() : "",
                    periodo = m.Periodo != null ? (m.Periodo.periodo ?? "").Trim() : ""
                })
                .ToListAsync();

            return Ok(lista);
        }

        // GET: api/Matriculas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetMatricula(int id)
        {
            var m = await _context.Matriculas
                .Include(x => x.Alumno)
                .Include(x => x.Periodo)
                .FirstOrDefaultAsync(x => x.idMatricula == id);

            if (m == null) return NotFound();

            var dto = new
            {
                idMatricula = m.idMatricula,
                fecha = m.fecha,
                idAlumno = m.idAlumno,
                idPeriodo = m.idPeriodo,
                alumno = m.Alumno != null ? (m.Alumno.nombre ?? "").Trim() : "",
                periodo = m.Periodo != null ? (m.Periodo.periodo ?? "").Trim() : ""
            };

            return Ok(dto);
        }

        // GET: api/Matriculas/buscar?buscar=texto
        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<object>>> BuscarMatriculas([FromQuery] MatriculaBusquedaParametro parametros)
        {
            var q = _context.Matriculas
                .Include(m => m.Alumno)
                .Include(m => m.Periodo)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(parametros?.buscar))
            {
                var term = parametros.buscar.Trim();
                q = q.Where(m =>
                    (m.Alumno != null && EF.Functions.Like(m.Alumno.nombre ?? "", $"%{term}%")) ||
                    (m.Periodo != null && EF.Functions.Like(m.Periodo.periodo ?? "", $"%{term}%"))
                );
            }

            var lista = await q
                .Select(m => new
                {
                    idMatricula = m.idMatricula,
                    fecha = m.fecha,
                    alumno = m.Alumno != null ? (m.Alumno.nombre ?? "").Trim() : "",
                    periodo = m.Periodo != null ? (m.Periodo.periodo ?? "").Trim() : ""
                })
                .ToListAsync();

            return Ok(lista);
        }

        // PUT: api/Matriculas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatricula(int id, Matricula matricula)
        {
            if (id != matricula.idMatricula) return BadRequest();

            _context.Entry(matricula).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatriculaExists(id)) return NotFound();
                throw;
            }

            return NoContent();
        }

        // POST: api/Matriculas
        [HttpPost]
        public async Task<ActionResult<Matricula>> PostMatricula(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMatricula), new { id = matricula.idMatricula }, matricula);
        }

        // DELETE: api/Matriculas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatricula(int id)
        {
            var matricula = await _context.Matriculas.FindAsync(id);
            if (matricula == null) return NotFound();

            _context.Matriculas.Remove(matricula);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MatriculaExists(int id) =>
            _context.Matriculas.Any(e => e.idMatricula == id);
    }
}
