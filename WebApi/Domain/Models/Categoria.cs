using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Models {
	public class Categoria {
		[Key]
		public int CodigoCategoria { get; set; }
		public string NomeCategoria { get; set; }
	}
}