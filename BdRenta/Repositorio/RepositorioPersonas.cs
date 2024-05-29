using BdRenta.Modelos;
using BdRenta.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BdRenta.Repositorio
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        private readonly CatalogoDBContext _context;

        public RepositorioPersonas(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Persona> Add(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task Delete(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Persona?> Get(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task<List<Persona>> GetAll()
        {
            return await _context.Personas.Include(r=>r.Automovil).ToListAsync();

        }

        public async Task Update(int id, Persona persona)
        {
            var personaactual = await _context.Personas.FindAsync(id);
            if (personaactual != null)
            {
                personaactual.Nombre = persona.Nombre;
                personaactual.Correo = persona.Correo;
                personaactual.Telefono = persona.Telefono;
                personaactual.Direccion = persona.Direccion;
                personaactual.Ciudad = persona.Ciudad;
                personaactual.Dias = persona.Dias;
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<Automovil>> GetAutomovil()
        {
            return await _context.Automoviles.ToListAsync();
        }

    }
}