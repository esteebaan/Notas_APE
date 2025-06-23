using Notas_APE.Models;

namespace Notas_APE.Repositories
{
    public interface INotaRepository
    {
        Task<IEnumerable<Nota>> GetAllNotasAsync();
        Task<Nota> GetNotaByIdAsync(int id);
        Task<Nota> CrearNotaAsync(Nota nota);
        Task<bool> ActualizarNotaAsync(int id, decimal nuevaNota);
    }
}
