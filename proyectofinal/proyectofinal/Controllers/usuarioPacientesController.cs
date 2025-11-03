using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using proyectofinal.Models;

namespace proyectofinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarioPacientesController : ControllerBase
    {
        private readonly MydbContext _context;

        public usuarioPacientesController(MydbContext context)
        {
            _context = context;
        }

        // GET: api/usuarioPacientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<usuarioPaciente>>> GetusuarioPaciente()
        {
            return await _context.usuarioPaciente.ToListAsync();
        }

        // GET: api/usuarioPacientes/5
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

        // PUT: api/usuarioPacientes/5
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

        // POST: api/usuarioPacientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostusuarioPaciente")]
        public async Task<IActionResult> PostusuarioPaciente([FromBody] usuarioPaciente usuarioPaciente)
        {
            // Validar si la contraseña ya está en uso
            bool passwordExiste = await _context.usuarioPaciente
                .AnyAsync(u => u.password == usuarioPaciente.password);

            if (passwordExiste)
            {
                var sugerencias = new List<string>();
                var random = new Random();

                while (sugerencias.Count < 3)
                {
                    string sugerida = $"pass{random.Next(1000, 9999)}";
                    bool yaExiste = await _context.usuarioPaciente.AnyAsync(u => u.password == sugerida);
                    if (!yaExiste)
                    {
                        sugerencias.Add(sugerida);
                    }
                }

                return Conflict(new
                {
                    mensaje = "La contraseña ya está en uso. Elige otra.",
                    sugerencias = sugerencias
                });
            }

            // Guardar el nuevo usuario
            _context.usuarioPaciente.Add(usuarioPaciente);
            await _context.SaveChangesAsync();

            // Devolver solo el ID para el frontend
            return Ok(new { idPacienteUsuario = usuarioPaciente.idPacienteUsuario });
        }
        [HttpPost("guardarDatosPaciente")]
        public async Task<IActionResult> GuardarDatosPaciente([FromBody] DatosPacientes paciente)
        {
            if (paciente == null)
                return BadRequest("Datos inválidos");

            bool existeUsuario = await _context.usuarioPaciente
                .AnyAsync(u => u.idPacienteUsuario == paciente.idPacienteUsuario);

            if (!existeUsuario)
                return BadRequest("El usuario no existe");

            bool yaTieneDatos = await _context.DatosPacientes
                .AnyAsync(d => d.idPacienteUsuario == paciente.idPacienteUsuario);

            if (yaTieneDatos)
                return Conflict("Este usuario ya tiene datos registrados");

            try
            {
                _context.DatosPacientes.Add(paciente);
                await _context.SaveChangesAsync();
                return Ok(new { mensaje = "Datos guardados" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
        [HttpPost("validarCredenciales")]
        public async Task<IActionResult> ValidarCredenciales([FromBody] usuarioPaciente credenciales)
        {
            var usuario = await _context.usuarioPaciente
                .FirstOrDefaultAsync(u => u.email == credenciales.email);

            if (usuario == null)
                return Ok(new { valido = false, error = "email" });

            if (usuario.password != credenciales.password)
                return Ok(new { valido = false, error = "password" });

            return Ok(new { valido = true, idPacienteUsuario = usuario.idPacienteUsuario });
        }


        [HttpPost("agendarCita")]
        public async Task<IActionResult> AgendarCita([FromBody] agendaPaciente cita)
        {
            if (cita == null ||
                string.IsNullOrWhiteSpace(cita.nombre) ||
                string.IsNullOrWhiteSpace(cita.motivo) ||
                string.IsNullOrWhiteSpace(cita.hora) ||
                cita.fecha == default)
            {
                return BadRequest("Todos los campos son obligatorios");
            }

            // Verificar que el paciente existe
            bool existePaciente = await _context.usuarioPaciente
                .AnyAsync(p => p.idPacienteUsuario == cita.idPacienteUsuario);

            if (!existePaciente)
            {
                return BadRequest("El paciente no está registrado");
            }

            try
            {
                _context.agendarCita.Add(cita);
                await _context.SaveChangesAsync();
                return Ok(new { mensaje = "✅ Cita agendada correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }




        // DELETE: api/usuarioPacientes/5
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
