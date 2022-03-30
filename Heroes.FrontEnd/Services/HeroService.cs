using Heroes.FrontEnd.DTOs;
using System.Net.Http.Json;

namespace Heroes.FrontEnd.Services
{
    public class HeroService : IHeroService
    {
        private readonly HttpClient Http;

        public HeroService(HttpClient? http)
        {
            Http = http;
        }
        public List<Hero>? Heroes { get; set; }
        public Hero Hero { get; set; } = new() { ComicID = 2 };
        public List<Comic>? Comics { get; set; }


        //consuming web API from: https://github.com/GabrielGonMorais/SuperHeroes.API
        public async Task DeleteHero(int ID) => await Http.DeleteAsync($"https://localhost:7299/Hero/{ID}");
        public async Task GetComic() => Comics = await Http.GetFromJsonAsync<List<Comic>>("https://localhost:7299/Comics");
        public async Task GetHero() => Heroes = await Http.GetFromJsonAsync<List<Hero>>("https://localhost:7299/Heroes");

        public async Task PostHero(Hero hero)
        {
            await Http.PostAsJsonAsync("https://localhost:7299/Hero", hero);
            Hero = new Hero() { ComicID = 2 };
        }
    }
}
