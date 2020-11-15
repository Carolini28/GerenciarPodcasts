using System.Collections.Generic;
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
		public void Post([FromBody] Episodio episodio)
		{
		}

		// PUT api/<EpisodiosController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<EpisodiosController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
