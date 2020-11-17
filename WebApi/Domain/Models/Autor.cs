using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Models {

	public class Autor {
		[Key]
		public int CodigoAutor { get; set; }
		public string NomeAutor { get; set; }
		public string ProfissaoDoAutor { get; set; }
		public string Imagem { get; set; }
		public IList<Episodio> Episodio { get; set; } = new List<Episodio>();
	}
}