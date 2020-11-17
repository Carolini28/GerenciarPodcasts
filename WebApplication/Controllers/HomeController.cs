using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Controllers {
	public class HomeController : Controller {
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public ActionResult Index()
		{
			ViewBag.Title = "ValtechPod";

			IEnumerable<Episodio> episodios = null;

			using (var cliente = new HttpClient())
			{
				cliente.BaseAddress = new Uri("https://localhost:44367/api/");

				var responseTask =  cliente.GetAsync("episodios");
				responseTask.Wait();
				var result = responseTask.Result;

				if (result.IsSuccessStatusCode)
				{
					var readTask = result.Content.ReadAsAsync<IList<Episodio>>();
					readTask.Wait();
					episodios = readTask.Result;
				}
				else
				{
					episodios = Enumerable.Empty<Episodio>();
					ModelState.AddModelError(string.Empty, "Erro no servidor. Contate o Administrador.");
				}
			}

			return View(episodios);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
