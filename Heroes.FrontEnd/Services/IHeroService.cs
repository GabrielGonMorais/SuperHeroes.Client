
using Heroes.FrontEnd.DTOs;

namespace Heroes.FrontEnd.Services
{
    public interface IHeroService
    {
        List<Hero> Heroes { get; set; }
        Hero Hero { get; set; }
        List<Comic>? Comics { get; set; }
        Task GetComic();
        Task GetHero();
        Task PostHero(Hero hero);
        Task DeleteHero(int ID);
    }
}
