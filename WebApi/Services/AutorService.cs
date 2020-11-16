using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.Models;
using WebApi.Domain.Repositories;
using WebApi.Domain.Services;

namespace WebApi.Services {
	public class AutorService : IAutorService {
		
		private readonly IAutorRepository _autorRepository;

		public AutorService(IAutorRepository autorRepository)
		{
			_autorRepository = autorRepository;
		}

		public async Task Add(Autor item)
		{
			await _autorRepository.Add(item);
		}

		public Autor Get(int id)
		{
			return _autorRepository.Get(id);
		}

		public IEnumerable<Autor> GetAll()
		{
			return _autorRepository.GetAll();
		}

		public void Remove(Autor item)
		{
			_autorRepository.Remove(item);
		}

		public void Update(Autor item)
		{
			_autorRepository.Update(item);
		}
	}
}