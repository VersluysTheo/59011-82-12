using crudapirelationnn.Models;
using crudapirelationnn.Models.Services;
using Microsoft.EntityFrameworkCore;

namespace crudapirelationnn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<CrudapirelationnnDbContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("Default")));
            builder.Services.AddTransient<EnfantService>();
            builder.Services.AddTransient<ParentService>();
            builder.Services.AddTransient<ParentEnfantService>();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}