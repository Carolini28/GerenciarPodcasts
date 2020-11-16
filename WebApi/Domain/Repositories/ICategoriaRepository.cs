using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.Models;

namespace WebApi.Domain.Repositories {
	public interface ICategoriaRepository {
        IEnumerable<Categoria> GetAll();
        Categoria Get(int id);
        Task Add(Categoria item);
        void Remove(Categoria item);
        void Update(Categoria item);
    }
}