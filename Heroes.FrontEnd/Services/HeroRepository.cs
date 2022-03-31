using Heroes.FrontEnd.DTOs;

namespace Heroes.FrontEnd.Services
{
    public partial class HeroService
    {
        public List<Hero> Heroes { get; set; } = new List<Hero>()
        {
            new Hero() {ID= 0, HeroName= "Spider-Man", AlterEgo = "Peter Parker", Image = "https://upload.wikimedia.org/wikipedia/en/2/21/Web_of_Spider-Man_Vol_1_129-1.png", Info = "Our friendly neighborhood",Comic = Marvel, ComicID = 2},
            new Hero() {ID= 1, HeroName= "Batman", AlterEgo= "Bruce Wayne", Image= "https://upload.wikimedia.org/wikipedia/pt/8/8d/Batman_por_Jim_Lee.jpg", Info= "The dark knight", Comic = DC, ComicID= 1},
            new Hero() {ID= 2, HeroName= "Iron Man", AlterEgo= "Tony Stark", Image= "http://artecult.com/wp-content/uploads/2019/10/Iron-Man-2020-Ron-Lim-Variant-Cover-600x911.jpg", Info= "Genius, Billionaire, Playboy, Philanthropist", Comic = Marvel, ComicID= 2 },
            new Hero() {ID= 3, HeroName= "Dr. Strange", AlterEgo= "Stephen Strange", Image= "https://images.universohq.com/2014/01/dr_strange.jpg", Info= "\"We never lose our demons, Mordo. We only learn to live above them.\"", Comic = Marvel, ComicID= 2},
            new Hero() {ID= 4, HeroName= "Captain America", AlterEgo= "Steve Rogers", Image= "https://i.pinimg.com/originals/07/23/d6/0723d6631b0db97bc01ec19723d90aa5.png", Info= "'I can do this all day'", Comic = Marvel, ComicID= 2},
            new Hero() {ID= 5, HeroName= "Daredevil",AlterEgo= "Matthew Murdock",Image= "https://i.pinimg.com/originals/5d/9e/cf/5d9ecf4ca339a846d8ace940ed13ea63.jpg",Info= "'And how do you know the angels and the Devil inside me aren't the same things?'", Comic = Marvel, ComicID= 2},
            new Hero() {ID= 6, HeroName= "Superman",AlterEgo= "Clark Joseph Kent",Image= "https://upload.wikimedia.org/wikipedia/pt/b/be/Super-Homem.jpg",Info= "Do good to others and every man can be a Superman", Comic = DC, ComicID= 1}
        };

        static Comic DC = new Comic() { ID = 1, Name = "DC" };
        static Comic Marvel = new Comic() { ID = 2, Name = "Marvel"};
        public List<Comic>? Comics { get; set; }= new List<Comic>() { DC, Marvel };
    }
}
