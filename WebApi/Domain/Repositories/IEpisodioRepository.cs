using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.Models;

namespace WebApi.Domain.Repositories {
	public interface IEpisodioRepository {
        IEnumerable<Episodio> GetAll();
        Episodio Get(int id);
        Task Add(Episodio item);
        void Remove(Episodio item);
        void Update(Episodio item);
    }
}