﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using VastraIndiaWebAPI.Models;

namespace VastraIndiaWebAPI
{
    //public class Startup
    //{
    //    public void Configure(IApplicationBuilder app)
    //    {
    //        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    //    }
    //}


    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        //This method gets called by the runtime.Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    //services.AddDbContext<CoreDbContext>(op => op.UseSqlServer(Configuration.GetConnectionString("Database"))); //Add       
        //    //services.AddControllers();

        //    services.AddCors(options =>
        //    {
        //        options.AddPolicy("EnableCORS", builder =>
        //        {
        //            builder.AllowAnyOrigin()
        //            .AllowAnyHeader()
        //            .AllowAnyMethod();
        //        });
        //    });

        //    services.AddAuthentication(opt =>
        //    {
        //        opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //        opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //    })
        //    .AddJwtBearer(options =>
        //    {
        //       options.TokenValidationParameters = new TokenValidationParameters
        //    {
        //           ValidateIssuer = true,
        //           ValidateAudience = true,
        //           ValidateLifetime = true,
        //           ValidateIssuerSigningKey = true,
        //           ValidIssuer = "https://localhost:7181",
        //           ValidAudience = "https://localhost:7181",
        //           IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))
        //    };
        //    });
        //    services.AddControllers();
        //}

        //This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, string[] args)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            //app.UseCors("EnableCORS");
            app.UseRouting();
            //app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }


    }
}
