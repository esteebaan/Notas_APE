using Notas_APE.DTO_s;
using Notas_APE.Repositories;

namespace Notas_APE.Services
{
    public class PromedioService
    {
        private readonly IPromedioRepository _repository;

        public PromedioService(IPromedioRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PromedioDTO>> GetPromediosDTOAsync()
        {
            return await _repository.GetAllPromediosConCursoAsync();
        }
    }
}
