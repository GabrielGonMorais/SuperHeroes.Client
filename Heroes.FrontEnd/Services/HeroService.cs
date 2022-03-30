using Heroes.FrontEnd.DTOs;

namespace Heroes.FrontEnd.Services
{
    public partial class HeroService : IHeroService
    {             
        public Hero Hero { get; set; } = new() { ComicID = 2 };

        public List<Hero> GetList() => Heroes;

        public List<Comic> GetComicList() => Comics;

        public void RemoveHero(int ID)
        {
            Heroes.Remove(Heroes.Find((Hero)=> Hero.ID == ID));
        }

        public void AddHero(Hero hero)
        {
            hero.ID = Heroes.Count;

            switch (hero.ComicID)
            {
                case 1:
                    hero.Comic = DC;
                    break;
                case 2:
                    hero.Comic = Marvel;
                    break;
            };

            Heroes.Add(hero);
            Hero = new Hero() { ComicID = 2 };
        }
    }
}
