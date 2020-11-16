using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Models;
using WebApi.Domain.Repositories;
using WebApi.Persistence.Contexts;

namespace WebApi.Persistence.Repositories {
	public class CategoriaRepository : BaseRepository, ICategoriaRepository {
		public CategoriaRepository(AppDbContext context) : base(context) { }

		public async Task Add(Categoria item)
		{
			await _context.Categorias.AddAsync(item);
			_context.SaveChanges();
		}

		public Categoria Get(int id)
		{
			return _context.Categorias.Find(id);
		}

		public IEnumerable<Categoria> GetAll()
		{
			return _context.Categorias.ToList();
		}

		public void Remove(Categoria item)
		{
			_context.Categorias.Remove(item);
			_context.SaveChanges();
		}

		public void Update(Categoria item)
		{
			_context.Categorias.Update(item);
			_context.SaveChanges();
		}
	}
}