using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.Models;

namespace WebApi.Domain.Repositories {
	public interface IAutorRepository {
        IEnumerable<Autor> GetAll();
        Autor Get(int id);
        Task Add(Autor item);
        void Remove(Autor item);
        void Update(Autor item);
    }
}