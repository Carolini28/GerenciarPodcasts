﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Models {
	public class Episodio {
		[Key]
		public int Id { get; set; }
		public string Nome { get; set; }
		public int CodigoAutor { get; set; }
		public Autor Autor { get; set; }
		public int CodigoCategoria { get; set; }
		public Categoria Categoria { get; set; }
		public string NomeDoAudio { get; set; }
	}
}