public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
    private readonly string _policyName = "CorsPolicy";
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddPolicy(name: _policyName, builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
        services.AddControllers();
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseCors(_policyName);
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}