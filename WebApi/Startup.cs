using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApi.Domain.Repositories;
using WebApi.Domain.Services;
using WebApi.Persistence.Contexts;
using WebApi.Persistence.Repositories;
using WebApi.Services;

namespace WebApi {
	public class Startup {
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("GerenciarPodcastEntities")));
			services.AddScoped<IEpisodioRepository, EpisodioRepository>();
			services.AddScoped<IEpisodioService, EpisodioService>();
			services.AddScoped<ICategoriaRepository, CategoriaRepository>();
			services.AddScoped<ICategoriaService, CategoriaService>();
			services.AddScoped<IAutorRepository, AutorRepository>();
			services.AddScoped<IAutorService, AutorService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
