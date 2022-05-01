using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WEBAPI.Domain.DTO;
using WEBAPI.Domain.Entities;
using WEBAPI.Infra;
using WEBAPI.Infra.Data;
using WEBAPI.Infra.Repositories;
using WEBAPI.Infra.Repositories.Interfaces;
using WEBAPI.Service;
using WEBAPI.Service.Interfaces;

namespace DataProcess.WEBAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=ms-sql-server,1433;Database=clientecompradb;User=sa;Password=root123@;";
            services.AddDbContextPool<AppDBContext>(
                        options => options.UseLazyLoadingProxies()
                                          .UseSqlServer(connection, b => b.MigrationsAssembly("WEBAPI.Infra")));

            services.AddScoped<IClienteFacade, ClienteFacade>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ICompraFacade, CompraFacade>();
            services.AddScoped<ICompraRepository, CompraRepository>();
            services.AddScoped<IEmailFacade, EmailFacade>();


            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteDTO>();
                cfg.CreateMap<ClienteDTO, Cliente>();
                cfg.CreateMap<ClienteRequestDTO, Cliente>();
                cfg.CreateMap<Cliente,ClienteRequestDTO>();
                cfg.CreateMap<ClienteResponseDTO, Cliente>();
                cfg.CreateMap<Cliente, ClienteResponseDTO>();
                cfg.CreateMap<CompraRequestDTO, Compra>();
                cfg.CreateMap<Compra, CompraRequestDTO>();
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DataProcess.WEBAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DataProcess.WEBAPI v1"));
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            PrepDB.PrepPopulation(app);
        }
    }
}
