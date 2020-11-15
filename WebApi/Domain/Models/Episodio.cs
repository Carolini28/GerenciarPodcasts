namespace WebApi.Domain.Models {
	public class Episodio {
		public int Id { get; set; }
		public string Nome { get; set; }
		public int CodigoAutor { get; set; }
		public int CodigoCategoria { get; set; }
		public string NomeDoAudio { get; set; }
	}
}