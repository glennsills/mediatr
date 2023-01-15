using SampleValueFeatures.Features.DataValues.DataAccess;
using MediatR;
using MediatR.Extensions.FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Sample.Data;

namespace SampleWeb;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<SampleDataContext>(
        dbContextOptionsBuilder =>
        {

            dbContextOptionsBuilder.UseSqlite("yourConnection",
                options => { options.MigrationsAssembly("SampleData"); });

        });


        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var mediatrAssembly = typeof(DataContainer).Assembly;
        builder.Services.AddMediatR(mediatrAssembly);
        //builder.Services.AddFluentValidation(new[] { mediatrAssembly });


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