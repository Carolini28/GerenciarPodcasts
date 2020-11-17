using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApi.Domain.Models;
using WebApi.Domain.Repositories;
using System.Linq;
using WebApi.Persistence.Contexts;
using WebApi.Domain.Models.Queries;

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

		public async Task<IEnumerable<Episodio>> GetAll()
		{
			return await _context.Episodios.AsNoTracking().ToListAsync();
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