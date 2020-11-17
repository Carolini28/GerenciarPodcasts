using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Domain.Models;
using WebApi.Domain.Services;

namespace WebApi.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriasController : ControllerBase {

		private readonly ICategoriaService _categoriaService;

		public CategoriasController(ICategoriaService categoriaService)
		{
			_categoriaService = categoriaService;
		}

		// GET: api/<CategoriasController>
		[HttpGet]
		public async Task<IEnumerable<Categoria>> Get()
		{
			return await _categoriaService.GetAll();
		}

		// GET api/<CategoriasController>/5
		[HttpGet("{id}")]
		public Categoria Get(int id)
		{
			return _categoriaService.Get(id);
		}

		// POST api/<CategoriasController>
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public IActionResult Post([FromBody] Categoria categoria)
		{
			if (!ModelState.IsValid)
				return BadRequest("Not a valid model");

			return Ok(_categoriaService.Add(categoria));
		}

		// PUT api/<CategoriasController>/5
		[HttpPut]
		public IActionResult Put([FromBody] Categoria categoria)
		{
			if (!ModelState.IsValid)
				return BadRequest("Not a valid model");

			_categoriaService.Update(categoria);

			return Ok(categoria);
		}

		// DELETE api/<CategoriasController>/5
		[HttpDelete]
		public IActionResult Delete([FromBody] Categoria categoria)
		{
			if (!ModelState.IsValid)
				return BadRequest("Not a valid model");

			_categoriaService.Remove(categoria);

			return Ok($"Produto {categoria.CodigoCategoria} foi deletado com sucesso");
		}
	}
}