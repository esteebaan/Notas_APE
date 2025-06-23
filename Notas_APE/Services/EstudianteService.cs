using Notas_APE.Models;
using Notas_APE.Repositories;

namespace Notas_APE.Services
{
    public class EstudianteService
    {
        private readonly IEstudianteRepository _repository;

        public EstudianteService(IEstudianteRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Estudiante>> GetEstudiantesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<IEnumerable<Estudiante>> FiltrarEstudiantesAsync(string? cedula, string? apellido)
        {
            return await _repository.FiltrarAsync(cedula, apellido);
        }
    }
}
