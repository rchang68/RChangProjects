namespace OurFirstWebApp
{
    public class Startup
    {

        //configre services
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseHsts();
            }
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapGet("/hello", () => "Welcome to CPT-206 Web Development Demo!");
            });
        }
    }
}
