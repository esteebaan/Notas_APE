using Notas_APE.DTO_s;

namespace Notas_APE.Repositories
{
    public interface IPromedioRepository
    {
        // Task<IEnumerable<Promedio>> GetAllPromediosAsync(); 
        Task<IEnumerable<PromedioDTO>> GetAllPromediosConCursoAsync();
    }
}
