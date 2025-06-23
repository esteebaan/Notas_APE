using Notas_APE.Models;

namespace Notas_APE.Repositories
{
    public interface IEstudianteRepository
    {
        Task<IEnumerable<Estudiante>> GetAllAsync();
        Task<Estudiante> GetByCedulaAsync(string cedula);
        Task AddAsync(Estudiante estudiante);
        Task<IEnumerable<Estudiante>> FiltrarAsync(string? cedula, string? apellido);
    }
}
