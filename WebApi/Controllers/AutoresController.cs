using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Domain.Models;
using WebApi.Domain.Services;

namespace WebApi.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class AutoresController : ControllerBase {

		private readonly IAutorService _autorService;

		public AutoresController(IAutorService autorService)
		{
			_autorService = autorService;
		}

		// GET: api/<AutoresController>
		[HttpGet]
		public IEnumerable<Autor> Get()
		{
			return _autorService.GetAll();
		}

		// GET api/<AutoresController>/5
		[HttpGet("{id}")]
		public Autor Get(int id)
		{
			return _autorService.Get(id);
		}

		// POST api/<AutoresController>
		[HttpPost]
		public IActionResult Post([FromBody] Autor autor)
		{
			if (!ModelState.IsValid)
				return BadRequest("Not a valid model");

			return Ok(_autorService.Add(autor));
		}

		// PUT api/<AutoresController>/5
		[HttpPut]
		public IActionResult Put([FromBody] Autor autor)
		{
			if (!ModelState.IsValid)
				return BadRequest("Not a valid model");

			_autorService.Update(autor);

			return Ok(autor);
		}

		// DELETE api/<AutoresController>/5
		[HttpDelete]
		public IActionResult Delete([FromBody] Autor autor)
		{
			if (!ModelState.IsValid)
				return BadRequest("Not a valid model");

			_autorService.Remove(autor);

			return Ok($"Produto {autor.CodigoAutor} foi deletado com sucesso");
		}
	}
}