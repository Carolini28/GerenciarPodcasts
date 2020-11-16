using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Models;
using WebApi.Domain.Repositories;
using WebApi.Persistence.Contexts;

namespace WebApi.Persistence.Repositories {
	public class AutorRepository : BaseRepository, IAutorRepository {

		public AutorRepository(AppDbContext context) : base(context) { }

		public async Task Add(Autor item)
		{
			await _context.Autores.AddAsync(item);
			_context.SaveChanges();
		}

		public Autor Get(int id)
		{
			return _context.Autores.Find(id);
		}

		public IEnumerable<Autor> GetAll()
		{
			return _context.Autores.ToList();
		}

		public void Remove(Autor item)
		{
			_context.Autores.Remove(item);
			_context.SaveChanges();
		}

		public void Update(Autor item)
		{
			_context.Autores.Update(item);
			_context.SaveChanges();
		}
	}
}