using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace FirstAppCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Run(context => {
            //    return context.Response.WriteAsync("Welcome to primary middleware");
            //});

            //app.Run(context => {
            //    return context.Response.WriteAsync("Welcome to First Middleware");
            //});

            //app.Run(context =>{
            //    return context.Response.WriteAsync("Welcome to Second Middleware");
            //});

            app.Run(SayHelloToMiddleware);


            app.Use(async(context, next) => {
                await context.Response.WriteAsync("Request is in first middleware -- > ");
                await next();
                await context.Response.WriteAsync("Response is at first middleware -- > ");
            });

            app.Use(async (context, next) => {
                await context.Response.WriteAsync("Request is in second middleware -- > ");
                await next();
                await context.Response.WriteAsync("Response is at second middleware -- > ");
            });

            app.Use(async(context, next) =>
            {
                await context.Response.WriteAsync("Request is in third middleware -- > ");
                await next();
                await context.Response.WriteAsync("Response is at third middleware -- > ");
            });

            app.Run(context => {
                return context.Response.WriteAsync("Request is at final middleware -- > ");
            });
        }

        public Task SayHelloToMiddleware(HttpContext cntx)
        {
            return cntx.Response.WriteAsync("SayHelloToMiddleware");
        }
    }
}
