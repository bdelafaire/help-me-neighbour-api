using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HelpMeNeighbour.Data;
using HelpMeNeighbour.Helper;
using HelpMeNeighbour.mapper;
using HelpMeNeighbour.Security;
using HelpMeNeighbour.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace HelpMeNeighbour
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "allowany";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin();
                                  });
            });
            services.AddControllers().AddJsonOptions(options => { options.JsonSerializerOptions.IgnoreNullValues = true; }); ;

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes("THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING");

            string MYSQL_HOST = Environment.GetEnvironmentVariable("MYSQL_HOST");
            string MYSQL_PORT = Environment.GetEnvironmentVariable("MYSQL_PORT");
            string MYSQL_DBNAME = Environment.GetEnvironmentVariable("MYSQL_DBNAME");
            string MYSQL_USER = Environment.GetEnvironmentVariable("MYSQL_USER");
            string MYSQL_PWD = Environment.GetEnvironmentVariable("MYSQL_PWD");

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql($"server ={MYSQL_HOST} ; port = {MYSQL_PORT}; database ={MYSQL_DBNAME}; user = {MYSQL_USER}; password = {MYSQL_PWD}");
            });

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            // configure DI for application services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAdService, AdService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<IAdService, AdService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
