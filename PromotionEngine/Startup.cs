﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PromotionEngine
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
				services.AddMemoryCache();
			  
			   services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
			   services.AddSession(options => {
				options.IdleTimeout = TimeSpan.FromMinutes(1);
			   });

			   services.AddDistributedMemoryCache();
			   services.AddMvc();
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
			 
			   app.UseStaticFiles();
			   app.UseCookiePolicy();
			   app.UseSession();

  			   app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ProductDetails}/{action=GetAllProductsWithDetails}/{productBuyModel?}");
            });
			 
		}
    }
}
