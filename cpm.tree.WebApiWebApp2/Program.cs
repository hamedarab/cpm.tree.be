namespace cpm.tree.WebApiWebApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            AddServicesToContainer(builder);

            var app = builder.Build();

            ConfigureHttpRequestPipeline(app);

            app.Run();
        }

        private static void ConfigureHttpRequestPipeline(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseSwagger();
            //    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "cpm.tree.WebApi v1"));
            //}

            //if (!app.Environment.IsDevelopment())
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}


            app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();
            //if authentication service is added // app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");
        }

        private static void AddServicesToContainer(WebApplicationBuilder builder)
        {
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //               .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));
            builder.Services.AddControllers();

            /*
             *  For production environments that are implementing HTTPS for the first time, set the initial HstsOptions.MaxAge to a small value using one of the TimeSpan methods. 
             *  Set the value from hours to no more than a single day in case you need to revert the HTTPS infrastructure to HTTP. 
             *  After you're confident in the sustainability of the HTTPS configuration, increase the HSTS max-age value; a commonly used value is one year.
             */
            //builder.Services.AddHsts(options =>
            //{
            //    options.Preload = true;
            //    options.IncludeSubDomains = true;
            //    options.MaxAge = TimeSpan.FromHours(1); // TimeSpan.FromDays(60);
            //                                            //options.ExcludedHosts.Add("example.com");
            //                                            //options.ExcludedHosts.Add("www.example.com");
            //});
            //builder.Services.AddHttpsRedirection(options =>
            //{
            //    options.RedirectStatusCode = (int)HttpStatusCode.TemporaryRedirect;
            //    options.HttpsPort = 5001;
            //});

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "cpm.tree.WebApi", Version = "v1" });
            //});
        }
    }
}