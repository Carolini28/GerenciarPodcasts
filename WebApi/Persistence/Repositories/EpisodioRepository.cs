using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Models;
using WebApi.Domain.Repositories;
using WebApi.Persistence.Contexts;

namespace WebApi.Persistence.Repositories {
	public class EpisodioRepository : BaseRepository, IEpisodioRepository {
		public EpisodioRepository(AppDbContext context) : base(context) { }
		public async Task Add(Episodio item)
		{
			await _context.Episodios.AddAsync(item);
			_context.SaveChanges();
		}

		public Episodio Get(int id)
		{
			return _context.Episodios.Find(id);
		}

		public IEnumerable<Episodio> GetAll()
		{
			return  _context.Episodios.ToList();
		}

		public void Remove(Episodio item)
		{
			_context.Episodios.Remove(item);
			_context.SaveChanges();
		}

		public void Update(Episodio item)
		{
			_context.Episodios.Update(item);
			_context.SaveChanges();
		}
	}
}