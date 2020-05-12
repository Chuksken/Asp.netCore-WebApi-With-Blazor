using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorMovies.Client.Shared;
using Blazor.FileReader;
using Microsoft.Extensions.Options;
using BlazorMovies.Client.Helpers;
using BlazorMovies.Client.Repository;

namespace BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            //builder.Services.AddSingleton<SingletonService>();
            //builder.Services.AddTransient<TransientService>();
            builder.Services.AddTransient<IRepository, RepositoryInMemory>();
            builder.Services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddScoped<IGenreRepository, GenreRepository>();
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();

            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<IRepository, RepositoryInMemory>();
            //services.AddScoped<IHttpService, HttpService>();
            //services.AddScoped<IGenreRepository, GenreRepository>();
            //services.AddScoped<IPersonRepository, PersonRepository>();
            //services.AddScoped<IMoviesRepository, MoviesRepository>();
            //services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }
    }
}
