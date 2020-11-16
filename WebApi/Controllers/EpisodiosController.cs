using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Domain.Models;
using WebApi.Domain.Services;

namespace WebApi.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class EpisodiosController : ControllerBase {

		private readonly IEpisodioService _episodioService;

		public EpisodiosController(IEpisodioService episodioService)
		{
			_episodioService = episodioService;
		}

		// GET: api/<EpisodiosController>
		[HttpGet]
		public IEnumerable<Episodio> Get()
		{
			return _episodioService.GetAll();
		}

		// GET api/<EpisodiosController>/5
		[HttpGet("{id}")]
		public Episodio Get(int id)
		{
			return _episodioService.Get(id);
		}

		// POST api/<EpisodiosController>
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> Post([FromBody] Episodio episodio)
		{
			if (!ModelState.IsValid)
				return BadRequest("Not a valid model");

			await _episodioService.Add(episodio);
			return CreatedAtAction(nameof(Get), new { id = episodio.Id }, episodio);
		}

		// PUT api/<EpisodiosController>/5
		[HttpPut]
		public IActionResult Put([FromBody] Episodio episodio)
		{
			if (!ModelState.IsValid)
				return BadRequest("Not a valid model");

			 _episodioService.Update(episodio);

			return Ok(episodio);
		}

		// DELETE api/<EpisodiosController>/5
		[HttpDelete]
		public IActionResult Delete([FromBody] Episodio episodio)
		{
			if (!ModelState.IsValid)
				return BadRequest("Not a valid model");

			_episodioService.Remove(episodio);

			return  Ok($"Produto {episodio.Id} foi deletado com sucesso");
		}

		[HttpGet("Categoria/{id}")]
		public IEnumerable<Episodio> GetEpisodiosPorCategoria(int id)
		{
			return _episodioService.GetAll().Where(x => x.CodigoCategoria == id);
		}
	}
}