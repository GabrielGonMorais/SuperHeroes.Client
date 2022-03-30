
using Heroes.FrontEnd.DTOs;

namespace Heroes.FrontEnd.Services
{
    public interface IHeroService
    {
        List<Hero> Heroes { get; set; }
        Hero Hero { get; set; }
        List<Comic>? Comics { get; set; }
        
        List<Hero> GetList();
        List<Comic> GetComicList();
        void AddHero(Hero hero);
        void RemoveHero(int ID);

        
    }
}
