using BdRenta.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BdRenta.Repositorio
{
    public class RepositorioAutomoviles : IRepositorioAutomoviles
    {
        private readonly CatalogoDBContext _context;

        public RepositorioAutomoviles(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Automovil> Add(Automovil automovil)
        {
            await _context.Automoviles.AddAsync(automovil);
            await _context.SaveChangesAsync();
            return automovil;
        }

        public async Task Delete(int id)
        {
            var automovil = await _context.Automoviles.FindAsync(id);
            if (automovil != null)
            {
                _context.Automoviles.Remove(automovil);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Automovil?> Get(int id)
        {
            return await _context.Automoviles.FindAsync(id);
        }

        public async Task<List<Automovil>> GetAll()
        {
            return await _context.Automoviles.ToListAsync();
        }

        public async Task Update(int id, Automovil automovil)
        {
            var automovilactual = await _context.Automoviles.FindAsync(id);
            if (automovilactual != null)
            {
                automovilactual.Modelo = automovil.Modelo;
                automovilactual.Matricula = automovil.Matricula;
                automovilactual.Especificaciones = automovil.Especificaciones;
                await _context.SaveChangesAsync();
            }
        }
    }
}
