using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace RESTAPIVersioning
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
            services.AddMvc();
             //Check https://github.com/Microsoft/aspnet-api-versioning/wiki/API-Versioning-Options for details on these properties
            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1,0);

                //Query String Approach - Default - api-version
                options.ApiVersionReader = new QueryStringApiVersionReader(); 

                //Query String Approach - Custom
                //options.ApiVersionReader = new QueryStringApiVersionReader("v1");

                //Http Header Approach - No default, only custom
                //options.ApiVersionReader = new HeaderApiVersionReader("api-version");

                //Media type approach - Default - v
                //options.ApiVersionReader = new MediaTypeApiVersionReader();

                //Media type approach - custom
                //options.ApiVersionReader = new MediaTypeApiVersionReader("version");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
