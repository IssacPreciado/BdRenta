using BdRenta.Modelos;

namespace BdRenta.Repositorio
{
    public interface IRepositorioAutomoviles
    {
        Task<List<Automovil>> GetAll();
        Task<Automovil?> Get(int id);
        Task<Automovil> Add(Automovil automovil);

        Task Update(int id, Automovil automovil);

        Task Delete(int id);
    }
}
