using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.Models;
using WebApi.Domain.Repositories;
using WebApi.Domain.Services;

namespace WebApi.Services {
	public class CategoriaService : ICategoriaService {

		private readonly ICategoriaRepository _categoriaRepository;

		public CategoriaService(ICategoriaRepository categoriaRepository)
		{
			_categoriaRepository = categoriaRepository;
		}

		public async Task Add(Categoria item)
		{
			await _categoriaRepository.Add(item);
		}

		public Categoria Get(int id)
		{
			return _categoriaRepository.Get(id);
		}

		public IEnumerable<Categoria> GetAll()
		{
			return _categoriaRepository.GetAll();
		}

		public void Remove(Categoria item)
		{
			_categoriaRepository.Remove(item);
		}

		public void Update(Categoria item)
		{
			_categoriaRepository.Update(item);
		}
	}
}