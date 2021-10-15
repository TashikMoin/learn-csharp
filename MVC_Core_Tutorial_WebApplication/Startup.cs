using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC_Core_WebApplication.Models;

namespace MVC_Core_WebApplication
{
    /*
     *                          How to add MVC to the .NET Core project?
     *                          
     * - Call services.AddMvc(options => options.EnableEndpointRouting = false); in ConfigureService dependency 
     *   container to add mvc in your project. We could have called services.AddMvcCore() function too but 
     *   services.AddMvcCore() only adds core functionalities of MVC however, services.AddMvc() function adds "all"
     *   the required MVC functionalities like json formatter, view objects that helps the controller classes to 
     *   return view objects, json objects etc. The services.AddMvcCore() does not include these services.
     *   
     * - The services.AddMvc() function calls services.AddMvcCore() in its definition.
     *   
     * - Add app.UseMvcWithDefaultRoute(); after useStatic for efficient middleware calls, for example 
     *   if the request is for static files, the default routemiddleware for requests like abc.com/home/index/.. 
     *   (default route) will not get executed. If a defaultroute is found, this defaultroute middleware then becomes
     *   the terminal middleware of the pipeline.
     *   
     * - if a default route (abc.com/home/index/.. ) is not found and other routes like abc.com/about/.. etc
     *   is requested, then this defaultroutemiddleeware will pass the request to the next middlewares in the 
     *   pipeline.
     * 
    */
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddSingleton<IStudentRepository, StudentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
