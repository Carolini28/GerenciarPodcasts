using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Models;
using WebApi.Domain.Repositories;
using WebApi.Persistence.Contexts;

namespace WebApi.Persistence.Repositories {
	public class EpisodioRepository : BaseRepository, IEpisodioRepository {
		public EpisodioRepository(AppDbContext context) : base(context) { }
		public void Add(Episodio item)
		{
			_context.Episodios.Add(item);
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
		}

		public void Update(Episodio item)
		{
			_context.Episodios.Update(item);
		}
	}
}