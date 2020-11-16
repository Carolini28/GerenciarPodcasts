using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.Models;
using WebApi.Domain.Repositories;
using WebApi.Domain.Services;

namespace WebApi.Services {
	public class EpisodioService : IEpisodioService {

		private readonly IEpisodioRepository _episodioRepository;

		public EpisodioService(IEpisodioRepository episodioRepository)
		{
			_episodioRepository = episodioRepository;
		}

		public async Task Add(Episodio item)
		{
			 await _episodioRepository.Add(item);
		}

		public Episodio Get(int id)
		{
			return _episodioRepository.Get(id);
		}

		public IEnumerable<Episodio> GetAll()
		{
			return  _episodioRepository.GetAll();
		}

		public void Remove(Episodio item)
		{
			_episodioRepository.Remove(item);
		}

		public void Update(Episodio item)
		{
			_episodioRepository.Update(item);
		}
	}
}