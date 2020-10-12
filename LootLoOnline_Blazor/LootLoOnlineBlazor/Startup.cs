using LootLoOnline.Business;
using LootLoOnline.Business.BusinessClass;
using LootLoOnline.Business.Repository;
using LootLoOnline.Business.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO.Compression;
using System.Linq;

namespace LootLoOnlineBlazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

            // services.AddResponseCompression();
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<BrotliCompressionProvider>();
                options.Providers.Add<GzipCompressionProvider>();

                options.MimeTypes =
                   ResponseCompressionDefaults.MimeTypes.Concat(
                       new[] { "image/svg+xml" });
            });
            services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Fastest;
            });
            //services.Configure<ForwardedHeadersOptions>(options =>
            //{
            //    options.ForwardedHeaders =
            //        ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            //});
            services.AddHttpContextAccessor();
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddMemoryCache();
            services.AddSingleton<FlipkartService>();
            services.AddSingleton<OfferAdapter>();
            services.AddSingleton<FlipkartOfferAdapter>();
            services.AddSingleton<AppStateService>();
            services.AddSingleton<MongodbVisitorService>();
            services.AddSingleton<FlipKartOfferProductRepo>();
            services.AddSingleton<FlipKartDealsOftheDayRepo>();

            services.AddDbContext<LootLoOnlineDbContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:SQLServerconnectionString"]));
            // services.AddTransient(typeof(IDataRepository<>), typeof(DataRepository<>));
            services.AddScoped<OfferProductRepository>();
            services.AddScoped<LogsRepository>();
            services.AddScoped<VisitedUserRepository>();
            // services.AddTransient<ICustomerRepository, CustomerRepository>();
            //services.AddScoped<OfferProductRepo>();
            //services.AddScoped<LogsRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseForwardedHeaders();
            app.UseResponseCompression();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/{name?}", "/_Host");
                //endpoints.MapFallbackToPage("/caragoryoffers/{ProductId?}", "/_Host");
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
