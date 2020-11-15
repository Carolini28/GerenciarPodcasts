using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.Models;

namespace WebApi.Domain.Services {
	public interface IEpisodioService {
        IEnumerable<Episodio> GetAll();
        Episodio Get(int id);
        void Add(Episodio item);
        void Remove(Episodio item);
        void Update(Episodio item);
    }
}