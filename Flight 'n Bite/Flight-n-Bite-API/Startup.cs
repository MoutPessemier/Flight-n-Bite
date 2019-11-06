using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_n_Bite_API.Data;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Flight_n_Bite_API
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
            var connectionstring = @"Server=(localdb)\MSSQLLocalDB;Database=Flight-n-biteDB;Trusted_Connection=True;MultipleActiveResultSets=true";

            services.AddDbContext<FlightDbContext>(options => options.UseSqlServer(connectionstring));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<FlightDbContext>(options => options.UseSqlServer(connectionstring));

            services.AddScoped<DataInitializer>();
            services.AddScoped<IFlightRepository, FlightRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMusicRepository, MusicRepository>();
            services.AddScoped<IArtistRepository, ArtistRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderLineRepository, OrderLineRepository>();
            services.AddScoped<IPersonnelRepository, PersonnelRepository>();
            services.AddScoped<IPassengerRepository, PassengerRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DataInitializer dataInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseCors("AllowAllOrigins");

            dataInitializer.InitializeData();
        }
    }
}
